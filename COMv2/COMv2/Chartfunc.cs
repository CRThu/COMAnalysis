using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace COMv2
{
    partial class MainForm
    {
        void Chartinit()
        {
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

            chtData.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = false;   // 设置滚动条外部显示
            chtData.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
            chtData.ChartAreas[0].AxisX.Minimum = 1;

            // Series
            //Series chtDataSeries = new Series("chtDataSeries");
            // New Channel 1
            chtDataSeriesAdd.Add(new Series(ChartChannelNameList[0]));
            chtDataSeriesAdd[0].ChartType = SeriesChartType.Line;
            //chtDataSeriesAdd[0].IsValueShownAsLabel = cbChartShowValue.Checked;
            chtData.Series.Add(chtDataSeriesAdd[0]);
            //tbPortRead.Text = "9.234,6.111,2.222,8.888,4.886,9.234,4.111,4.333,7.78,9.092,5.234,6.111,4.333,8.888,2.092,9.234,3.09,4.333,5.8,9.092,4.234,6.111,4.333,8.888,1.092,9.234,5.32,4.333,1.8,7.02";
            // Legend
            Legend chtDataLegend = new Legend("chtDataLegend");
            chtData.Legends.Add(chtDataLegend);
        }

        void ChartDraw()
        {
            chtData.Invoke(new Action(() =>
            {
                for (int i = 0; i < ChartChannelNameList.Count; i++)
                    chtData.Series[ChartChannelNameList[i]].Points.DataBindY(MultiChannelDataPoint[i]);
            }));
            //chtData.Invoke(new Action(() =>
            //{
            //    chtData.Series[ChartChannelNameList[0]].Points.DataBindY(DataPoint);
            //}));
        }
    }
}