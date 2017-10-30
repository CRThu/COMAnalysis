using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMv2
{
    partial class MainForm
    {
        List<double> DataPoint = new List<double>();            // 数据集
        List<double> AllDataPoint = new List<double>();            // 总数据集
        List<List<double>> MultiChannelDataPoint = new List<List<double>>();      // 多通道数据集

        void DataClear()
        {
            DataPoint.Clear();
            MultiChannelDataPoint.Clear();
        }

        List<double> ByteIsString(byte[] ByteArray)
        {
            //return System.Text.Encoding.Default.GetString(ByteArray);
            List<double> DoubleArray = new List<double>();
            string[] DoubleStringArray = System.Text.Encoding.Default.GetString(ByteArray).Split(tbStringFilter.Text.ToCharArray());
            for (int i = 0; i < DoubleStringArray.Length; i++)
                if (DoubleStringArray[i] != "")
                    DoubleArray.Add(Convert.ToDouble(DoubleStringArray[i]));
            return DoubleArray;
        }

        List<double> ByteIsInt16(byte[] ByteArray)
        {
            //    Int16[] Int16Array = new Int16[ByteArray.Length / 2];
            //    if (ByteArray.Length % 2 == 0)
            //        for (int i = 0; i < ByteArray.Length; i += 2)
            //            Int16Array[i / 2] = BitConverter.ToInt16(ByteArray, i);
            //    return Int16Array;
            List<double> Int16Array = new List<double>();
            if (ByteArray.Length % 2 == 0)
                for (int i = 0; i < ByteArray.Length; i += 2)
                    Int16Array.Add(BitConverter.ToInt16(ByteArray, i));
            return Int16Array;
        }

        List<double> ByteIsInt32(byte[] ByteArray)
        {
            List<double> Int32Array = new List<double>();
            if (ByteArray.Length % 4 == 0)
                for (int i = 0; i < ByteArray.Length; i += 4)
                    Int32Array.Add(BitConverter.ToInt32(ByteArray, i));
            return Int32Array;
            //Int32[] Int32Array = new Int32[ByteArray.Length / 4];
            //if (ByteArray.Length % 4 == 0)
            //    for (int i = 0; i < ByteArray.Length; i += 4)
            //        Int32Array[i / 4] = BitConverter.ToInt32(ByteArray, i);
            //return Int32Array;
        }

        List<double> ByteIsFloat(byte[] ByteArray)
        {
            List<double> FloatArray = new List<double>();
            if (ByteArray.Length % 4 == 0)
                for (int i = 0; i < ByteArray.Length; i += 4)
                    FloatArray.Add(BitConverter.ToSingle(ByteArray, i));
            return FloatArray;
        }

        List<double> ByteIsDouble(byte[] ByteArray)
        {
            List<double> DoubleArray = new List<double>();
            if (ByteArray.Length % 8 == 0)
                for (int i = 0; i < ByteArray.Length; i += 8)
                    DoubleArray.Add(BitConverter.ToDouble(ByteArray, i));
            return DoubleArray;
        }

        // 选择解析器
        void ByteDecoder()
        {
            try
            {
                DataClear();

                if (!rbNoDecoder.Checked)       // 绘制图表分支
                {
                    if (rbByteIsString.Checked)
                        DataPoint = ByteIsString(COMdataNow);
                    if (rbByteIsNumber.Checked)
                    {
                        string NumSI = "";
                        chtData.Invoke(new Action(() =>
                        {
                            NumSI = (string)cbByteIsNumber.SelectedItem;
                        }));
                        switch (NumSI)
                        {
                            case "int16": DataPoint = ByteIsInt16(COMdataNow); break;
                            case "int32": DataPoint = ByteIsInt32(COMdataNow); break;
                            case "float": DataPoint = ByteIsFloat(COMdataNow); break;
                            case "double": DataPoint = ByteIsDouble(COMdataNow); break;
                        }
                    }
                    AllDataPoint.AddRange(DataPoint);
                    if(cbChartTotb.Checked)
                        DataToText();                     // 解释器
                    DataToMultiChannel();       // 单通道转多通道
                    ChartDraw();                      // 绘图
                }
                else
                {
                    if (rbNoDecoder.Checked)        // 不使用图表
                        chtData.Invoke(new Action(() =>
                        {
                            tbPortRead.Text += System.Text.Encoding.Default.GetString(COMdataNow);
                        }));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // 单通道转多通道
        void DataToMultiChannel()
        {
            for (int i = 0; i < ChartChannelNameList.Count; i++)
            {
                List<double> ci = new List<double>();
                for (int j = i; j < AllDataPoint.Count; j += ChartChannelNameList.Count)
                    ci.Add(AllDataPoint[j]);
                MultiChannelDataPoint.Add(ci);
            }
        }

        // 解释器
        void DataToText()
        {
            //for (int i = 0; i < DataPoint.Count; i++)
            //    chtData.Invoke(new Action(() =>
            //    {
            //        tbPortRead.Text += (DataPoint[i].ToString() + tbStringFilter.Text);
            //}));
            // Version 2.3.7.1
            //chtData.Invoke(new Action(() =>
            //{
            //    tbPortRead.Text = "";
            //    for (int i = 0; i < AllDataPoint.Count; i++)
            //        tbPortRead.Text += (AllDataPoint[i].ToString() + tbStringFilter.Text);
            //}));
            // Version 2.3.8.0
            chtData.Invoke(new Action(() =>
            {
                for (int i = 0; i < DataPoint.Count; i++)
                    tbPortRead.Text += (DataPoint[i].ToString() + tbStringFilter.Text);
            }));
        }
    }
}