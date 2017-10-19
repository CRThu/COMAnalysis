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
    public partial class MainForm : Form
    {
        public Thread thread = null;
        volatile bool loop=false;
        string COMdataAll;
        string COMdataNow;
        List<string> ChartChannelNameList=new List<string>();

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
            tbChartChannelName.Text = ChartChannelNameList[cbChartChannelNameList.SelectedIndex];

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
            Series chtDataSeries = new Series("chtDataSeries");
            chtDataSeries.ChartType = SeriesChartType.Line;
            chtDataSeries.IsValueShownAsLabel = true;
            chtDataSeries.LegendText = "data1";
            chtData.Series.Add(chtDataSeries);
            tbPortRead.Text = "9.234,6.111,4.333,8.888,9.092,9.234,6.111,4.333,8.888,9.092,9.234,6.111,4.333,8.888,9.092,9.234,6.111,4.333,8.888,9.092,9.234,6.111,4.333,8.888,9.092,9.234,6.111,4.333,8.888,9.092";
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
            chtData.Invoke(new Action(() =>
            {
                string[] b = tbPortRead.Text.Split(new char[] { ',' });
                double[] c = new double[b.Length];
                for (int i = 0; i < b.Length; i++)
                {
                    if (b[i] == "")
                        b[i] = "0";
                    c[i] = Convert.ToDouble(b[i]);
                }
                chtData.Series["chtDataSeries"].Points.DataBindY(c);
            }));
        }

        private void cbChartChannelName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)cbChartChannelNameList.SelectedItem == "Add Channel")
            {
                ChartChannelNameList.Add("data" + cbChartChannelNameList.Items.Count.ToString());
                cbChartChannelNameList.Items.Insert(cbChartChannelNameList.Items.Count - 1, "Channel " + cbChartChannelNameList.Items.Count.ToString());
                cbChartChannelNameList.SelectedIndex--;
            }
            else
                tbChartChannelName.Text = ChartChannelNameList[cbChartChannelNameList.SelectedIndex];

        }

        private void btnChartChannelName_Click(object sender, EventArgs e)
        {
            ChartChannelNameList[cbChartChannelNameList.SelectedIndex] = tbChartChannelName.Text;
        }
    }
}
