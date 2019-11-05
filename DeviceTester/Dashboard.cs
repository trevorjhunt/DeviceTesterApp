using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private bool panelButton13IsExpanded;
        private bool panelSideBarIsExpanded;


        // Main entry point
        public Dashboard()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
        }

        //
        // minimize window icon click event
        // minimizes the window
        //
        private void PicBoxMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //
        // restore window icon click event
        // restore the window size to default setting
        //
        private void PicBoxRestore_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            picBoxRestore.Visible = false;
            picBoxMaximize.Visible = true;
        }

        //
        // maximize window icon click event
        // maximizes the window
        //
        private void PicBoxMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            picBoxMaximize.Visible = false;
            picBoxRestore.Visible = true;
        }

        //
        // exit icon click event
        // exits the program
        //
        private void PicBoxExit_Click(object sender, EventArgs e)
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
        // Draws a resize grip icon on the bottom LHS of window
        // 
        protected override void OnPaint(PaintEventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor,
                    this.ClientSize.Width - 16, this.ClientSize.Height - 16, 16, 16);
            }

            base.OnPaint(e);
        }

        //
        //
        //
        private void button1_Click(object sender, EventArgs e)
        {
            panelActiveButtonIndicator.Height = button1.Height;
            panelActiveButtonIndicator.Top = button1.Top;

            panelEatin.Visible = false;
            panelHome.Visible = true;
        }


        //
        //
        //
        private void button2_Click(object sender, EventArgs e)
        {
            panelActiveButtonIndicator.Height = button2.Height;
            panelActiveButtonIndicator.Top = button2.Top;

            panelHome.Visible = false;
            panelEatin.Visible = true;
        }

        //
        //
        //
        private void picBoxSideBarMenu_Click(object sender, EventArgs e)
        {
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
                if (panelSideBar.Width >= panelSideBar.MaximumSize.Width)
                {
                    panelSideBar.Width = panelSideBar.MaximumSize.Width;
                    panelSideBarIsExpanded = true;
                    timerDashboard.Stop();
                }
            }
            else
            {
                panelSideBar.Width -= 10;
                if (panelSideBar.Width == panelSideBar.MinimumSize.Width)
                {
                    panelSideBar.Width = panelSideBar.MinimumSize.Width;
                    panelSideBarIsExpanded = false;
                    timerDashboard.Stop();
                }
            }
    
        }

        //
        //
        //
        private void timerButton13Menu_Tick(object sender, EventArgs e)
        {
            if (!panelButton13IsExpanded)
            {
                button5.Image = Properties.Resources.Collapse_Arrow_20px;
                panelButton13.Height += 10;
                if (panelButton13.Height >= panelButton13.MaximumSize.Height)
                {
                    timerbutton13Menu.Stop();
                    panelButton13IsExpanded = true;
                }
            }
            else
            {
                button5.Image = Properties.Resources.Expand_Arrow_20px;
                panelButton13.Height -= 10;
                if (panelButton13.Height <= panelButton13.MinimumSize.Height)
                {
                    timerbutton13Menu.Stop();
                    panelButton13IsExpanded = false;
                }
            }
        }

        //
        //
        //
        private void button13_Click(object sender, EventArgs e)
        {
            timerbutton13Menu.Start();
            panelActiveButtonIndicator.Height = button13.Height;
            panelActiveButtonIndicator.Top = panelButton13.Top;

            // need to reposition buttons based on whether the panel is going to be 
            // expanded or collapsed
            if (panelButton13IsExpanded)
                buttonSettings.Top = panelButton13.Top + panelButton13.MinimumSize.Height;
            else                
                buttonSettings.Top = panelButton13.Top + panelButton13.MaximumSize.Height;
        }

        //
        //
        //
        private void timerChart_Tick(object sender, EventArgs e)
        {
            timerChart.Stop();
            this.chart1.Series["chartLine"].Points.AddXY("JAN", 10);
            this.chart1.Series["chartLine"].Points.AddXY("FEB", 20);
            this.chart1.Series["chartLine"].Points.AddXY("MAR", 30);
            this.chart1.Series["chartLine"].Points.AddXY("APR", 50);
            this.chart1.Series["chartLine"].Points.AddXY("MAY", 30);
            this.chart1.Series["chartLine"].Points.AddXY("JUN", 30);
            this.chart1.Series["chartLine"].Points.AddXY("JUL", 10);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            panelActiveButtonIndicator.Height = buttonSettings.Height;
            panelActiveButtonIndicator.Top = buttonSettings.Top;
        }
    }
}
