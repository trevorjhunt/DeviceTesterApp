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
            this.panelTop = new System.Windows.Forms.Panel();
            this.picBoxRestore = new System.Windows.Forms.PictureBox();
            this.picBoxMinimize = new System.Windows.Forms.PictureBox();
            this.picBoxMaximize = new System.Windows.Forms.PictureBox();
            this.picBoxExit = new System.Windows.Forms.PictureBox();
            this.labelDashboard = new System.Windows.Forms.Label();
            this.picBoxDashboard = new System.Windows.Forms.PictureBox();
            this.textBoxFactoryConnectedPort = new System.Windows.Forms.TextBox();
            this.buttonFactoryConnect = new System.Windows.Forms.Button();
            this.panelFactory = new System.Windows.Forms.Panel();
            this.groupBoxFactorySettings = new System.Windows.Forms.GroupBox();
            this.buttonFactoryWrite = new System.Windows.Forms.Button();
            this.buttonFactoryRead = new System.Windows.Forms.Button();
            this.labelSerialNumber = new System.Windows.Forms.Label();
            this.labelTempOffset = new System.Windows.Forms.Label();
            this.textBoxSerialNumber = new System.Windows.Forms.TextBox();
            this.textBoxTempOffset = new System.Windows.Forms.TextBox();
            this.labelProduct = new System.Windows.Forms.Label();
            this.labelFrequency = new System.Windows.Forms.Label();
            this.comboBoxFrequency = new System.Windows.Forms.ComboBox();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.comboBoxVariant = new System.Windows.Forms.ComboBox();
            this.labelVariant = new System.Windows.Forms.Label();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.labelCountry = new System.Windows.Forms.Label();
            this.panelTerminal = new System.Windows.Forms.Panel();
            this.timerChart = new System.Windows.Forms.Timer(this.components);
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSerialPort = new System.Windows.Forms.Panel();
            this.buttonSerialPortConnect = new System.Windows.Forms.Button();
            this.groupboxSerialPortOptions = new System.Windows.Forms.GroupBox();
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
            this.panelLog = new System.Windows.Forms.Panel();
            this.groupBoxLog = new System.Windows.Forms.GroupBox();
            this.panelLogOptions = new System.Windows.Forms.Panel();
            this.radiobuttonLogAppend = new System.Windows.Forms.RadioButton();
            this.checkboxEnableLog = new System.Windows.Forms.CheckBox();
            this.radiobuttonLogOverwrite = new System.Windows.Forms.RadioButton();
            this.timerSettingsMenu = new System.Windows.Forms.Timer(this.components);
            this.timerDashboard = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.serialPortDut = new System.IO.Ports.SerialPort(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.checkBoxTimestamp = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxTerminal = new System.Windows.Forms.GroupBox();
            this.radioButtonRxDisplayHex = new System.Windows.Forms.RadioButton();
            this.buttonTerminalRxClear = new System.Windows.Forms.Button();
            this.labelRecieve = new System.Windows.Forms.Label();
            this.buttonTerminalTxClear = new System.Windows.Forms.Button();
            this.textboxRecievedData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTerminalPort = new System.Windows.Forms.TextBox();
            this.buttonTerminalConnectPort = new System.Windows.Forms.Button();
            this.radioButtonTxFile = new System.Windows.Forms.RadioButton();
            this.radioButtonTxKeys = new System.Windows.Forms.RadioButton();
            this.radioButtonTxCommands = new System.Windows.Forms.RadioButton();
            this.labelDelay = new System.Windows.Forms.Label();
            this.labelRepeats = new System.Windows.Forms.Label();
            this.buttonTerminalSend = new System.Windows.Forms.Button();
            this.numericUpDownTxRepeats = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gradientPanel1 = new DeviceTester.CustomControls.GradientPanel();
            this.panelButtonSettings = new System.Windows.Forms.Panel();
            this.buttonLogSettings = new System.Windows.Forms.Button();
            this.buttonSerialPortSettings = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonTerminal = new System.Windows.Forms.Button();
            this.buttonFactory = new System.Windows.Forms.Button();
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
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDashboard)).BeginInit();
            this.panelFactory.SuspendLayout();
            this.groupBoxFactorySettings.SuspendLayout();
            this.panelTerminal.SuspendLayout();
            this.panelSideBar.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelSerialPort.SuspendLayout();
            this.groupboxSerialPortOptions.SuspendLayout();
            this.panelLog.SuspendLayout();
            this.groupBoxLog.SuspendLayout();
            this.panelLogOptions.SuspendLayout();
            this.groupBoxTerminal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTxRepeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.panelButtonSettings.SuspendLayout();
            this.gradientPanelSideBar.SuspendLayout();
            this.panelDropDown.SuspendLayout();
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
            this.panelTop.Size = new System.Drawing.Size(790, 51);
            this.panelTop.TabIndex = 1;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // picBoxRestore
            // 
            this.picBoxRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxRestore.Image = ((System.Drawing.Image)(resources.GetObject("picBoxRestore.Image")));
            this.picBoxRestore.Location = new System.Drawing.Point(726, 14);
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
            this.picBoxMinimize.Location = new System.Drawing.Point(700, 14);
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
            this.picBoxMaximize.Location = new System.Drawing.Point(726, 14);
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
            this.picBoxExit.Location = new System.Drawing.Point(752, 14);
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
            // textBoxFactoryConnectedPort
            // 
            this.textBoxFactoryConnectedPort.Location = new System.Drawing.Point(443, 286);
            this.textBoxFactoryConnectedPort.Name = "textBoxFactoryConnectedPort";
            this.textBoxFactoryConnectedPort.Size = new System.Drawing.Size(76, 20);
            this.textBoxFactoryConnectedPort.TabIndex = 33;
            this.textBoxFactoryConnectedPort.TextChanged += new System.EventHandler(this.textBoxFactoryConnectedPort_TextChanged);
            // 
            // buttonFactoryConnect
            // 
            this.buttonFactoryConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.buttonFactoryConnect.FlatAppearance.BorderSize = 0;
            this.buttonFactoryConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.buttonFactoryConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFactoryConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonFactoryConnect.ForeColor = System.Drawing.Color.White;
            this.buttonFactoryConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFactoryConnect.Location = new System.Drawing.Point(363, 284);
            this.buttonFactoryConnect.Name = "buttonFactoryConnect";
            this.buttonFactoryConnect.Size = new System.Drawing.Size(76, 27);
            this.buttonFactoryConnect.TabIndex = 32;
            this.buttonFactoryConnect.Text = "Connect";
            this.buttonFactoryConnect.UseVisualStyleBackColor = false;
            this.buttonFactoryConnect.Click += new System.EventHandler(this.buttonFactoryConnect_Click);
            // 
            // panelFactory
            // 
            this.panelFactory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panelFactory.Controls.Add(this.buttonFactoryConnect);
            this.panelFactory.Controls.Add(this.textBoxFactoryConnectedPort);
            this.panelFactory.Controls.Add(this.groupBoxFactorySettings);
            this.panelFactory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFactory.Location = new System.Drawing.Point(3, 3);
            this.panelFactory.Name = "panelFactory";
            this.panelFactory.Padding = new System.Windows.Forms.Padding(2);
            this.panelFactory.Size = new System.Drawing.Size(584, 413);
            this.panelFactory.TabIndex = 1;
            // 
            // groupBoxFactorySettings
            // 
            this.groupBoxFactorySettings.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxFactorySettings.Controls.Add(this.buttonFactoryWrite);
            this.groupBoxFactorySettings.Controls.Add(this.buttonFactoryRead);
            this.groupBoxFactorySettings.Controls.Add(this.labelSerialNumber);
            this.groupBoxFactorySettings.Controls.Add(this.labelTempOffset);
            this.groupBoxFactorySettings.Controls.Add(this.textBoxSerialNumber);
            this.groupBoxFactorySettings.Controls.Add(this.textBoxTempOffset);
            this.groupBoxFactorySettings.Controls.Add(this.labelProduct);
            this.groupBoxFactorySettings.Controls.Add(this.labelFrequency);
            this.groupBoxFactorySettings.Controls.Add(this.comboBoxFrequency);
            this.groupBoxFactorySettings.Controls.Add(this.comboBoxProduct);
            this.groupBoxFactorySettings.Controls.Add(this.comboBoxVariant);
            this.groupBoxFactorySettings.Controls.Add(this.labelVariant);
            this.groupBoxFactorySettings.Controls.Add(this.comboBoxCountry);
            this.groupBoxFactorySettings.Controls.Add(this.labelCountry);
            this.groupBoxFactorySettings.ForeColor = System.Drawing.Color.White;
            this.groupBoxFactorySettings.Location = new System.Drawing.Point(11, 5);
            this.groupBoxFactorySettings.Name = "groupBoxFactorySettings";
            this.groupBoxFactorySettings.Size = new System.Drawing.Size(510, 273);
            this.groupBoxFactorySettings.TabIndex = 11;
            this.groupBoxFactorySettings.TabStop = false;
            this.groupBoxFactorySettings.Text = "Factory settings";
            // 
            // buttonFactoryWrite
            // 
            this.buttonFactoryWrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.buttonFactoryWrite.FlatAppearance.BorderSize = 0;
            this.buttonFactoryWrite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.buttonFactoryWrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFactoryWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonFactoryWrite.ForeColor = System.Drawing.Color.White;
            this.buttonFactoryWrite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFactoryWrite.Location = new System.Drawing.Point(397, 51);
            this.buttonFactoryWrite.Name = "buttonFactoryWrite";
            this.buttonFactoryWrite.Size = new System.Drawing.Size(76, 27);
            this.buttonFactoryWrite.TabIndex = 34;
            this.buttonFactoryWrite.Text = "Write";
            this.buttonFactoryWrite.UseVisualStyleBackColor = false;
            // 
            // buttonFactoryRead
            // 
            this.buttonFactoryRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.buttonFactoryRead.FlatAppearance.BorderSize = 0;
            this.buttonFactoryRead.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.buttonFactoryRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFactoryRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonFactoryRead.ForeColor = System.Drawing.Color.White;
            this.buttonFactoryRead.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFactoryRead.Location = new System.Drawing.Point(397, 88);
            this.buttonFactoryRead.Name = "buttonFactoryRead";
            this.buttonFactoryRead.Size = new System.Drawing.Size(76, 27);
            this.buttonFactoryRead.TabIndex = 33;
            this.buttonFactoryRead.Text = "Read";
            this.buttonFactoryRead.UseVisualStyleBackColor = false;
            // 
            // labelSerialNumber
            // 
            this.labelSerialNumber.AutoSize = true;
            this.labelSerialNumber.Location = new System.Drawing.Point(57, 58);
            this.labelSerialNumber.Name = "labelSerialNumber";
            this.labelSerialNumber.Size = new System.Drawing.Size(73, 13);
            this.labelSerialNumber.TabIndex = 14;
            this.labelSerialNumber.Text = "Serial Number";
            // 
            // labelTempOffset
            // 
            this.labelTempOffset.AutoSize = true;
            this.labelTempOffset.Location = new System.Drawing.Point(65, 188);
            this.labelTempOffset.Name = "labelTempOffset";
            this.labelTempOffset.Size = new System.Drawing.Size(65, 13);
            this.labelTempOffset.TabIndex = 13;
            this.labelTempOffset.Text = "Temp Offset";
            // 
            // textBoxSerialNumber
            // 
            this.textBoxSerialNumber.Location = new System.Drawing.Point(141, 55);
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.Size = new System.Drawing.Size(76, 20);
            this.textBoxSerialNumber.TabIndex = 12;
            // 
            // textBoxTempOffset
            // 
            this.textBoxTempOffset.Location = new System.Drawing.Point(141, 189);
            this.textBoxTempOffset.Name = "textBoxTempOffset";
            this.textBoxTempOffset.Size = new System.Drawing.Size(76, 20);
            this.textBoxTempOffset.TabIndex = 11;
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(86, 84);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(44, 13);
            this.labelProduct.TabIndex = 8;
            this.labelProduct.Text = "Product";
            // 
            // labelFrequency
            // 
            this.labelFrequency.AutoSize = true;
            this.labelFrequency.Location = new System.Drawing.Point(73, 162);
            this.labelFrequency.Name = "labelFrequency";
            this.labelFrequency.Size = new System.Drawing.Size(57, 13);
            this.labelFrequency.TabIndex = 7;
            this.labelFrequency.Text = "Frequency";
            // 
            // comboBoxFrequency
            // 
            this.comboBoxFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFrequency.FormattingEnabled = true;
            this.comboBoxFrequency.Location = new System.Drawing.Point(141, 162);
            this.comboBoxFrequency.Name = "comboBoxFrequency";
            this.comboBoxFrequency.Size = new System.Drawing.Size(76, 21);
            this.comboBoxFrequency.TabIndex = 1;
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Items.AddRange(new object[] {
            "RF-Output",
            "RF-MicroContact"});
            this.comboBoxProduct.Location = new System.Drawing.Point(142, 81);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(76, 21);
            this.comboBoxProduct.TabIndex = 2;
            // 
            // comboBoxVariant
            // 
            this.comboBoxVariant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.comboBoxVariant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVariant.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxVariant.FormattingEnabled = true;
            this.comboBoxVariant.Location = new System.Drawing.Point(141, 135);
            this.comboBoxVariant.Name = "comboBoxVariant";
            this.comboBoxVariant.Size = new System.Drawing.Size(76, 21);
            this.comboBoxVariant.TabIndex = 4;
            // 
            // labelVariant
            // 
            this.labelVariant.AutoSize = true;
            this.labelVariant.Location = new System.Drawing.Point(90, 136);
            this.labelVariant.Name = "labelVariant";
            this.labelVariant.Size = new System.Drawing.Size(40, 13);
            this.labelVariant.TabIndex = 10;
            this.labelVariant.Text = "Variant";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Items.AddRange(new object[] {
            "Ireland",
            "UnitedKingdom"});
            this.comboBoxCountry.Location = new System.Drawing.Point(141, 108);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(76, 21);
            this.comboBoxCountry.TabIndex = 3;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Location = new System.Drawing.Point(87, 110);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(43, 13);
            this.labelCountry.TabIndex = 9;
            this.labelCountry.Text = "Country";
            // 
            // panelTerminal
            // 
            this.panelTerminal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panelTerminal.Controls.Add(this.groupBoxTerminal);
            this.panelTerminal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTerminal.Location = new System.Drawing.Point(3, 3);
            this.panelTerminal.Name = "panelTerminal";
            this.panelTerminal.Padding = new System.Windows.Forms.Padding(2);
            this.panelTerminal.Size = new System.Drawing.Size(584, 413);
            this.panelTerminal.TabIndex = 2;
            this.panelTerminal.Visible = false;
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
            this.panelSideBar.Size = new System.Drawing.Size(200, 419);
            this.panelSideBar.TabIndex = 3;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelMain.Controls.Add(this.panelLog);
            this.panelMain.Controls.Add(this.panelTerminal);
            this.panelMain.Controls.Add(this.panelFactory);
            this.panelMain.Controls.Add(this.panelSerialPort);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(205, 56);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(3);
            this.panelMain.Size = new System.Drawing.Size(590, 419);
            this.panelMain.TabIndex = 4;
            // 
            // panelSerialPort
            // 
            this.panelSerialPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panelSerialPort.Controls.Add(this.buttonSerialPortConnect);
            this.panelSerialPort.Controls.Add(this.groupboxSerialPortOptions);
            this.panelSerialPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSerialPort.Location = new System.Drawing.Point(3, 3);
            this.panelSerialPort.Name = "panelSerialPort";
            this.panelSerialPort.Padding = new System.Windows.Forms.Padding(2);
            this.panelSerialPort.Size = new System.Drawing.Size(584, 413);
            this.panelSerialPort.TabIndex = 4;
            this.panelSerialPort.Visible = false;
            // 
            // buttonSerialPortConnect
            // 
            this.buttonSerialPortConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.buttonSerialPortConnect.FlatAppearance.BorderSize = 0;
            this.buttonSerialPortConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.buttonSerialPortConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSerialPortConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSerialPortConnect.ForeColor = System.Drawing.Color.White;
            this.buttonSerialPortConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSerialPortConnect.Location = new System.Drawing.Point(164, 247);
            this.buttonSerialPortConnect.Name = "buttonSerialPortConnect";
            this.buttonSerialPortConnect.Size = new System.Drawing.Size(110, 31);
            this.buttonSerialPortConnect.TabIndex = 31;
            this.buttonSerialPortConnect.Text = "Connect";
            this.buttonSerialPortConnect.UseVisualStyleBackColor = false;
            this.buttonSerialPortConnect.Click += new System.EventHandler(this.buttonSerialPortConnect_Click);
            // 
            // groupboxSerialPortOptions
            // 
            this.groupboxSerialPortOptions.BackColor = System.Drawing.Color.Transparent;
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
            this.groupboxSerialPortOptions.Location = new System.Drawing.Point(11, 5);
            this.groupboxSerialPortOptions.Name = "groupboxSerialPortOptions";
            this.groupboxSerialPortOptions.Size = new System.Drawing.Size(262, 230);
            this.groupboxSerialPortOptions.TabIndex = 10;
            this.groupboxSerialPortOptions.TabStop = false;
            this.groupboxSerialPortOptions.Text = "Serial port options";
            // 
            // labelFlowControl
            // 
            this.labelFlowControl.AutoSize = true;
            this.labelFlowControl.Location = new System.Drawing.Point(19, 184);
            this.labelFlowControl.Name = "labelFlowControl";
            this.labelFlowControl.Size = new System.Drawing.Size(64, 13);
            this.labelFlowControl.TabIndex = 13;
            this.labelFlowControl.Text = "Flow control";
            // 
            // labelBaudrate
            // 
            this.labelBaudrate.AutoSize = true;
            this.labelBaudrate.Location = new System.Drawing.Point(33, 68);
            this.labelBaudrate.Name = "labelBaudrate";
            this.labelBaudrate.Size = new System.Drawing.Size(50, 13);
            this.labelBaudrate.TabIndex = 8;
            this.labelBaudrate.Text = "Baudrate";
            // 
            // comboboxFlowControl
            // 
            this.comboboxFlowControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxFlowControl.FormattingEnabled = true;
            this.comboboxFlowControl.Location = new System.Drawing.Point(89, 179);
            this.comboboxFlowControl.Name = "comboboxFlowControl";
            this.comboboxFlowControl.Size = new System.Drawing.Size(76, 21);
            this.comboboxFlowControl.TabIndex = 12;
            // 
            // labelParity
            // 
            this.labelParity.AutoSize = true;
            this.labelParity.Location = new System.Drawing.Point(50, 155);
            this.labelParity.Name = "labelParity";
            this.labelParity.Size = new System.Drawing.Size(33, 13);
            this.labelParity.TabIndex = 11;
            this.labelParity.Text = "Parity";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(57, 39);
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
            this.comboboxBaudrate.Size = new System.Drawing.Size(76, 21);
            this.comboboxBaudrate.TabIndex = 2;
            // 
            // comboboxParity
            // 
            this.comboboxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxParity.FormattingEnabled = true;
            this.comboboxParity.Location = new System.Drawing.Point(89, 150);
            this.comboboxParity.Name = "comboboxParity";
            this.comboboxParity.Size = new System.Drawing.Size(76, 21);
            this.comboboxParity.TabIndex = 5;
            // 
            // comboboxStopbits
            // 
            this.comboboxStopbits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.comboboxStopbits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxStopbits.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboboxStopbits.FormattingEnabled = true;
            this.comboboxStopbits.Location = new System.Drawing.Point(89, 121);
            this.comboboxStopbits.Name = "comboboxStopbits";
            this.comboboxStopbits.Size = new System.Drawing.Size(76, 21);
            this.comboboxStopbits.TabIndex = 4;
            // 
            // labelStopbits
            // 
            this.labelStopbits.AutoSize = true;
            this.labelStopbits.Location = new System.Drawing.Point(35, 126);
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
            this.labelDatabits.Location = new System.Drawing.Point(34, 97);
            this.labelDatabits.Name = "labelDatabits";
            this.labelDatabits.Size = new System.Drawing.Size(49, 13);
            this.labelDatabits.TabIndex = 9;
            this.labelDatabits.Text = "Data bits";
            // 
            // panelLog
            // 
            this.panelLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panelLog.Controls.Add(this.groupBoxLog);
            this.panelLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLog.Location = new System.Drawing.Point(3, 3);
            this.panelLog.Name = "panelLog";
            this.panelLog.Padding = new System.Windows.Forms.Padding(2);
            this.panelLog.Size = new System.Drawing.Size(584, 413);
            this.panelLog.TabIndex = 3;
            this.panelLog.Visible = false;
            // 
            // groupBoxLog
            // 
            this.groupBoxLog.Controls.Add(this.panelLogOptions);
            this.groupBoxLog.ForeColor = System.Drawing.Color.White;
            this.groupBoxLog.Location = new System.Drawing.Point(11, 5);
            this.groupBoxLog.Name = "groupBoxLog";
            this.groupBoxLog.Size = new System.Drawing.Size(414, 189);
            this.groupBoxLog.TabIndex = 29;
            this.groupBoxLog.TabStop = false;
            this.groupBoxLog.Text = "Log";
            // 
            // panelLogOptions
            // 
            this.panelLogOptions.Controls.Add(this.textBox1);
            this.panelLogOptions.Controls.Add(this.checkBoxTimestamp);
            this.panelLogOptions.Controls.Add(this.radiobuttonLogAppend);
            this.panelLogOptions.Controls.Add(this.checkboxEnableLog);
            this.panelLogOptions.Controls.Add(this.radiobuttonLogOverwrite);
            this.panelLogOptions.Location = new System.Drawing.Point(9, 25);
            this.panelLogOptions.Name = "panelLogOptions";
            this.panelLogOptions.Size = new System.Drawing.Size(389, 126);
            this.panelLogOptions.TabIndex = 28;
            // 
            // radiobuttonLogAppend
            // 
            this.radiobuttonLogAppend.AutoSize = true;
            this.radiobuttonLogAppend.BackColor = System.Drawing.Color.Transparent;
            this.radiobuttonLogAppend.Checked = true;
            this.radiobuttonLogAppend.Enabled = false;
            this.radiobuttonLogAppend.ForeColor = System.Drawing.Color.White;
            this.radiobuttonLogAppend.Location = new System.Drawing.Point(56, 35);
            this.radiobuttonLogAppend.Name = "radiobuttonLogAppend";
            this.radiobuttonLogAppend.Size = new System.Drawing.Size(62, 17);
            this.radiobuttonLogAppend.TabIndex = 31;
            this.radiobuttonLogAppend.TabStop = true;
            this.radiobuttonLogAppend.Text = "Append";
            this.radiobuttonLogAppend.UseVisualStyleBackColor = false;
            // 
            // checkboxEnableLog
            // 
            this.checkboxEnableLog.AutoSize = true;
            this.checkboxEnableLog.BackColor = System.Drawing.Color.Transparent;
            this.checkboxEnableLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkboxEnableLog.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkboxEnableLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.checkboxEnableLog.Location = new System.Drawing.Point(22, 5);
            this.checkboxEnableLog.MaximumSize = new System.Drawing.Size(400, 19);
            this.checkboxEnableLog.Name = "checkboxEnableLog";
            this.checkboxEnableLog.Size = new System.Drawing.Size(80, 17);
            this.checkboxEnableLog.TabIndex = 15;
            this.checkboxEnableLog.Text = "Enable Log";
            this.checkboxEnableLog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkboxEnableLog.UseVisualStyleBackColor = false;
            this.checkboxEnableLog.CheckedChanged += new System.EventHandler(this.checkboxEnableLog_CheckedChanged);
            // 
            // radiobuttonLogOverwrite
            // 
            this.radiobuttonLogOverwrite.AutoSize = true;
            this.radiobuttonLogOverwrite.BackColor = System.Drawing.Color.Transparent;
            this.radiobuttonLogOverwrite.Enabled = false;
            this.radiobuttonLogOverwrite.ForeColor = System.Drawing.Color.White;
            this.radiobuttonLogOverwrite.Location = new System.Drawing.Point(56, 55);
            this.radiobuttonLogOverwrite.Name = "radiobuttonLogOverwrite";
            this.radiobuttonLogOverwrite.Size = new System.Drawing.Size(70, 17);
            this.radiobuttonLogOverwrite.TabIndex = 30;
            this.radiobuttonLogOverwrite.Text = "Overwrite";
            this.radiobuttonLogOverwrite.UseVisualStyleBackColor = false;
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
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "log_file";
            this.openFileDialog1.Filter = "Text|*.txt";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // serialPortDut
            // 
            this.serialPortDut.BaudRate = 115200;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // checkBoxTimestamp
            // 
            this.checkBoxTimestamp.AutoSize = true;
            this.checkBoxTimestamp.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxTimestamp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBoxTimestamp.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBoxTimestamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.checkBoxTimestamp.Location = new System.Drawing.Point(56, 78);
            this.checkBoxTimestamp.MaximumSize = new System.Drawing.Size(400, 19);
            this.checkBoxTimestamp.Name = "checkBoxTimestamp";
            this.checkBoxTimestamp.Size = new System.Drawing.Size(80, 17);
            this.checkBoxTimestamp.TabIndex = 32;
            this.checkBoxTimestamp.Text = "Time stamp";
            this.checkBoxTimestamp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxTimestamp.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 20);
            this.textBox1.TabIndex = 30;
            // 
            // groupBoxTerminal
            // 
            this.groupBoxTerminal.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTerminal.Controls.Add(this.radioButtonRxDisplayHex);
            this.groupBoxTerminal.Controls.Add(this.buttonTerminalRxClear);
            this.groupBoxTerminal.Controls.Add(this.labelRecieve);
            this.groupBoxTerminal.Controls.Add(this.buttonTerminalTxClear);
            this.groupBoxTerminal.Controls.Add(this.textboxRecievedData);
            this.groupBoxTerminal.Controls.Add(this.label1);
            this.groupBoxTerminal.Controls.Add(this.textBoxTerminalPort);
            this.groupBoxTerminal.Controls.Add(this.buttonTerminalConnectPort);
            this.groupBoxTerminal.Controls.Add(this.radioButtonTxFile);
            this.groupBoxTerminal.Controls.Add(this.radioButtonTxKeys);
            this.groupBoxTerminal.Controls.Add(this.radioButtonTxCommands);
            this.groupBoxTerminal.Controls.Add(this.labelDelay);
            this.groupBoxTerminal.Controls.Add(this.labelRepeats);
            this.groupBoxTerminal.Controls.Add(this.buttonTerminalSend);
            this.groupBoxTerminal.Controls.Add(this.numericUpDownTxRepeats);
            this.groupBoxTerminal.Controls.Add(this.numericUpDown1);
            this.groupBoxTerminal.Controls.Add(this.textBox2);
            this.groupBoxTerminal.ForeColor = System.Drawing.Color.White;
            this.groupBoxTerminal.Location = new System.Drawing.Point(11, 5);
            this.groupBoxTerminal.Name = "groupBoxTerminal";
            this.groupBoxTerminal.Size = new System.Drawing.Size(568, 403);
            this.groupBoxTerminal.TabIndex = 57;
            this.groupBoxTerminal.TabStop = false;
            this.groupBoxTerminal.Text = "Terminal";
            // 
            // radioButtonRxDisplayHex
            // 
            this.radioButtonRxDisplayHex.AutoSize = true;
            this.radioButtonRxDisplayHex.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonRxDisplayHex.Enabled = false;
            this.radioButtonRxDisplayHex.ForeColor = System.Drawing.Color.White;
            this.radioButtonRxDisplayHex.Location = new System.Drawing.Point(18, 368);
            this.radioButtonRxDisplayHex.Name = "radioButtonRxDisplayHex";
            this.radioButtonRxDisplayHex.Size = new System.Drawing.Size(81, 17);
            this.radioButtonRxDisplayHex.TabIndex = 73;
            this.radioButtonRxDisplayHex.Text = "Hex Display";
            this.radioButtonRxDisplayHex.UseVisualStyleBackColor = false;
            // 
            // buttonTerminalRxClear
            // 
            this.buttonTerminalRxClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.buttonTerminalRxClear.FlatAppearance.BorderSize = 0;
            this.buttonTerminalRxClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.buttonTerminalRxClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTerminalRxClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonTerminalRxClear.ForeColor = System.Drawing.Color.White;
            this.buttonTerminalRxClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTerminalRxClear.Location = new System.Drawing.Point(503, 369);
            this.buttonTerminalRxClear.Name = "buttonTerminalRxClear";
            this.buttonTerminalRxClear.Size = new System.Drawing.Size(45, 20);
            this.buttonTerminalRxClear.TabIndex = 72;
            this.buttonTerminalRxClear.Text = "Clear";
            this.buttonTerminalRxClear.UseVisualStyleBackColor = false;
            // 
            // labelRecieve
            // 
            this.labelRecieve.AutoSize = true;
            this.labelRecieve.ForeColor = System.Drawing.Color.White;
            this.labelRecieve.Location = new System.Drawing.Point(15, 163);
            this.labelRecieve.Name = "labelRecieve";
            this.labelRecieve.Size = new System.Drawing.Size(47, 13);
            this.labelRecieve.TabIndex = 71;
            this.labelRecieve.Text = "Recieve";
            // 
            // buttonTerminalTxClear
            // 
            this.buttonTerminalTxClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.buttonTerminalTxClear.FlatAppearance.BorderSize = 0;
            this.buttonTerminalTxClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.buttonTerminalTxClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTerminalTxClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonTerminalTxClear.ForeColor = System.Drawing.Color.White;
            this.buttonTerminalTxClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTerminalTxClear.Location = new System.Drawing.Point(500, 97);
            this.buttonTerminalTxClear.Name = "buttonTerminalTxClear";
            this.buttonTerminalTxClear.Size = new System.Drawing.Size(45, 20);
            this.buttonTerminalTxClear.TabIndex = 70;
            this.buttonTerminalTxClear.Text = "Clear";
            this.buttonTerminalTxClear.UseVisualStyleBackColor = false;
            // 
            // textboxRecievedData
            // 
            this.textboxRecievedData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.textboxRecievedData.Location = new System.Drawing.Point(16, 177);
            this.textboxRecievedData.Multiline = true;
            this.textboxRecievedData.Name = "textboxRecievedData";
            this.textboxRecievedData.Size = new System.Drawing.Size(537, 186);
            this.textboxRecievedData.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Transmit";
            // 
            // textBoxTerminalPort
            // 
            this.textBoxTerminalPort.Location = new System.Drawing.Point(488, 21);
            this.textBoxTerminalPort.Name = "textBoxTerminalPort";
            this.textBoxTerminalPort.Size = new System.Drawing.Size(60, 20);
            this.textBoxTerminalPort.TabIndex = 67;
            // 
            // buttonTerminalConnectPort
            // 
            this.buttonTerminalConnectPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.buttonTerminalConnectPort.FlatAppearance.BorderSize = 0;
            this.buttonTerminalConnectPort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.buttonTerminalConnectPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTerminalConnectPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonTerminalConnectPort.ForeColor = System.Drawing.Color.White;
            this.buttonTerminalConnectPort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTerminalConnectPort.Location = new System.Drawing.Point(424, 21);
            this.buttonTerminalConnectPort.Name = "buttonTerminalConnectPort";
            this.buttonTerminalConnectPort.Size = new System.Drawing.Size(60, 20);
            this.buttonTerminalConnectPort.TabIndex = 66;
            this.buttonTerminalConnectPort.Text = "Connect";
            this.buttonTerminalConnectPort.UseVisualStyleBackColor = false;
            // 
            // radioButtonTxFile
            // 
            this.radioButtonTxFile.AutoSize = true;
            this.radioButtonTxFile.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonTxFile.Enabled = false;
            this.radioButtonTxFile.ForeColor = System.Drawing.Color.White;
            this.radioButtonTxFile.Location = new System.Drawing.Point(16, 129);
            this.radioButtonTxFile.Name = "radioButtonTxFile";
            this.radioButtonTxFile.Size = new System.Drawing.Size(41, 17);
            this.radioButtonTxFile.TabIndex = 65;
            this.radioButtonTxFile.Text = "File";
            this.radioButtonTxFile.UseVisualStyleBackColor = false;
            // 
            // radioButtonTxKeys
            // 
            this.radioButtonTxKeys.AutoSize = true;
            this.radioButtonTxKeys.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonTxKeys.Checked = true;
            this.radioButtonTxKeys.Enabled = false;
            this.radioButtonTxKeys.ForeColor = System.Drawing.Color.White;
            this.radioButtonTxKeys.Location = new System.Drawing.Point(16, 97);
            this.radioButtonTxKeys.Name = "radioButtonTxKeys";
            this.radioButtonTxKeys.Size = new System.Drawing.Size(48, 17);
            this.radioButtonTxKeys.TabIndex = 59;
            this.radioButtonTxKeys.TabStop = true;
            this.radioButtonTxKeys.Text = "Keys";
            this.radioButtonTxKeys.UseVisualStyleBackColor = false;
            // 
            // radioButtonTxCommands
            // 
            this.radioButtonTxCommands.AutoSize = true;
            this.radioButtonTxCommands.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonTxCommands.Enabled = false;
            this.radioButtonTxCommands.ForeColor = System.Drawing.Color.White;
            this.radioButtonTxCommands.Location = new System.Drawing.Point(16, 113);
            this.radioButtonTxCommands.Name = "radioButtonTxCommands";
            this.radioButtonTxCommands.Size = new System.Drawing.Size(77, 17);
            this.radioButtonTxCommands.TabIndex = 58;
            this.radioButtonTxCommands.Text = "Commands";
            this.radioButtonTxCommands.UseVisualStyleBackColor = false;
            // 
            // labelDelay
            // 
            this.labelDelay.AutoSize = true;
            this.labelDelay.ForeColor = System.Drawing.Color.White;
            this.labelDelay.Location = new System.Drawing.Point(292, 104);
            this.labelDelay.Name = "labelDelay";
            this.labelDelay.Size = new System.Drawing.Size(58, 13);
            this.labelDelay.TabIndex = 63;
            this.labelDelay.Text = "Delay (mS)";
            // 
            // labelRepeats
            // 
            this.labelRepeats.AutoSize = true;
            this.labelRepeats.ForeColor = System.Drawing.Color.White;
            this.labelRepeats.Location = new System.Drawing.Point(172, 104);
            this.labelRepeats.Name = "labelRepeats";
            this.labelRepeats.Size = new System.Drawing.Size(47, 13);
            this.labelRepeats.TabIndex = 60;
            this.labelRepeats.Text = "Repeats";
            // 
            // buttonTerminalSend
            // 
            this.buttonTerminalSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.buttonTerminalSend.FlatAppearance.BorderSize = 0;
            this.buttonTerminalSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.buttonTerminalSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTerminalSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonTerminalSend.ForeColor = System.Drawing.Color.White;
            this.buttonTerminalSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTerminalSend.Location = new System.Drawing.Point(450, 96);
            this.buttonTerminalSend.Name = "buttonTerminalSend";
            this.buttonTerminalSend.Size = new System.Drawing.Size(45, 20);
            this.buttonTerminalSend.TabIndex = 61;
            this.buttonTerminalSend.Text = "Send";
            this.buttonTerminalSend.UseVisualStyleBackColor = false;
            // 
            // numericUpDownTxRepeats
            // 
            this.numericUpDownTxRepeats.Location = new System.Drawing.Point(221, 101);
            this.numericUpDownTxRepeats.Name = "numericUpDownTxRepeats";
            this.numericUpDownTxRepeats.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownTxRepeats.TabIndex = 64;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(352, 101);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown1.TabIndex = 62;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.textBox2.Location = new System.Drawing.Point(16, 51);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(537, 39);
            this.textBox2.TabIndex = 57;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.gradientPanel1.Controls.Add(this.panelButtonSettings);
            this.gradientPanel1.Controls.Add(this.buttonTerminal);
            this.gradientPanel1.Controls.Add(this.buttonFactory);
            this.gradientPanel1.Controls.Add(this.panelActiveButtonIndicator);
            this.gradientPanel1.Location = new System.Drawing.Point(5, 3);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.gradientPanel1.Size = new System.Drawing.Size(192, 416);
            this.gradientPanel1.TabIndex = 0;
            // 
            // panelButtonSettings
            // 
            this.panelButtonSettings.BackColor = System.Drawing.Color.Transparent;
            this.panelButtonSettings.Controls.Add(this.buttonLogSettings);
            this.panelButtonSettings.Controls.Add(this.buttonSerialPortSettings);
            this.panelButtonSettings.Controls.Add(this.buttonSettings);
            this.panelButtonSettings.Location = new System.Drawing.Point(15, 67);
            this.panelButtonSettings.MaximumSize = new System.Drawing.Size(177, 93);
            this.panelButtonSettings.MinimumSize = new System.Drawing.Size(177, 31);
            this.panelButtonSettings.Name = "panelButtonSettings";
            this.panelButtonSettings.Size = new System.Drawing.Size(177, 93);
            this.panelButtonSettings.TabIndex = 4;
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
            this.buttonLogSettings.Text = "Log   ";
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
            this.buttonSettings.Text = "Settings   ";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonTerminal
            // 
            this.buttonTerminal.BackColor = System.Drawing.Color.Transparent;
            this.buttonTerminal.FlatAppearance.BorderSize = 0;
            this.buttonTerminal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.buttonTerminal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTerminal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTerminal.ForeColor = System.Drawing.Color.White;
            this.buttonTerminal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTerminal.Location = new System.Drawing.Point(18, 39);
            this.buttonTerminal.Name = "buttonTerminal";
            this.buttonTerminal.Size = new System.Drawing.Size(177, 31);
            this.buttonTerminal.TabIndex = 7;
            this.buttonTerminal.Text = "Terminal         ";
            this.buttonTerminal.UseVisualStyleBackColor = false;
            this.buttonTerminal.Click += new System.EventHandler(this.buttonTerminal_Click);
            // 
            // buttonFactory
            // 
            this.buttonFactory.BackColor = System.Drawing.Color.Transparent;
            this.buttonFactory.FlatAppearance.BorderSize = 0;
            this.buttonFactory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.buttonFactory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFactory.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFactory.ForeColor = System.Drawing.Color.Transparent;
            this.buttonFactory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFactory.Location = new System.Drawing.Point(15, 3);
            this.buttonFactory.Name = "buttonFactory";
            this.buttonFactory.Size = new System.Drawing.Size(177, 31);
            this.buttonFactory.TabIndex = 5;
            this.buttonFactory.Text = "Factory        ";
            this.buttonFactory.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonFactory.UseVisualStyleBackColor = false;
            this.buttonFactory.Click += new System.EventHandler(this.buttonHome_Click);
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
            this.button2.Click += new System.EventHandler(this.buttonTerminal_Click);
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
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 480);
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
            this.panelFactory.ResumeLayout(false);
            this.panelFactory.PerformLayout();
            this.groupBoxFactorySettings.ResumeLayout(false);
            this.groupBoxFactorySettings.PerformLayout();
            this.panelTerminal.ResumeLayout(false);
            this.panelSideBar.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelSerialPort.ResumeLayout(false);
            this.groupboxSerialPortOptions.ResumeLayout(false);
            this.groupboxSerialPortOptions.PerformLayout();
            this.panelLog.ResumeLayout(false);
            this.groupBoxLog.ResumeLayout(false);
            this.panelLogOptions.ResumeLayout(false);
            this.panelLogOptions.PerformLayout();
            this.groupBoxTerminal.ResumeLayout(false);
            this.groupBoxTerminal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTxRepeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.panelButtonSettings.ResumeLayout(false);
            this.gradientPanelSideBar.ResumeLayout(false);
            this.panelDropDown.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelFactory;
        private System.Windows.Forms.Panel panelTerminal;
        private System.Windows.Forms.Timer timerChart;
        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Panel panelMain;
        private CustomControls.GradientPanel gradientPanel1;
        private System.Windows.Forms.Panel panelButtonSettings;
        private System.Windows.Forms.Button buttonLogSettings;
        private System.Windows.Forms.Button buttonSerialPortSettings;
        private System.Windows.Forms.Button buttonFactory;
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
        private System.Windows.Forms.Panel panelSerialPort;
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
        private System.Windows.Forms.Button buttonTerminal;
        private System.Windows.Forms.Panel panelLog;
        private System.Windows.Forms.GroupBox groupBoxLog;
        private System.Windows.Forms.Panel panelLogOptions;
        private System.Windows.Forms.CheckBox checkboxEnableLog;
        private System.Windows.Forms.RadioButton radiobuttonLogOverwrite;
        private System.Windows.Forms.RadioButton radiobuttonLogAppend;
        private System.Windows.Forms.Button buttonSerialPortConnect;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.IO.Ports.SerialPort serialPortDut;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxFactorySettings;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label labelFrequency;
        private System.Windows.Forms.ComboBox comboBoxFrequency;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.ComboBox comboBoxVariant;
        private System.Windows.Forms.Label labelVariant;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.TextBox textBoxSerialNumber;
        private System.Windows.Forms.TextBox textBoxTempOffset;
        private System.Windows.Forms.Label labelSerialNumber;
        private System.Windows.Forms.Label labelTempOffset;
        private System.Windows.Forms.TextBox textBoxFactoryConnectedPort;
        private System.Windows.Forms.Button buttonFactoryConnect;
        private System.Windows.Forms.Button buttonFactoryWrite;
        private System.Windows.Forms.Button buttonFactoryRead;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBoxTimestamp;
        private System.Windows.Forms.GroupBox groupBoxTerminal;
        private System.Windows.Forms.RadioButton radioButtonRxDisplayHex;
        private System.Windows.Forms.Button buttonTerminalRxClear;
        private System.Windows.Forms.Label labelRecieve;
        private System.Windows.Forms.Button buttonTerminalTxClear;
        private System.Windows.Forms.TextBox textboxRecievedData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTerminalPort;
        private System.Windows.Forms.Button buttonTerminalConnectPort;
        private System.Windows.Forms.RadioButton radioButtonTxFile;
        private System.Windows.Forms.RadioButton radioButtonTxKeys;
        private System.Windows.Forms.RadioButton radioButtonTxCommands;
        private System.Windows.Forms.Label labelDelay;
        private System.Windows.Forms.Label labelRepeats;
        private System.Windows.Forms.Button buttonTerminalSend;
        private System.Windows.Forms.NumericUpDown numericUpDownTxRepeats;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

