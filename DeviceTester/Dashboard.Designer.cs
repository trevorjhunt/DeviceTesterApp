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
            this.buttonSerialPortConnect = new System.Windows.Forms.Button();
            this.comboboxPort = new System.Windows.Forms.ComboBox();
            this.panelFactory = new System.Windows.Forms.Panel();
            this.labelFactoryStatus = new System.Windows.Forms.Label();
            this.textBoxFactoryStatus = new System.Windows.Forms.TextBox();
            this.buttonFactoryConnect = new System.Windows.Forms.Button();
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
            this.labelFactorySettings = new System.Windows.Forms.Label();
            this.panelTerminal = new System.Windows.Forms.Panel();
            this.labelTerminal = new System.Windows.Forms.Label();
            this.panelTerminalItems = new System.Windows.Forms.Panel();
            this.radioButtonTerminalHexDisplay = new System.Windows.Forms.RadioButton();
            this.radioButtonTerminalFile = new System.Windows.Forms.RadioButton();
            this.radioButtonTerminalKeys = new System.Windows.Forms.RadioButton();
            this.radioButtonTerminalCommands = new System.Windows.Forms.RadioButton();
            this.labelTerminalDelay = new System.Windows.Forms.Label();
            this.numericUpDownTerminalDelay = new System.Windows.Forms.NumericUpDown();
            this.labelTerminalRepeat = new System.Windows.Forms.Label();
            this.numericUpDownTerminalRepeats = new System.Windows.Forms.NumericUpDown();
            this.buttonTerminalTransmitSend = new System.Windows.Forms.Button();
            this.labelTerminalReceive = new System.Windows.Forms.Label();
            this.labelTerminalTransmit = new System.Windows.Forms.Label();
            this.textBoxTransmitData = new System.Windows.Forms.TextBox();
            this.buttonTerminalReceiveClear = new System.Windows.Forms.Button();
            this.textboxRecievedData = new System.Windows.Forms.TextBox();
            this.timerChart = new System.Windows.Forms.Timer(this.components);
            this.panelLog = new System.Windows.Forms.Panel();
            this.panelLogOptions = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBoxTimestamp = new System.Windows.Forms.CheckBox();
            this.radiobuttonLogAppend = new System.Windows.Forms.RadioButton();
            this.checkboxEnableLog = new System.Windows.Forms.CheckBox();
            this.radiobuttonLogOverwrite = new System.Windows.Forms.RadioButton();
            this.labelLog = new System.Windows.Forms.Label();
            this.timerSettingsMenu = new System.Windows.Forms.Timer(this.components);
            this.timerDashboard = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.serialPortDut = new System.IO.Ports.SerialPort(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTerminalOptions = new System.Windows.Forms.Panel();
            this.labelTerminalOptions = new System.Windows.Forms.Label();
            this.panelSerialPort = new System.Windows.Forms.Panel();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelBaudrate = new System.Windows.Forms.Label();
            this.labelDatabits = new System.Windows.Forms.Label();
            this.labelFlowControl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelParity = new System.Windows.Forms.Label();
            this.comboboxFlowControl = new System.Windows.Forms.ComboBox();
            this.labelStopbits = new System.Windows.Forms.Label();
            this.comboboxBaudrate = new System.Windows.Forms.ComboBox();
            this.comboboxParity = new System.Windows.Forms.ComboBox();
            this.comboboxStopbits = new System.Windows.Forms.ComboBox();
            this.comboboxDatabits = new System.Windows.Forms.ComboBox();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panelAll = new System.Windows.Forms.Panel();
            this.gradientPanel1 = new DeviceTester.CustomControls.GradientPanel();
            this.panelButtonSettings = new System.Windows.Forms.Panel();
            this.buttonTerminalOptions = new System.Windows.Forms.Button();
            this.buttonLogSettings = new System.Windows.Forms.Button();
            this.buttonSerialPortSettings = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonTerminal = new System.Windows.Forms.Button();
            this.buttonFactory = new System.Windows.Forms.Button();
            this.panelActiveButtonIndicator = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDashboard)).BeginInit();
            this.panelFactory.SuspendLayout();
            this.panelTerminal.SuspendLayout();
            this.panelTerminalItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTerminalDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTerminalRepeats)).BeginInit();
            this.panelLog.SuspendLayout();
            this.panelLogOptions.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelTerminalOptions.SuspendLayout();
            this.panelSerialPort.SuspendLayout();
            this.panelSideBar.SuspendLayout();
            this.panelAll.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.panelButtonSettings.SuspendLayout();
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
            this.panelTop.Location = new System.Drawing.Point(2, 2);
            this.panelTop.Margin = new System.Windows.Forms.Padding(0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(646, 35);
            this.panelTop.TabIndex = 1;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // picBoxRestore
            // 
            this.picBoxRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxRestore.Image = ((System.Drawing.Image)(resources.GetObject("picBoxRestore.Image")));
            this.picBoxRestore.Location = new System.Drawing.Point(592, 5);
            this.picBoxRestore.Name = "picBoxRestore";
            this.picBoxRestore.Size = new System.Drawing.Size(23, 23);
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
            this.picBoxMinimize.Location = new System.Drawing.Point(567, 5);
            this.picBoxMinimize.Name = "picBoxMinimize";
            this.picBoxMinimize.Size = new System.Drawing.Size(23, 23);
            this.picBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMinimize.TabIndex = 4;
            this.picBoxMinimize.TabStop = false;
            this.picBoxMinimize.Click += new System.EventHandler(this.picboxMinimize_Click);
            // 
            // picBoxMaximize
            // 
            this.picBoxMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxMaximize.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMaximize.Image")));
            this.picBoxMaximize.Location = new System.Drawing.Point(592, 5);
            this.picBoxMaximize.Name = "picBoxMaximize";
            this.picBoxMaximize.Size = new System.Drawing.Size(23, 23);
            this.picBoxMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMaximize.TabIndex = 3;
            this.picBoxMaximize.TabStop = false;
            this.picBoxMaximize.Click += new System.EventHandler(this.picboxMaximize_Click);
            // 
            // picBoxExit
            // 
            this.picBoxExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("picBoxExit.Image")));
            this.picBoxExit.Location = new System.Drawing.Point(617, 5);
            this.picBoxExit.Name = "picBoxExit";
            this.picBoxExit.Size = new System.Drawing.Size(23, 23);
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
            this.labelDashboard.Location = new System.Drawing.Point(47, 16);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(0, 20);
            this.labelDashboard.TabIndex = 1;
            // 
            // picBoxDashboard
            // 
            this.picBoxDashboard.Image = ((System.Drawing.Image)(resources.GetObject("picBoxDashboard.Image")));
            this.picBoxDashboard.Location = new System.Drawing.Point(16, 6);
            this.picBoxDashboard.Name = "picBoxDashboard";
            this.picBoxDashboard.Size = new System.Drawing.Size(25, 22);
            this.picBoxDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxDashboard.TabIndex = 0;
            this.picBoxDashboard.TabStop = false;
            this.picBoxDashboard.Click += new System.EventHandler(this.picBoxSideBarMenu_Click);
            // 
            // buttonSerialPortConnect
            // 
            this.buttonSerialPortConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.buttonSerialPortConnect.FlatAppearance.BorderSize = 0;
            this.buttonSerialPortConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.buttonSerialPortConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSerialPortConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonSerialPortConnect.ForeColor = System.Drawing.Color.White;
            this.buttonSerialPortConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSerialPortConnect.Location = new System.Drawing.Point(191, 248);
            this.buttonSerialPortConnect.Name = "buttonSerialPortConnect";
            this.buttonSerialPortConnect.Size = new System.Drawing.Size(130, 21);
            this.buttonSerialPortConnect.TabIndex = 51;
            this.buttonSerialPortConnect.Text = "Connect";
            this.buttonSerialPortConnect.UseVisualStyleBackColor = false;
            this.buttonSerialPortConnect.UseWaitCursor = true;
            this.buttonSerialPortConnect.Click += new System.EventHandler(this.buttonSerialPortConnect_Click);
            // 
            // comboboxPort
            // 
            this.comboboxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxPort.FormattingEnabled = true;
            this.comboboxPort.Location = new System.Drawing.Point(191, 70);
            this.comboboxPort.Name = "comboboxPort";
            this.comboboxPort.Size = new System.Drawing.Size(129, 21);
            this.comboboxPort.TabIndex = 36;
            // 
            // panelFactory
            // 
            this.panelFactory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panelFactory.Controls.Add(this.labelFactoryStatus);
            this.panelFactory.Controls.Add(this.textBoxFactoryStatus);
            this.panelFactory.Controls.Add(this.buttonFactoryConnect);
            this.panelFactory.Controls.Add(this.buttonFactoryWrite);
            this.panelFactory.Controls.Add(this.buttonFactoryRead);
            this.panelFactory.Controls.Add(this.labelSerialNumber);
            this.panelFactory.Controls.Add(this.labelTempOffset);
            this.panelFactory.Controls.Add(this.textBoxSerialNumber);
            this.panelFactory.Controls.Add(this.textBoxTempOffset);
            this.panelFactory.Controls.Add(this.labelProduct);
            this.panelFactory.Controls.Add(this.labelFrequency);
            this.panelFactory.Controls.Add(this.comboBoxFrequency);
            this.panelFactory.Controls.Add(this.comboBoxProduct);
            this.panelFactory.Controls.Add(this.comboBoxVariant);
            this.panelFactory.Controls.Add(this.labelVariant);
            this.panelFactory.Controls.Add(this.comboBoxCountry);
            this.panelFactory.Controls.Add(this.labelCountry);
            this.panelFactory.Controls.Add(this.labelFactorySettings);
            this.panelFactory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFactory.Location = new System.Drawing.Point(0, 0);
            this.panelFactory.Margin = new System.Windows.Forms.Padding(0);
            this.panelFactory.Name = "panelFactory";
            this.panelFactory.Size = new System.Drawing.Size(496, 422);
            this.panelFactory.TabIndex = 1;
            // 
            // labelFactoryStatus
            // 
            this.labelFactoryStatus.AutoSize = true;
            this.labelFactoryStatus.ForeColor = System.Drawing.Color.White;
            this.labelFactoryStatus.Location = new System.Drawing.Point(163, 234);
            this.labelFactoryStatus.Name = "labelFactoryStatus";
            this.labelFactoryStatus.Size = new System.Drawing.Size(37, 13);
            this.labelFactoryStatus.TabIndex = 65;
            this.labelFactoryStatus.Text = "Status";
            // 
            // textBoxFactoryStatus
            // 
            this.textBoxFactoryStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.textBoxFactoryStatus.Location = new System.Drawing.Point(167, 251);
            this.textBoxFactoryStatus.Multiline = true;
            this.textBoxFactoryStatus.Name = "textBoxFactoryStatus";
            this.textBoxFactoryStatus.Size = new System.Drawing.Size(235, 83);
            this.textBoxFactoryStatus.TabIndex = 64;
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
            this.buttonFactoryConnect.Location = new System.Drawing.Point(326, 66);
            this.buttonFactoryConnect.Name = "buttonFactoryConnect";
            this.buttonFactoryConnect.Size = new System.Drawing.Size(76, 27);
            this.buttonFactoryConnect.TabIndex = 54;
            this.buttonFactoryConnect.Text = "Connect";
            this.buttonFactoryConnect.UseVisualStyleBackColor = false;
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
            this.buttonFactoryWrite.Location = new System.Drawing.Point(326, 138);
            this.buttonFactoryWrite.Name = "buttonFactoryWrite";
            this.buttonFactoryWrite.Size = new System.Drawing.Size(76, 27);
            this.buttonFactoryWrite.TabIndex = 50;
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
            this.buttonFactoryRead.Location = new System.Drawing.Point(326, 102);
            this.buttonFactoryRead.Name = "buttonFactoryRead";
            this.buttonFactoryRead.Size = new System.Drawing.Size(76, 27);
            this.buttonFactoryRead.TabIndex = 49;
            this.buttonFactoryRead.Text = "Read";
            this.buttonFactoryRead.UseVisualStyleBackColor = false;
            // 
            // labelSerialNumber
            // 
            this.labelSerialNumber.AutoSize = true;
            this.labelSerialNumber.ForeColor = System.Drawing.Color.White;
            this.labelSerialNumber.Location = new System.Drawing.Point(81, 67);
            this.labelSerialNumber.Name = "labelSerialNumber";
            this.labelSerialNumber.Size = new System.Drawing.Size(73, 13);
            this.labelSerialNumber.TabIndex = 48;
            this.labelSerialNumber.Text = "Serial Number";
            // 
            // labelTempOffset
            // 
            this.labelTempOffset.AutoSize = true;
            this.labelTempOffset.ForeColor = System.Drawing.Color.White;
            this.labelTempOffset.Location = new System.Drawing.Point(89, 197);
            this.labelTempOffset.Name = "labelTempOffset";
            this.labelTempOffset.Size = new System.Drawing.Size(65, 13);
            this.labelTempOffset.TabIndex = 47;
            this.labelTempOffset.Text = "Temp Offset";
            // 
            // textBoxSerialNumber
            // 
            this.textBoxSerialNumber.Location = new System.Drawing.Point(167, 66);
            this.textBoxSerialNumber.Name = "textBoxSerialNumber";
            this.textBoxSerialNumber.Size = new System.Drawing.Size(115, 20);
            this.textBoxSerialNumber.TabIndex = 46;
            // 
            // textBoxTempOffset
            // 
            this.textBoxTempOffset.Location = new System.Drawing.Point(167, 200);
            this.textBoxTempOffset.Name = "textBoxTempOffset";
            this.textBoxTempOffset.Size = new System.Drawing.Size(115, 20);
            this.textBoxTempOffset.TabIndex = 45;
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.ForeColor = System.Drawing.Color.White;
            this.labelProduct.Location = new System.Drawing.Point(110, 93);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(44, 13);
            this.labelProduct.TabIndex = 42;
            this.labelProduct.Text = "Product";
            // 
            // labelFrequency
            // 
            this.labelFrequency.AutoSize = true;
            this.labelFrequency.ForeColor = System.Drawing.Color.White;
            this.labelFrequency.Location = new System.Drawing.Point(97, 171);
            this.labelFrequency.Name = "labelFrequency";
            this.labelFrequency.Size = new System.Drawing.Size(57, 13);
            this.labelFrequency.TabIndex = 41;
            this.labelFrequency.Text = "Frequency";
            // 
            // comboBoxFrequency
            // 
            this.comboBoxFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFrequency.FormattingEnabled = true;
            this.comboBoxFrequency.Location = new System.Drawing.Point(167, 173);
            this.comboBoxFrequency.Name = "comboBoxFrequency";
            this.comboBoxFrequency.Size = new System.Drawing.Size(115, 21);
            this.comboBoxFrequency.TabIndex = 37;
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Items.AddRange(new object[] {
            "RF-Output",
            "RF-MicroContact"});
            this.comboBoxProduct.Location = new System.Drawing.Point(168, 92);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(115, 21);
            this.comboBoxProduct.TabIndex = 38;
            // 
            // comboBoxVariant
            // 
            this.comboBoxVariant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.comboBoxVariant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVariant.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxVariant.FormattingEnabled = true;
            this.comboBoxVariant.Location = new System.Drawing.Point(167, 146);
            this.comboBoxVariant.Name = "comboBoxVariant";
            this.comboBoxVariant.Size = new System.Drawing.Size(115, 21);
            this.comboBoxVariant.TabIndex = 40;
            // 
            // labelVariant
            // 
            this.labelVariant.AutoSize = true;
            this.labelVariant.ForeColor = System.Drawing.Color.White;
            this.labelVariant.Location = new System.Drawing.Point(114, 145);
            this.labelVariant.Name = "labelVariant";
            this.labelVariant.Size = new System.Drawing.Size(40, 13);
            this.labelVariant.TabIndex = 44;
            this.labelVariant.Text = "Variant";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Items.AddRange(new object[] {
            "Ireland",
            "UnitedKingdom"});
            this.comboBoxCountry.Location = new System.Drawing.Point(167, 119);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(115, 21);
            this.comboBoxCountry.TabIndex = 39;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.ForeColor = System.Drawing.Color.White;
            this.labelCountry.Location = new System.Drawing.Point(111, 119);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(43, 13);
            this.labelCountry.TabIndex = 43;
            this.labelCountry.Text = "Country";
            // 
            // labelFactorySettings
            // 
            this.labelFactorySettings.AutoSize = true;
            this.labelFactorySettings.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFactorySettings.ForeColor = System.Drawing.Color.White;
            this.labelFactorySettings.Location = new System.Drawing.Point(18, 13);
            this.labelFactorySettings.Name = "labelFactorySettings";
            this.labelFactorySettings.Size = new System.Drawing.Size(122, 20);
            this.labelFactorySettings.TabIndex = 15;
            this.labelFactorySettings.Text = "Factory settings";
            // 
            // panelTerminal
            // 
            this.panelTerminal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panelTerminal.Controls.Add(this.labelTerminal);
            this.panelTerminal.Controls.Add(this.panelTerminalItems);
            this.panelTerminal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTerminal.Location = new System.Drawing.Point(0, 0);
            this.panelTerminal.Margin = new System.Windows.Forms.Padding(0);
            this.panelTerminal.Name = "panelTerminal";
            this.panelTerminal.Size = new System.Drawing.Size(496, 422);
            this.panelTerminal.TabIndex = 2;
            this.panelTerminal.Visible = false;
            // 
            // labelTerminal
            // 
            this.labelTerminal.AutoSize = true;
            this.labelTerminal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTerminal.ForeColor = System.Drawing.Color.White;
            this.labelTerminal.Location = new System.Drawing.Point(18, 13);
            this.labelTerminal.Name = "labelTerminal";
            this.labelTerminal.Size = new System.Drawing.Size(67, 20);
            this.labelTerminal.TabIndex = 60;
            this.labelTerminal.Text = "Terminal";
            // 
            // panelTerminalItems
            // 
            this.panelTerminalItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTerminalItems.Controls.Add(this.radioButtonTerminalHexDisplay);
            this.panelTerminalItems.Controls.Add(this.radioButtonTerminalFile);
            this.panelTerminalItems.Controls.Add(this.radioButtonTerminalKeys);
            this.panelTerminalItems.Controls.Add(this.radioButtonTerminalCommands);
            this.panelTerminalItems.Controls.Add(this.labelTerminalDelay);
            this.panelTerminalItems.Controls.Add(this.numericUpDownTerminalDelay);
            this.panelTerminalItems.Controls.Add(this.labelTerminalRepeat);
            this.panelTerminalItems.Controls.Add(this.numericUpDownTerminalRepeats);
            this.panelTerminalItems.Controls.Add(this.buttonTerminalTransmitSend);
            this.panelTerminalItems.Controls.Add(this.labelTerminalReceive);
            this.panelTerminalItems.Controls.Add(this.labelTerminalTransmit);
            this.panelTerminalItems.Controls.Add(this.textBoxTransmitData);
            this.panelTerminalItems.Controls.Add(this.buttonTerminalReceiveClear);
            this.panelTerminalItems.Controls.Add(this.textboxRecievedData);
            this.panelTerminalItems.Location = new System.Drawing.Point(3, 36);
            this.panelTerminalItems.MaximumSize = new System.Drawing.Size(1000, 800);
            this.panelTerminalItems.Name = "panelTerminalItems";
            this.panelTerminalItems.Size = new System.Drawing.Size(490, 383);
            this.panelTerminalItems.TabIndex = 65;
            // 
            // radioButtonTerminalHexDisplay
            // 
            this.radioButtonTerminalHexDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonTerminalHexDisplay.AutoSize = true;
            this.radioButtonTerminalHexDisplay.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonTerminalHexDisplay.Enabled = false;
            this.radioButtonTerminalHexDisplay.ForeColor = System.Drawing.Color.White;
            this.radioButtonTerminalHexDisplay.Location = new System.Drawing.Point(7, 216);
            this.radioButtonTerminalHexDisplay.Name = "radioButtonTerminalHexDisplay";
            this.radioButtonTerminalHexDisplay.Size = new System.Drawing.Size(81, 17);
            this.radioButtonTerminalHexDisplay.TabIndex = 77;
            this.radioButtonTerminalHexDisplay.Text = "Hex Display";
            this.radioButtonTerminalHexDisplay.UseVisualStyleBackColor = false;
            // 
            // radioButtonTerminalFile
            // 
            this.radioButtonTerminalFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonTerminalFile.AutoSize = true;
            this.radioButtonTerminalFile.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonTerminalFile.Enabled = false;
            this.radioButtonTerminalFile.ForeColor = System.Drawing.Color.White;
            this.radioButtonTerminalFile.Location = new System.Drawing.Point(145, 306);
            this.radioButtonTerminalFile.Name = "radioButtonTerminalFile";
            this.radioButtonTerminalFile.Size = new System.Drawing.Size(41, 17);
            this.radioButtonTerminalFile.TabIndex = 76;
            this.radioButtonTerminalFile.Text = "File";
            this.radioButtonTerminalFile.UseVisualStyleBackColor = false;
            // 
            // radioButtonTerminalKeys
            // 
            this.radioButtonTerminalKeys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonTerminalKeys.AutoSize = true;
            this.radioButtonTerminalKeys.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonTerminalKeys.Checked = true;
            this.radioButtonTerminalKeys.Enabled = false;
            this.radioButtonTerminalKeys.ForeColor = System.Drawing.Color.White;
            this.radioButtonTerminalKeys.Location = new System.Drawing.Point(20, 306);
            this.radioButtonTerminalKeys.Name = "radioButtonTerminalKeys";
            this.radioButtonTerminalKeys.Size = new System.Drawing.Size(48, 17);
            this.radioButtonTerminalKeys.TabIndex = 75;
            this.radioButtonTerminalKeys.TabStop = true;
            this.radioButtonTerminalKeys.Text = "Keys";
            this.radioButtonTerminalKeys.UseVisualStyleBackColor = false;
            // 
            // radioButtonTerminalCommands
            // 
            this.radioButtonTerminalCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonTerminalCommands.AutoSize = true;
            this.radioButtonTerminalCommands.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonTerminalCommands.Enabled = false;
            this.radioButtonTerminalCommands.ForeColor = System.Drawing.Color.White;
            this.radioButtonTerminalCommands.Location = new System.Drawing.Point(70, 306);
            this.radioButtonTerminalCommands.Name = "radioButtonTerminalCommands";
            this.radioButtonTerminalCommands.Size = new System.Drawing.Size(77, 17);
            this.radioButtonTerminalCommands.TabIndex = 74;
            this.radioButtonTerminalCommands.Text = "Commands";
            this.radioButtonTerminalCommands.UseVisualStyleBackColor = false;
            // 
            // labelTerminalDelay
            // 
            this.labelTerminalDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTerminalDelay.AutoSize = true;
            this.labelTerminalDelay.ForeColor = System.Drawing.Color.White;
            this.labelTerminalDelay.Location = new System.Drawing.Point(296, 306);
            this.labelTerminalDelay.Name = "labelTerminalDelay";
            this.labelTerminalDelay.Size = new System.Drawing.Size(58, 13);
            this.labelTerminalDelay.TabIndex = 71;
            this.labelTerminalDelay.Text = "Delay (mS)";
            // 
            // numericUpDownTerminalDelay
            // 
            this.numericUpDownTerminalDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownTerminalDelay.Location = new System.Drawing.Point(357, 306);
            this.numericUpDownTerminalDelay.Name = "numericUpDownTerminalDelay";
            this.numericUpDownTerminalDelay.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownTerminalDelay.TabIndex = 70;
            // 
            // labelTerminalRepeat
            // 
            this.labelTerminalRepeat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTerminalRepeat.AutoSize = true;
            this.labelTerminalRepeat.ForeColor = System.Drawing.Color.White;
            this.labelTerminalRepeat.Location = new System.Drawing.Point(195, 309);
            this.labelTerminalRepeat.Name = "labelTerminalRepeat";
            this.labelTerminalRepeat.Size = new System.Drawing.Size(42, 13);
            this.labelTerminalRepeat.TabIndex = 72;
            this.labelTerminalRepeat.Text = "Repeat";
            // 
            // numericUpDownTerminalRepeats
            // 
            this.numericUpDownTerminalRepeats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownTerminalRepeats.Location = new System.Drawing.Point(238, 306);
            this.numericUpDownTerminalRepeats.Name = "numericUpDownTerminalRepeats";
            this.numericUpDownTerminalRepeats.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownTerminalRepeats.TabIndex = 73;
            // 
            // buttonTerminalTransmitSend
            // 
            this.buttonTerminalTransmitSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonTerminalTransmitSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.buttonTerminalTransmitSend.FlatAppearance.BorderSize = 0;
            this.buttonTerminalTransmitSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.buttonTerminalTransmitSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTerminalTransmitSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonTerminalTransmitSend.ForeColor = System.Drawing.Color.White;
            this.buttonTerminalTransmitSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTerminalTransmitSend.Location = new System.Drawing.Point(429, 306);
            this.buttonTerminalTransmitSend.Name = "buttonTerminalTransmitSend";
            this.buttonTerminalTransmitSend.Size = new System.Drawing.Size(55, 23);
            this.buttonTerminalTransmitSend.TabIndex = 69;
            this.buttonTerminalTransmitSend.Text = "Send";
            this.buttonTerminalTransmitSend.UseVisualStyleBackColor = false;
            this.buttonTerminalTransmitSend.Click += new System.EventHandler(this.buttonTerminalTransmitSend_Click);
            // 
            // labelTerminalReceive
            // 
            this.labelTerminalReceive.AutoSize = true;
            this.labelTerminalReceive.ForeColor = System.Drawing.Color.White;
            this.labelTerminalReceive.Location = new System.Drawing.Point(7, 12);
            this.labelTerminalReceive.Name = "labelTerminalReceive";
            this.labelTerminalReceive.Size = new System.Drawing.Size(47, 13);
            this.labelTerminalReceive.TabIndex = 68;
            this.labelTerminalReceive.Text = "Receive";
            // 
            // labelTerminalTransmit
            // 
            this.labelTerminalTransmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTerminalTransmit.AutoSize = true;
            this.labelTerminalTransmit.ForeColor = System.Drawing.Color.White;
            this.labelTerminalTransmit.Location = new System.Drawing.Point(4, 248);
            this.labelTerminalTransmit.Name = "labelTerminalTransmit";
            this.labelTerminalTransmit.Size = new System.Drawing.Size(47, 13);
            this.labelTerminalTransmit.TabIndex = 67;
            this.labelTerminalTransmit.Text = "Transmit";
            // 
            // textBoxTransmitData
            // 
            this.textBoxTransmitData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxTransmitData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.textBoxTransmitData.Location = new System.Drawing.Point(7, 261);
            this.textBoxTransmitData.Multiline = true;
            this.textBoxTransmitData.Name = "textBoxTransmitData";
            this.textBoxTransmitData.Size = new System.Drawing.Size(477, 39);
            this.textBoxTransmitData.TabIndex = 65;
            // 
            // buttonTerminalReceiveClear
            // 
            this.buttonTerminalReceiveClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTerminalReceiveClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.buttonTerminalReceiveClear.FlatAppearance.BorderSize = 0;
            this.buttonTerminalReceiveClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.buttonTerminalReceiveClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTerminalReceiveClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonTerminalReceiveClear.ForeColor = System.Drawing.Color.White;
            this.buttonTerminalReceiveClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTerminalReceiveClear.Location = new System.Drawing.Point(429, 215);
            this.buttonTerminalReceiveClear.Name = "buttonTerminalReceiveClear";
            this.buttonTerminalReceiveClear.Size = new System.Drawing.Size(55, 23);
            this.buttonTerminalReceiveClear.TabIndex = 64;
            this.buttonTerminalReceiveClear.Text = "Clear";
            this.buttonTerminalReceiveClear.UseVisualStyleBackColor = false;
            // 
            // textboxRecievedData
            // 
            this.textboxRecievedData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxRecievedData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.textboxRecievedData.Location = new System.Drawing.Point(7, 28);
            this.textboxRecievedData.Multiline = true;
            this.textboxRecievedData.Name = "textboxRecievedData";
            this.textboxRecievedData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textboxRecievedData.Size = new System.Drawing.Size(477, 183);
            this.textboxRecievedData.TabIndex = 63;
            // 
            // panelLog
            // 
            this.panelLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panelLog.Controls.Add(this.panelLogOptions);
            this.panelLog.Controls.Add(this.labelLog);
            this.panelLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLog.Location = new System.Drawing.Point(0, 0);
            this.panelLog.Margin = new System.Windows.Forms.Padding(0);
            this.panelLog.Name = "panelLog";
            this.panelLog.Size = new System.Drawing.Size(496, 422);
            this.panelLog.TabIndex = 3;
            this.panelLog.Visible = false;
            // 
            // panelLogOptions
            // 
            this.panelLogOptions.Controls.Add(this.textBox1);
            this.panelLogOptions.Controls.Add(this.checkBoxTimestamp);
            this.panelLogOptions.Controls.Add(this.radiobuttonLogAppend);
            this.panelLogOptions.Controls.Add(this.checkboxEnableLog);
            this.panelLogOptions.Controls.Add(this.radiobuttonLogOverwrite);
            this.panelLogOptions.Location = new System.Drawing.Point(52, 44);
            this.panelLogOptions.Name = "panelLogOptions";
            this.panelLogOptions.Size = new System.Drawing.Size(389, 126);
            this.panelLogOptions.TabIndex = 28;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 20);
            this.textBox1.TabIndex = 30;
            // 
            // checkBoxTimestamp
            // 
            this.checkBoxTimestamp.AutoSize = true;
            this.checkBoxTimestamp.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxTimestamp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBoxTimestamp.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBoxTimestamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.checkBoxTimestamp.ForeColor = System.Drawing.Color.White;
            this.checkBoxTimestamp.Location = new System.Drawing.Point(56, 78);
            this.checkBoxTimestamp.MaximumSize = new System.Drawing.Size(400, 19);
            this.checkBoxTimestamp.Name = "checkBoxTimestamp";
            this.checkBoxTimestamp.Size = new System.Drawing.Size(80, 17);
            this.checkBoxTimestamp.TabIndex = 32;
            this.checkBoxTimestamp.Text = "Time stamp";
            this.checkBoxTimestamp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxTimestamp.UseVisualStyleBackColor = false;
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
            this.checkboxEnableLog.ForeColor = System.Drawing.Color.White;
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
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLog.ForeColor = System.Drawing.Color.White;
            this.labelLog.Location = new System.Drawing.Point(18, 13);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(36, 20);
            this.labelLog.TabIndex = 61;
            this.labelLog.Text = "Log";
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
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelMain.Controls.Add(this.panelTerminal);
            this.panelMain.Controls.Add(this.panelLog);
            this.panelMain.Controls.Add(this.panelTerminalOptions);
            this.panelMain.Controls.Add(this.panelSerialPort);
            this.panelMain.Controls.Add(this.panelFactory);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.MinimumSize = new System.Drawing.Size(492, 422);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(496, 422);
            this.panelMain.TabIndex = 4;
            // 
            // panelTerminalOptions
            // 
            this.panelTerminalOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panelTerminalOptions.Controls.Add(this.labelTerminalOptions);
            this.panelTerminalOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTerminalOptions.Location = new System.Drawing.Point(0, 0);
            this.panelTerminalOptions.Margin = new System.Windows.Forms.Padding(0);
            this.panelTerminalOptions.Name = "panelTerminalOptions";
            this.panelTerminalOptions.Size = new System.Drawing.Size(496, 422);
            this.panelTerminalOptions.TabIndex = 75;
            this.panelTerminalOptions.Visible = false;
            // 
            // labelTerminalOptions
            // 
            this.labelTerminalOptions.AutoSize = true;
            this.labelTerminalOptions.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTerminalOptions.ForeColor = System.Drawing.Color.White;
            this.labelTerminalOptions.Location = new System.Drawing.Point(18, 13);
            this.labelTerminalOptions.Name = "labelTerminalOptions";
            this.labelTerminalOptions.Size = new System.Drawing.Size(124, 20);
            this.labelTerminalOptions.TabIndex = 61;
            this.labelTerminalOptions.Text = "Terminal options";
            // 
            // panelSerialPort
            // 
            this.panelSerialPort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelSerialPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panelSerialPort.Controls.Add(this.labelPort);
            this.panelSerialPort.Controls.Add(this.buttonSerialPortConnect);
            this.panelSerialPort.Controls.Add(this.labelBaudrate);
            this.panelSerialPort.Controls.Add(this.labelDatabits);
            this.panelSerialPort.Controls.Add(this.labelFlowControl);
            this.panelSerialPort.Controls.Add(this.label8);
            this.panelSerialPort.Controls.Add(this.comboboxPort);
            this.panelSerialPort.Controls.Add(this.labelParity);
            this.panelSerialPort.Controls.Add(this.comboboxFlowControl);
            this.panelSerialPort.Controls.Add(this.labelStopbits);
            this.panelSerialPort.Controls.Add(this.comboboxBaudrate);
            this.panelSerialPort.Controls.Add(this.comboboxParity);
            this.panelSerialPort.Controls.Add(this.comboboxStopbits);
            this.panelSerialPort.Controls.Add(this.comboboxDatabits);
            this.panelSerialPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSerialPort.Location = new System.Drawing.Point(0, 0);
            this.panelSerialPort.Margin = new System.Windows.Forms.Padding(0);
            this.panelSerialPort.Name = "panelSerialPort";
            this.panelSerialPort.Size = new System.Drawing.Size(496, 422);
            this.panelSerialPort.TabIndex = 4;
            this.panelSerialPort.Visible = false;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.ForeColor = System.Drawing.Color.White;
            this.labelPort.Location = new System.Drawing.Point(158, 74);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(26, 13);
            this.labelPort.TabIndex = 62;
            this.labelPort.Text = "Port";
            // 
            // labelBaudrate
            // 
            this.labelBaudrate.AutoSize = true;
            this.labelBaudrate.ForeColor = System.Drawing.Color.White;
            this.labelBaudrate.Location = new System.Drawing.Point(134, 101);
            this.labelBaudrate.Name = "labelBaudrate";
            this.labelBaudrate.Size = new System.Drawing.Size(50, 13);
            this.labelBaudrate.TabIndex = 8;
            this.labelBaudrate.Text = "Baudrate";
            // 
            // labelDatabits
            // 
            this.labelDatabits.AutoSize = true;
            this.labelDatabits.ForeColor = System.Drawing.Color.White;
            this.labelDatabits.Location = new System.Drawing.Point(135, 127);
            this.labelDatabits.Name = "labelDatabits";
            this.labelDatabits.Size = new System.Drawing.Size(49, 13);
            this.labelDatabits.TabIndex = 9;
            this.labelDatabits.Text = "Data bits";
            // 
            // labelFlowControl
            // 
            this.labelFlowControl.AutoSize = true;
            this.labelFlowControl.ForeColor = System.Drawing.Color.White;
            this.labelFlowControl.Location = new System.Drawing.Point(119, 213);
            this.labelFlowControl.Name = "labelFlowControl";
            this.labelFlowControl.Size = new System.Drawing.Size(64, 13);
            this.labelFlowControl.TabIndex = 13;
            this.labelFlowControl.Text = "Flow control";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(18, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 20);
            this.label8.TabIndex = 61;
            this.label8.Text = "Serial port settings";
            // 
            // labelParity
            // 
            this.labelParity.AutoSize = true;
            this.labelParity.ForeColor = System.Drawing.Color.White;
            this.labelParity.Location = new System.Drawing.Point(150, 186);
            this.labelParity.Name = "labelParity";
            this.labelParity.Size = new System.Drawing.Size(33, 13);
            this.labelParity.TabIndex = 11;
            this.labelParity.Text = "Parity";
            // 
            // comboboxFlowControl
            // 
            this.comboboxFlowControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxFlowControl.FormattingEnabled = true;
            this.comboboxFlowControl.Location = new System.Drawing.Point(191, 211);
            this.comboboxFlowControl.Name = "comboboxFlowControl";
            this.comboboxFlowControl.Size = new System.Drawing.Size(130, 21);
            this.comboboxFlowControl.TabIndex = 12;
            // 
            // labelStopbits
            // 
            this.labelStopbits.AutoSize = true;
            this.labelStopbits.ForeColor = System.Drawing.Color.White;
            this.labelStopbits.Location = new System.Drawing.Point(135, 157);
            this.labelStopbits.Name = "labelStopbits";
            this.labelStopbits.Size = new System.Drawing.Size(48, 13);
            this.labelStopbits.TabIndex = 10;
            this.labelStopbits.Text = "Stop bits";
            // 
            // comboboxBaudrate
            // 
            this.comboboxBaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxBaudrate.FormattingEnabled = true;
            this.comboboxBaudrate.Location = new System.Drawing.Point(192, 99);
            this.comboboxBaudrate.Name = "comboboxBaudrate";
            this.comboboxBaudrate.Size = new System.Drawing.Size(130, 21);
            this.comboboxBaudrate.TabIndex = 2;
            // 
            // comboboxParity
            // 
            this.comboboxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxParity.FormattingEnabled = true;
            this.comboboxParity.Location = new System.Drawing.Point(191, 183);
            this.comboboxParity.Name = "comboboxParity";
            this.comboboxParity.Size = new System.Drawing.Size(130, 21);
            this.comboboxParity.TabIndex = 5;
            // 
            // comboboxStopbits
            // 
            this.comboboxStopbits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.comboboxStopbits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxStopbits.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboboxStopbits.FormattingEnabled = true;
            this.comboboxStopbits.Location = new System.Drawing.Point(191, 155);
            this.comboboxStopbits.Name = "comboboxStopbits";
            this.comboboxStopbits.Size = new System.Drawing.Size(130, 21);
            this.comboboxStopbits.TabIndex = 4;
            // 
            // comboboxDatabits
            // 
            this.comboboxDatabits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxDatabits.FormattingEnabled = true;
            this.comboboxDatabits.Location = new System.Drawing.Point(192, 127);
            this.comboboxDatabits.Name = "comboboxDatabits";
            this.comboboxDatabits.Size = new System.Drawing.Size(130, 21);
            this.comboboxDatabits.TabIndex = 3;
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelSideBar.Controls.Add(this.gradientPanel1);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(2, 37);
            this.panelSideBar.Margin = new System.Windows.Forms.Padding(0);
            this.panelSideBar.MaximumSize = new System.Drawing.Size(150, 442);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(150, 441);
            this.panelSideBar.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.statusStrip1.Location = new System.Drawing.Point(0, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(496, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panelAll
            // 
            this.panelAll.Controls.Add(this.panelMain);
            this.panelAll.Controls.Add(this.statusStrip1);
            this.panelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAll.Location = new System.Drawing.Point(152, 37);
            this.panelAll.Name = "panelAll";
            this.panelAll.Size = new System.Drawing.Size(496, 441);
            this.panelAll.TabIndex = 6;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.gradientPanel1.Controls.Add(this.panelButtonSettings);
            this.gradientPanel1.Controls.Add(this.buttonTerminal);
            this.gradientPanel1.Controls.Add(this.buttonFactory);
            this.gradientPanel1.Controls.Add(this.panelActiveButtonIndicator);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(150, 441);
            this.gradientPanel1.TabIndex = 0;
            // 
            // panelButtonSettings
            // 
            this.panelButtonSettings.BackColor = System.Drawing.Color.Transparent;
            this.panelButtonSettings.Controls.Add(this.buttonTerminalOptions);
            this.panelButtonSettings.Controls.Add(this.buttonLogSettings);
            this.panelButtonSettings.Controls.Add(this.buttonSerialPortSettings);
            this.panelButtonSettings.Controls.Add(this.buttonSettings);
            this.panelButtonSettings.Location = new System.Drawing.Point(13, 76);
            this.panelButtonSettings.MaximumSize = new System.Drawing.Size(130, 124);
            this.panelButtonSettings.MinimumSize = new System.Drawing.Size(130, 31);
            this.panelButtonSettings.Name = "panelButtonSettings";
            this.panelButtonSettings.Size = new System.Drawing.Size(130, 31);
            this.panelButtonSettings.TabIndex = 4;
            // 
            // buttonTerminalOptions
            // 
            this.buttonTerminalOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(21)))), ((int)(((byte)(79)))));
            this.buttonTerminalOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTerminalOptions.FlatAppearance.BorderSize = 0;
            this.buttonTerminalOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTerminalOptions.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTerminalOptions.ForeColor = System.Drawing.Color.White;
            this.buttonTerminalOptions.Location = new System.Drawing.Point(0, 93);
            this.buttonTerminalOptions.Name = "buttonTerminalOptions";
            this.buttonTerminalOptions.Size = new System.Drawing.Size(130, 31);
            this.buttonTerminalOptions.TabIndex = 5;
            this.buttonTerminalOptions.Text = "Terminal";
            this.buttonTerminalOptions.UseVisualStyleBackColor = false;
            this.buttonTerminalOptions.Click += new System.EventHandler(this.buttonTerminalOptions_Click);
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
            this.buttonLogSettings.Size = new System.Drawing.Size(130, 31);
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
            this.buttonSerialPortSettings.Size = new System.Drawing.Size(130, 31);
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
            this.buttonSettings.Size = new System.Drawing.Size(130, 31);
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
            this.buttonTerminal.Location = new System.Drawing.Point(12, 39);
            this.buttonTerminal.MinimumSize = new System.Drawing.Size(130, 31);
            this.buttonTerminal.Name = "buttonTerminal";
            this.buttonTerminal.Size = new System.Drawing.Size(130, 31);
            this.buttonTerminal.TabIndex = 7;
            this.buttonTerminal.Text = "Terminal       ";
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
            this.buttonFactory.Location = new System.Drawing.Point(13, 3);
            this.buttonFactory.MinimumSize = new System.Drawing.Size(130, 31);
            this.buttonFactory.Name = "buttonFactory";
            this.buttonFactory.Size = new System.Drawing.Size(130, 31);
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
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(650, 480);
            this.Controls.Add(this.panelAll);
            this.Controls.Add(this.panelSideBar);
            this.Controls.Add(this.panelTop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 480);
            this.Name = "Dashboard";
            this.Padding = new System.Windows.Forms.Padding(2);
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
            this.panelTerminal.ResumeLayout(false);
            this.panelTerminal.PerformLayout();
            this.panelTerminalItems.ResumeLayout(false);
            this.panelTerminalItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTerminalDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTerminalRepeats)).EndInit();
            this.panelLog.ResumeLayout(false);
            this.panelLog.PerformLayout();
            this.panelLogOptions.ResumeLayout(false);
            this.panelLogOptions.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelTerminalOptions.ResumeLayout(false);
            this.panelTerminalOptions.PerformLayout();
            this.panelSerialPort.ResumeLayout(false);
            this.panelSerialPort.PerformLayout();
            this.panelSideBar.ResumeLayout(false);
            this.panelAll.ResumeLayout(false);
            this.panelAll.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            this.panelButtonSettings.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelFactory;
        private System.Windows.Forms.Panel panelTerminal;
        private System.Windows.Forms.Timer timerChart;
        private CustomControls.GradientPanel gradientPanel1;
        private System.Windows.Forms.Panel panelButtonSettings;
        private System.Windows.Forms.Button buttonLogSettings;
        private System.Windows.Forms.Button buttonSerialPortSettings;
        private System.Windows.Forms.Button buttonFactory;
        private System.Windows.Forms.Panel panelActiveButtonIndicator;
        private System.Windows.Forms.Timer timerSettingsMenu;
        private System.Windows.Forms.Timer timerDashboard;
        private System.Windows.Forms.Button buttonTerminal;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.IO.Ports.SerialPort serialPortDut;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Panel panelLog;
        private System.Windows.Forms.Panel panelLogOptions;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBoxTimestamp;
        private System.Windows.Forms.RadioButton radiobuttonLogAppend;
        private System.Windows.Forms.CheckBox checkboxEnableLog;
        private System.Windows.Forms.RadioButton radiobuttonLogOverwrite;
        private System.Windows.Forms.Label labelTerminal;
        private System.Windows.Forms.Label labelFactorySettings;
        private System.Windows.Forms.Button buttonTerminalReceiveClear;
        private System.Windows.Forms.TextBox textboxRecievedData;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.Button buttonSerialPortConnect;
        private System.Windows.Forms.Label labelSerialNumber;
        private System.Windows.Forms.Label labelTempOffset;
        private System.Windows.Forms.ComboBox comboboxPort;
        private System.Windows.Forms.TextBox textBoxSerialNumber;
        private System.Windows.Forms.TextBox textBoxTempOffset;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label labelFrequency;
        private System.Windows.Forms.ComboBox comboBoxFrequency;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.ComboBox comboBoxVariant;
        private System.Windows.Forms.Label labelVariant;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.TextBox textBoxFactoryStatus;
        private System.Windows.Forms.Label labelFactoryStatus;
        private System.Windows.Forms.Button buttonFactoryConnect;
        private System.Windows.Forms.Button buttonFactoryWrite;
        private System.Windows.Forms.Button buttonFactoryRead;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Panel panelSerialPort;
        private System.Windows.Forms.Label labelBaudrate;
        private System.Windows.Forms.Label labelDatabits;
        private System.Windows.Forms.Label labelFlowControl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelParity;
        private System.Windows.Forms.ComboBox comboboxFlowControl;
        private System.Windows.Forms.Label labelStopbits;
        private System.Windows.Forms.ComboBox comboboxBaudrate;
        private System.Windows.Forms.ComboBox comboboxParity;
        private System.Windows.Forms.ComboBox comboboxStopbits;
        private System.Windows.Forms.ComboBox comboboxDatabits;
        private System.Windows.Forms.Button buttonTerminalOptions;
        private System.Windows.Forms.Panel panelTerminalItems;
        private System.Windows.Forms.TextBox textBoxTransmitData;
        private System.Windows.Forms.Label labelTerminalTransmit;
        private System.Windows.Forms.Label labelTerminalReceive;
        private System.Windows.Forms.Button buttonTerminalTransmitSend;
        private System.Windows.Forms.RadioButton radioButtonTerminalFile;
        private System.Windows.Forms.RadioButton radioButtonTerminalKeys;
        private System.Windows.Forms.RadioButton radioButtonTerminalCommands;
        private System.Windows.Forms.Label labelTerminalDelay;
        private System.Windows.Forms.NumericUpDown numericUpDownTerminalDelay;
        private System.Windows.Forms.Label labelTerminalRepeat;
        private System.Windows.Forms.NumericUpDown numericUpDownTerminalRepeats;
        private System.Windows.Forms.RadioButton radioButtonTerminalHexDisplay;
        private System.Windows.Forms.Panel panelTerminalOptions;
        private System.Windows.Forms.Label labelTerminalOptions;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panelAll;
    }
}

