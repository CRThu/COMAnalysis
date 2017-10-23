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
    public partial class MainForm : Form
    {
        public Thread thread = null;
        volatile bool loop=false;
        string COMdataAll;
        string COMdataNow;
        List<string> ChartChannelNameList=new List<string>();
        List<Series> chtDataSeriesAdd = new List<Series>();

        public delegate void EventHandle(byte[] readBuffer);
        public event EventHandle DataReceived;

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

        void COMGetData(byte[] readBuffer)
        {
            // byte[] to string
            COMdataAll += System.Text.Encoding.Default.GetString(readBuffer);
            COMdataNow = System.Text.Encoding.Default.GetString(readBuffer);
            tbPortRead.Invoke(new Action(() => { tbPortRead.Text += COMdataNow; }));

            //chtData.Invoke(new Action(() =>
            //{
            //    chtData.Series["Series1"].Points.AddY(COMdataNow);
            //}));
        }

        string ByteIsString(byte[] ByteArray)
        {
            return System.Text.Encoding.Default.GetString(ByteArray);
        }

        Int16[] ByteIsInt16(byte[] ByteArray)
        {
            Int16[] Int16Array=new Int16[ByteArray.Length/2];
            if (ByteArray.Length % 2 == 0)
                for (int i = 0; i < ByteArray.Length; i += 2)
                    Int16Array[i / 2] = BitConverter.ToInt16(ByteArray, i);
            return Int16Array;
        }

        Int32[] ByteIsInt32(byte[] ByteArray)
        {
            Int32[] Int32Array = new Int32[ByteArray.Length / 4];
            if (ByteArray.Length % 4 == 0)
                for (int i = 0; i < ByteArray.Length; i += 4)
                    Int32Array[i / 4] = BitConverter.ToInt32(ByteArray, i);
            return Int32Array;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] PortNames = SerialPort.GetPortNames();
            foreach (string PortName in PortNames)
                cbPort.Items.Add(PortName);

            cbPort.SelectedIndex = 0;
            cbBaudRate.SelectedText = "9600";
            cbDataBits.SelectedText = "8";
            cbStopBits.SelectedText = "1";
            cbParity.SelectedText = "None";

            // Chart Set
            ChartChannelNameList.Add("data1");
            cbChartChannelNameList.SelectedIndex = 0;
            tbChartChannelName.Text = ChartChannelNameList[0];

            // Chart Clear Param
            chtData.Annotations.Clear();
            chtData.ChartAreas.Clear();
            chtData.Legends.Clear();
            chtData.Series.Clear();
            chtData.Titles.Clear();

            // Title
            Title chtDataTitle = new Title("title");
            chtData.Titles.Add(chtDataTitle);
            // ChartArea
            ChartArea chtDataChartArea = new ChartArea("ChartArea");
            chtData.ChartAreas.Add(chtDataChartArea);
            // Series
            //Series chtDataSeries = new Series("chtDataSeries");
            // New Channel 1
            chtDataSeriesAdd.Add(new Series(ChartChannelNameList[0]));
            chtDataSeriesAdd[0].ChartType = SeriesChartType.Line;
            chtDataSeriesAdd[0].IsValueShownAsLabel = cbChartShowValue.Checked;
            chtData.Series.Add(chtDataSeriesAdd[0]);
            //tbPortRead.Text = "9.234,6.111,2.222,8.888,4.886,9.234,4.111,4.333,7.78,9.092,5.234,6.111,4.333,8.888,2.092,9.234,3.09,4.333,5.8,9.092,4.234,6.111,4.333,8.888,1.092,9.234,5.32,4.333,1.8,7.02";
            // Legend
            Legend chtDataLegend = new Legend("chtDataLegend");
            chtData.Legends.Add(chtDataLegend);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnPortReadEnd_Click(null, null);
            btnPortClose_Click(null, null);
        }

        private void btnPortOpen_Click(object sender, EventArgs e)
        {
            if (!COM.IsOpen)
            {
                COM.Open();
                DataReceived += new EventHandle(COMGetData);
            }
            else
            {
                MessageBox.Show("Port Opened.");
            }
        }

        private void btnPortClose_Click(object sender, EventArgs e)
        {
            if (COM.IsOpen)
            {
                COM.Close();
            }
            else
            {
                MessageBox.Show("Port Closed.");
            }
        }

        private void btnPortReadBegin_Click(object sender, EventArgs e)
        {
            if (!loop)
            {
                loop = true;
                thread = new Thread(new ThreadStart(PortRead));
                thread.Start();
            }
        }

        private void btnPortReadEnd_Click(object sender, EventArgs e)
        {
            if (loop)
            {
                loop = false;
                thread.Join();
                thread = null;
            }
        }

        private void btnPortWrite_Click(object sender, EventArgs e)
        {
            if (COM.IsOpen)
            {
                if (ckbNewLine.Checked == true)
                    tbPortWrite.Text += Environment.NewLine;
                COM.Write(tbPortWrite.Text);
                tbPortWrite.Text = "";
            }
        }

        private void tbPortRead_TextChanged(object sender, EventArgs e)
        {
            //only one channel
            //chtData.Invoke(new Action(() =>
            //{
            //    string[] b = tbPortRead.Text.Split(new char[] { ',' });
            //    double[] c = new double[b.Length];
            //    for (int i = 0; i < b.Length; i++)
            //    {
            //        if (b[i] == "")
            //            b[i] = "0";
            //        c[i] = Convert.ToDouble(b[i]);
            //    }
            //    chtData.Series["chtDataSeries"].Points.DataBindY(c);
            //}));
            //only one channel
            //string[] b = tbPortRead.Text.Split(new char[] { ',' });
            string[] b = tbPortRead.Text.Split(tbStringFilter.Text.ToCharArray());
            List<List<double>> c = new List<List<double>>();
            for (int i = 0; i < ChartChannelNameList.Count; i++)
            {
                List<double> ci = new List<double>();
                for (int j = i; j < b.Length; j += ChartChannelNameList.Count)
                {
                    if (b[j] != "")
                        ci.Add(Convert.ToDouble(b[j]));
                }
                c.Add(ci);
            }
            chtData.Invoke(new Action(() =>
            {
                for (int i = 0; i < ChartChannelNameList.Count; i++)
                    chtData.Series[ChartChannelNameList[i]].Points.DataBindY(c[i]);
            }));
        }

        private void cbChartChannelName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)cbChartChannelNameList.SelectedItem == "Add Channel")
            {
                // Add Channel Name To List
                ChartChannelNameList.Add("data" + cbChartChannelNameList.Items.Count.ToString());
                // New Channel n
                chtDataSeriesAdd.Add(new Series(ChartChannelNameList[cbChartChannelNameList.Items.Count - 1]));
                chtDataSeriesAdd[cbChartChannelNameList.Items.Count - 1].ChartType = SeriesChartType.Line;
                chtDataSeriesAdd[cbChartChannelNameList.Items.Count - 1].IsValueShownAsLabel = cbChartShowValue.Checked;
                chtData.Series.Add(chtDataSeriesAdd[cbChartChannelNameList.Items.Count - 1]);
                // Add Channel Name To ComboBox
                cbChartChannelNameList.Items.Insert(cbChartChannelNameList.Items.Count - 1, "Channel " + cbChartChannelNameList.Items.Count.ToString());
                cbChartChannelNameList.SelectedIndex--;
            }
            else
                tbChartChannelName.Text = ChartChannelNameList[cbChartChannelNameList.SelectedIndex];
        }

        private void btnChartChannelName_Click(object sender, EventArgs e)
        {
            // Change Channel Name In List
            ChartChannelNameList[cbChartChannelNameList.SelectedIndex] = tbChartChannelName.Text;
            // Change Channel Name In Series
            chtDataSeriesAdd[cbChartChannelNameList.SelectedIndex].Name = tbChartChannelName.Text;
        }

        private void cbChartShowValue_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < chtDataSeriesAdd.Count; i++)
                chtDataSeriesAdd[i].IsValueShownAsLabel = cbChartShowValue.Checked;
        }

        private void btnOnlyForTest_Click(object sender, EventArgs e)
        {
            // for test
            byte[] t = { 0x0D, 0x6B, 0x3C, 0x05, 0x11, 0x55, 0x40, 0xDD, 0xF0, 0x65, 0x8E, 0xA3, 0xD5, 0xC7, 0x11, 0x05 };
            // int16    {   27405     ,      1340     ,    21777    ,    -8896     ,    26096    ,    -23666   ,    -14379   ,       1297    }
            // int32    {           87845645           ,        -582986479	         ,          -1550948880      ,	            85051349	       }

            for (int i = 0; i < t.Length / 2; i++)
                tbPortWrite.Text += ByteIsInt16(t)[i].ToString() + "\t";

            tbPortWrite.Text += Environment.NewLine;

            for (int i = 0; i < t.Length / 4; i++)
                tbPortWrite.Text += ByteIsInt32(t)[i].ToString() + "\t";

            // for test
            tbPortRead.Text = "9.234,6.111,2.222,8.888,4.886,9.234,4.111,4.333,7.78,9.092,5.234,6.111,4.333,8.888,2.092,9.234,3.09,4.333,5.8,9.092,4.234,6.111,4.333,8.888,1.092,9.234,5.32,4.333,1.8,7.02";

            tbPortRead_TextChanged(null, null);
        }
    }
}
