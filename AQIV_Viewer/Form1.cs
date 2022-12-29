using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AQIV_Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string Directory = "C:\\Users\\proje\\source\\repos\\Arduino_Quake_Intensity_Viewer\\Arduino_Quake_Intensity_Viewer\\bin\\x64\\Debug\\Logs";

        private void View_Click(object sender, EventArgs e)
        {
            try
            {
                Chart.Series.Clear();
                Chart.ChartAreas.Clear();
                Chart.ChartAreas.Add(new ChartArea("Main"));
                string Name1 = "加速度x";
                string Name2 = "加速度y";
                string Name3 = "加速度z";
                string Name4 = "合成加速度";
                Chart.Series.Add("加速度x");
                Chart.Series.Add("加速度y");
                Chart.Series.Add("加速度z");
                Chart.Series.Add("合成加速度");
                Chart.Series[Name1].ChartType = SeriesChartType.Line;
                Chart.Series[Name2].ChartType = SeriesChartType.Line;
                Chart.Series[Name3].ChartType = SeriesChartType.Line;
                Chart.Series[Name4].ChartType = SeriesChartType.Line;

                DateTime STime = Convert.ToDateTime(StartTime.Text);
                double MaxValue = 0;
                for (int i = 0; i < Convert.ToInt32(Times.Text); i++)
                {
                    try
                    {
                        DateTime GT = STime.AddSeconds(i);
                        string Value1 = File.ReadAllText($"{Directory}\\{GT.Year}\\{GT.Month}\\{GT.Day}\\{GT.Hour}\\{GT.Minute}\\{GT:yyyyMMddHHmmss}.txt").Replace("\n", ",");
                        string[] Value2 = Value1.Split(',');
                        for (int j = 0; j < Value2.Length / 4; j++)
                        {
                            Chart.Series[Name1].Points.AddY(Convert.ToDouble(Value2[j * 4]));
                            Chart.Series[Name2].Points.AddY(Convert.ToDouble(Value2[j * 4 + 1]));
                            Chart.Series[Name3].Points.AddY(Convert.ToDouble(Value2[j * 4 + 2]));
                            Chart.Series[Name4].Points.AddY(Convert.ToDouble(Value2[j * 4 + 3]));
                            if (MaxValue < Convert.ToDouble(Value2[j * 4 + 3]))
                                MaxValue = Convert.ToDouble(Value2[j * 4 + 3]);
                        }
                    }
                    catch
                    {

                    }
                }
                PGA.Text = $"Max:{MaxValue}gal";
                Message.Text = "";
            }
            catch (Exception ex)
            {
                Message.Text = ex.Message;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        private void NowTime_Click(object sender, EventArgs e)
        {
            StartTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        private void RealTimeCB_CheckedChanged(object sender, EventArgs e)
        {
            if (RealTimeCB.Checked)
            {
                RealTime.Interval = 100;
                RealTime.Enabled = true;
                View.Enabled = false;
            }
            else
            {
                RealTime.Enabled = false;
                View.Enabled = true;
            }
        }

        private void RealTime_Tick(object sender, EventArgs e)
        {
            try
            {
                RealTime.Interval = 1000;
                Chart.Series.Clear();
                Chart.ChartAreas.Clear();
                Chart.ChartAreas.Add(new ChartArea("Main"));
                string Name1 = "加速度x";
                string Name2 = "加速度y";
                string Name3 = "加速度z";
                string Name4 = "合成加速度";
                Chart.Series.Add("加速度x");
                Chart.Series.Add("加速度y");
                Chart.Series.Add("加速度z");
                Chart.Series.Add("合成加速度");
                Chart.Series[Name1].ChartType = SeriesChartType.Line;
                Chart.Series[Name2].ChartType = SeriesChartType.Line;
                Chart.Series[Name3].ChartType = SeriesChartType.Line;
                Chart.Series[Name4].ChartType = SeriesChartType.Line;
                double MaxValue = 0;
                DateTime GT = DateTime.Now.AddSeconds(-1);
                string Value1 = File.ReadAllText($"{Directory}\\{GT.Year}\\{GT.Month}\\{GT.Day}\\{GT.Hour}\\{GT.Minute}\\{GT:yyyyMMddHHmmss}.txt").Replace("\n", ",");
                string[] Value2 = Value1.Split(',');
                for (int j = 0; j < Value2.Length / 4; j++)
                {
                    Chart.Series[Name1].Points.AddY(Convert.ToDouble(Value2[j * 4]));
                    Chart.Series[Name2].Points.AddY(Convert.ToDouble(Value2[j * 4 + 1]));
                    Chart.Series[Name3].Points.AddY(Convert.ToDouble(Value2[j * 4 + 2]));
                    Chart.Series[Name4].Points.AddY(Convert.ToDouble(Value2[j * 4 + 3]));
                    if (MaxValue < Convert.ToDouble(Value2[j * 4 + 3]))
                        MaxValue = Convert.ToDouble(Value2[j * 4 + 3]);
                }
                PGA.Text = $"Max:{MaxValue}gal";
                StartTime.Text = GT.ToString("yyyy/MM/dd HH:mm:ss");
                Message.Text = "";
            }
            catch (Exception ex)
            {
                Message.Text = ex.Message;
            }
        }
    }
}

