using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
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
        string commandResponse;
        bool commandActive;
        string device_version;

        System.IO.StreamWriter out_file;



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
            timerDeviceConnect.Tick += new EventHandler(ConnectToDevice); 


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
                    textBoxLogFileName.Text = openFileDialog1.FileName;
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

        /* Append text to rx_textarea*/
        private void TerminalUpdateReceiveDataTextbox(string strText)
        {
            // if hex display enabled, then convert ascii to hex and display
            if (radioButtonTerminalHex.Checked)
            {
                byte[] asciiBytes = Encoding.ASCII.GetBytes(strText);
                string asciiStr = BitConverter.ToString(asciiBytes);
                textboxRecievedData.AppendText(asciiStr);
                return;
            }

            if (checkboxEnableLog.Checked)
            {
                try
                {
                    if (!strText.Contains("\b"))
                        out_file.Write(strText);
                }
                catch
                {
                    /*alert("Can't write to " + textboxLogFileName.Text + " file it might be not exist or it is opennd in another program");*/
                }
            }

            // handle backspace, remove a char from the text box if detected
            if (strText.Contains("\b"))
            {                
                if (textboxRecievedData.Text.Length > 0)
                {
                    textboxRecievedData.Text = textboxRecievedData.Text.Substring(0, textboxRecievedData.Text.Length - 1);
                    textboxRecievedData.SelectionStart = textboxRecievedData.Text.Length;
                }
                return;
            }

            // add new char to text box
            textboxRecievedData.AppendText(strText);            
        }

        private void serialPortDut_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string stringReceived = serialPortDut.ReadExisting();

            if (commandActive)
            {
                commandResponse += stringReceived;
            }

            this.BeginInvoke(new EventHandler(delegate
            {
                TerminalUpdateReceiveDataTextbox(stringReceived);
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
            try   
            { 
                serialPortDut.PortName = comboboxPort.Text;
                serialPortDut.BaudRate = (Int32.Parse(comboboxBaudrate.Text));
                serialPortDut.StopBits = (StopBits)Enum.Parse(typeof(StopBits), (comboboxStopbits.SelectedIndex + 1).ToString(), true);
                serialPortDut.Parity = (Parity)Enum.Parse(typeof(Parity), comboboxParity.SelectedIndex.ToString(), true);
                serialPortDut.DataBits = (Int32.Parse(comboboxDatabits.Text));
                serialPortDut.Handshake = (Handshake)Enum.Parse(typeof(Handshake), comboboxFlowControl.SelectedIndex.ToString(), true);
                serialPortDut.Open();
            }
            catch 
            {
                // TODO alert("Can't open " + mySerial.PortName + " port, it might be used in another program");
                return false;
            }
            return true;
        }

        private void CloseSerialPort()
        {
            try
            {
                serialPortDut.Close();
                serialPortDut.DiscardInBuffer();
                serialPortDut.DiscardOutBuffer();
            }
            catch { }
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
                            out_file = new System.IO.StreamWriter(textBoxLogFileName.Text, radiobuttonLogAppend.Checked);
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


            if (checkboxEnableLog.Checked)
            {
                try { out_file.Dispose(); }
                catch { }
            }
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
            buttonTerminalTransmitSend.Enabled = false;
            buttonTerminalTransmitClear.Enabled = false;
            numericUpDownTerminalDelay.Enabled = !radioButtonTerminalKeys.Checked;
            numericUpDownTerminalRepeats.Enabled = !radioButtonTerminalKeys.Checked;
            buttonTerminalTransmitSend.Text = "Send";
            timerTerminalCommandDelay.Stop();
        }

        private void radioButtonTerminalCommands_CheckedChanged(object sender, EventArgs e)
        {
            buttonTerminalTransmitSend.Enabled = true;
            buttonTerminalTransmitClear.Enabled = true;
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

            buttonTerminalTransmitClear.Enabled = true;
            buttonTerminalTransmitSend.Enabled = true;
            buttonTerminalTransmitSend.Text = "Send";
            timerTerminalCommandDelay.Stop();
        }

        private bool command_send_receive(string command, out string response)
        {
            response = "";

            if (!serialPortDut.IsOpen)
                return false;

            commandResponse = "";
            commandActive = true;
            serialPortDut.Write(command);
            System.Threading.Thread.Sleep(250);
            commandActive = false;

            if (commandResponse.Contains(command))
            {
                int index = commandResponse.IndexOf(command);
                response = commandResponse.Remove(index, command.Length);
                response = response.ToLower();
            }

            if (response.Length == 0)
                return false;
            return true;
        }

        private bool ReadFactorySettings()
        {
            bool snIsOk = false, countryIsOk = false, VariantIsOk = false, frequencyIsOk = false, temperatureOffsetIsOk = false;
            string response;

            if (command_send_receive("version\r\n", out response))
            {
                if (!response.Contains(device_version))
                    return false;
            }

            if (!command_send_receive("factory\r\n", out response))
                return false;
              
            string[] separatingStrings2 = { " = " };
            string[] separatingStrings = { "\r\n" };
            string[] lines = response.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in lines)
            {
                if (line.Contains("s/n"))
                {
                    string[] tokens = line.Split(separatingStrings2, System.StringSplitOptions.RemoveEmptyEntries);
                    textBoxSerialNumber.Text = tokens[1];
                    snIsOk = true;
                }

                if (line.Contains("country"))
                {
                    string[] tokens = line.Split(separatingStrings2, System.StringSplitOptions.RemoveEmptyEntries);
                    if (tokens[1] == "353")
                        comboBoxCountry.SelectedIndex = 0;
                    else if (tokens[1] == "44")
                        comboBoxCountry.SelectedIndex = 1;
                    else
                        comboBoxCountry.SelectedIndex = -1;
                    countryIsOk = true;
                }

                if (line.Contains("variant"))
                {
                    string[] tokens = line.Split(separatingStrings2, System.StringSplitOptions.RemoveEmptyEntries);
                    if (tokens[1] == "1")
                        comboBoxVariant.SelectedIndex = 0;
                    else if (tokens[1] == "2")
                        comboBoxVariant.SelectedIndex = 1;
                    else
                        comboBoxVariant.SelectedIndex = -1;
                    VariantIsOk = true;
                }

                if (line.Contains("rf"))
                {
                    string[] tokens = line.Split(separatingStrings2, System.StringSplitOptions.RemoveEmptyEntries);
                    if (tokens[1] == "868.0 mhz")
                        comboBoxFrequency.SelectedIndex = 0;
                    else if (tokens[1] == "868.1 mhz")
                        comboBoxFrequency.SelectedIndex = 1;
                    else if (tokens[1] == "868.2 mhz")
                        comboBoxFrequency.SelectedIndex = 2;
                    else if (tokens[1] == "868.3 mhz")
                        comboBoxFrequency.SelectedIndex = 3;
                    else if (tokens[1] == "868.4 mhz")
                        comboBoxFrequency.SelectedIndex = 4;
                    else if (tokens[1] == "868.5 mhz")
                        comboBoxFrequency.SelectedIndex = 5;
                    else if (tokens[1] == "868.6 mhz")
                        comboBoxFrequency.SelectedIndex = 6;
                    else if (tokens[1] == "868.7 mhz")
                        comboBoxFrequency.SelectedIndex = 7;
                    else if (tokens[1] == "868.8 mhz")
                        comboBoxFrequency.SelectedIndex = 8;
                    else
                        comboBoxFrequency.SelectedIndex = -1;
                    frequencyIsOk = true;
                }

                if (line.Contains("temp_cal"))
                {
                    string[] tokens = line.Split(separatingStrings2, System.StringSplitOptions.RemoveEmptyEntries);
                    textBoxTempOffset.Text = tokens[1];
                    temperatureOffsetIsOk = true;
                }
            }

            if (snIsOk == countryIsOk == VariantIsOk == frequencyIsOk == temperatureOffsetIsOk == true)
                return true;
            return false;
        }

        private UInt32 GetPassword(UInt32 serial_number, Byte rf_frequency, UInt16 country_code, Byte variant)
        {
            UInt32 code = 0;
            UInt32 val;

            val = serial_number & 0x000000FF;
            val <<= 8;
            code |= val;

            val = serial_number & 0x0000FF00;
            val <<= 16;
            code |= val;

            val = serial_number & 0x00FF0000;
            val >>= 16;
            code |= val;

            val = serial_number & 0xFF000000;
            val >>= 8;
            code |= val;

            code ^= rf_frequency;

            val = country_code;
            val <<= 8;
            code ^= val;

            val = variant;
            val <<= 24;
            code ^= val;

            return code;
        }

        // TODO - temp offset input should only handle values from -65535 to +655535
        private bool WriteFactorySettings()
        {
            string serialNumber, frequency, country, variant, temperature_offset, command;
 
            serialNumber = textBoxSerialNumber.Text;
            frequency = comboBoxFrequency.SelectedIndex.ToString();

            country = comboBoxCountry.SelectedItem.ToString();
            country = (country == "Ireland") ? "353" : "44";

            variant = comboBoxVariant.SelectedItem.ToString();
            temperature_offset = textBoxTempOffset.Text;

            UInt32 s;
            Byte f, v;
            UInt16 c;
            UInt32 code;

           
            s = UInt32.Parse(serialNumber, System.Globalization.NumberStyles.AllowHexSpecifier); // TODO - hex values wont work
            f = Byte.Parse(frequency);
            c = UInt16.Parse(country);
            v = Byte.Parse(variant);
            code = GetPassword(s, f, c, v);

            //command = "factory " + serialNumber + " " + code.ToString("X") + " " + country + " " + frequency + " " + "42 " + variant + " " + temperature_offset + "\r\n";
            command = "factory " + serialNumber + " " + code.ToString("X") + " " + country + " " + frequency + " " + variant + " " + temperature_offset + "\r\n";
            //textBoxFactoryStatus.Text = command;

            string response;
            if (command_send_receive("version\r\n", out response))
            {
                if (!response.Contains(device_version))
                    return false;
            }

            if (!command_send_receive(command, out response))
                return false;

            if (!response.Contains("ok"))
                return false;

            return true;
        }


        private void ConnectToDevice(object sender, EventArgs e)
        {
            // sent 'version' command to the device to get the version
            if (command_send_receive("version\r\n", out string response))
            {
                if (response.Contains("rf ucs boot"))
                {
                    device_version = "rf ucs boot";
                    textBoxProduct.Enabled = true;
                    textBoxProduct.Text = "Micro Contact";
                    textBoxFactoryStatus.Text = "Connected to " + textBoxProduct.Text;
                    buttonFactoryConnect.Text = "Connected";

                    ReadFactorySettings();
                    timerDeviceConnect.Stop();
                    return;
                }
            }
            
            textBoxProduct.Enabled = false;
            textBoxProduct.Text = "";
            textBoxFactoryStatus.Text = "Connecting...\r\nPlease try resetting the device";
            return;
        }

        private void buttonFactoryConnect_Click(object sender, EventArgs e)
        {
            if (buttonFactoryConnect.Text == "Connect")
            {
                timerDeviceConnect.Start();
                buttonFactoryConnect.Text = "Connecting";
            }            
            else 
            {
                buttonFactoryConnect.Text = "Connect";
                textBoxFactoryStatus.Clear();
                timerDeviceConnect.Stop();
                textBoxFactoryStatus.Text = "Disconnected... ";
                textBoxProduct.Text = "";
                textBoxSerialNumber.Text = "";
                comboBoxCountry.SelectedIndex = -1;
                comboBoxVariant.SelectedIndex = -1;
                comboBoxFrequency.SelectedIndex = -1;
                textBoxTempOffset.Text = "";
            }
        }

        private void buttonFactoryRead_Click(object sender, EventArgs e)
        {
            if (buttonFactoryConnect.Text == "Connected")
            {
                if (ReadFactorySettings())
                {
                    textBoxFactoryStatus.Text = "Factory settings read successfully";
                }
                else
                {
                    textBoxFactoryStatus.Text = "Factory settings read failed.. try reconnecting";
                }
            }
        }

        private void buttonFactoryWrite_Click(object sender, EventArgs e)
        {
            if (buttonFactoryConnect.Text == "Connected")
            {
                if (WriteFactorySettings())
                {
                    textBoxFactoryStatus.Text = "Factory settings programmed successfully";
                }
                else
                {
                    textBoxFactoryStatus.Text = "Factory settings programming failed.. try reconnecting";
                }
            }
                
        }

        private void TextboxSerialNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            string HexLetters = "0123456789abcdefABCDEF\b"; // \b is the BackSpace character

            if (!HexLetters.Contains(e.KeyChar)) e.Handled = true;
        }
    }
}
