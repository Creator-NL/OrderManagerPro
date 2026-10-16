using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagerPro
{
    public partial class TimeTracking : Form
    {
        public TimeTracking()
        {
            InitializeComponent();
        }


        DataTable dt;
        private void TimeTracking_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.OrderIcon;
            string StartDate = DateTime.Now.AddDays(-14).ToString("yyyy-MM-dd");
            string EndtDate = DateTime.Now.ToString("yyyy-MM-dd");


            string constring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\DataBase\DatabaseOrderManagerPro.mdf; Integrated Security = True; Connect Timeout = 30";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM OrderProblems WHERE DateAndTimeCreated between '" + StartDate + "' and '" + EndtDate + "';", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (dt = new DataTable())
                        {
                            sda.Fill(dt);
                        }
                    }
                }
            }


            MainWindowChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            MainWindowChart.Titles.Add("Time Tracking (Hours)");
            MainWindowChart.ChartAreas[0].AxisY.Interval = 10;
            MainWindowChart.ChartAreas[0].AxisX.Interval = 1;
            MainWindowChart.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular);
            MainWindowChart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

            LoadStats();
        }














        List<string> FoundDates = new List<string>();
        List<Int32> FoundInquiries = new List<Int32>();
        List<TimeSpan> FoundSolveTimes = new List<TimeSpan>();


        private void LoadStats()
        {
            #region Get Dates and create Linked Lists
            foreach (DataRow row in dt.Rows)
            {
                string FoundDate = row["DateAndtimeCreated"].ToString().Trim();
                string[] FoundDateArry = FoundDate.Split(' ');

                if (!FoundDates.Contains(FoundDateArry[0]))
                {
                    FoundDates.Add(FoundDateArry[0]);
                    FoundSolveTimes.Add(new TimeSpan(0, 0, 0));
                    FoundInquiries.Add(0);
                }
            }
            #endregion






            foreach (DataRow row in dt.Rows)
            {
                if (row["DateAndtimeCreated"].ToString() != string.Empty && row["DateAndtimeReady"].ToString() != string.Empty)
                {
                    string FixDate = row["DateAndtimeCreated"].ToString().Trim();
                    string[] FixDateArry = FixDate.Split(' ');
                    int DateIndex = FoundDates.IndexOf(FixDateArry[0]);

                    FoundInquiries[DateIndex]++;





                    DateTime DTStart = Convert.ToDateTime(row["DateAndtimeCreated"]);
                    DateTime DTEnd = Convert.ToDateTime(row["DateAndtimeReady"]);
                    TimeSpan timeSpan = new TimeSpan();

                    timeSpan = DTEnd.Subtract(DTStart);

                    int TimeDays = timeSpan.Days;
                    int TimeHours = timeSpan.Hours;
                    int TimeMinutes = timeSpan.Minutes;
                    int TimeTotal1 = TimeDays * 24 * 60 + TimeHours * 60 + TimeMinutes;



                    int ListTimeDays = FoundSolveTimes[DateIndex].Days;
                    int ListTimeHours = FoundSolveTimes[DateIndex].Hours;
                    int ListtimeMinutes = FoundSolveTimes[DateIndex].Minutes;
                    int TimeTotal2 = ListTimeDays * 24 * 60 + ListTimeHours * 60 + ListtimeMinutes;
                    //int time2 = FoundSolveTimes[DateIndex].Minutes;
                    //TimeSpan TimespanTotal = new TimeSpan(0, time1 + time2, 0);


                    TimeSpan TimespanTotal = new TimeSpan(0, TimeTotal1 + TimeTotal2, 0);

                    FoundSolveTimes[DateIndex] = TimespanTotal;
                }







            }









            for (var i = 0; i < FoundDates.Count; i++)
            {
                int ListTimeDays = FoundSolveTimes[i].Days;
                int ListTimeHours = FoundSolveTimes[i].Hours;
                int ListtimeMinutes = FoundSolveTimes[i].Minutes;

                decimal total = ListTimeDays * 24 * 60 + ListTimeHours * 60 + ListtimeMinutes;
                decimal AverageSolveTime = (total / 60) / FoundInquiries[i];
                
                //double AverageSolveTimeD = total / 60 / FoundInquiries[i];
                //float valueF = (total / 60) / FoundInquiries[i];
                //valueF = (float)System.Math.Round(valueF, 2);         // value = 92.2;
                //string test = FoundSolveTimes[i].ToString().Trim();
                //string[] testArr = test.Split(':');
                //test = testArr[0].ToString();
                MainWindowChart.Series["Average Solve Time"].Points.AddXY(FoundDates[i], decimal.Round(AverageSolveTime , 1));
            }
        }











    }
}
