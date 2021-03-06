﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace COMv2
{
    partial class MainForm
    {
        List<List<int>> MultiChannelChartViewX = new List<List<int>>();      // 多通道显示数据集
        List<List<double>> MultiChannelChartViewY = new List<List<double>>();      // 多通道显示数据集

        void Chartinit()
        {
            // Chart Clear Param
            chtData.Annotations.Clear();
            chtData.ChartAreas.Clear();
            chtData.Legends.Clear();
            chtData.Series.Clear();
            chtData.Titles.Clear();

            // Title
            Title chtDataTitle = new Title("波形显示");
            chtData.Titles.Add(chtDataTitle);
            // ChartArea
            ChartArea chtDataChartArea = new ChartArea("ChartArea");
            chtData.ChartAreas.Add(chtDataChartArea);

            chtData.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = false;   // 设置滚动条外部显示
            chtData.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
            chtData.ChartAreas[0].AxisX.Minimum = 1;

            // Series
            //Series chtDataSeries = new Series("chtDataSeries");
            // New Channel 1
            chtDataSeriesAdd.Add(new Series(ChartChannelNameList[0]));
            chtDataSeriesAdd[0].ChartType = SeriesChartType.Line;
            chtDataSeriesAdd[0].BorderWidth = 2;
            //chtDataSeriesAdd[0].IsValueShownAsLabel = cbChartShowValue.Checked;
            chtData.Series.Add(chtDataSeriesAdd[0]);
            //tbPortRead.Text = "9.234,6.111,2.222,8.888,4.886,9.234,4.111,4.333,7.78,9.092,5.234,6.111,4.333,8.888,2.092,9.234,3.09,4.333,5.8,9.092,4.234,6.111,4.333,8.888,1.092,9.234,5.32,4.333,1.8,7.02";
            // Legend
            Legend chtDataLegend = new Legend("chtDataLegend");
            chtData.Legends.Add(chtDataLegend);
        }

        void ChartDataClear()
        {
            MultiChannelChartViewX.Clear();
            MultiChannelChartViewY.Clear();
        }

        void ToViewData()
        {
            // 完整多通道数据集 MultiChannelDataPoint[]

            // 显示多通道数据集 MultiChannelChartViewX[i]
            //                              MultiChannelChartViewY[i]

            // 滚动条 chtData.ChartAreas[].AxisX.ScaleView.ViewMinimum
            //            chtData.ChartAreas[].AxisX.ScaleView.ViewMaximum

            // 数据量 chtData.ChartAreas[].AxisX.Minimum
            //            chtData.ChartAreas[].AxisX.Maximum

            // 控件尺寸 chtData.Size.Height
            //                chtData.Size.Width


            for (int i = 0; i < ChartChannelNameList.Count; i++)
            {
                MultiChannelChartViewX.Add(new List<int>());
                MultiChannelChartViewY.Add(new List<double>());

                //float ViewScaleX = (float)MultiChannelDataPoint[i].Count / chtData.Size.Width;         // 数据总量/控件分辨率
                float ViewScaleX = (float)(double.IsNaN(chtData.ChartAreas[0].AxisX.ScaleView.Size) ? MultiChannelDataPoint[i].Count : chtData.ChartAreas[0].AxisX.ScaleView.Size) / chtData.Size.Width;         // 数据总量/控件分辨率
                //TODO
                for (int j = 0; j < MultiChannelDataPoint[i].Count; j += ((int)ViewScaleX<1)?1:(int)ViewScaleX)
                {
                    MultiChannelChartViewX[i].Add(j);
                    MultiChannelChartViewY[i].Add(MultiChannelDataPoint[i][j]);
                }
            }

        }

        void ChartDraw()
        {
            try
            {
                if (testForLarge.Checked)
                    chtData.Invoke(new Action(() =>
                {
                    for (int i = 0; i < ChartChannelNameList.Count; i++)
                        chtData.Series[ChartChannelNameList[i]].Points.DataBindXY(MultiChannelChartViewX[i], MultiChannelChartViewY[i]);
                    if (chkAutoChartScroll.Checked)
                        chtData.ChartAreas[0].AxisX.ScaleView.Scroll(ScrollType.Last); //水平滚动条始终居于最右边
                }));
                else
                    // 2.4.9.0
                    chtData.Invoke(new Action(() =>
                    {
                        for (int i = 0; i < ChartChannelNameList.Count; i++)
                            chtData.Series[ChartChannelNameList[i]].Points.DataBindY(MultiChannelDataPoint[i]);
                        if (chkAutoChartScroll.Checked)
                            chtData.ChartAreas[0].AxisX.ScaleView.Scroll(ScrollType.Last); //水平滚动条始终居于最右边
                    }));

                // old
                //chtData.Invoke(new Action(() =>
                //{
                //    chtData.Series[ChartChannelNameList[0]].Points.DataBindY(DataPoint);
                //}));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void ChartUpdate()
        {
            DataClear();
            DataToMultiChannel();       // 单通道转多通道
            ChartDataClear();               // 清空绘图点
            if (testForLarge.Checked)
                ToViewData();                    // 计算绘图点
            ChartDraw();                      // 绘图
        }
    }
}