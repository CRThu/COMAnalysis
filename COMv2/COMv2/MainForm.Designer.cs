namespace COMv2
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.COM = new System.IO.Ports.SerialPort(this.components);
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.lbPort = new System.Windows.Forms.Label();
            this.lbBaudRate = new System.Windows.Forms.Label();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.lbStopBits = new System.Windows.Forms.Label();
            this.cbStopBits = new System.Windows.Forms.ComboBox();
            this.lbDataBits = new System.Windows.Forms.Label();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.lbParity = new System.Windows.Forms.Label();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.gbPort = new System.Windows.Forms.GroupBox();
            this.lbThreadSleep = new System.Windows.Forms.Label();
            this.btnPortOpen = new System.Windows.Forms.Button();
            this.btnPortClose = new System.Windows.Forms.Button();
            this.gbCmd = new System.Windows.Forms.GroupBox();
            this.lbCOMstatus = new System.Windows.Forms.Label();
            this.btnPortWrite = new System.Windows.Forms.Button();
            this.tbPortWrite = new System.Windows.Forms.TextBox();
            this.gbSend = new System.Windows.Forms.GroupBox();
            this.ckb16 = new System.Windows.Forms.CheckBox();
            this.ckbNewLine = new System.Windows.Forms.CheckBox();
            this.tbPortRead = new System.Windows.Forms.TextBox();
            this.gbRead = new System.Windows.Forms.GroupBox();
            this.chtData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbChartScrollBar = new System.Windows.Forms.CheckBox();
            this.cbChartShowValue = new System.Windows.Forms.CheckBox();
            this.btnChartChannelName = new System.Windows.Forms.Button();
            this.tbChartChannelName = new System.Windows.Forms.TextBox();
            this.cbChartChannelNameList = new System.Windows.Forms.ComboBox();
            this.lbChartChannelName = new System.Windows.Forms.Label();
            this.rbByteIsString = new System.Windows.Forms.RadioButton();
            this.gbByteDecoder = new System.Windows.Forms.GroupBox();
            this.btnOnlyForTest = new System.Windows.Forms.Button();
            this.rbNoDecoder = new System.Windows.Forms.RadioButton();
            this.cbByteIsNumber = new System.Windows.Forms.ComboBox();
            this.rbByteIsNumber = new System.Windows.Forms.RadioButton();
            this.lbStringFilter = new System.Windows.Forms.Label();
            this.tbStringFilter = new System.Windows.Forms.TextBox();
            this.tcOutput = new System.Windows.Forms.TabControl();
            this.tpChart = new System.Windows.Forms.TabPage();
            this.chkUseFrame = new System.Windows.Forms.CheckBox();
            this.lbStopFrame = new System.Windows.Forms.Label();
            this.lbStartFrame = new System.Windows.Forms.Label();
            this.tbStopFrame = new System.Windows.Forms.TextBox();
            this.tbStartFrame = new System.Windows.Forms.TextBox();
            this.cbChartChannelEnable = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChartNormal = new System.Windows.Forms.Button();
            this.btnChartMaximized = new System.Windows.Forms.Button();
            this.cbChartTotb = new System.Windows.Forms.CheckBox();
            this.btnChartXSmall = new System.Windows.Forms.Button();
            this.btnChartXBig = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tpExcel = new System.Windows.Forms.TabPage();
            this.lbExcelFileName = new System.Windows.Forms.Label();
            this.tbExcelFileName = new System.Windows.Forms.TextBox();
            this.cbExcelChannelDataOutput = new System.Windows.Forms.CheckBox();
            this.cbExcelAllDataOutput = new System.Windows.Forms.CheckBox();
            this.btnExcelWrite = new System.Windows.Forms.Button();
            this.TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MS = new System.Windows.Forms.MenuStrip();
            this.tbThreadSleep = new System.Windows.Forms.TextBox();
            this.lbThreadSleepms = new System.Windows.Forms.Label();
            this.gbPort.SuspendLayout();
            this.gbCmd.SuspendLayout();
            this.gbSend.SuspendLayout();
            this.gbRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtData)).BeginInit();
            this.gbByteDecoder.SuspendLayout();
            this.tcOutput.SuspendLayout();
            this.tpChart.SuspendLayout();
            this.tpExcel.SuspendLayout();
            this.MS.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(94, 40);
            this.cbPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(94, 28);
            this.cbPort.TabIndex = 0;
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(28, 44);
            this.lbPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(43, 20);
            this.lbPort.TabIndex = 8;
            this.lbPort.Text = "端口:";
            // 
            // lbBaudRate
            // 
            this.lbBaudRate.AutoSize = true;
            this.lbBaudRate.Location = new System.Drawing.Point(28, 85);
            this.lbBaudRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBaudRate.Name = "lbBaudRate";
            this.lbBaudRate.Size = new System.Drawing.Size(58, 20);
            this.lbBaudRate.TabIndex = 10;
            this.lbBaudRate.Text = "波特率:";
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.cbBaudRate.Location = new System.Drawing.Point(94, 81);
            this.cbBaudRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(94, 28);
            this.cbBaudRate.TabIndex = 1;
            // 
            // lbStopBits
            // 
            this.lbStopBits.AutoSize = true;
            this.lbStopBits.Location = new System.Drawing.Point(28, 168);
            this.lbStopBits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStopBits.Name = "lbStopBits";
            this.lbStopBits.Size = new System.Drawing.Size(58, 20);
            this.lbStopBits.TabIndex = 14;
            this.lbStopBits.Text = "停止位:";
            // 
            // cbStopBits
            // 
            this.cbStopBits.FormattingEnabled = true;
            this.cbStopBits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.cbStopBits.Location = new System.Drawing.Point(94, 164);
            this.cbStopBits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStopBits.Name = "cbStopBits";
            this.cbStopBits.Size = new System.Drawing.Size(94, 28);
            this.cbStopBits.TabIndex = 3;
            // 
            // lbDataBits
            // 
            this.lbDataBits.AutoSize = true;
            this.lbDataBits.Location = new System.Drawing.Point(28, 127);
            this.lbDataBits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDataBits.Name = "lbDataBits";
            this.lbDataBits.Size = new System.Drawing.Size(58, 20);
            this.lbDataBits.TabIndex = 12;
            this.lbDataBits.Text = "数据位:";
            // 
            // cbDataBits
            // 
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbDataBits.Location = new System.Drawing.Point(94, 123);
            this.cbDataBits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(94, 28);
            this.cbDataBits.TabIndex = 2;
            // 
            // lbParity
            // 
            this.lbParity.AutoSize = true;
            this.lbParity.Location = new System.Drawing.Point(28, 209);
            this.lbParity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbParity.Name = "lbParity";
            this.lbParity.Size = new System.Drawing.Size(43, 20);
            this.lbParity.TabIndex = 16;
            this.lbParity.Text = "校验:";
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.cbParity.Location = new System.Drawing.Point(94, 205);
            this.cbParity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(94, 28);
            this.cbParity.TabIndex = 4;
            // 
            // gbPort
            // 
            this.gbPort.Controls.Add(this.lbThreadSleepms);
            this.gbPort.Controls.Add(this.tbThreadSleep);
            this.gbPort.Controls.Add(this.lbThreadSleep);
            this.gbPort.Controls.Add(this.cbPort);
            this.gbPort.Controls.Add(this.lbParity);
            this.gbPort.Controls.Add(this.cbDataBits);
            this.gbPort.Controls.Add(this.lbDataBits);
            this.gbPort.Controls.Add(this.lbPort);
            this.gbPort.Controls.Add(this.lbBaudRate);
            this.gbPort.Controls.Add(this.cbStopBits);
            this.gbPort.Controls.Add(this.cbParity);
            this.gbPort.Controls.Add(this.cbBaudRate);
            this.gbPort.Controls.Add(this.lbStopBits);
            this.gbPort.Location = new System.Drawing.Point(15, 30);
            this.gbPort.Margin = new System.Windows.Forms.Padding(4);
            this.gbPort.Name = "gbPort";
            this.gbPort.Padding = new System.Windows.Forms.Padding(4);
            this.gbPort.Size = new System.Drawing.Size(211, 285);
            this.gbPort.TabIndex = 17;
            this.gbPort.TabStop = false;
            this.gbPort.Text = "串口参数";
            // 
            // lbThreadSleep
            // 
            this.lbThreadSleep.AutoSize = true;
            this.lbThreadSleep.Location = new System.Drawing.Point(28, 244);
            this.lbThreadSleep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbThreadSleep.Name = "lbThreadSleep";
            this.lbThreadSleep.Size = new System.Drawing.Size(73, 20);
            this.lbThreadSleep.TabIndex = 17;
            this.lbThreadSleep.Text = "读取频率:";
            // 
            // btnPortOpen
            // 
            this.btnPortOpen.Location = new System.Drawing.Point(15, 28);
            this.btnPortOpen.Margin = new System.Windows.Forms.Padding(4);
            this.btnPortOpen.Name = "btnPortOpen";
            this.btnPortOpen.Size = new System.Drawing.Size(94, 29);
            this.btnPortOpen.TabIndex = 5;
            this.btnPortOpen.Text = "打开串口";
            this.btnPortOpen.UseVisualStyleBackColor = true;
            this.btnPortOpen.Click += new System.EventHandler(this.btnPortOpen_Click);
            // 
            // btnPortClose
            // 
            this.btnPortClose.Location = new System.Drawing.Point(116, 28);
            this.btnPortClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnPortClose.Name = "btnPortClose";
            this.btnPortClose.Size = new System.Drawing.Size(94, 29);
            this.btnPortClose.TabIndex = 6;
            this.btnPortClose.Text = "关闭串口";
            this.btnPortClose.UseVisualStyleBackColor = true;
            this.btnPortClose.Click += new System.EventHandler(this.btnPortClose_Click);
            // 
            // gbCmd
            // 
            this.gbCmd.Controls.Add(this.lbCOMstatus);
            this.gbCmd.Controls.Add(this.btnPortOpen);
            this.gbCmd.Controls.Add(this.btnPortClose);
            this.gbCmd.Location = new System.Drawing.Point(234, 30);
            this.gbCmd.Margin = new System.Windows.Forms.Padding(4);
            this.gbCmd.Name = "gbCmd";
            this.gbCmd.Padding = new System.Windows.Forms.Padding(4);
            this.gbCmd.Size = new System.Drawing.Size(224, 125);
            this.gbCmd.TabIndex = 22;
            this.gbCmd.TabStop = false;
            this.gbCmd.Text = "串口操作";
            // 
            // lbCOMstatus
            // 
            this.lbCOMstatus.AutoSize = true;
            this.lbCOMstatus.Location = new System.Drawing.Point(66, 75);
            this.lbCOMstatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCOMstatus.Name = "lbCOMstatus";
            this.lbCOMstatus.Size = new System.Drawing.Size(84, 20);
            this.lbCOMstatus.TabIndex = 7;
            this.lbCOMstatus.Text = "串口已关闭";
            // 
            // btnPortWrite
            // 
            this.btnPortWrite.Location = new System.Drawing.Point(398, 116);
            this.btnPortWrite.Margin = new System.Windows.Forms.Padding(4);
            this.btnPortWrite.Name = "btnPortWrite";
            this.btnPortWrite.Size = new System.Drawing.Size(94, 29);
            this.btnPortWrite.TabIndex = 14;
            this.btnPortWrite.Text = "发送";
            this.btnPortWrite.UseVisualStyleBackColor = true;
            this.btnPortWrite.Click += new System.EventHandler(this.btnPortWrite_Click);
            // 
            // tbPortWrite
            // 
            this.tbPortWrite.Location = new System.Drawing.Point(8, 28);
            this.tbPortWrite.Margin = new System.Windows.Forms.Padding(4);
            this.tbPortWrite.Multiline = true;
            this.tbPortWrite.Name = "tbPortWrite";
            this.tbPortWrite.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbPortWrite.Size = new System.Drawing.Size(483, 80);
            this.tbPortWrite.TabIndex = 12;
            this.tbPortWrite.TextChanged += new System.EventHandler(this.tbPortWrite_TextChanged);
            this.tbPortWrite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPortWrite_KeyPress);
            // 
            // gbSend
            // 
            this.gbSend.Controls.Add(this.ckb16);
            this.gbSend.Controls.Add(this.ckbNewLine);
            this.gbSend.Controls.Add(this.tbPortWrite);
            this.gbSend.Controls.Add(this.btnPortWrite);
            this.gbSend.Location = new System.Drawing.Point(15, 322);
            this.gbSend.Margin = new System.Windows.Forms.Padding(4);
            this.gbSend.Name = "gbSend";
            this.gbSend.Padding = new System.Windows.Forms.Padding(4);
            this.gbSend.Size = new System.Drawing.Size(499, 152);
            this.gbSend.TabIndex = 23;
            this.gbSend.TabStop = false;
            this.gbSend.Text = "发送";
            // 
            // ckb16
            // 
            this.ckb16.AutoSize = true;
            this.ckb16.Location = new System.Drawing.Point(8, 119);
            this.ckb16.Margin = new System.Windows.Forms.Padding(4);
            this.ckb16.Name = "ckb16";
            this.ckb16.Size = new System.Drawing.Size(109, 24);
            this.ckb16.TabIndex = 15;
            this.ckb16.Text = "16进制输入";
            this.ckb16.UseVisualStyleBackColor = true;
            this.ckb16.CheckedChanged += new System.EventHandler(this.ckb16_CheckedChanged);
            // 
            // ckbNewLine
            // 
            this.ckbNewLine.AutoSize = true;
            this.ckbNewLine.Checked = true;
            this.ckbNewLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbNewLine.Location = new System.Drawing.Point(126, 119);
            this.ckbNewLine.Margin = new System.Windows.Forms.Padding(4);
            this.ckbNewLine.Name = "ckbNewLine";
            this.ckbNewLine.Size = new System.Drawing.Size(106, 24);
            this.ckbNewLine.TabIndex = 13;
            this.ckbNewLine.Text = "发送时换行";
            this.ckbNewLine.UseVisualStyleBackColor = true;
            // 
            // tbPortRead
            // 
            this.tbPortRead.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPortRead.Location = new System.Drawing.Point(8, 28);
            this.tbPortRead.Margin = new System.Windows.Forms.Padding(4);
            this.tbPortRead.Multiline = true;
            this.tbPortRead.Name = "tbPortRead";
            this.tbPortRead.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbPortRead.Size = new System.Drawing.Size(483, 135);
            this.tbPortRead.TabIndex = 15;
            // 
            // gbRead
            // 
            this.gbRead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbRead.Controls.Add(this.tbPortRead);
            this.gbRead.Location = new System.Drawing.Point(15, 482);
            this.gbRead.Margin = new System.Windows.Forms.Padding(4);
            this.gbRead.Name = "gbRead";
            this.gbRead.Padding = new System.Windows.Forms.Padding(4);
            this.gbRead.Size = new System.Drawing.Size(499, 171);
            this.gbRead.TabIndex = 25;
            this.gbRead.TabStop = false;
            this.gbRead.Text = "接收";
            // 
            // chtData
            // 
            this.chtData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.Name = "ChartArea1";
            this.chtData.ChartAreas.Add(chartArea5);
            this.chtData.Cursor = System.Windows.Forms.Cursors.Hand;
            legend5.Name = "Legend1";
            this.chtData.Legends.Add(legend5);
            this.chtData.Location = new System.Drawing.Point(8, 176);
            this.chtData.Margin = new System.Windows.Forms.Padding(4);
            this.chtData.Name = "chtData";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.LegendText = "data1";
            series5.Name = "Series1";
            this.chtData.Series.Add(series5);
            this.chtData.Size = new System.Drawing.Size(695, 402);
            this.chtData.TabIndex = 26;
            this.chtData.DoubleClick += new System.EventHandler(this.chtData_DoubleClick);
            this.chtData.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chtData_MouseMove);
            // 
            // cbChartScrollBar
            // 
            this.cbChartScrollBar.AutoSize = true;
            this.cbChartScrollBar.Location = new System.Drawing.Point(26, 121);
            this.cbChartScrollBar.Margin = new System.Windows.Forms.Padding(4);
            this.cbChartScrollBar.Name = "cbChartScrollBar";
            this.cbChartScrollBar.Size = new System.Drawing.Size(106, 24);
            this.cbChartScrollBar.TabIndex = 28;
            this.cbChartScrollBar.Text = "显示滚动条";
            this.cbChartScrollBar.UseVisualStyleBackColor = true;
            this.cbChartScrollBar.CheckedChanged += new System.EventHandler(this.cbChartScrollBar_CheckedChanged);
            // 
            // cbChartShowValue
            // 
            this.cbChartShowValue.AutoSize = true;
            this.cbChartShowValue.Location = new System.Drawing.Point(26, 88);
            this.cbChartShowValue.Margin = new System.Windows.Forms.Padding(4);
            this.cbChartShowValue.Name = "cbChartShowValue";
            this.cbChartShowValue.Size = new System.Drawing.Size(91, 24);
            this.cbChartShowValue.TabIndex = 19;
            this.cbChartShowValue.Text = "显示数值";
            this.cbChartShowValue.UseVisualStyleBackColor = true;
            this.cbChartShowValue.CheckedChanged += new System.EventHandler(this.cbChartShowValue_CheckedChanged);
            // 
            // btnChartChannelName
            // 
            this.btnChartChannelName.Location = new System.Drawing.Point(310, 15);
            this.btnChartChannelName.Margin = new System.Windows.Forms.Padding(4);
            this.btnChartChannelName.Name = "btnChartChannelName";
            this.btnChartChannelName.Size = new System.Drawing.Size(94, 29);
            this.btnChartChannelName.TabIndex = 18;
            this.btnChartChannelName.Text = "修改";
            this.btnChartChannelName.UseVisualStyleBackColor = true;
            this.btnChartChannelName.Click += new System.EventHandler(this.btnChartChannelName_Click);
            // 
            // tbChartChannelName
            // 
            this.tbChartChannelName.Location = new System.Drawing.Point(182, 15);
            this.tbChartChannelName.Margin = new System.Windows.Forms.Padding(4);
            this.tbChartChannelName.Name = "tbChartChannelName";
            this.tbChartChannelName.Size = new System.Drawing.Size(119, 27);
            this.tbChartChannelName.TabIndex = 17;
            // 
            // cbChartChannelNameList
            // 
            this.cbChartChannelNameList.FormattingEnabled = true;
            this.cbChartChannelNameList.Items.AddRange(new object[] {
            "Channel 1",
            "Add Channel"});
            this.cbChartChannelNameList.Location = new System.Drawing.Point(74, 15);
            this.cbChartChannelNameList.Margin = new System.Windows.Forms.Padding(4);
            this.cbChartChannelNameList.Name = "cbChartChannelNameList";
            this.cbChartChannelNameList.Size = new System.Drawing.Size(100, 28);
            this.cbChartChannelNameList.TabIndex = 16;
            this.cbChartChannelNameList.SelectedIndexChanged += new System.EventHandler(this.cbChartChannelName_SelectedIndexChanged);
            // 
            // lbChartChannelName
            // 
            this.lbChartChannelName.AutoSize = true;
            this.lbChartChannelName.Location = new System.Drawing.Point(22, 19);
            this.lbChartChannelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbChartChannelName.Name = "lbChartChannelName";
            this.lbChartChannelName.Size = new System.Drawing.Size(43, 20);
            this.lbChartChannelName.TabIndex = 27;
            this.lbChartChannelName.Text = "通道:";
            // 
            // rbByteIsString
            // 
            this.rbByteIsString.AutoSize = true;
            this.rbByteIsString.Location = new System.Drawing.Point(8, 35);
            this.rbByteIsString.Margin = new System.Windows.Forms.Padding(4);
            this.rbByteIsString.Name = "rbByteIsString";
            this.rbByteIsString.Size = new System.Drawing.Size(74, 24);
            this.rbByteIsString.TabIndex = 25;
            this.rbByteIsString.Text = "String";
            this.rbByteIsString.UseVisualStyleBackColor = true;
            // 
            // gbByteDecoder
            // 
            this.gbByteDecoder.Controls.Add(this.btnOnlyForTest);
            this.gbByteDecoder.Controls.Add(this.rbNoDecoder);
            this.gbByteDecoder.Controls.Add(this.cbByteIsNumber);
            this.gbByteDecoder.Controls.Add(this.rbByteIsNumber);
            this.gbByteDecoder.Controls.Add(this.lbStringFilter);
            this.gbByteDecoder.Controls.Add(this.tbStringFilter);
            this.gbByteDecoder.Controls.Add(this.rbByteIsString);
            this.gbByteDecoder.Location = new System.Drawing.Point(234, 162);
            this.gbByteDecoder.Margin = new System.Windows.Forms.Padding(4);
            this.gbByteDecoder.Name = "gbByteDecoder";
            this.gbByteDecoder.Padding = new System.Windows.Forms.Padding(4);
            this.gbByteDecoder.Size = new System.Drawing.Size(224, 152);
            this.gbByteDecoder.TabIndex = 28;
            this.gbByteDecoder.TabStop = false;
            this.gbByteDecoder.Text = "字节解析";
            // 
            // btnOnlyForTest
            // 
            this.btnOnlyForTest.Location = new System.Drawing.Point(116, 109);
            this.btnOnlyForTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnOnlyForTest.Name = "btnOnlyForTest";
            this.btnOnlyForTest.Size = new System.Drawing.Size(94, 29);
            this.btnOnlyForTest.TabIndex = 11;
            this.btnOnlyForTest.Text = "解析测试";
            this.btnOnlyForTest.UseVisualStyleBackColor = true;
            this.btnOnlyForTest.Click += new System.EventHandler(this.btnOnlyForTest_Click);
            // 
            // rbNoDecoder
            // 
            this.rbNoDecoder.AutoSize = true;
            this.rbNoDecoder.Location = new System.Drawing.Point(8, 110);
            this.rbNoDecoder.Margin = new System.Windows.Forms.Padding(4);
            this.rbNoDecoder.Name = "rbNoDecoder";
            this.rbNoDecoder.Size = new System.Drawing.Size(105, 24);
            this.rbNoDecoder.TabIndex = 34;
            this.rbNoDecoder.TabStop = true;
            this.rbNoDecoder.Text = "不使用图表";
            this.rbNoDecoder.UseVisualStyleBackColor = true;
            // 
            // cbByteIsNumber
            // 
            this.cbByteIsNumber.FormattingEnabled = true;
            this.cbByteIsNumber.Items.AddRange(new object[] {
            "int16",
            "int32",
            "float",
            "double"});
            this.cbByteIsNumber.Location = new System.Drawing.Point(119, 71);
            this.cbByteIsNumber.Margin = new System.Windows.Forms.Padding(4);
            this.cbByteIsNumber.Name = "cbByteIsNumber";
            this.cbByteIsNumber.Size = new System.Drawing.Size(90, 28);
            this.cbByteIsNumber.TabIndex = 10;
            // 
            // rbByteIsNumber
            // 
            this.rbByteIsNumber.AutoSize = true;
            this.rbByteIsNumber.Location = new System.Drawing.Point(8, 72);
            this.rbByteIsNumber.Margin = new System.Windows.Forms.Padding(4);
            this.rbByteIsNumber.Name = "rbByteIsNumber";
            this.rbByteIsNumber.Size = new System.Drawing.Size(82, 24);
            this.rbByteIsNumber.TabIndex = 30;
            this.rbByteIsNumber.Text = "double";
            this.rbByteIsNumber.UseVisualStyleBackColor = true;
            // 
            // lbStringFilter
            // 
            this.lbStringFilter.AutoSize = true;
            this.lbStringFilter.Location = new System.Drawing.Point(115, 39);
            this.lbStringFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStringFilter.Name = "lbStringFilter";
            this.lbStringFilter.Size = new System.Drawing.Size(50, 20);
            this.lbStringFilter.TabIndex = 29;
            this.lbStringFilter.Text = "Filter:";
            // 
            // tbStringFilter
            // 
            this.tbStringFilter.Location = new System.Drawing.Point(171, 35);
            this.tbStringFilter.Margin = new System.Windows.Forms.Padding(4);
            this.tbStringFilter.Name = "tbStringFilter";
            this.tbStringFilter.Size = new System.Drawing.Size(38, 27);
            this.tbStringFilter.TabIndex = 9;
            this.tbStringFilter.Text = ",";
            // 
            // tcOutput
            // 
            this.tcOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcOutput.Controls.Add(this.tpChart);
            this.tcOutput.Controls.Add(this.tpExcel);
            this.tcOutput.Location = new System.Drawing.Point(521, 30);
            this.tcOutput.Margin = new System.Windows.Forms.Padding(4);
            this.tcOutput.Name = "tcOutput";
            this.tcOutput.SelectedIndex = 0;
            this.tcOutput.Size = new System.Drawing.Size(720, 624);
            this.tcOutput.TabIndex = 29;
            // 
            // tpChart
            // 
            this.tpChart.Controls.Add(this.chkUseFrame);
            this.tpChart.Controls.Add(this.lbStopFrame);
            this.tpChart.Controls.Add(this.lbStartFrame);
            this.tpChart.Controls.Add(this.tbStopFrame);
            this.tpChart.Controls.Add(this.tbStartFrame);
            this.tpChart.Controls.Add(this.cbChartChannelEnable);
            this.tpChart.Controls.Add(this.label2);
            this.tpChart.Controls.Add(this.btnChartNormal);
            this.tpChart.Controls.Add(this.btnChartMaximized);
            this.tpChart.Controls.Add(this.cbChartTotb);
            this.tpChart.Controls.Add(this.btnChartXSmall);
            this.tpChart.Controls.Add(this.btnChartXBig);
            this.tpChart.Controls.Add(this.label1);
            this.tpChart.Controls.Add(this.cbChartScrollBar);
            this.tpChart.Controls.Add(this.cbChartShowValue);
            this.tpChart.Controls.Add(this.chtData);
            this.tpChart.Controls.Add(this.btnChartChannelName);
            this.tpChart.Controls.Add(this.lbChartChannelName);
            this.tpChart.Controls.Add(this.tbChartChannelName);
            this.tpChart.Controls.Add(this.cbChartChannelNameList);
            this.tpChart.Location = new System.Drawing.Point(4, 29);
            this.tpChart.Margin = new System.Windows.Forms.Padding(4);
            this.tpChart.Name = "tpChart";
            this.tpChart.Padding = new System.Windows.Forms.Padding(4);
            this.tpChart.Size = new System.Drawing.Size(712, 591);
            this.tpChart.TabIndex = 0;
            this.tpChart.Text = "图表显示";
            this.tpChart.UseVisualStyleBackColor = true;
            // 
            // chkUseFrame
            // 
            this.chkUseFrame.AutoSize = true;
            this.chkUseFrame.Location = new System.Drawing.Point(526, 42);
            this.chkUseFrame.Name = "chkUseFrame";
            this.chkUseFrame.Size = new System.Drawing.Size(106, 24);
            this.chkUseFrame.TabIndex = 42;
            this.chkUseFrame.Text = "使用标识帧";
            this.chkUseFrame.UseVisualStyleBackColor = true;
            // 
            // lbStopFrame
            // 
            this.lbStopFrame.AutoSize = true;
            this.lbStopFrame.Location = new System.Drawing.Point(522, 118);
            this.lbStopFrame.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStopFrame.Name = "lbStopFrame";
            this.lbStopFrame.Size = new System.Drawing.Size(58, 20);
            this.lbStopFrame.TabIndex = 40;
            this.lbStopFrame.Text = "终止帧:";
            // 
            // lbStartFrame
            // 
            this.lbStartFrame.AutoSize = true;
            this.lbStartFrame.Location = new System.Drawing.Point(522, 81);
            this.lbStartFrame.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStartFrame.Name = "lbStartFrame";
            this.lbStartFrame.Size = new System.Drawing.Size(58, 20);
            this.lbStartFrame.TabIndex = 39;
            this.lbStartFrame.Text = "起始帧:";
            // 
            // tbStopFrame
            // 
            this.tbStopFrame.Location = new System.Drawing.Point(587, 115);
            this.tbStopFrame.Name = "tbStopFrame";
            this.tbStopFrame.Size = new System.Drawing.Size(57, 27);
            this.tbStopFrame.TabIndex = 38;
            this.tbStopFrame.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStopFrame_KeyPress);
            // 
            // tbStartFrame
            // 
            this.tbStartFrame.Location = new System.Drawing.Point(587, 78);
            this.tbStartFrame.Name = "tbStartFrame";
            this.tbStartFrame.Size = new System.Drawing.Size(56, 27);
            this.tbStartFrame.TabIndex = 37;
            this.tbStartFrame.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStartFrame_KeyPress);
            // 
            // cbChartChannelEnable
            // 
            this.cbChartChannelEnable.AutoSize = true;
            this.cbChartChannelEnable.Location = new System.Drawing.Point(411, 18);
            this.cbChartChannelEnable.Margin = new System.Windows.Forms.Padding(4);
            this.cbChartChannelEnable.Name = "cbChartChannelEnable";
            this.cbChartChannelEnable.Size = new System.Drawing.Size(61, 24);
            this.cbChartChannelEnable.TabIndex = 36;
            this.cbChartChannelEnable.Text = "显示";
            this.cbChartChannelEnable.UseVisualStyleBackColor = true;
            this.cbChartChannelEnable.CheckedChanged += new System.EventHandler(this.cbChartChannelEnable_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "图表大小:";
            // 
            // btnChartNormal
            // 
            this.btnChartNormal.Location = new System.Drawing.Point(348, 84);
            this.btnChartNormal.Margin = new System.Windows.Forms.Padding(4);
            this.btnChartNormal.Name = "btnChartNormal";
            this.btnChartNormal.Size = new System.Drawing.Size(94, 29);
            this.btnChartNormal.TabIndex = 34;
            this.btnChartNormal.Text = "小窗";
            this.btnChartNormal.UseVisualStyleBackColor = true;
            this.btnChartNormal.Click += new System.EventHandler(this.btnChartNormal_Click);
            // 
            // btnChartMaximized
            // 
            this.btnChartMaximized.Location = new System.Drawing.Point(246, 84);
            this.btnChartMaximized.Margin = new System.Windows.Forms.Padding(4);
            this.btnChartMaximized.Name = "btnChartMaximized";
            this.btnChartMaximized.Size = new System.Drawing.Size(94, 29);
            this.btnChartMaximized.TabIndex = 33;
            this.btnChartMaximized.Text = "全屏";
            this.btnChartMaximized.UseVisualStyleBackColor = true;
            this.btnChartMaximized.Click += new System.EventHandler(this.btnChartMaximized_Click);
            // 
            // cbChartTotb
            // 
            this.cbChartTotb.AutoSize = true;
            this.cbChartTotb.Location = new System.Drawing.Point(26, 54);
            this.cbChartTotb.Margin = new System.Windows.Forms.Padding(4);
            this.cbChartTotb.Name = "cbChartTotb";
            this.cbChartTotb.Size = new System.Drawing.Size(91, 24);
            this.cbChartTotb.TabIndex = 32;
            this.cbChartTotb.Text = "数据回显";
            this.cbChartTotb.UseVisualStyleBackColor = true;
            // 
            // btnChartXSmall
            // 
            this.btnChartXSmall.Enabled = false;
            this.btnChartXSmall.Location = new System.Drawing.Point(348, 119);
            this.btnChartXSmall.Margin = new System.Windows.Forms.Padding(4);
            this.btnChartXSmall.Name = "btnChartXSmall";
            this.btnChartXSmall.Size = new System.Drawing.Size(94, 29);
            this.btnChartXSmall.TabIndex = 31;
            this.btnChartXSmall.Text = "缩小";
            this.btnChartXSmall.UseVisualStyleBackColor = true;
            this.btnChartXSmall.Click += new System.EventHandler(this.btnChartXSmall_Click);
            // 
            // btnChartXBig
            // 
            this.btnChartXBig.Enabled = false;
            this.btnChartXBig.Location = new System.Drawing.Point(246, 119);
            this.btnChartXBig.Margin = new System.Windows.Forms.Padding(4);
            this.btnChartXBig.Name = "btnChartXBig";
            this.btnChartXBig.Size = new System.Drawing.Size(94, 29);
            this.btnChartXBig.TabIndex = 30;
            this.btnChartXBig.Text = "放大";
            this.btnChartXBig.UseVisualStyleBackColor = true;
            this.btnChartXBig.Click += new System.EventHandler(this.btnChartXBig_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "X轴缩放:";
            // 
            // tpExcel
            // 
            this.tpExcel.Controls.Add(this.lbExcelFileName);
            this.tpExcel.Controls.Add(this.tbExcelFileName);
            this.tpExcel.Controls.Add(this.cbExcelChannelDataOutput);
            this.tpExcel.Controls.Add(this.cbExcelAllDataOutput);
            this.tpExcel.Controls.Add(this.btnExcelWrite);
            this.tpExcel.Location = new System.Drawing.Point(4, 29);
            this.tpExcel.Margin = new System.Windows.Forms.Padding(4);
            this.tpExcel.Name = "tpExcel";
            this.tpExcel.Padding = new System.Windows.Forms.Padding(4);
            this.tpExcel.Size = new System.Drawing.Size(712, 591);
            this.tpExcel.TabIndex = 1;
            this.tpExcel.Text = "Excel显示";
            this.tpExcel.UseVisualStyleBackColor = true;
            // 
            // lbExcelFileName
            // 
            this.lbExcelFileName.AutoSize = true;
            this.lbExcelFileName.Location = new System.Drawing.Point(186, 29);
            this.lbExcelFileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbExcelFileName.Name = "lbExcelFileName";
            this.lbExcelFileName.Size = new System.Drawing.Size(58, 20);
            this.lbExcelFileName.TabIndex = 4;
            this.lbExcelFileName.Text = "文件名:";
            // 
            // tbExcelFileName
            // 
            this.tbExcelFileName.Location = new System.Drawing.Point(252, 25);
            this.tbExcelFileName.Margin = new System.Windows.Forms.Padding(4);
            this.tbExcelFileName.Name = "tbExcelFileName";
            this.tbExcelFileName.Size = new System.Drawing.Size(182, 27);
            this.tbExcelFileName.TabIndex = 3;
            // 
            // cbExcelChannelDataOutput
            // 
            this.cbExcelChannelDataOutput.AutoSize = true;
            this.cbExcelChannelDataOutput.Location = new System.Drawing.Point(31, 61);
            this.cbExcelChannelDataOutput.Margin = new System.Windows.Forms.Padding(4);
            this.cbExcelChannelDataOutput.Name = "cbExcelChannelDataOutput";
            this.cbExcelChannelDataOutput.Size = new System.Drawing.Size(136, 24);
            this.cbExcelChannelDataOutput.TabIndex = 2;
            this.cbExcelChannelDataOutput.Text = "输出多通道数据";
            this.cbExcelChannelDataOutput.UseVisualStyleBackColor = true;
            // 
            // cbExcelAllDataOutput
            // 
            this.cbExcelAllDataOutput.AutoSize = true;
            this.cbExcelAllDataOutput.Location = new System.Drawing.Point(31, 28);
            this.cbExcelAllDataOutput.Margin = new System.Windows.Forms.Padding(4);
            this.cbExcelAllDataOutput.Name = "cbExcelAllDataOutput";
            this.cbExcelAllDataOutput.Size = new System.Drawing.Size(121, 24);
            this.cbExcelAllDataOutput.TabIndex = 1;
            this.cbExcelAllDataOutput.Text = "输出所有数据";
            this.cbExcelAllDataOutput.UseVisualStyleBackColor = true;
            // 
            // btnExcelWrite
            // 
            this.btnExcelWrite.Location = new System.Drawing.Point(31, 98);
            this.btnExcelWrite.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcelWrite.Name = "btnExcelWrite";
            this.btnExcelWrite.Size = new System.Drawing.Size(94, 29);
            this.btnExcelWrite.TabIndex = 0;
            this.btnExcelWrite.Text = "生成Excel";
            this.btnExcelWrite.UseVisualStyleBackColor = true;
            this.btnExcelWrite.Click += new System.EventHandler(this.btnExcelWrite_Click);
            // 
            // TSMI
            // 
            this.TSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIAbout});
            this.TSMI.Name = "TSMI";
            this.TSMI.Size = new System.Drawing.Size(51, 24);
            this.TSMI.Text = "更新";
            // 
            // TSMIAbout
            // 
            this.TSMIAbout.Name = "TSMIAbout";
            this.TSMIAbout.Size = new System.Drawing.Size(114, 26);
            this.TSMIAbout.Text = "更新";
            this.TSMIAbout.Click += new System.EventHandler(this.TSMIAbout_Click);
            // 
            // MS
            // 
            this.MS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI});
            this.MS.Location = new System.Drawing.Point(0, 0);
            this.MS.Name = "MS";
            this.MS.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MS.Size = new System.Drawing.Size(1256, 28);
            this.MS.TabIndex = 30;
            this.MS.Text = "menuStrip1";
            // 
            // tbThreadSleep
            // 
            this.tbThreadSleep.Location = new System.Drawing.Point(108, 241);
            this.tbThreadSleep.MaxLength = 3;
            this.tbThreadSleep.Name = "tbThreadSleep";
            this.tbThreadSleep.Size = new System.Drawing.Size(43, 27);
            this.tbThreadSleep.TabIndex = 5;
            this.tbThreadSleep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbThreadSleep_KeyPress);
            // 
            // lbThreadSleepms
            // 
            this.lbThreadSleepms.AutoSize = true;
            this.lbThreadSleepms.Location = new System.Drawing.Point(158, 244);
            this.lbThreadSleepms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbThreadSleepms.Name = "lbThreadSleepms";
            this.lbThreadSleepms.Size = new System.Drawing.Size(30, 20);
            this.lbThreadSleepms.TabIndex = 19;
            this.lbThreadSleepms.Text = "ms";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1256, 669);
            this.Controls.Add(this.tcOutput);
            this.Controls.Add(this.gbByteDecoder);
            this.Controls.Add(this.gbRead);
            this.Controls.Add(this.gbSend);
            this.Controls.Add(this.gbCmd);
            this.Controls.Add(this.gbPort);
            this.Controls.Add(this.MS);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.MS;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "COM.Analysis.v2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbPort.ResumeLayout(false);
            this.gbPort.PerformLayout();
            this.gbCmd.ResumeLayout(false);
            this.gbCmd.PerformLayout();
            this.gbSend.ResumeLayout(false);
            this.gbSend.PerformLayout();
            this.gbRead.ResumeLayout(false);
            this.gbRead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtData)).EndInit();
            this.gbByteDecoder.ResumeLayout(false);
            this.gbByteDecoder.PerformLayout();
            this.tcOutput.ResumeLayout(false);
            this.tpChart.ResumeLayout(false);
            this.tpChart.PerformLayout();
            this.tpExcel.ResumeLayout(false);
            this.tpExcel.PerformLayout();
            this.MS.ResumeLayout(false);
            this.MS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort COM;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Label lbBaudRate;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.Label lbStopBits;
        private System.Windows.Forms.ComboBox cbStopBits;
        private System.Windows.Forms.Label lbDataBits;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.Label lbParity;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.GroupBox gbPort;
        private System.Windows.Forms.Button btnPortOpen;
        private System.Windows.Forms.Button btnPortClose;
        private System.Windows.Forms.GroupBox gbCmd;
        private System.Windows.Forms.Button btnPortWrite;
        private System.Windows.Forms.TextBox tbPortWrite;
        private System.Windows.Forms.GroupBox gbSend;
        private System.Windows.Forms.TextBox tbPortRead;
        private System.Windows.Forms.GroupBox gbRead;
        private System.Windows.Forms.CheckBox ckbNewLine;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtData;
        private System.Windows.Forms.Label lbChartChannelName;
        private System.Windows.Forms.ComboBox cbChartChannelNameList;
        private System.Windows.Forms.TextBox tbChartChannelName;
        private System.Windows.Forms.Button btnChartChannelName;
        private System.Windows.Forms.CheckBox cbChartShowValue;
        private System.Windows.Forms.RadioButton rbByteIsString;
        private System.Windows.Forms.GroupBox gbByteDecoder;
        private System.Windows.Forms.Label lbStringFilter;
        private System.Windows.Forms.TextBox tbStringFilter;
        private System.Windows.Forms.ComboBox cbByteIsNumber;
        private System.Windows.Forms.RadioButton rbByteIsNumber;
        private System.Windows.Forms.RadioButton rbNoDecoder;
        private System.Windows.Forms.Button btnOnlyForTest;
        private System.Windows.Forms.CheckBox cbChartScrollBar;
        private System.Windows.Forms.TabControl tcOutput;
        private System.Windows.Forms.TabPage tpChart;
        private System.Windows.Forms.TabPage tpExcel;
        private System.Windows.Forms.Button btnExcelWrite;
        private System.Windows.Forms.CheckBox cbExcelChannelDataOutput;
        private System.Windows.Forms.CheckBox cbExcelAllDataOutput;
        private System.Windows.Forms.Label lbExcelFileName;
        private System.Windows.Forms.TextBox tbExcelFileName;
        private System.Windows.Forms.ToolStripMenuItem TSMI;
        private System.Windows.Forms.ToolStripMenuItem TSMIAbout;
        private System.Windows.Forms.MenuStrip MS;
        private System.Windows.Forms.Button btnChartXSmall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChartXBig;
        private System.Windows.Forms.CheckBox cbChartTotb;
        private System.Windows.Forms.Button btnChartNormal;
        private System.Windows.Forms.Button btnChartMaximized;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCOMstatus;
        private System.Windows.Forms.CheckBox cbChartChannelEnable;
        private System.Windows.Forms.CheckBox ckb16;
        private System.Windows.Forms.Label lbStopFrame;
        private System.Windows.Forms.Label lbStartFrame;
        private System.Windows.Forms.TextBox tbStopFrame;
        private System.Windows.Forms.TextBox tbStartFrame;
        private System.Windows.Forms.CheckBox chkUseFrame;
        private System.Windows.Forms.Label lbThreadSleep;
        private System.Windows.Forms.Label lbThreadSleepms;
        private System.Windows.Forms.TextBox tbThreadSleep;
    }
}

