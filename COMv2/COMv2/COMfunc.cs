﻿using System;
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
        }
        // 读取用户输入配置
        void COMGetSettings()
        {
            COM.PortName = (string)cbPort.SelectedItem;
            COM.BaudRate = Convert.ToInt32(cbBaudRate.SelectedItem);
            COM.DataBits = Convert.ToInt32(cbDataBits.SelectedItem);
            switch ((string)cbStopBits.SelectedItem)
            {
                case "1": COM.StopBits = StopBits.One; break;
                case "1.5": COM.StopBits = StopBits.OnePointFive; break;
                case "2": COM.StopBits = StopBits.Two; break;
            }
            switch ((string)cbParity.SelectedItem)
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
                            Thread.Sleep(100);
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
    }
}