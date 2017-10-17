namespace COMv1
{
    partial class Form1
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
            this.PortOpen = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PortClose = new System.Windows.Forms.Button();
            this.StopReadLoop = new System.Windows.Forms.Button();
            this.StartReadLoop = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.PortWrite = new System.Windows.Forms.Button();
            this.COM = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // PortOpen
            // 
            this.PortOpen.Location = new System.Drawing.Point(42, 35);
            this.PortOpen.Name = "PortOpen";
            this.PortOpen.Size = new System.Drawing.Size(75, 23);
            this.PortOpen.TabIndex = 0;
            this.PortOpen.Text = "PortOpen";
            this.PortOpen.UseVisualStyleBackColor = true;
            this.PortOpen.Click += new System.EventHandler(this.PortOpen_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 21);
            this.textBox1.TabIndex = 1;
            // 
            // PortClose
            // 
            this.PortClose.Location = new System.Drawing.Point(141, 35);
            this.PortClose.Name = "PortClose";
            this.PortClose.Size = new System.Drawing.Size(75, 23);
            this.PortClose.TabIndex = 2;
            this.PortClose.Text = "PortClose";
            this.PortClose.UseVisualStyleBackColor = true;
            this.PortClose.Click += new System.EventHandler(this.PortClose_Click);
            // 
            // StopReadLoop
            // 
            this.StopReadLoop.Location = new System.Drawing.Point(141, 76);
            this.StopReadLoop.Name = "StopReadLoop";
            this.StopReadLoop.Size = new System.Drawing.Size(105, 23);
            this.StopReadLoop.TabIndex = 4;
            this.StopReadLoop.Text = "StopReadLoop";
            this.StopReadLoop.UseVisualStyleBackColor = true;
            this.StopReadLoop.Click += new System.EventHandler(this.StopReadLoop_Click);
            // 
            // StartReadLoop
            // 
            this.StartReadLoop.Location = new System.Drawing.Point(12, 76);
            this.StartReadLoop.Name = "StartReadLoop";
            this.StartReadLoop.Size = new System.Drawing.Size(105, 23);
            this.StartReadLoop.TabIndex = 3;
            this.StartReadLoop.Text = "StartReadLoop";
            this.StartReadLoop.UseVisualStyleBackColor = true;
            this.StartReadLoop.Click += new System.EventHandler(this.StartReadLoop_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(30, 173);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(216, 66);
            this.textBox2.TabIndex = 5;
            // 
            // PortWrite
            // 
            this.PortWrite.Location = new System.Drawing.Point(141, 115);
            this.PortWrite.Name = "PortWrite";
            this.PortWrite.Size = new System.Drawing.Size(75, 23);
            this.PortWrite.TabIndex = 6;
            this.PortWrite.Text = "PortWrite";
            this.PortWrite.UseVisualStyleBackColor = true;
            this.PortWrite.Click += new System.EventHandler(this.PortWrite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.PortWrite);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.StopReadLoop);
            this.Controls.Add(this.StartReadLoop);
            this.Controls.Add(this.PortClose);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PortOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PortOpen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button PortClose;
        private System.Windows.Forms.Button StopReadLoop;
        private System.Windows.Forms.Button StartReadLoop;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button PortWrite;
        private System.IO.Ports.SerialPort COM;
    }
}

