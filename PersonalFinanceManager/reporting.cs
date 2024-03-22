using LiveCharts;
using LiveCharts.Definitions.Series;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Forms;
using CartesianChart = LiveCharts.WinForms.CartesianChart;
using MessageBox = System.Windows.MessageBox;

namespace PersonalFinanceManager
{
    internal class reporting
    {
        public static DataTable dataTable { get; set; }
        private static CartesianChart chart;
        private static string title;

        private static void SetChartFrame(CartesianChart chart,Panel pnl)
        {
            chart.Width = pnl.Width - 50;
            chart.Height = pnl.Height - 50;
            int chartX = (pnl.Width - chart.Width) / 2;
            int chartY = (pnl.Height - chart.Height) / 2;
            chart.Location = new System.Drawing.Point(chartX, chartY);
            chart.Background = System.Windows.Media.Brushes.White;
            chart.LegendLocation = LiveCharts.LegendLocation.Bottom;
            pnl.Controls.Add(chart);
        }

        public static void GetLineChart(Panel pnl)
        {
            pnl.Controls.Clear();
            dataTable = DB.GetDataTable();
            chart = new CartesianChart();
            foreach(DataRow row in dataTable.Rows)
            {
                title = row[1].ToString();
            }
            LineSeries series = new LineSeries
            {
                Title = title,
                Values = new ChartValues<int>()
            };
            foreach(DataRow row in dataTable.Rows)
            {
                series.Values.Add(row[2]);
            }
            chart.Series = new SeriesCollection { series };
            chart.AxisX.Clear();
            List<string> labels = new List<string>();
            foreach(DataRow row in dataTable.Rows)
            {
                labels.Add(row[0].ToString());
            }
            chart.AxisX.Add(new LiveCharts.Wpf.Axis { Title = dataTable.Columns[0].ColumnName,Labels = labels });
            chart.AxisY.Add(new LiveCharts.Wpf.Axis { Title = dataTable.Columns[2].ColumnName,LabelsRotation = -45 });

            SetChartFrame(chart, pnl);
        }

        public static void GetStackBarChart(Panel pnl)
        {
            pnl.Controls.Clear();
            dataTable = DB.GetDataTable();
            chart = new CartesianChart();

            SeriesCollection seriesCollection = new SeriesCollection();
            string xAxisTitle = null;
            string yAxisTitle = null;

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow row = dataTable.Rows[i];
                    StackedColumnSeries budgetSeries = new StackedColumnSeries()
                    {
                        Title = $"{row[1]} {row[0]} Budget",
                        Values = new ChartValues<decimal> { decimal.Parse(row[2].ToString()) }
                    };
                    StackedColumnSeries expenseSeries = new StackedColumnSeries()
                    {
                        Title = $"{row[1]} {row[0]} Expense",
                        Values = new ChartValues<decimal> { decimal.Parse(row[3].ToString()) }
                    };

                    seriesCollection.Add(budgetSeries);
                    seriesCollection.Add(expenseSeries);

                    if (i == 0)
                    {
                        xAxisTitle = dataTable.Columns[1].ColumnName;
                        yAxisTitle = dataTable.Columns[2].ColumnName;
                    }
                }

                chart.Series = seriesCollection;

                List<string> labels = new List<string>();
                foreach (DataRow row in dataTable.Rows)
                {
                    labels.Add($"{row[1]} {row[0]}");
                }
                chart.AxisX.Add(new LiveCharts.Wpf.Axis { Title = xAxisTitle, Labels = labels });

                chart.AxisY.Add(new LiveCharts.Wpf.Axis { Title = yAxisTitle });

                SetChartFrame(chart, pnl);
            }
            else
            {
                MessageBox.Show("No data available.");
                return;
            }
        }

        public static void GetBarChart(Panel pnl)
        {
            pnl.Controls.Clear();
            dataTable = DB.GetDataTable();
            chart = new CartesianChart();

            SeriesCollection seriesCollection = new SeriesCollection();
            foreach (DataRow row in dataTable.Rows)
            {
                var series = new ColumnSeries
                {
                    Title = $"{row[1]} {row[0]}",
                    Values = new ChartValues<decimal> { decimal.Parse(row[3].ToString()) }
                };
                seriesCollection.Add(series);
            }
            chart.Series = seriesCollection;

            List<string> labels = new List<string>();
            List<string> labels1 = new List<string>();
            foreach (DataRow row in dataTable.Rows)
            {
                labels.Add($"{row[1]} {row[0]}");
                labels1.Add($"{row[2]}");
                
            }

            chart.AxisX.Add(new LiveCharts.Wpf.Axis { Title = dataTable.Columns[1].ColumnName,Labels = labels});

            chart.AxisY.Add(new LiveCharts.Wpf.Axis { Title = dataTable.Columns[2].ColumnName,LabelsRotation = -45 });
            SetChartFrame(chart, pnl);
        }

        public static void GetBarChartMonth(Panel pnl)
        {
            pnl.Controls.Clear();
            dataTable = DB.GetDataTable();
            chart = new CartesianChart();

            SeriesCollection seriesCollection = new SeriesCollection();
            foreach (DataRow row in dataTable.Rows)
            {
                var series = new ColumnSeries
                {
                    Title = $"{row[0]}",
                    Values = new ChartValues<decimal> { decimal.Parse(row[2].ToString()) }
                };
                seriesCollection.Add(series);
            }
            
            
            chart.Series = seriesCollection;

            List<string> labels = new List<string>();
            foreach (DataRow row in dataTable.Rows)
            {
                labels.Add($"{row[0]}");

            }

            chart.AxisX.Add(new LiveCharts.Wpf.Axis { Title = dataTable.Columns[0].ColumnName, Labels = labels });

            chart.AxisY.Add(new LiveCharts.Wpf.Axis { Title = dataTable.Columns[1].ColumnName, LabelsRotation = -45 });
            SetChartFrame(chart, pnl);
        }
    }
}
