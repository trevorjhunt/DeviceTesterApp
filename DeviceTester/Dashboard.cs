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
        public Dashboard()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
        }

        private void PicBoxMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PicBoxRestore_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            picBoxRestore.Visible = false;
            picBoxMaximize.Visible = true;
        }

        private void PicBoxMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            picBoxMaximize.Visible = false;
            picBoxRestore.Visible = true;
        }

        private void PicBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // allows the form to be moved around the screen
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panelTop_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        const uint WM_NCHITTEST = 0x0084, WM_MOUSEMOVE = 0x0200,
                 HTLEFT = 10, HTRIGHT = 11, HTBOTTOMRIGHT = 17,
                 HTBOTTOM = 15, HTBOTTOMLEFT = 16, HTTOP = 12,
                 HTTOPLEFT = 13, HTTOPRIGHT = 14;

        Size formSize;
        Point screenPoint;
        Point clientPoint;

 

        Dictionary<uint, Rectangle> boxes;
        const int RHS = 10; // RESIZE_HANDLE_SIZE


        bool handled;


        protected override void WndProc(ref Message m)
        {
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

                boxes = new Dictionary<uint, Rectangle>() {
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


        protected override void OnPaint(PaintEventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor,
                    this.ClientSize.Width - 16, this.ClientSize.Height - 16, 16, 16);
            }

            base.OnPaint(e);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            panelActiveButtonIndicator.Height = button1.Height;
            panelActiveButtonIndicator.Top = button1.Top;

            panelEatin.Visible = false;
            panelHome.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelActiveButtonIndicator.Height = button2.Height;
            panelActiveButtonIndicator.Top = button2.Top;

            panelHome.Visible = false;
            panelEatin.Visible = true;
        }

        private void picBoxDashboard_Click(object sender, EventArgs e)
        {
            timerDashboard.Start();
        }

        private bool dashboardIsCollapsed;
        private void timerDashboard_Tick(object sender, EventArgs e)
        {
            if (dashboardIsCollapsed)
            {
                panelSideBar.Width += 10;
                if (panelSideBar.Width >= panelSideBar.MaximumSize.Width)
                {
                    panelSideBar.Width = panelSideBar.MaximumSize.Width;
                    dashboardIsCollapsed = false;
                    timerDashboard.Stop();
                }
            }
            else
            {
                panelSideBar.Width -= 10;
                if (panelSideBar.Width == panelSideBar.MinimumSize.Width)
                {
                    panelSideBar.Width = panelSideBar.MinimumSize.Width;
                    dashboardIsCollapsed = true;
                    timerDashboard.Stop();
                }
            }
    
        }

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

        private bool isCollapsed;
        private void timerDropdown1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                button5.Image = Properties.Resources.Collapse_Arrow_20px;
                panelDropDown1.Height += 10;
                if (panelDropDown1.Height >= panelDropDown1.MaximumSize.Height)
                {
                    timerDropdown1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                button5.Image = Properties.Resources.Expand_Arrow_20px;
                panelDropDown1.Height -= 10;
                if (panelDropDown1.Height <= panelDropDown1.MinimumSize.Height)
                {
                    timerDropdown1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            timerDropdown1.Start();
            panelActiveButtonIndicator.Height = button13.Height;
            panelActiveButtonIndicator.Top = panelDropDown1.Top;
        }
    }
}
