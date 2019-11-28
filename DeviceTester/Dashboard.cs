using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviceTester
{
    public partial class Dashboard : Form
    {
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private bool settingsMenuIsExpanded;
        private bool panelSideBarIsExpanded = true;
        private int terminalSendCommandCounter = 0;

        public string ReceivedData      { get; set; } // TODO - make private
        public string ReceivedDataInHex { get; set; } // TODO - make private

        System.IO.StreamWriter out_file;
        System.IO.StreamReader in_file;


        // Main entry point
        public Dashboard()
        {
            InitializeComponent();
            SetDefaults();            
        }

        // 
        // called to set the initial defaults on start up
        //
        private void SetDefaults()
        {
            comboboxPort.Items.AddRange(SerialPort.GetPortNames());

            comboboxBaudrate.DataSource = new[] { "115200", "19200", "230400", "57600", "38400", "9600", "4800" };
            comboboxBaudrate.SelectedIndex = 0;

            comboboxParity.DataSource = new[] { "None", "Odd", "Even", "Mark", "Space" };
            comboboxParity.SelectedIndex = 0;

            comboboxDatabits.DataSource = new[] { "5", "6", "7", "8" };
            comboboxDatabits.SelectedIndex = 3;

            comboboxStopbits.DataSource = new[] { "1", "2", "1.5" };
            comboboxStopbits.SelectedIndex = 0;

            comboboxFlowControl.DataSource = new[] { "None", "RTS", "RTS/X", "Xon/Xoff" };           
            comboboxFlowControl.SelectedIndex = 0;

            this.serialPortDut.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortDut_DataReceived);

            timerTerminalCommandDelay.Tick += new EventHandler(TerminalSendData);

            textboxRecievedData.Clear();
            textBoxTransmitData.Clear();
        }


        //
        // minimize window icon click event
        // minimizes the window
        //
        private void picboxMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //
        // restore window icon click event
        // restore the window size to default setting
        //
        private void picboxRestore_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            picBoxRestore.Visible = false;
            picBoxMaximize.Visible = true;
            Dashboard.ActiveForm.Width = Dashboard.ActiveForm.MaximumSize.Width;
            Dashboard.ActiveForm.Height = Dashboard.ActiveForm.MaximumSize.Height;
        }

        //
        // maximize window icon click event
        // maximizes the window
        //
        private void picboxMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            picBoxMaximize.Visible = false;
            picBoxRestore.Visible = true;
        }

        //
        // exit icon click event
        // exits the program
        //
        private void picboxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //
        // allows the window to be moved around the screen
        //
        private void panelTop_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            const int WM_NCLBUTTONDOWN = 0xA1;
            const int HT_CAPTION = 0x2;

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //
        // Allows the window to be resized from all sides 
        // 
        protected override void WndProc(ref Message m)
        {
            Size formSize;
            Point screenPoint;
            Point clientPoint;
            Dictionary<uint, Rectangle> boxes;
            const int RHS = 10; // RESIZE_HANDLE_SIZE
            const uint WM_NCHITTEST = 0x0084, WM_MOUSEMOVE = 0x0200, HTLEFT = 10, HTRIGHT = 11, HTBOTTOMRIGHT = 17, HTBOTTOM = 15, HTBOTTOMLEFT = 16, HTTOP = 12, HTTOPLEFT = 13, HTTOPRIGHT = 14;
            bool handled;

            if (this.WindowState == FormWindowState.Maximized)
            {
                base.WndProc(ref m);
                return;
            }

            handled = false;
            if (m.Msg == WM_NCHITTEST || m.Msg == WM_MOUSEMOVE)
            {
                formSize = this.Size;
                screenPoint = new Point(m.LParam.ToInt32());
                clientPoint = this.PointToClient(screenPoint);

                boxes = new Dictionary<uint, Rectangle>()
                {
                    {HTBOTTOMLEFT, new Rectangle(0, formSize.Height - RHS, RHS, RHS)},
                    {HTBOTTOM, new Rectangle(RHS, formSize.Height - RHS, formSize.Width - 2*RHS, RHS)},
                    {HTBOTTOMRIGHT, new Rectangle(formSize.Width - RHS, formSize.Height - RHS, RHS, RHS)},
                    {HTRIGHT, new Rectangle(formSize.Width - RHS, RHS, RHS, formSize.Height - 2*RHS)},
                    {HTTOPRIGHT, new Rectangle(formSize.Width - RHS, 0, RHS, RHS) },
                    {HTTOP, new Rectangle(RHS, 0, formSize.Width - 2*RHS, RHS) },
                    {HTTOPLEFT, new Rectangle(0, 0, RHS, RHS) },
                    {HTLEFT, new Rectangle(0, RHS, RHS, formSize.Height - 2*RHS) }
                };

                foreach (var hitBox in boxes)
                {
                    if (hitBox.Value.Contains(clientPoint))
                    {
                        m.Result = (IntPtr)hitBox.Key;
                        handled = true;
                        break;
                    }
                }
            }

            if (!handled)
                base.WndProc(ref m);
        }

        //
        // Shows only the panel that is active TODO - better explanation TODO - make methods upper case
        //
        private void show_panel(ref System.Windows.Forms.Panel panel)
        {
            panelTerminal.Visible = false;
            panelFactory.Visible = false;
            panelSerialPort.Visible = false;
            panelLog.Visible = false;
            panelTerminalOptions.Visible = false;

            panel.Visible = true;
        }

        //
        //
        //
        private void buttonHome_Click(object sender, EventArgs e)
        {
            panelActiveButtonIndicator.Height = buttonFactory.Height;
            panelActiveButtonIndicator.Top = buttonFactory.Top;

            show_panel(ref panelFactory);
        }


        //
        //
        //
        private void buttonTerminal_Click(object sender, EventArgs e)
        {
            panelActiveButtonIndicator.Height = buttonTerminal.Height;
            panelActiveButtonIndicator.Top = buttonTerminal.Top;

            show_panel(ref panelTerminal);
        }

        //
        //
        //
        private void picBoxSideBarMenu_Click(object sender, EventArgs e)
        {
            if (panelSideBarIsExpanded)
                this.MinimumSize = new Size(496, 480);
   
            timerDashboard.Start();            
        }

        //
        //
        //
        private void timerSideBarMenu_Tick(object sender, EventArgs e)
        {
            if (!panelSideBarIsExpanded)
            {
                panelSideBar.Width += 10;
                panelPages.Width -= 10;
                this.Size = new Size(this.Size.Width + 10, this.Size.Height);

                if (panelSideBar.Width >= panelSideBar.MaximumSize.Width)
                {
                    panelSideBar.Width = panelSideBar.MaximumSize.Width;
                    panelSideBarIsExpanded = true;
                    timerDashboard.Stop();
                    this.MinimumSize = new Size(650, 480);
                }
            }
            else
            {
                this.Size = new Size(this.Size.Width - 10, this.Size.Height);
                panelSideBar.Width -= 10;
                if (panelSideBar.Width == panelSideBar.MinimumSize.Width)
                {
                    panelSideBar.Width = panelSideBar.MinimumSize.Width;
                    panelSideBarIsExpanded = false;
                    timerDashboard.Stop();                    
                }
            }
    
        }

        // TODO - make all the methods start with a uppercase letter
        //
        //
        private void timerSettingsDropdownMenu_Tick(object sender, EventArgs e)
        {
            if (!settingsMenuIsExpanded)
            {
                buttonSettings.Image = Properties.Resources.Collapse_Arrow_20px;
                panelButtonSettings.Height += 10;
                if (panelButtonSettings.Height >= panelButtonSettings.MaximumSize.Height)
                {
                    timerSettingsMenu.Stop();
                    settingsMenuIsExpanded = true;
                }
            }
            else
            {
                buttonSettings.Image = Properties.Resources.Expand_Arrow_20px;
                panelButtonSettings.Height -= 10;
                if (panelButtonSettings.Height <= panelButtonSettings.MinimumSize.Height)
                {
                    timerSettingsMenu.Stop();
                    settingsMenuIsExpanded = false;
                }
            }
        }

        //
        //
        //
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            timerSettingsMenu.Start();
            panelActiveButtonIndicator.Height = buttonSettings.Height;
            panelActiveButtonIndicator.Top = panelButtonSettings.Top;
        }


        //
        // handle serial port settings button click
        //
        private void buttonSerialPortSettings_Click(object sender, EventArgs e)
        {
            panelActiveButtonIndicator.Height = buttonSerialPortSettings.Height;
            panelActiveButtonIndicator.Top = panelButtonSettings.Top + buttonSerialPortSettings.Top;
            show_panel(ref panelSerialPort);
        }

        //
        // handle 'log' button click
        //
        private void buttonLogSettings_Click(object sender, EventArgs e)
        {
            panelActiveButtonIndicator.Height = buttonLogSettings.Height;
            panelActiveButtonIndicator.Top = panelButtonSettings.Top + buttonLogSettings.Top;
            show_panel(ref panelLog);
        }

        // 
        //  handle 'log' enable/disable checkbox check event
        //

        private void checkboxEnableLog_CheckedChanged(object sender, EventArgs e)
        {

            if (checkboxEnableLog.Checked)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    checkboxEnableLog.Text = openFileDialog1.FileName;
                    radiobuttonLogAppend.Enabled = true;
                    radiobuttonLogOverwrite.Enabled = true;
                }
                else
                {
                    radiobuttonLogAppend.Enabled = false;
                    radiobuttonLogOverwrite.Enabled = false;
                    checkboxEnableLog.Checked = false;
                }
            }
            else
            {
                radiobuttonLogOverwrite.Enabled = false;
                radiobuttonLogAppend.Enabled = false;
                checkboxEnableLog.Text = "Enable Data logger";
            }
        }


        // 
        //  handle 'terminal options' click
        //

        private void buttonTerminalOptions_Click(object sender, EventArgs e)
        {
            panelActiveButtonIndicator.Height = buttonTerminalOptions.Height;
            panelActiveButtonIndicator.Top = panelButtonSettings.Top + buttonTerminalOptions.Top;
            show_panel(ref panelTerminalOptions);
        }

        /* Append text to rx_textarea*/
        private void TerminalUpdateReceiveDataTextbox(string strText)
        {
            if (radioButtonTerminalHex.Checked)
            {
                byte[] asciiBytes = Encoding.ASCII.GetBytes(strText);
                string asciiStr = BitConverter.ToString(asciiBytes);
                textboxRecievedData.AppendText(asciiStr);
            }                
            else
                textboxRecievedData.AppendText(strText);           
        }

        private void serialPortDut_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string strErg = serialPortDut.ReadExisting();
            this.BeginInvoke(new EventHandler(delegate
            {
                TerminalUpdateReceiveDataTextbox(strErg);
            }));
            Application.DoEvents();
        }

        private void radioButtonTerminaAscii_CheckedChanged(object sender, EventArgs e)
        {
            textboxRecievedData.Clear();
        }

        private void buttonTerminalReceiveClear_Click(object sender, EventArgs e)
        {
            textboxRecievedData.Clear();
        }

        private void radioButtonTerminalHex_CheckedChanged(object sender, EventArgs e)
        {
            textboxRecievedData.Clear();
        }

        private bool OpenSerialPort()
        {
            bool success = false;
            try   
            { 
                serialPortDut.PortName = comboboxPort.Text;
                serialPortDut.BaudRate = (Int32.Parse(comboboxBaudrate.Text));
                serialPortDut.StopBits = (StopBits)Enum.Parse(typeof(StopBits), (comboboxStopbits.SelectedIndex + 1).ToString(), true);
                serialPortDut.Parity = (Parity)Enum.Parse(typeof(Parity), comboboxParity.SelectedIndex.ToString(), true);
                serialPortDut.DataBits = (Int32.Parse(comboboxDatabits.Text));
                serialPortDut.Handshake = (Handshake)Enum.Parse(typeof(Handshake), comboboxFlowControl.SelectedIndex.ToString(), true);
                serialPortDut.Open();
                success = true;
            }
            catch 
            {
                // TODO alert("Can't open " + mySerial.PortName + " port, it might be used in another program");
                success = false;
            }
            return success;
        }

        private void CloseSerialPort()
        {
            try
            {
                serialPortDut.Close();
                serialPortDut.DiscardInBuffer();
                serialPortDut.DiscardOutBuffer();
            }
            catch
            {
            }

            if (checkboxEnableLog.Checked)
            {
                try
                {
                    out_file.Dispose();
                }
                catch
                {
                }
            }

            try
            {
                in_file.Dispose();
            }
            catch
            {
            }
        }

        private void buttonSerialPortConnect_Click(object sender, EventArgs e)
        {
            // open serial port connetion if not already open
            if (!serialPortDut.IsOpen)
            {
                if (OpenSerialPort())
                {
                    if (checkboxEnableLog.Checked)
                    {
                        try
                        {
                            out_file = new System.IO.StreamWriter(checkboxEnableLog.Text, radiobuttonLogAppend.Checked);
                        }
                        catch
                        {
                            // TODO alert("Can't open " + datalogger_checkbox.Text + " file, it might be used in another program");
                            return;
                        }
                    }


                    textboxRecievedData.Clear();
                    textBoxTransmitData.Clear();
                    panelTerminalTransmit.Enabled = true;
                    panelTerminalReceive.Enabled = true;
                    panelFactorySettingsItems.Enabled = true;                    
                    panelLogOptions.Enabled = false;
                    buttonSerialPortConnect.Text = "Disconnect";
                    toolStripStatusLabelConnection.Text = "Connected port: " + serialPortDut.PortName + " @ " + serialPortDut.BaudRate + " bps";
                    return;
                }
            }

            CloseSerialPort();
            panelLogOptions.Enabled = true;
            buttonSerialPortConnect.Text = "Connect";
            toolStripStatusLabelConnection.Text = "Not connected: please connect to a port";
            panelFactorySettingsItems.Enabled = false;
            panelTerminalTransmit.Enabled = false;
            panelTerminalReceive.Enabled = false;
        }

        /* write data when keydown*/
        private void TextboxTransmitData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioButtonTerminalKeys.Checked && serialPortDut.IsOpen)
            {
                serialPortDut.Write(e.KeyChar.ToString());              
            }
        }

        private void TextboxReceiveData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (serialPortDut.IsOpen)
            {
                serialPortDut.Write(e.KeyChar.ToString());
                e.Handled = true;
            }
        }

        private void TerminalSendData(object sender, EventArgs e)
        {
            string tx_data = "";

            if (radioButtonTerminalCommands.Checked)
            {
                tx_data = textBoxTransmitData.Text.Replace("\\n", "\r\n");
                if (terminalSendCommandCounter > 0)
                {
                    --terminalSendCommandCounter;
                    if (serialPortDut.IsOpen)
                        serialPortDut.Write(tx_data);
                }

                if (terminalSendCommandCounter == 0)
                {
                    buttonTerminalTransmitSend.Text = "Send";
                    timerTerminalCommandDelay.Stop();
                    terminalSendCommandCounter = 0;
                }
                return;
            }
        }

        // TODO - terminal BS not handled
        // TODO - Transmit 'send' should not be enabled when 'commands' not
        private void buttonTerminalTransmitSend_Click(object sender, EventArgs e)
        {
            // send 'commmand' option checked
            if (radioButtonTerminalCommands.Checked)
            {
                if (buttonTerminalTransmitSend.Text == "Send")
                {   
                    terminalSendCommandCounter = (int)numericUpDownTerminalRepeats.Value;
                    timerTerminalCommandDelay.Interval = (int)numericUpDownTerminalDelay.Value;
                    timerTerminalCommandDelay.Start();
                    buttonTerminalTransmitSend.Text = "Stop";   
                }
                else
                {
                    buttonTerminalTransmitSend.Text = "Send";
                    timerTerminalCommandDelay.Stop();
                }
                return;
            }

            // send 'keys' option checked?
            if (radioButtonTerminalKeys.Checked)
            {
                return;
            }

            // send file option checked
            if (radioButtonTerminalFile.Checked)
            {
                // TODO - file handling
                return;
            }
        }

        private void buttonTerminalTransmitClear_Click(object sender, EventArgs e)
        {
            textBoxTransmitData.Clear();
        }

        private void radioButtonTerminalKeys_CheckedChanged(object sender, EventArgs e)
        {
            textBoxTransmitData.Clear();
            numericUpDownTerminalDelay.Enabled = !radioButtonTerminalKeys.Checked;
            numericUpDownTerminalRepeats.Enabled = !radioButtonTerminalKeys.Checked;
            buttonTerminalTransmitSend.Text = "Send";
            timerTerminalCommandDelay.Stop();
        }

        private void radioButtonTerminalCommands_CheckedChanged(object sender, EventArgs e)
        {
            textBoxTransmitData.Clear();
            numericUpDownTerminalDelay.Enabled = radioButtonTerminalCommands.Checked;
            numericUpDownTerminalRepeats.Enabled = radioButtonTerminalCommands.Checked;
            buttonTerminalTransmitSend.Text = "Send";
            timerTerminalCommandDelay.Stop();
        }

        private void radioButtonTerminalFile_CheckedChanged(object sender, EventArgs e)
        {
            textBoxTransmitData.Clear();
            numericUpDownTerminalDelay.Enabled = !radioButtonTerminalFile.Checked;
            numericUpDownTerminalRepeats.Enabled = !radioButtonTerminalFile.Checked;
            buttonTerminalTransmitSend.Text = "Send";
            timerTerminalCommandDelay.Stop();
        }

        private void buttonFactoryConnect_Click(object sender, EventArgs e)
        {
            if (buttonFactoryConnect.Text == "Connect")
            {
                textBoxFactoryStatus.Text = "Connecting...\r\nPlease reset reboot device";
            }

            if (buttonFactoryConnect.Text == "Connected")
            {
                buttonFactoryConnect.Text = "Connect";
                textBoxFactoryStatus.Clear();
            }
        }
    }
}
