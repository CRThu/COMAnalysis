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
    struct Frame
    {
        public byte[] Begin;
        public byte[] End;

        public Frame(UInt16 uBegin, UInt16 uEnd) : this()
        {
            this.Begin = BitConverter.GetBytes(uBegin);
            this.End = BitConverter.GetBytes(uEnd);
        }
    }
    public partial class MainForm : Form
    {
        public Thread thread = null;     // 监听线程
        volatile bool loop = false;           // 串口读取循环使能
        byte[] COMdataNow;                // 缓冲区数据
        List<string> ChartChannelNameList = new List<string>();   // 通道名
        List<Series> chtDataSeriesAdd = new List<Series>();         // 通道类
        Frame chtDataFrame = new Frame(0xcc00,0xcdab);              // 通道帧
        
        public delegate void EventHandle(byte[] readBuffer);    // 读取串口委托
        public event EventHandle DataReceived;                      // 读取串口函数


        public MainForm()
        {
            InitializeComponent();
       }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // COMinit
            try
            {
                COMinit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            // Chart Set
            cbChartTotb.Checked = true;

            ChartChannelNameList.Add("data1");
            cbChartChannelNameList.SelectedIndex = 0;
            tbChartChannelName.Text = ChartChannelNameList[0];
            cbChartChannelEnable.Checked = true;

            Chartinit();
            // 添加鼠标滚轮事件
            this.chtData.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.chtData_MouseWheel);

            // Excel
            cbExcelAllDataOutput.Checked = true;
            tbExcelFileName.Text = DateTime.Now.ToString("g").Replace("/", "-").Replace(" ", "-").Replace(":", "-") + "-" + DateTime.Now.Second;

            // byte[] decode
            rbByteIsString.Checked = true;
            cbByteIsNumber.Text = "int16";

            // Frame
            // how to use it?
            // chkUseFrame.checked
            // HexStringToByteArray(tbStartFrame.Text)
            // HexStringToByteArray(tbStopFrame.Text)
            tbStartFrame.Text = BitConverter.ToUInt16(chtDataFrame.Begin,0).ToString("x04");
            tbStopFrame.Text = BitConverter.ToUInt16(chtDataFrame.End, 0).ToString("x04");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnPortClose_Click(null, null);
        }

        private void btnPortOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (!COM.IsOpen)    // open
                {
                    COMGetSettings();
                    COM.Open();
                    DataReceived += new EventHandle(COMGetData);
                }

                if (!loop)                  // begin read
                {
                    loop = true;
                    thread = new Thread(new ThreadStart(PortRead));
                    thread.Start();
                }

                if (COM.IsOpen)
                    lbCOMstatus.Text = "串口已打开";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnPortClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (loop)                   // end read
                {
                    loop = false;
                    thread.Join();
                    thread = null;
                }

                if (COM.IsOpen)     // close
                {
                    COM.Close();
                }

                if (!COM.IsOpen)
                    lbCOMstatus.Text = "串口已关闭";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnPortWrite_Click(object sender, EventArgs e)
        {
            if (COM.IsOpen)
            {
                try
                {
                    if (ckb16.Checked)
                    {
                        byte[] WriteStr = HexStringToByteArray(tbPortWrite.Text);
                        COM.Write(WriteStr, 0, WriteStr.Length);
                    }
                    else
                        COM.Write(tbPortWrite.Text);

                if (ckbNewLine.Checked == true)
                    COM.Write(Environment.NewLine);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                tbPortWrite.Text = "";
            }
        }

        private void ckb16_CheckedChanged(object sender, EventArgs e)
        {
            tbPortWrite.Text = "";
        }

        private void tbPortWrite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ckb16.Checked)
            {
                if (!((e.KeyChar == '\b')
                    || ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                    || ((e.KeyChar >= 'A') && (e.KeyChar <= 'F'))
                    || ((e.KeyChar >= 'a') && (e.KeyChar <= 'f'))))
                {
                    e.Handled = true;
                }
                if((e.KeyChar >= 'a') && (e.KeyChar <= 'f'))
                {
                    e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
                }
                if (e.KeyChar == '\b')
                    tbPortWrite.Text = tbPortWrite.Text.Substring(0, (tbPortWrite.Text.Length - 2 >= 0) ? tbPortWrite.Text.Length - 2 : tbPortWrite.Text.Length);
            }
        }

        private void tbPortWrite_TextChanged(object sender, EventArgs e)
        {
            string tb = "";
            char n;
            if (ckb16.Checked)
            {
                for (int i = 0; i < tbPortWrite.Text.Replace(" ", "").Length; i++)
                {
                    n = tbPortWrite.Text.Replace(" ", "")[i];
                    if (((n>='0')&&(n<='9'))
                        ||((n >= 'A') && (n <= 'F'))
                        ||((n >= 'a') && (n <= 'f')))
                            tb += n;
                    if (i % 2 != 0)
                        tb += " ";
                }
                tbPortWrite.Text = tb;
                tbPortWrite.Select(tbPortWrite.Text.Length, 0);
            }
        }

        //private void tbPortRead_TextChanged(object sender, EventArgs e)
        //{
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
        //string[] b = tbPortRead.Text.Split(new char[] { ',' });
        //string[] b = tbPortRead.Text.Split(tbStringFilter.Text.ToCharArray());
        //List<List<double>> c = new List<List<double>>();
        //for (int i = 0; i < ChartChannelNameList.Count; i++)
        //{
        //    List<double> ci = new List<double>();
        //    for (int j = i; j < b.Length; j += ChartChannelNameList.Count)
        //    {
        //        if (b[j] != "")
        //            ci.Add(Convert.ToDouble(b[j]));
        //    }
        //    c.Add(ci);
        //}
        //chtData.Invoke(new Action(() =>
        //{
        //    for (int i = 0; i < ChartChannelNameList.Count; i++)
        //        chtData.Series[ChartChannelNameList[i]].Points.DataBindY(c[i]);
        //}));
        //}

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
                chtDataSeriesAdd[cbChartChannelNameList.Items.Count - 1].BorderWidth = 2;
                chtData.Series.Add(chtDataSeriesAdd[cbChartChannelNameList.Items.Count - 1]);
                // Add Channel Name To ComboBox
                cbChartChannelNameList.Items.Insert(cbChartChannelNameList.Items.Count - 1, "Channel " + cbChartChannelNameList.Items.Count.ToString());
                cbChartChannelNameList.SelectedIndex--;
                
                ChartUpdate();
            }
            else
            {
                tbChartChannelName.Text = ChartChannelNameList[cbChartChannelNameList.SelectedIndex];
            }

            if (chtDataSeriesAdd.Count != 0)
            {
                cbChartChannelEnable.Checked = chtDataSeriesAdd[cbChartChannelNameList.SelectedIndex].Enabled;
            }
        }

        private void btnChartChannelName_Click(object sender, EventArgs e)
        {
            // Change Channel Name In List
            ChartChannelNameList[cbChartChannelNameList.SelectedIndex] = tbChartChannelName.Text;
            // Change Channel Name In Series
            chtDataSeriesAdd[cbChartChannelNameList.SelectedIndex].Name = tbChartChannelName.Text;

            ChartUpdate();
        }

        private void cbChartShowValue_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < chtDataSeriesAdd.Count; i++)
                chtDataSeriesAdd[i].IsValueShownAsLabel = cbChartShowValue.Checked;
        }

        private void btnOnlyForTest_Click(object sender, EventArgs e)
        {
            // float to byte[]
            //float a = 123.321F;
            //COMdataNow = BitConverter.GetBytes(a);
            // for test
            if (rbByteIsString.Checked)
                COMdataNow = System.Text.Encoding.Default.GetBytes("9.234,6.111,2.222,8.888,4.886,9.234,4.111,4.333,7.78,9.092,5.234,6.111,4.333,8.888,2.092,9.234,3.09,4.333,5.8,9.092,4.234,6.111,4.333,8.888,1.092,9.234,5.32,4.333,1.8,7.02");
            if (rbByteIsNumber.Checked)
                COMdataNow = new byte[] { 0x0D, 0x6B, 0x3C, 0x05, 0x11, 0x55, 0x40, 0xDD, 0xF0, 0x65, 0x8E, 0xA3, 0xD5, 0xC7, 0x11, 0x05 };
            if (rbNoDecoder.Checked)
                COMdataNow = System.Text.Encoding.Default.GetBytes("helloworld");

            // for float test
            //for (int i = 0; i < 4; i++)
            //    tbPortWrite.Text += (COMdataNow[i]+" ");

            ByteDecoder();
            // for test
            //byte[] t = { 0x0D, 0x6B, 0x3C, 0x05, 0x11, 0x55, 0x40, 0xDD, 0xF0, 0x65, 0x8E, 0xA3, 0xD5, 0xC7, 0x11, 0x05 };

            // int16    {   27405     ,      1340     ,    21777    ,    -8896     ,    26096    ,    -23666   ,    -14379   ,       1297    }
            // int32    {           87845645           ,        -582986479	         ,          -1550948880      ,	            85051349	       }

            // for convert test
            //for (int i = 0; i < t.Length / 2; i++)
            //    tbPortWrite.Text += ByteIsInt16(t)[i].ToString() + "\t";

            //tbPortWrite.Text += Environment.NewLine;

            //for (int i = 0; i < t.Length / 4; i++)
            //    tbPortWrite.Text += ByteIsInt32(t)[i].ToString() + "\t";

            //tbPortRead_TextChanged(null, null);
        }

        private void cbChartScrollBar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbChartScrollBar.Checked)
            {
                chtData.ChartAreas[0].AxisX.ScaleView.Size = 10;           // 可见数据点数
                chtData.ChartAreas[0].AxisX.ScaleView.MinSize = 1;       // 步进
                chtData.ChartAreas[0].AxisX.Interval = 1;                       // 设置X轴间隔
                btnChartXBig.Enabled = true;
                btnChartXSmall.Enabled = true;
            }
            else
            {
                chtData.ChartAreas[0].AxisX.ScaleView.Size = double.NaN;           // 可见数据点数
                chtData.ChartAreas[0].AxisX.ScaleView.MinSize = double.NaN;     // 步进
                chtData.ChartAreas[0].AxisX.Interval = 0;                                      // 设置X轴间隔
                btnChartXBig.Enabled = false;
                btnChartXSmall.Enabled = false;
            }
        }

        private void btnExcelWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application ExcelApplication;
                Microsoft.Office.Interop.Excel.Workbook ExcelWorkbook;
                Microsoft.Office.Interop.Excel.Worksheet ExcelWorksheet;
                int Column = 1;

                // create
                ExcelApplication = new Microsoft.Office.Interop.Excel.Application();
                ExcelApplication.Visible = true;    // open GUI
                ExcelWorkbook = ExcelApplication.Workbooks.Add();
                ExcelWorksheet = ExcelWorkbook.Worksheets.Add();
                ExcelWorksheet.Name = COM.PortName + "-Data";    // Sheet Name
                ExcelWorkbook.Worksheets["Sheet1"].Delete();
                // data
                if (cbExcelAllDataOutput.Checked)
                {
                    ExcelWorksheet.Cells[1, Column] = "AllDataPoint";
                    for (int i = 0; i < AllDataPoint.Count; i++)
                        ExcelWorksheet.Cells[i + 2, Column] = AllDataPoint[i];
                    Column++;
                }
                if (cbExcelChannelDataOutput.Checked)
                {
                    for (int i = 0; i < ChartChannelNameList.Count; i++)
                    {
                        ExcelWorksheet.Cells[1, Column] = ChartChannelNameList[i];
                        for (int j = 0; j < MultiChannelDataPoint[i].Count; j++)
                            ExcelWorksheet.Cells[j + 2, Column] = MultiChannelDataPoint[i][j];
                        Column++;
                    }
                }
                // save
                //ExcelWorkbook.SaveAs("D:\\Data2017");
                ExcelWorkbook.SaveAs(Application.StartupPath + "\\" + tbExcelFileName.Text);
                //ExcelWorkbook.SaveAs(saveFileDialog1.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void TSMIAbout_Click(object sender, EventArgs e)
        {
            // About
            About about = new About();
            about.ShowDialog();
        }

        private void btnChartXBig_Click(object sender, EventArgs e)
        {
            chtData.ChartAreas[0].AxisX.Interval /= 2;
            chtData.ChartAreas[0].AxisX.ScaleView.Size /= 2;           // 可见数据点数
            if (chtData.ChartAreas[0].AxisX.Interval <= 1)
                btnChartXBig.Enabled = false;

        }

        private void btnChartXSmall_Click(object sender, EventArgs e)
        {
            chtData.ChartAreas[0].AxisX.Interval *= 2;
            chtData.ChartAreas[0].AxisX.ScaleView.Size *= 2;           // 可见数据点数
            btnChartXBig.Enabled = true;
        }

        private void btnChartMaximized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            tcOutput.Dock = DockStyle.Fill;
        }

        private void btnChartNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            tcOutput.Dock = DockStyle.None;
        }

        private void chtData_DoubleClick(object sender, EventArgs e)        // 双击放大缩小
        {
            if (this.WindowState == FormWindowState.Maximized)   // IsMaximized ?
                btnChartNormal_Click(null, null);
            else
                btnChartMaximized_Click(null, null);
        }

        private void chtData_MouseMove(object sender, MouseEventArgs e)
        {
            // 指向Chart时获取焦点
            chtData.Focus();
        }

        public void chtData_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                chtData.ChartAreas[0].AxisX.ScaleView.Position -= 1;
            else
                chtData.ChartAreas[0].AxisX.ScaleView.Position += 1;
            if (chtData.ChartAreas[0].AxisX.ScaleView.Position >= chtData.ChartAreas[0].AxisX.Maximum - chtData.ChartAreas[0].AxisX.ScaleView.Size)
                chtData.ChartAreas[0].AxisX.ScaleView.Position = chtData.ChartAreas[0].AxisX.Maximum - chtData.ChartAreas[0].AxisX.ScaleView.Size;
            if (chtData.ChartAreas[0].AxisX.ScaleView.Position <= 1)
                chtData.ChartAreas[0].AxisX.ScaleView.Position = 1;
        }

        private void cbChartChannelEnable_CheckedChanged(object sender, EventArgs e)
        {
            chtData.Series[cbChartChannelNameList.SelectedIndex].Enabled = cbChartChannelEnable.Checked;
        }

        private void tbStartFrame_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar == '\b')
                 || ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                 || ((e.KeyChar >= 'A') && (e.KeyChar <= 'F'))
                 || ((e.KeyChar >= 'a') && (e.KeyChar <= 'f'))))
            {
                e.Handled = true;
            }
            if (tbStartFrame.Text.Length == 4 && e.KeyChar != '\b')
                e.Handled = true;
            if ((e.KeyChar >= 'a') && (e.KeyChar <= 'f'))
            {
                e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
            }
        }

        private void tbStopFrame_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar == '\b')
                 || ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                 || ((e.KeyChar >= 'A') && (e.KeyChar <= 'F'))
                 || ((e.KeyChar >= 'a') && (e.KeyChar <= 'f'))))
            {
                e.Handled = true;
            }
            if (tbStopFrame.Text.Length == 4 && e.KeyChar != '\b')
                e.Handled = true;
            if ((e.KeyChar >= 'a') && (e.KeyChar <= 'f'))
            {
                e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
            }
        }
    }
}