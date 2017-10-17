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
            textBox2.Invoke(new Action(() => { textBox2.Text += COMdataNow; }));
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
                COM.Write(textBox1.Text);
                textBox1.Text = "";
            }
        }
    }
}
