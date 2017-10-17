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

namespace COMv2
{
    public partial class MainForm : Form
    {
        public Thread thread = null;
        volatile bool loop=false;
        string COMdataAll;
        string COMdataNow;

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
                //string test = "9.234,9.111,9.333,9.888,9.092";
                //string[] b = test.Split(new char[] { ',' });
                string[] b = tbPortRead.Text.Split(new char[] { ',' });
                double[] c = new double[b.Length];
                for (int i = 0; i < b.Length; i++)
                {
                    if (b[i] == "")
                        b[i] = "0";
                    c[i] = Convert.ToDouble(b[i]);
                }
                chtData.Series["Series1"].Points.DataBindY(c);
            }));
        }
    }
}
