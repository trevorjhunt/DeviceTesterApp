namespace DeviceTester
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop = new System.Windows.Forms.Panel();
            this.picBoxRestore = new System.Windows.Forms.PictureBox();
            this.picBoxMinimize = new System.Windows.Forms.PictureBox();
            this.picBoxMaximize = new System.Windows.Forms.PictureBox();
            this.picBoxExit = new System.Windows.Forms.PictureBox();
            this.labelDashboard = new System.Windows.Forms.Label();
            this.picBoxDashboard = new System.Windows.Forms.PictureBox();
            this.panelHome = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelHome = new System.Windows.Forms.Label();
            this.panelEatin = new System.Windows.Forms.Panel();
            this.labelEatin = new System.Windows.Forms.Label();
            this.timerChart = new System.Windows.Forms.Timer(this.components);
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.gradientPanelSideBar = new DeviceTester.CustomControls.GradientPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDashboard)).BeginInit();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panelEatin.SuspendLayout();
            this.panelSideBar.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.gradientPanelSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelTop.Controls.Add(this.picBoxRestore);
            this.panelTop.Controls.Add(this.picBoxMinimize);
            this.panelTop.Controls.Add(this.picBoxMaximize);
            this.panelTop.Controls.Add(this.picBoxExit);
            this.panelTop.Controls.Add(this.labelDashboard);
            this.panelTop.Controls.Add(this.picBoxDashboard);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(5, 5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(2);
            this.panelTop.Size = new System.Drawing.Size(952, 51);
            this.panelTop.TabIndex = 1;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // picBoxRestore
            // 
            this.picBoxRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxRestore.Image = ((System.Drawing.Image)(resources.GetObject("picBoxRestore.Image")));
            this.picBoxRestore.Location = new System.Drawing.Point(888, 14);
            this.picBoxRestore.Name = "picBoxRestore";
            this.picBoxRestore.Size = new System.Drawing.Size(24, 24);
            this.picBoxRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxRestore.TabIndex = 5;
            this.picBoxRestore.TabStop = false;
            this.picBoxRestore.Visible = false;
            this.picBoxRestore.Click += new System.EventHandler(this.PicBoxRestore_Click);
            // 
            // picBoxMinimize
            // 
            this.picBoxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxMinimize.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMinimize.Image")));
            this.picBoxMinimize.Location = new System.Drawing.Point(862, 14);
            this.picBoxMinimize.Name = "picBoxMinimize";
            this.picBoxMinimize.Size = new System.Drawing.Size(24, 24);
            this.picBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMinimize.TabIndex = 4;
            this.picBoxMinimize.TabStop = false;
            this.picBoxMinimize.Click += new System.EventHandler(this.PicBoxMinimize_Click);
            // 
            // picBoxMaximize
            // 
            this.picBoxMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxMaximize.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMaximize.Image")));
            this.picBoxMaximize.Location = new System.Drawing.Point(888, 14);
            this.picBoxMaximize.Name = "picBoxMaximize";
            this.picBoxMaximize.Size = new System.Drawing.Size(24, 24);
            this.picBoxMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMaximize.TabIndex = 3;
            this.picBoxMaximize.TabStop = false;
            this.picBoxMaximize.Click += new System.EventHandler(this.PicBoxMaximize_Click);
            // 
            // picBoxExit
            // 
            this.picBoxExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("picBoxExit.Image")));
            this.picBoxExit.Location = new System.Drawing.Point(914, 14);
            this.picBoxExit.Name = "picBoxExit";
            this.picBoxExit.Size = new System.Drawing.Size(24, 24);
            this.picBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxExit.TabIndex = 2;
            this.picBoxExit.TabStop = false;
            this.picBoxExit.Click += new System.EventHandler(this.PicBoxExit_Click);
            // 
            // labelDashboard
            // 
            this.labelDashboard.AutoEllipsis = true;
            this.labelDashboard.AutoSize = true;
            this.labelDashboard.BackColor = System.Drawing.Color.Transparent;
            this.labelDashboard.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.labelDashboard.ForeColor = System.Drawing.Color.White;
            this.labelDashboard.Location = new System.Drawing.Point(64, 21);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(101, 20);
            this.labelDashboard.TabIndex = 1;
            this.labelDashboard.Text = "DASHBOARD";
            // 
            // picBoxDashboard
            // 
            this.picBoxDashboard.Image = ((System.Drawing.Image)(resources.GetObject("picBoxDashboard.Image")));
            this.picBoxDashboard.Location = new System.Drawing.Point(34, 16);
            this.picBoxDashboard.Name = "picBoxDashboard";
            this.picBoxDashboard.Size = new System.Drawing.Size(24, 24);
            this.picBoxDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxDashboard.TabIndex = 0;
            this.picBoxDashboard.TabStop = false;
            this.picBoxDashboard.Click += new System.EventHandler(this.picBoxDashboard_Click);
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panelHome.Controls.Add(this.chart1);
            this.panelHome.Controls.Add(this.labelHome);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(3, 3);
            this.panelHome.Name = "panelHome";
            this.panelHome.Padding = new System.Windows.Forms.Padding(2);
            this.panelHome.Size = new System.Drawing.Size(746, 467);
            this.panelHome.TabIndex = 1;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.chart1.BorderlineWidth = 0;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(83, 63);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            series1.Legend = "Legend1";
            series1.Name = "chartLine";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(443, 266);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.BackColor = System.Drawing.Color.Transparent;
            this.labelHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.labelHome.Location = new System.Drawing.Point(69, 30);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(49, 18);
            this.labelHome.TabIndex = 3;
            this.labelHome.Text = "Home";
            // 
            // panelEatin
            // 
            this.panelEatin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panelEatin.Controls.Add(this.labelEatin);
            this.panelEatin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEatin.Location = new System.Drawing.Point(3, 3);
            this.panelEatin.Name = "panelEatin";
            this.panelEatin.Padding = new System.Windows.Forms.Padding(2);
            this.panelEatin.Size = new System.Drawing.Size(746, 467);
            this.panelEatin.TabIndex = 2;
            this.panelEatin.Visible = false;
            // 
            // labelEatin
            // 
            this.labelEatin.AutoSize = true;
            this.labelEatin.BackColor = System.Drawing.Color.Transparent;
            this.labelEatin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEatin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.labelEatin.Location = new System.Drawing.Point(69, 30);
            this.labelEatin.Name = "labelEatin";
            this.labelEatin.Size = new System.Drawing.Size(41, 18);
            this.labelEatin.TabIndex = 3;
            this.labelEatin.Text = "Eatin";
            // 
            // timerChart
            // 
            this.timerChart.Enabled = true;
            this.timerChart.Tick += new System.EventHandler(this.timerChart_Tick);
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelSideBar.Controls.Add(this.gradientPanelSideBar);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(5, 56);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(200, 473);
            this.panelSideBar.TabIndex = 3;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelMain.Controls.Add(this.panelEatin);
            this.panelMain.Controls.Add(this.panelHome);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(205, 56);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(3);
            this.panelMain.Size = new System.Drawing.Size(752, 473);
            this.panelMain.TabIndex = 4;
            // 
            // gradientPanelSideBar
            // 
            this.gradientPanelSideBar.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.gradientPanelSideBar.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.gradientPanelSideBar.Controls.Add(this.button2);
            this.gradientPanelSideBar.Controls.Add(this.button1);
            this.gradientPanelSideBar.Controls.Add(this.SidePanel);
            this.gradientPanelSideBar.Location = new System.Drawing.Point(5, 3);
            this.gradientPanelSideBar.Name = "gradientPanelSideBar";
            this.gradientPanelSideBar.Padding = new System.Windows.Forms.Padding(2);
            this.gradientPanelSideBar.Size = new System.Drawing.Size(192, 467);
            this.gradientPanelSideBar.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(15, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "       Eat-In";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(15, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "       Home";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.LimeGreen;
            this.SidePanel.Location = new System.Drawing.Point(3, 3);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(7, 31);
            this.SidePanel.TabIndex = 5;
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(962, 534);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSideBar);
            this.Controls.Add(this.panelTop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeviceTester";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDashboard)).EndInit();
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panelEatin.ResumeLayout(false);
            this.panelEatin.PerformLayout();
            this.panelSideBar.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.gradientPanelSideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox picBoxDashboard;
        private System.Windows.Forms.Label labelDashboard;
        private System.Windows.Forms.PictureBox picBoxRestore;
        private System.Windows.Forms.PictureBox picBoxMinimize;
        private System.Windows.Forms.PictureBox picBoxMaximize;
        private System.Windows.Forms.PictureBox picBoxExit;
        private CustomControls.GradientPanel gradientPanelSideBar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Panel panelEatin;
        private System.Windows.Forms.Label labelEatin;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timerChart;
        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Panel panelMain;
    }
}

