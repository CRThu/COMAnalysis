﻿namespace COMv2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.btnPortOpen = new System.Windows.Forms.Button();
            this.btnPortClose = new System.Windows.Forms.Button();
            this.gbCmd = new System.Windows.Forms.GroupBox();
            this.lbCOMstatus = new System.Windows.Forms.Label();
            this.btnPortWrite = new System.Windows.Forms.Button();
            this.tbPortWrite = new System.Windows.Forms.TextBox();
            this.gbSend = new System.Windows.Forms.GroupBox();
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
            this.cbPort.Location = new System.Drawing.Point(69, 41);
            this.cbPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(76, 25);
            this.cbPort.TabIndex = 0;
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(16, 44);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(35, 17);
            this.lbPort.TabIndex = 8;
            this.lbPort.Text = "端口:";
            // 
            // lbBaudRate
            // 
            this.lbBaudRate.AutoSize = true;
            this.lbBaudRate.Location = new System.Drawing.Point(16, 77);
            this.lbBaudRate.Name = "lbBaudRate";
            this.lbBaudRate.Size = new System.Drawing.Size(47, 17);
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
            this.cbBaudRate.Location = new System.Drawing.Point(69, 74);
            this.cbBaudRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(76, 25);
            this.cbBaudRate.TabIndex = 1;
            // 
            // lbStopBits
            // 
            this.lbStopBits.AutoSize = true;
            this.lbStopBits.Location = new System.Drawing.Point(16, 143);
            this.lbStopBits.Name = "lbStopBits";
            this.lbStopBits.Size = new System.Drawing.Size(47, 17);
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
            this.cbStopBits.Location = new System.Drawing.Point(69, 140);
            this.cbStopBits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbStopBits.Name = "cbStopBits";
            this.cbStopBits.Size = new System.Drawing.Size(76, 25);
            this.cbStopBits.TabIndex = 3;
            // 
            // lbDataBits
            // 
            this.lbDataBits.AutoSize = true;
            this.lbDataBits.Location = new System.Drawing.Point(16, 110);
            this.lbDataBits.Name = "lbDataBits";
            this.lbDataBits.Size = new System.Drawing.Size(47, 17);
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
            this.cbDataBits.Location = new System.Drawing.Point(69, 107);
            this.cbDataBits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(76, 25);
            this.cbDataBits.TabIndex = 2;
            // 
            // lbParity
            // 
            this.lbParity.AutoSize = true;
            this.lbParity.Location = new System.Drawing.Point(16, 176);
            this.lbParity.Name = "lbParity";
            this.lbParity.Size = new System.Drawing.Size(35, 17);
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
            this.cbParity.Location = new System.Drawing.Point(69, 173);
            this.cbParity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(76, 25);
            this.cbParity.TabIndex = 4;
            // 
            // gbPort
            // 
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
            this.gbPort.Location = new System.Drawing.Point(12, 24);
            this.gbPort.Name = "gbPort";
            this.gbPort.Size = new System.Drawing.Size(169, 228);
            this.gbPort.TabIndex = 17;
            this.gbPort.TabStop = false;
            this.gbPort.Text = "串口参数";
            // 
            // btnPortOpen
            // 
            this.btnPortOpen.Location = new System.Drawing.Point(12, 22);
            this.btnPortOpen.Name = "btnPortOpen";
            this.btnPortOpen.Size = new System.Drawing.Size(75, 23);
            this.btnPortOpen.TabIndex = 5;
            this.btnPortOpen.Text = "打开串口";
            this.btnPortOpen.UseVisualStyleBackColor = true;
            this.btnPortOpen.Click += new System.EventHandler(this.btnPortOpen_Click);
            // 
            // btnPortClose
            // 
            this.btnPortClose.Location = new System.Drawing.Point(93, 22);
            this.btnPortClose.Name = "btnPortClose";
            this.btnPortClose.Size = new System.Drawing.Size(75, 23);
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
            this.gbCmd.Location = new System.Drawing.Point(187, 24);
            this.gbCmd.Name = "gbCmd";
            this.gbCmd.Size = new System.Drawing.Size(179, 100);
            this.gbCmd.TabIndex = 22;
            this.gbCmd.TabStop = false;
            this.gbCmd.Text = "串口操作";
            // 
            // lbCOMstatus
            // 
            this.lbCOMstatus.AutoSize = true;
            this.lbCOMstatus.Location = new System.Drawing.Point(53, 60);
            this.lbCOMstatus.Name = "lbCOMstatus";
            this.lbCOMstatus.Size = new System.Drawing.Size(68, 17);
            this.lbCOMstatus.TabIndex = 7;
            this.lbCOMstatus.Text = "串口已关闭";
            // 
            // btnPortWrite
            // 
            this.btnPortWrite.Location = new System.Drawing.Point(318, 93);
            this.btnPortWrite.Name = "btnPortWrite";
            this.btnPortWrite.Size = new System.Drawing.Size(75, 23);
            this.btnPortWrite.TabIndex = 14;
            this.btnPortWrite.Text = "发送";
            this.btnPortWrite.UseVisualStyleBackColor = true;
            this.btnPortWrite.Click += new System.EventHandler(this.btnPortWrite_Click);
            // 
            // tbPortWrite
            // 
            this.tbPortWrite.Location = new System.Drawing.Point(6, 22);
            this.tbPortWrite.Multiline = true;
            this.tbPortWrite.Name = "tbPortWrite";
            this.tbPortWrite.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbPortWrite.Size = new System.Drawing.Size(387, 61);
            this.tbPortWrite.TabIndex = 12;
            // 
            // gbSend
            // 
            this.gbSend.Controls.Add(this.ckbNewLine);
            this.gbSend.Controls.Add(this.tbPortWrite);
            this.gbSend.Controls.Add(this.btnPortWrite);
            this.gbSend.Location = new System.Drawing.Point(12, 258);
            this.gbSend.Name = "gbSend";
            this.gbSend.Size = new System.Drawing.Size(399, 122);
            this.gbSend.TabIndex = 23;
            this.gbSend.TabStop = false;
            this.gbSend.Text = "发送";
            // 
            // ckbNewLine
            // 
            this.ckbNewLine.AutoSize = true;
            this.ckbNewLine.Checked = true;
            this.ckbNewLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbNewLine.Location = new System.Drawing.Point(6, 95);
            this.ckbNewLine.Name = "ckbNewLine";
            this.ckbNewLine.Size = new System.Drawing.Size(87, 21);
            this.ckbNewLine.TabIndex = 13;
            this.ckbNewLine.Text = "发送时换行";
            this.ckbNewLine.UseVisualStyleBackColor = true;
            // 
            // tbPortRead
            // 
            this.tbPortRead.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPortRead.Location = new System.Drawing.Point(6, 22);
            this.tbPortRead.Multiline = true;
            this.tbPortRead.Name = "tbPortRead";
            this.tbPortRead.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbPortRead.Size = new System.Drawing.Size(387, 109);
            this.tbPortRead.TabIndex = 15;
            // 
            // gbRead
            // 
            this.gbRead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbRead.Controls.Add(this.tbPortRead);
            this.gbRead.Location = new System.Drawing.Point(12, 386);
            this.gbRead.Name = "gbRead";
            this.gbRead.Size = new System.Drawing.Size(399, 137);
            this.gbRead.TabIndex = 25;
            this.gbRead.TabStop = false;
            this.gbRead.Text = "接收";
            // 
            // chtData
            // 
            this.chtData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chtData.ChartAreas.Add(chartArea1);
            this.chtData.Cursor = System.Windows.Forms.Cursors.Hand;
            legend1.Name = "Legend1";
            this.chtData.Legends.Add(legend1);
            this.chtData.Location = new System.Drawing.Point(6, 141);
            this.chtData.Name = "chtData";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.LegendText = "data1";
            series1.Name = "Series1";
            this.chtData.Series.Add(series1);
            this.chtData.Size = new System.Drawing.Size(556, 322);
            this.chtData.TabIndex = 26;
            this.chtData.DoubleClick += new System.EventHandler(this.chtData_DoubleClick);
            this.chtData.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chtData_MouseMove);
            // 
            // cbChartScrollBar
            // 
            this.cbChartScrollBar.AutoSize = true;
            this.cbChartScrollBar.Location = new System.Drawing.Point(21, 97);
            this.cbChartScrollBar.Name = "cbChartScrollBar";
            this.cbChartScrollBar.Size = new System.Drawing.Size(87, 21);
            this.cbChartScrollBar.TabIndex = 28;
            this.cbChartScrollBar.Text = "显示滚动条";
            this.cbChartScrollBar.UseVisualStyleBackColor = true;
            this.cbChartScrollBar.CheckedChanged += new System.EventHandler(this.cbChartScrollBar_CheckedChanged);
            // 
            // cbChartShowValue
            // 
            this.cbChartShowValue.AutoSize = true;
            this.cbChartShowValue.Location = new System.Drawing.Point(21, 70);
            this.cbChartShowValue.Name = "cbChartShowValue";
            this.cbChartShowValue.Size = new System.Drawing.Size(75, 21);
            this.cbChartShowValue.TabIndex = 19;
            this.cbChartShowValue.Text = "显示数值";
            this.cbChartShowValue.UseVisualStyleBackColor = true;
            this.cbChartShowValue.CheckedChanged += new System.EventHandler(this.cbChartShowValue_CheckedChanged);
            // 
            // btnChartChannelName
            // 
            this.btnChartChannelName.Location = new System.Drawing.Point(248, 12);
            this.btnChartChannelName.Name = "btnChartChannelName";
            this.btnChartChannelName.Size = new System.Drawing.Size(75, 23);
            this.btnChartChannelName.TabIndex = 18;
            this.btnChartChannelName.Text = "修改";
            this.btnChartChannelName.UseVisualStyleBackColor = true;
            this.btnChartChannelName.Click += new System.EventHandler(this.btnChartChannelName_Click);
            // 
            // tbChartChannelName
            // 
            this.tbChartChannelName.Location = new System.Drawing.Point(146, 12);
            this.tbChartChannelName.Name = "tbChartChannelName";
            this.tbChartChannelName.Size = new System.Drawing.Size(96, 23);
            this.tbChartChannelName.TabIndex = 17;
            // 
            // cbChartChannelNameList
            // 
            this.cbChartChannelNameList.FormattingEnabled = true;
            this.cbChartChannelNameList.Items.AddRange(new object[] {
            "Channel 1",
            "Add Channel"});
            this.cbChartChannelNameList.Location = new System.Drawing.Point(59, 12);
            this.cbChartChannelNameList.Name = "cbChartChannelNameList";
            this.cbChartChannelNameList.Size = new System.Drawing.Size(81, 25);
            this.cbChartChannelNameList.TabIndex = 16;
            this.cbChartChannelNameList.SelectedIndexChanged += new System.EventHandler(this.cbChartChannelName_SelectedIndexChanged);
            // 
            // lbChartChannelName
            // 
            this.lbChartChannelName.AutoSize = true;
            this.lbChartChannelName.Location = new System.Drawing.Point(18, 15);
            this.lbChartChannelName.Name = "lbChartChannelName";
            this.lbChartChannelName.Size = new System.Drawing.Size(35, 17);
            this.lbChartChannelName.TabIndex = 27;
            this.lbChartChannelName.Text = "通道:";
            // 
            // rbByteIsString
            // 
            this.rbByteIsString.AutoSize = true;
            this.rbByteIsString.Location = new System.Drawing.Point(6, 28);
            this.rbByteIsString.Name = "rbByteIsString";
            this.rbByteIsString.Size = new System.Drawing.Size(60, 21);
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
            this.gbByteDecoder.Location = new System.Drawing.Point(187, 130);
            this.gbByteDecoder.Name = "gbByteDecoder";
            this.gbByteDecoder.Size = new System.Drawing.Size(179, 122);
            this.gbByteDecoder.TabIndex = 28;
            this.gbByteDecoder.TabStop = false;
            this.gbByteDecoder.Text = "字节解析";
            // 
            // btnOnlyForTest
            // 
            this.btnOnlyForTest.Location = new System.Drawing.Point(93, 87);
            this.btnOnlyForTest.Name = "btnOnlyForTest";
            this.btnOnlyForTest.Size = new System.Drawing.Size(75, 23);
            this.btnOnlyForTest.TabIndex = 11;
            this.btnOnlyForTest.Text = "解析测试";
            this.btnOnlyForTest.UseVisualStyleBackColor = true;
            this.btnOnlyForTest.Click += new System.EventHandler(this.btnOnlyForTest_Click);
            // 
            // rbNoDecoder
            // 
            this.rbNoDecoder.AutoSize = true;
            this.rbNoDecoder.Location = new System.Drawing.Point(6, 88);
            this.rbNoDecoder.Name = "rbNoDecoder";
            this.rbNoDecoder.Size = new System.Drawing.Size(86, 21);
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
            this.cbByteIsNumber.Location = new System.Drawing.Point(95, 57);
            this.cbByteIsNumber.Name = "cbByteIsNumber";
            this.cbByteIsNumber.Size = new System.Drawing.Size(73, 25);
            this.cbByteIsNumber.TabIndex = 10;
            // 
            // rbByteIsNumber
            // 
            this.rbByteIsNumber.AutoSize = true;
            this.rbByteIsNumber.Location = new System.Drawing.Point(6, 58);
            this.rbByteIsNumber.Name = "rbByteIsNumber";
            this.rbByteIsNumber.Size = new System.Drawing.Size(67, 21);
            this.rbByteIsNumber.TabIndex = 30;
            this.rbByteIsNumber.Text = "double";
            this.rbByteIsNumber.UseVisualStyleBackColor = true;
            // 
            // lbStringFilter
            // 
            this.lbStringFilter.AutoSize = true;
            this.lbStringFilter.Location = new System.Drawing.Point(92, 31);
            this.lbStringFilter.Name = "lbStringFilter";
            this.lbStringFilter.Size = new System.Drawing.Size(39, 17);
            this.lbStringFilter.TabIndex = 29;
            this.lbStringFilter.Text = "Filter:";
            // 
            // tbStringFilter
            // 
            this.tbStringFilter.Location = new System.Drawing.Point(137, 28);
            this.tbStringFilter.Name = "tbStringFilter";
            this.tbStringFilter.Size = new System.Drawing.Size(31, 23);
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
            this.tcOutput.Location = new System.Drawing.Point(417, 24);
            this.tcOutput.Name = "tcOutput";
            this.tcOutput.SelectedIndex = 0;
            this.tcOutput.Size = new System.Drawing.Size(576, 499);
            this.tcOutput.TabIndex = 29;
            // 
            // tpChart
            // 
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
            this.tpChart.Location = new System.Drawing.Point(4, 26);
            this.tpChart.Name = "tpChart";
            this.tpChart.Padding = new System.Windows.Forms.Padding(3);
            this.tpChart.Size = new System.Drawing.Size(568, 469);
            this.tpChart.TabIndex = 0;
            this.tpChart.Text = "图表显示";
            this.tpChart.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "图表大小:";
            // 
            // btnChartNormal
            // 
            this.btnChartNormal.Location = new System.Drawing.Point(278, 67);
            this.btnChartNormal.Name = "btnChartNormal";
            this.btnChartNormal.Size = new System.Drawing.Size(75, 23);
            this.btnChartNormal.TabIndex = 34;
            this.btnChartNormal.Text = "小窗";
            this.btnChartNormal.UseVisualStyleBackColor = true;
            this.btnChartNormal.Click += new System.EventHandler(this.btnChartNormal_Click);
            // 
            // btnChartMaximized
            // 
            this.btnChartMaximized.Location = new System.Drawing.Point(197, 67);
            this.btnChartMaximized.Name = "btnChartMaximized";
            this.btnChartMaximized.Size = new System.Drawing.Size(75, 23);
            this.btnChartMaximized.TabIndex = 33;
            this.btnChartMaximized.Text = "全屏";
            this.btnChartMaximized.UseVisualStyleBackColor = true;
            this.btnChartMaximized.Click += new System.EventHandler(this.btnChartMaximized_Click);
            // 
            // cbChartTotb
            // 
            this.cbChartTotb.AutoSize = true;
            this.cbChartTotb.Location = new System.Drawing.Point(21, 43);
            this.cbChartTotb.Name = "cbChartTotb";
            this.cbChartTotb.Size = new System.Drawing.Size(75, 21);
            this.cbChartTotb.TabIndex = 32;
            this.cbChartTotb.Text = "数据回显";
            this.cbChartTotb.UseVisualStyleBackColor = true;
            // 
            // btnChartXSmall
            // 
            this.btnChartXSmall.Enabled = false;
            this.btnChartXSmall.Location = new System.Drawing.Point(278, 95);
            this.btnChartXSmall.Name = "btnChartXSmall";
            this.btnChartXSmall.Size = new System.Drawing.Size(75, 23);
            this.btnChartXSmall.TabIndex = 31;
            this.btnChartXSmall.Text = "缩小";
            this.btnChartXSmall.UseVisualStyleBackColor = true;
            this.btnChartXSmall.Click += new System.EventHandler(this.btnChartXSmall_Click);
            // 
            // btnChartXBig
            // 
            this.btnChartXBig.Enabled = false;
            this.btnChartXBig.Location = new System.Drawing.Point(197, 95);
            this.btnChartXBig.Name = "btnChartXBig";
            this.btnChartXBig.Size = new System.Drawing.Size(75, 23);
            this.btnChartXBig.TabIndex = 30;
            this.btnChartXBig.Text = "放大";
            this.btnChartXBig.UseVisualStyleBackColor = true;
            this.btnChartXBig.Click += new System.EventHandler(this.btnChartXBig_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
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
            this.tpExcel.Location = new System.Drawing.Point(4, 26);
            this.tpExcel.Name = "tpExcel";
            this.tpExcel.Padding = new System.Windows.Forms.Padding(3);
            this.tpExcel.Size = new System.Drawing.Size(568, 469);
            this.tpExcel.TabIndex = 1;
            this.tpExcel.Text = "Excel显示";
            this.tpExcel.UseVisualStyleBackColor = true;
            // 
            // lbExcelFileName
            // 
            this.lbExcelFileName.AutoSize = true;
            this.lbExcelFileName.Location = new System.Drawing.Point(149, 23);
            this.lbExcelFileName.Name = "lbExcelFileName";
            this.lbExcelFileName.Size = new System.Drawing.Size(47, 17);
            this.lbExcelFileName.TabIndex = 4;
            this.lbExcelFileName.Text = "文件名:";
            // 
            // tbExcelFileName
            // 
            this.tbExcelFileName.Location = new System.Drawing.Point(202, 20);
            this.tbExcelFileName.Name = "tbExcelFileName";
            this.tbExcelFileName.Size = new System.Drawing.Size(146, 23);
            this.tbExcelFileName.TabIndex = 3;
            // 
            // cbExcelChannelDataOutput
            // 
            this.cbExcelChannelDataOutput.AutoSize = true;
            this.cbExcelChannelDataOutput.Location = new System.Drawing.Point(25, 49);
            this.cbExcelChannelDataOutput.Name = "cbExcelChannelDataOutput";
            this.cbExcelChannelDataOutput.Size = new System.Drawing.Size(111, 21);
            this.cbExcelChannelDataOutput.TabIndex = 2;
            this.cbExcelChannelDataOutput.Text = "输出多通道数据";
            this.cbExcelChannelDataOutput.UseVisualStyleBackColor = true;
            // 
            // cbExcelAllDataOutput
            // 
            this.cbExcelAllDataOutput.AutoSize = true;
            this.cbExcelAllDataOutput.Location = new System.Drawing.Point(25, 22);
            this.cbExcelAllDataOutput.Name = "cbExcelAllDataOutput";
            this.cbExcelAllDataOutput.Size = new System.Drawing.Size(99, 21);
            this.cbExcelAllDataOutput.TabIndex = 1;
            this.cbExcelAllDataOutput.Text = "输出所有数据";
            this.cbExcelAllDataOutput.UseVisualStyleBackColor = true;
            // 
            // btnExcelWrite
            // 
            this.btnExcelWrite.Location = new System.Drawing.Point(25, 78);
            this.btnExcelWrite.Name = "btnExcelWrite";
            this.btnExcelWrite.Size = new System.Drawing.Size(75, 23);
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
            this.TSMI.Size = new System.Drawing.Size(44, 21);
            this.TSMI.Text = "更新";
            // 
            // TSMIAbout
            // 
            this.TSMIAbout.Name = "TSMIAbout";
            this.TSMIAbout.Size = new System.Drawing.Size(100, 22);
            this.TSMIAbout.Text = "更新";
            this.TSMIAbout.Click += new System.EventHandler(this.TSMIAbout_Click);
            // 
            // MS
            // 
            this.MS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI});
            this.MS.Location = new System.Drawing.Point(0, 0);
            this.MS.Name = "MS";
            this.MS.Size = new System.Drawing.Size(1005, 25);
            this.MS.TabIndex = 30;
            this.MS.Text = "menuStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 535);
            this.Controls.Add(this.tcOutput);
            this.Controls.Add(this.gbByteDecoder);
            this.Controls.Add(this.gbRead);
            this.Controls.Add(this.gbSend);
            this.Controls.Add(this.gbCmd);
            this.Controls.Add(this.gbPort);
            this.Controls.Add(this.MS);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.MS;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
    }
}

