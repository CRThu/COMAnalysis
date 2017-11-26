using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace COMv2
{
    partial class MainForm
    {
        // 初始化串口
        void COMinit()
        {
            //try
            //{
            // 配置可用串口号
            string[] PortNames = SerialPort.GetPortNames();
            foreach (string PortName in PortNames)
                cbPort.Items.Add(PortName);

            // 配置默认串口参数
            cbPort.SelectedIndex = 0;
            cbBaudRate.SelectedText = "9600";
            cbDataBits.SelectedText = "8";
            cbStopBits.SelectedText = "1";
            cbParity.SelectedText = "None";
            tbThreadSleep.Text = "100";
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}

        }
        // 读取用户输入配置
        void COMGetSettings()
        {
            COM.PortName = cbPort.Text;
            COM.BaudRate = Convert.ToInt32(cbBaudRate.Text);
            COM.DataBits = Convert.ToInt32(cbDataBits.Text);
            switch (cbStopBits.Text)
            {
                case "1": COM.StopBits = StopBits.One; break;
                case "1.5": COM.StopBits = StopBits.OnePointFive; break;
                case "2": COM.StopBits = StopBits.Two; break;
            }
            switch (cbParity.Text)
            {
                case "None": COM.Parity = Parity.None; break;
                case "Odd": COM.Parity = Parity.Odd; break;
                case "Even": COM.Parity = Parity.Even; break;
                case "Mark": COM.Parity = Parity.Mark; break;
                case "Space": COM.Parity = Parity.Space; break;
            }
        }
        // 监听线程
        public void PortRead()
        {
            while (loop)
            {
                if (COM.IsOpen)
                {
                    int count = COM.BytesToRead;
                    if (count > 0)
                    {
                        byte[] readBuffer = new byte[count];
                        try
                        {
                            Application.DoEvents();
                            COM.Read(readBuffer, 0, count);
                            if (DataReceived != null)
                                DataReceived(readBuffer);
                            //Thread.Sleep(100);
                            Thread.Sleep(Convert.ToInt16(tbThreadSleep.Text));
                        }
                        catch (TimeoutException)
                        {
                        }
                    }
                }
            }
        }
        // 串口缓冲区处理
        void COMGetData(byte[] readBuffer)
        {
            COMdataNow = readBuffer;
            ByteDecoder();
            // byte[] to string
            //COMdataAll += System.Text.Encoding.Default.GetString(readBuffer);
            //COMdataNow = System.Text.Encoding.Default.GetString(readBuffer);
            //tbPortRead.Invoke(new Action(() => { tbPortRead.Text += COMdataNow; }));

            //chtData.Invoke(new Action(() =>
            //{
            //    chtData.Series["Series1"].Points.AddY(COMdataNow);
            //}));
        }

        // 16进制字符串转byte[]
        byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");
            byte[] buffer = new byte[s.Length / 2];
            if (s.Length % 2 != 0)
                throw new IndexOutOfRangeException();
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            return buffer;
        }
    }
}