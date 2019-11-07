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
            this.labelHome = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelEatin = new System.Windows.Forms.Panel();
            this.labelTemp = new System.Windows.Forms.Label();
            this.timerChart = new System.Windows.Forms.Timer(this.components);
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.gradientPanel1 = new DeviceTester.CustomControls.GradientPanel();
            this.panelButtonSettings = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.buttonLogSettings = new System.Windows.Forms.Button();
            this.buttonSerialPortSettings = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonTemp = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panelActiveButtonIndicator = new System.Windows.Forms.Panel();
            this.gradientPanelSideBar = new DeviceTester.CustomControls.GradientPanel();
            this.panelDropDown = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.groupboxSerialPortOptions = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.labelFlowControl = new System.Windows.Forms.Label();
            this.labelBaudrate = new System.Windows.Forms.Label();
            this.comboboxFlowControl = new System.Windows.Forms.ComboBox();
            this.labelParity = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.comboboxPort = new System.Windows.Forms.ComboBox();
            this.comboboxBaudrate = new System.Windows.Forms.ComboBox();
            this.comboboxParity = new System.Windows.Forms.ComboBox();
            this.comboboxStopbits = new System.Windows.Forms.ComboBox();
            this.labelStopbits = new System.Windows.Forms.Label();
            this.comboboxDatabits = new System.Windows.Forms.ComboBox();
            this.labelDatabits = new System.Windows.Forms.Label();
            this.labelSettings = new System.Windows.Forms.Label();
            this.panelLogSettings = new System.Windows.Forms.Panel();
            this.groupBoxLog = new System.Windows.Forms.GroupBox();
            this.panelLogOptions = new System.Windows.Forms.Panel();
            this.radiobuttonLogAppend = new System.Windows.Forms.RadioButton();
            this.checkboxEnableLog = new System.Windows.Forms.CheckBox();
            this.radiobuttonLogOverwrite = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.timerSettingsMenu = new System.Windows.Forms.Timer(this.components);
            this.timerDashboard = new System.Windows.Forms.Timer(this.components);
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
            this.gradientPanel1.SuspendLayout();
            this.panelButtonSettings.SuspendLayout();
            this.gradientPanelSideBar.SuspendLayout();
            this.panelDropDown.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelSettings.SuspendLayout();
            this.groupboxSerialPortOptions.SuspendLayout();
            this.panelLogSettings.SuspendLayout();
            this.groupBoxLog.SuspendLayout();
            this.panelLogOptions.SuspendLayout();
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
            this.picBoxRestore.Click += new System.EventHandler(this.picboxRestore_Click);
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
            this.picBoxMinimize.Click += new System.EventHandler(this.picboxMinimize_Click);
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
            this.picBoxMaximize.Click += new System.EventHandler(this.picboxMaximize_Click);
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
            this.picBoxExit.Click += new System.EventHandler(this.picboxExit_Click);
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
            this.picBoxDashboard.Click += new System.EventHandler(this.picBoxSideBarMenu_Click);
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panelHome.Controls.Add(this.labelHome);
            this.panelHome.Controls.Add(this.chart1);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(3, 3);
            this.panelHome.Name = "panelHome";
            this.panelHome.Padding = new System.Windows.Forms.Padding(2);
            this.panelHome.Size = new System.Drawing.Size(746, 467);
            this.panelHome.TabIndex = 1;
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.BackColor = System.Drawing.Color.Transparent;
            this.labelHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.labelHome.Location = new System.Drawing.Point(17, 12);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(49, 18);
            this.labelHome.TabIndex = 3;
            this.labelHome.Text = "Home";
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
            this.chart1.Location = new System.Drawing.Point(63, 69);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            series1.Legend = "Legend1";
            series1.Name = "chartLine";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(554, 324);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // panelEatin
            // 
            this.panelEatin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panelEatin.Controls.Add(this.labelTemp);
            this.panelEatin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEatin.Location = new System.Drawing.Point(3, 3);
            this.panelEatin.Name = "panelEatin";
            this.panelEatin.Padding = new System.Windows.Forms.Padding(2);
            this.panelEatin.Size = new System.Drawing.Size(746, 467);
            this.panelEatin.TabIndex = 2;
            this.panelEatin.Visible = false;
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.BackColor = System.Drawing.Color.Transparent;
            this.labelTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.labelTemp.Location = new System.Drawing.Point(17, 12);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(46, 18);
            this.labelTemp.TabIndex = 3;
            this.labelTemp.Text = "Temp";
            // 
            // timerChart
            // 
            this.timerChart.Enabled = true;
            this.timerChart.Tick += new System.EventHandler(this.timerChart_Tick);
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelSideBar.Controls.Add(this.gradientPanel1);
            this.panelSideBar.Controls.Add(this.gradientPanelSideBar);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(5, 56);
            this.panelSideBar.MaximumSize = new System.Drawing.Size(200, 0);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(200, 473);
            this.panelSideBar.TabIndex = 3;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.gradientPanel1.Controls.Add(this.panelButtonSettings);
            this.gradientPanel1.Controls.Add(this.buttonTemp);
            this.gradientPanel1.Controls.Add(this.buttonHome);
            this.gradientPanel1.Controls.Add(this.panelActiveButtonIndicator);
            this.gradientPanel1.Location = new System.Drawing.Point(5, 3);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.gradientPanel1.Size = new System.Drawing.Size(192, 467);
            this.gradientPanel1.TabIndex = 0;
            // 
            // panelButtonSettings
            // 
            this.panelButtonSettings.BackColor = System.Drawing.Color.Transparent;
            this.panelButtonSettings.Controls.Add(this.button4);
            this.panelButtonSettings.Controls.Add(this.button10);
            this.panelButtonSettings.Controls.Add(this.buttonLogSettings);
            this.panelButtonSettings.Controls.Add(this.buttonSerialPortSettings);
            this.panelButtonSettings.Controls.Add(this.buttonSettings);
            this.panelButtonSettings.Location = new System.Drawing.Point(15, 40);
            this.panelButtonSettings.MaximumSize = new System.Drawing.Size(177, 155);
            this.panelButtonSettings.MinimumSize = new System.Drawing.Size(177, 31);
            this.panelButtonSettings.Name = "panelButtonSettings";
            this.panelButtonSettings.Size = new System.Drawing.Size(177, 31);
            this.panelButtonSettings.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(21)))), ((int)(((byte)(79)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 124);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 31);
            this.button4.TabIndex = 6;
            this.button4.Text = "button9";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(21)))), ((int)(((byte)(79)))));
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(0, 93);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(177, 31);
            this.button10.TabIndex = 5;
            this.button10.Text = "button8";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // buttonLogSettings
            // 
            this.buttonLogSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(21)))), ((int)(((byte)(79)))));
            this.buttonLogSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLogSettings.FlatAppearance.BorderSize = 0;
            this.buttonLogSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogSettings.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogSettings.ForeColor = System.Drawing.Color.White;
            this.buttonLogSettings.Location = new System.Drawing.Point(0, 62);
            this.buttonLogSettings.Name = "buttonLogSettings";
            this.buttonLogSettings.Size = new System.Drawing.Size(177, 31);
            this.buttonLogSettings.TabIndex = 4;
            this.buttonLogSettings.Text = "Log          ";
            this.buttonLogSettings.UseVisualStyleBackColor = false;
            this.buttonLogSettings.Click += new System.EventHandler(this.buttonLogSettings_Click);
            // 
            // buttonSerialPortSettings
            // 
            this.buttonSerialPortSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(21)))), ((int)(((byte)(79)))));
            this.buttonSerialPortSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSerialPortSettings.FlatAppearance.BorderSize = 0;
            this.buttonSerialPortSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSerialPortSettings.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSerialPortSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSerialPortSettings.Location = new System.Drawing.Point(0, 31);
            this.buttonSerialPortSettings.Name = "buttonSerialPortSettings";
            this.buttonSerialPortSettings.Size = new System.Drawing.Size(177, 31);
            this.buttonSerialPortSettings.TabIndex = 3;
            this.buttonSerialPortSettings.Text = "Serial Port";
            this.buttonSerialPortSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSerialPortSettings.UseVisualStyleBackColor = false;
            this.buttonSerialPortSettings.Click += new System.EventHandler(this.buttonSerialPortSettings_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.Transparent;
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.Image = global::DeviceTester.Properties.Resources.Expand_Arrow_20px;
            this.buttonSettings.Location = new System.Drawing.Point(0, 0);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(177, 31);
            this.buttonSettings.TabIndex = 2;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonTemp
            // 
            this.buttonTemp.BackColor = System.Drawing.Color.Transparent;
            this.buttonTemp.FlatAppearance.BorderSize = 0;
            this.buttonTemp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.buttonTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTemp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTemp.ForeColor = System.Drawing.Color.White;
            this.buttonTemp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTemp.Location = new System.Drawing.Point(18, 70);
            this.buttonTemp.Name = "buttonTemp";
            this.buttonTemp.Size = new System.Drawing.Size(177, 31);
            this.buttonTemp.TabIndex = 7;
            this.buttonTemp.Text = "Button         ";
            this.buttonTemp.UseVisualStyleBackColor = false;
            this.buttonTemp.Click += new System.EventHandler(this.buttonTemp_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.Transparent;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.Transparent;
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(15, 3);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(177, 31);
            this.buttonHome.TabIndex = 5;
            this.buttonHome.Text = "Home        ";
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panelActiveButtonIndicator
            // 
            this.panelActiveButtonIndicator.BackColor = System.Drawing.Color.LimeGreen;
            this.panelActiveButtonIndicator.Location = new System.Drawing.Point(3, 3);
            this.panelActiveButtonIndicator.Name = "panelActiveButtonIndicator";
            this.panelActiveButtonIndicator.Size = new System.Drawing.Size(7, 31);
            this.panelActiveButtonIndicator.TabIndex = 5;
            // 
            // gradientPanelSideBar
            // 
            this.gradientPanelSideBar.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.gradientPanelSideBar.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.gradientPanelSideBar.Controls.Add(this.panelDropDown);
            this.gradientPanelSideBar.Controls.Add(this.button3);
            this.gradientPanelSideBar.Controls.Add(this.button2);
            this.gradientPanelSideBar.Controls.Add(this.button1);
            this.gradientPanelSideBar.Controls.Add(this.SidePanel);
            this.gradientPanelSideBar.Location = new System.Drawing.Point(5, 3);
            this.gradientPanelSideBar.Name = "gradientPanelSideBar";
            this.gradientPanelSideBar.Padding = new System.Windows.Forms.Padding(2);
            this.gradientPanelSideBar.Size = new System.Drawing.Size(192, 467);
            this.gradientPanelSideBar.TabIndex = 0;
            // 
            // panelDropDown
            // 
            this.panelDropDown.Controls.Add(this.button9);
            this.panelDropDown.Controls.Add(this.button8);
            this.panelDropDown.Controls.Add(this.button7);
            this.panelDropDown.Controls.Add(this.button6);
            this.panelDropDown.Controls.Add(this.button5);
            this.panelDropDown.Location = new System.Drawing.Point(3, 121);
            this.panelDropDown.MaximumSize = new System.Drawing.Size(200, 222);
            this.panelDropDown.MinimumSize = new System.Drawing.Size(200, 57);
            this.panelDropDown.Name = "panelDropDown";
            this.panelDropDown.Size = new System.Drawing.Size(200, 222);
            this.panelDropDown.TabIndex = 4;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(0, 183);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(200, 41);
            this.button9.TabIndex = 6;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(0, 142);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(200, 41);
            this.button8.TabIndex = 5;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(0, 101);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(200, 41);
            this.button7.TabIndex = 4;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(0, 60);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 41);
            this.button6.TabIndex = 3;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 60);
            this.button5.TabIndex = 2;
            this.button5.Text = "button5";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(15, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 31);
            this.button3.TabIndex = 7;
            this.button3.Text = "       Eat-In";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
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
            this.button2.Size = new System.Drawing.Size(177, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "       Eat-In";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonTemp_Click);
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
            this.button1.Size = new System.Drawing.Size(177, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "       Home";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.LimeGreen;
            this.SidePanel.Location = new System.Drawing.Point(3, 3);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(7, 31);
            this.SidePanel.TabIndex = 5;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelMain.Controls.Add(this.panelSettings);
            this.panelMain.Controls.Add(this.panelLogSettings);
            this.panelMain.Controls.Add(this.panelEatin);
            this.panelMain.Controls.Add(this.panelHome);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(205, 56);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(3);
            this.panelMain.Size = new System.Drawing.Size(752, 473);
            this.panelMain.TabIndex = 4;
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panelSettings.Controls.Add(this.groupboxSerialPortOptions);
            this.panelSettings.Controls.Add(this.labelSettings);
            this.panelSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettings.Location = new System.Drawing.Point(3, 3);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Padding = new System.Windows.Forms.Padding(2);
            this.panelSettings.Size = new System.Drawing.Size(746, 467);
            this.panelSettings.TabIndex = 4;
            this.panelSettings.Visible = false;
            // 
            // groupboxSerialPortOptions
            // 
            this.groupboxSerialPortOptions.Controls.Add(this.button11);
            this.groupboxSerialPortOptions.Controls.Add(this.labelFlowControl);
            this.groupboxSerialPortOptions.Controls.Add(this.labelBaudrate);
            this.groupboxSerialPortOptions.Controls.Add(this.comboboxFlowControl);
            this.groupboxSerialPortOptions.Controls.Add(this.labelParity);
            this.groupboxSerialPortOptions.Controls.Add(this.labelPort);
            this.groupboxSerialPortOptions.Controls.Add(this.comboboxPort);
            this.groupboxSerialPortOptions.Controls.Add(this.comboboxBaudrate);
            this.groupboxSerialPortOptions.Controls.Add(this.comboboxParity);
            this.groupboxSerialPortOptions.Controls.Add(this.comboboxStopbits);
            this.groupboxSerialPortOptions.Controls.Add(this.labelStopbits);
            this.groupboxSerialPortOptions.Controls.Add(this.comboboxDatabits);
            this.groupboxSerialPortOptions.Controls.Add(this.labelDatabits);
            this.groupboxSerialPortOptions.ForeColor = System.Drawing.Color.White;
            this.groupboxSerialPortOptions.Location = new System.Drawing.Point(20, 51);
            this.groupboxSerialPortOptions.Name = "groupboxSerialPortOptions";
            this.groupboxSerialPortOptions.Size = new System.Drawing.Size(388, 212);
            this.groupboxSerialPortOptions.TabIndex = 10;
            this.groupboxSerialPortOptions.TabStop = false;
            this.groupboxSerialPortOptions.Text = "Serial port options";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(89, 161);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(263, 31);
            this.button11.TabIndex = 31;
            this.button11.Text = "Connect    ";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // labelFlowControl
            // 
            this.labelFlowControl.AutoSize = true;
            this.labelFlowControl.Location = new System.Drawing.Point(205, 94);
            this.labelFlowControl.Name = "labelFlowControl";
            this.labelFlowControl.Size = new System.Drawing.Size(64, 13);
            this.labelFlowControl.TabIndex = 13;
            this.labelFlowControl.Text = "Flow control";
            // 
            // labelBaudrate
            // 
            this.labelBaudrate.AutoSize = true;
            this.labelBaudrate.Location = new System.Drawing.Point(26, 66);
            this.labelBaudrate.Name = "labelBaudrate";
            this.labelBaudrate.Size = new System.Drawing.Size(50, 13);
            this.labelBaudrate.TabIndex = 8;
            this.labelBaudrate.Text = "Baudrate";
            // 
            // comboboxFlowControl
            // 
            this.comboboxFlowControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxFlowControl.FormattingEnabled = true;
            this.comboboxFlowControl.Location = new System.Drawing.Point(278, 91);
            this.comboboxFlowControl.Name = "comboboxFlowControl";
            this.comboboxFlowControl.Size = new System.Drawing.Size(74, 21);
            this.comboboxFlowControl.TabIndex = 12;
            // 
            // labelParity
            // 
            this.labelParity.AutoSize = true;
            this.labelParity.Location = new System.Drawing.Point(205, 66);
            this.labelParity.Name = "labelParity";
            this.labelParity.Size = new System.Drawing.Size(33, 13);
            this.labelParity.TabIndex = 11;
            this.labelParity.Text = "Parity";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(28, 37);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(26, 13);
            this.labelPort.TabIndex = 7;
            this.labelPort.Text = "Port";
            // 
            // comboboxPort
            // 
            this.comboboxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxPort.FormattingEnabled = true;
            this.comboboxPort.Location = new System.Drawing.Point(89, 34);
            this.comboboxPort.Name = "comboboxPort";
            this.comboboxPort.Size = new System.Drawing.Size(76, 21);
            this.comboboxPort.TabIndex = 1;
            // 
            // comboboxBaudrate
            // 
            this.comboboxBaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxBaudrate.FormattingEnabled = true;
            this.comboboxBaudrate.Location = new System.Drawing.Point(89, 63);
            this.comboboxBaudrate.Name = "comboboxBaudrate";
            this.comboboxBaudrate.Size = new System.Drawing.Size(75, 21);
            this.comboboxBaudrate.TabIndex = 2;
            // 
            // comboboxParity
            // 
            this.comboboxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxParity.FormattingEnabled = true;
            this.comboboxParity.Location = new System.Drawing.Point(278, 63);
            this.comboboxParity.Name = "comboboxParity";
            this.comboboxParity.Size = new System.Drawing.Size(74, 21);
            this.comboboxParity.TabIndex = 5;
            // 
            // comboboxStopbits
            // 
            this.comboboxStopbits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.comboboxStopbits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxStopbits.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboboxStopbits.FormattingEnabled = true;
            this.comboboxStopbits.Location = new System.Drawing.Point(278, 34);
            this.comboboxStopbits.Name = "comboboxStopbits";
            this.comboboxStopbits.Size = new System.Drawing.Size(74, 21);
            this.comboboxStopbits.TabIndex = 4;
            // 
            // labelStopbits
            // 
            this.labelStopbits.AutoSize = true;
            this.labelStopbits.Location = new System.Drawing.Point(204, 37);
            this.labelStopbits.Name = "labelStopbits";
            this.labelStopbits.Size = new System.Drawing.Size(48, 13);
            this.labelStopbits.TabIndex = 10;
            this.labelStopbits.Text = "Stop bits";
            // 
            // comboboxDatabits
            // 
            this.comboboxDatabits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxDatabits.FormattingEnabled = true;
            this.comboboxDatabits.Location = new System.Drawing.Point(89, 92);
            this.comboboxDatabits.Name = "comboboxDatabits";
            this.comboboxDatabits.Size = new System.Drawing.Size(76, 21);
            this.comboboxDatabits.TabIndex = 3;
            // 
            // labelDatabits
            // 
            this.labelDatabits.AutoSize = true;
            this.labelDatabits.Location = new System.Drawing.Point(27, 95);
            this.labelDatabits.Name = "labelDatabits";
            this.labelDatabits.Size = new System.Drawing.Size(49, 13);
            this.labelDatabits.TabIndex = 9;
            this.labelDatabits.Text = "Data bits";
            // 
            // labelSettings
            // 
            this.labelSettings.AutoSize = true;
            this.labelSettings.BackColor = System.Drawing.Color.Transparent;
            this.labelSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.labelSettings.Location = new System.Drawing.Point(17, 12);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(61, 18);
            this.labelSettings.TabIndex = 3;
            this.labelSettings.Text = "Settings";
            // 
            // panelLogSettings
            // 
            this.panelLogSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panelLogSettings.Controls.Add(this.groupBoxLog);
            this.panelLogSettings.Controls.Add(this.label1);
            this.panelLogSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogSettings.Location = new System.Drawing.Point(3, 3);
            this.panelLogSettings.Name = "panelLogSettings";
            this.panelLogSettings.Padding = new System.Windows.Forms.Padding(2);
            this.panelLogSettings.Size = new System.Drawing.Size(746, 467);
            this.panelLogSettings.TabIndex = 3;
            this.panelLogSettings.Visible = false;
            // 
            // groupBoxLog
            // 
            this.groupBoxLog.Controls.Add(this.panelLogOptions);
            this.groupBoxLog.ForeColor = System.Drawing.Color.White;
            this.groupBoxLog.Location = new System.Drawing.Point(20, 53);
            this.groupBoxLog.Name = "groupBoxLog";
            this.groupBoxLog.Size = new System.Drawing.Size(194, 90);
            this.groupBoxLog.TabIndex = 29;
            this.groupBoxLog.TabStop = false;
            this.groupBoxLog.Text = "Data logger";
            // 
            // panelLogOptions
            // 
            this.panelLogOptions.Controls.Add(this.radiobuttonLogAppend);
            this.panelLogOptions.Controls.Add(this.checkboxEnableLog);
            this.panelLogOptions.Controls.Add(this.radiobuttonLogOverwrite);
            this.panelLogOptions.Location = new System.Drawing.Point(9, 25);
            this.panelLogOptions.Name = "panelLogOptions";
            this.panelLogOptions.Size = new System.Drawing.Size(171, 54);
            this.panelLogOptions.TabIndex = 28;
            // 
            // radiobuttonLogAppend
            // 
            this.radiobuttonLogAppend.AutoSize = true;
            this.radiobuttonLogAppend.Checked = true;
            this.radiobuttonLogAppend.ForeColor = System.Drawing.Color.White;
            this.radiobuttonLogAppend.Location = new System.Drawing.Point(28, 26);
            this.radiobuttonLogAppend.Name = "radiobuttonLogAppend";
            this.radiobuttonLogAppend.Size = new System.Drawing.Size(62, 17);
            this.radiobuttonLogAppend.TabIndex = 31;
            this.radiobuttonLogAppend.TabStop = true;
            this.radiobuttonLogAppend.Text = "Append";
            this.radiobuttonLogAppend.UseVisualStyleBackColor = true;
            // 
            // checkboxEnableLog
            // 
            this.checkboxEnableLog.AutoSize = true;
            this.checkboxEnableLog.BackColor = System.Drawing.Color.Transparent;
            this.checkboxEnableLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkboxEnableLog.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkboxEnableLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.checkboxEnableLog.Location = new System.Drawing.Point(6, 3);
            this.checkboxEnableLog.MaximumSize = new System.Drawing.Size(400, 19);
            this.checkboxEnableLog.Name = "checkboxEnableLog";
            this.checkboxEnableLog.Size = new System.Drawing.Size(117, 17);
            this.checkboxEnableLog.TabIndex = 15;
            this.checkboxEnableLog.Text = "Enable Data logger";
            this.checkboxEnableLog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkboxEnableLog.UseVisualStyleBackColor = false;
            // 
            // radiobuttonLogOverwrite
            // 
            this.radiobuttonLogOverwrite.AutoSize = true;
            this.radiobuttonLogOverwrite.ForeColor = System.Drawing.Color.White;
            this.radiobuttonLogOverwrite.Location = new System.Drawing.Point(98, 26);
            this.radiobuttonLogOverwrite.Name = "radiobuttonLogOverwrite";
            this.radiobuttonLogOverwrite.Size = new System.Drawing.Size(70, 17);
            this.radiobuttonLogOverwrite.TabIndex = 30;
            this.radiobuttonLogOverwrite.Text = "Overwrite";
            this.radiobuttonLogOverwrite.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Log";
            // 
            // timerSettingsMenu
            // 
            this.timerSettingsMenu.Interval = 10;
            this.timerSettingsMenu.Tick += new System.EventHandler(this.timerSettingsDropdownMenu_Tick);
            // 
            // timerDashboard
            // 
            this.timerDashboard.Interval = 10;
            this.timerDashboard.Tick += new System.EventHandler(this.timerSideBarMenu_Tick);
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
            this.gradientPanel1.ResumeLayout(false);
            this.panelButtonSettings.ResumeLayout(false);
            this.gradientPanelSideBar.ResumeLayout(false);
            this.panelDropDown.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.groupboxSerialPortOptions.ResumeLayout(false);
            this.groupboxSerialPortOptions.PerformLayout();
            this.panelLogSettings.ResumeLayout(false);
            this.panelLogSettings.PerformLayout();
            this.groupBoxLog.ResumeLayout(false);
            this.panelLogOptions.ResumeLayout(false);
            this.panelLogOptions.PerformLayout();
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
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timerChart;
        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Panel panelMain;
        private CustomControls.GradientPanel gradientPanel1;
        private System.Windows.Forms.Panel panelButtonSettings;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button buttonLogSettings;
        private System.Windows.Forms.Button buttonSerialPortSettings;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panelActiveButtonIndicator;
        private System.Windows.Forms.Panel panelDropDown;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timerSettingsMenu;
        private System.Windows.Forms.Timer timerDashboard;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.GroupBox groupboxSerialPortOptions;
        private System.Windows.Forms.Label labelFlowControl;
        private System.Windows.Forms.Label labelBaudrate;
        private System.Windows.Forms.ComboBox comboboxFlowControl;
        private System.Windows.Forms.Label labelParity;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.ComboBox comboboxPort;
        private System.Windows.Forms.ComboBox comboboxBaudrate;
        private System.Windows.Forms.ComboBox comboboxParity;
        private System.Windows.Forms.ComboBox comboboxStopbits;
        private System.Windows.Forms.Label labelStopbits;
        private System.Windows.Forms.ComboBox comboboxDatabits;
        private System.Windows.Forms.Label labelDatabits;
        private System.Windows.Forms.Button buttonTemp;
        private System.Windows.Forms.Panel panelLogSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxLog;
        private System.Windows.Forms.Panel panelLogOptions;
        private System.Windows.Forms.CheckBox checkboxEnableLog;
        private System.Windows.Forms.RadioButton radiobuttonLogOverwrite;
        private System.Windows.Forms.RadioButton radiobuttonLogAppend;
        private System.Windows.Forms.Button button11;
    }
}

