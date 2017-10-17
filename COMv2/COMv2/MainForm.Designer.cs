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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPortOpen = new System.Windows.Forms.Button();
            this.btnPortClose = new System.Windows.Forms.Button();
            this.btnPortReadBegin = new System.Windows.Forms.Button();
            this.btnPortReadEnd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPortWrite = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(204, 141);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 39);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(314, 246);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(251, 92);
            this.textBox2.TabIndex = 11;
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(69, 32);
            this.cbPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(76, 25);
            this.cbPort.TabIndex = 0;
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(16, 35);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(35, 17);
            this.lbPort.TabIndex = 8;
            this.lbPort.Text = "端口:";
            // 
            // lbBaudRate
            // 
            this.lbBaudRate.AutoSize = true;
            this.lbBaudRate.Location = new System.Drawing.Point(16, 68);
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
            this.cbBaudRate.Location = new System.Drawing.Point(69, 65);
            this.cbBaudRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(76, 25);
            this.cbBaudRate.TabIndex = 1;
            // 
            // lbStopBits
            // 
            this.lbStopBits.AutoSize = true;
            this.lbStopBits.Location = new System.Drawing.Point(16, 134);
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
            this.cbStopBits.Location = new System.Drawing.Point(69, 131);
            this.cbStopBits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbStopBits.Name = "cbStopBits";
            this.cbStopBits.Size = new System.Drawing.Size(76, 25);
            this.cbStopBits.TabIndex = 3;
            // 
            // lbDataBits
            // 
            this.lbDataBits.AutoSize = true;
            this.lbDataBits.Location = new System.Drawing.Point(16, 101);
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
            this.cbDataBits.Location = new System.Drawing.Point(69, 98);
            this.cbDataBits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(76, 25);
            this.cbDataBits.TabIndex = 2;
            // 
            // lbParity
            // 
            this.lbParity.AutoSize = true;
            this.lbParity.Location = new System.Drawing.Point(16, 167);
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
            this.cbParity.Location = new System.Drawing.Point(69, 164);
            this.cbParity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(76, 25);
            this.cbParity.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPort);
            this.groupBox1.Controls.Add(this.lbParity);
            this.groupBox1.Controls.Add(this.cbDataBits);
            this.groupBox1.Controls.Add(this.lbDataBits);
            this.groupBox1.Controls.Add(this.lbPort);
            this.groupBox1.Controls.Add(this.lbBaudRate);
            this.groupBox1.Controls.Add(this.cbStopBits);
            this.groupBox1.Controls.Add(this.cbParity);
            this.groupBox1.Controls.Add(this.cbBaudRate);
            this.groupBox1.Controls.Add(this.lbStopBits);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 214);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口参数";
            // 
            // btnPortOpen
            // 
            this.btnPortOpen.Location = new System.Drawing.Point(17, 22);
            this.btnPortOpen.Name = "btnPortOpen";
            this.btnPortOpen.Size = new System.Drawing.Size(75, 23);
            this.btnPortOpen.TabIndex = 5;
            this.btnPortOpen.Text = "打开串口";
            this.btnPortOpen.UseVisualStyleBackColor = true;
            this.btnPortOpen.Click += new System.EventHandler(this.btnPortOpen_Click);
            // 
            // btnPortClose
            // 
            this.btnPortClose.Location = new System.Drawing.Point(108, 22);
            this.btnPortClose.Name = "btnPortClose";
            this.btnPortClose.Size = new System.Drawing.Size(75, 23);
            this.btnPortClose.TabIndex = 6;
            this.btnPortClose.Text = "关闭串口";
            this.btnPortClose.UseVisualStyleBackColor = true;
            this.btnPortClose.Click += new System.EventHandler(this.btnPortClose_Click);
            // 
            // btnPortReadBegin
            // 
            this.btnPortReadBegin.Location = new System.Drawing.Point(17, 58);
            this.btnPortReadBegin.Name = "btnPortReadBegin";
            this.btnPortReadBegin.Size = new System.Drawing.Size(75, 23);
            this.btnPortReadBegin.TabIndex = 7;
            this.btnPortReadBegin.Text = "开始读取";
            this.btnPortReadBegin.UseVisualStyleBackColor = true;
            this.btnPortReadBegin.Click += new System.EventHandler(this.btnPortReadBegin_Click);
            // 
            // btnPortReadEnd
            // 
            this.btnPortReadEnd.Location = new System.Drawing.Point(108, 58);
            this.btnPortReadEnd.Name = "btnPortReadEnd";
            this.btnPortReadEnd.Size = new System.Drawing.Size(75, 23);
            this.btnPortReadEnd.TabIndex = 8;
            this.btnPortReadEnd.Text = "结束读取";
            this.btnPortReadEnd.UseVisualStyleBackColor = true;
            this.btnPortReadEnd.Click += new System.EventHandler(this.btnPortReadEnd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPortReadEnd);
            this.groupBox2.Controls.Add(this.btnPortOpen);
            this.groupBox2.Controls.Add(this.btnPortReadBegin);
            this.groupBox2.Controls.Add(this.btnPortClose);
            this.groupBox2.Location = new System.Drawing.Point(187, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "串口操作";
            // 
            // btnPortWrite
            // 
            this.btnPortWrite.Location = new System.Drawing.Point(204, 191);
            this.btnPortWrite.Name = "btnPortWrite";
            this.btnPortWrite.Size = new System.Drawing.Size(75, 23);
            this.btnPortWrite.TabIndex = 23;
            this.btnPortWrite.Text = "发送";
            this.btnPortWrite.UseVisualStyleBackColor = true;
            this.btnPortWrite.Click += new System.EventHandler(this.btnPortWrite_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 378);
            this.Controls.Add(this.btnPortWrite);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "COM.Analysis.v2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPortOpen;
        private System.Windows.Forms.Button btnPortClose;
        private System.Windows.Forms.Button btnPortReadBegin;
        private System.Windows.Forms.Button btnPortReadEnd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPortWrite;
    }
}

