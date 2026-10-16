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

namespace OrderManagerPro.Analyzing
{
    public partial class AnalyzingDashBoard : Form
    {
        DateTimePicker SendStartDate = new DateTimePicker();
        DateTimePicker SendEndDate = new DateTimePicker();
        public AnalyzingDashBoard(DateTimePicker CurrentStartDate, DateTimePicker CurrentEndDate)
        {
            InitializeComponent();
            SendStartDate = CurrentStartDate;
            SendEndDate = CurrentEndDate;
        }

        DataTable dt;
        private void AnalyzingDashBoard_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.OrderIcon;

            FromDateDateTimePicker.Value = SendStartDate.Value;
            EndDateDateTimePicker.Value = SendEndDate.Value;

            GetDataBaseDataToDataTable();




            LoadStatsMistakeMadeBy();

            MistakeMadeByChart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            MistakeMadeByChart.ChartAreas[0].AxisX.Interval = 1;

            LoadStatsMistakeMadeByType();
            MistakeMadeByTypeChart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            MistakeMadeByTypeChart.ChartAreas[0].AxisX.Interval = 1;



            LoadStatsTimeTracking();
            TimeTrackingChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            TimeTrackingChart.Titles.Add("Time Tracking (Hours)");
            TimeTrackingChart.ChartAreas[0].AxisY.Interval = 10;
            TimeTrackingChart.ChartAreas[0].AxisX.Interval = 1;
            TimeTrackingChart.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular);
            TimeTrackingChart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;


            CreateChartData();




            InquiryChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }

        #region Get DataBase Data To DataTable
        private void GetDataBaseDataToDataTable()
        {
            string StartDate = SendStartDate.Value.ToString("yyyy-MM-dd");
            string EndtDate = SendEndDate.Value.ToString("yyyy-MM-dd");

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
        }
        #endregion








        int InquiryCount = 0;
        //List<int> FoundInquiries = new List<int>();

        private void CreateChartData()
        {
            InquiryCount = dt.Rows.Count;









            InquiryChart.Titles.Add("Total Inquiries ( " + InquiryCount + " )");

        }









        private void LoadStatsMistakeMadeBy()
        {
            MistakeMadeByChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            List<string> FoundMistakemadeBy = new List<string>();
            List<int> FoundMistakes = new List<int>();

            foreach (DataRow row in dt.Rows)
            {
                if (row["MistakeMadeBy"].ToString().Trim() != string.Empty)
                {
                    if (!FoundMistakemadeBy.Contains(row["MistakeMadeBy"].ToString().Trim()))
                    {
                        FoundMistakemadeBy.Add(row["MistakeMadeBy"].ToString().Trim());
                        FoundMistakes.Add(0);
                    }
                }

                for (var i = 0; i < FoundMistakemadeBy.Count; i++)
                {
                    if (FoundMistakemadeBy[i].Equals(row["MistakeMadeBy"].ToString().Trim()))
                    {
                        FoundMistakes[i]++;
                    }
                }
            }

            for (var i = 0; i < FoundMistakemadeBy.Count; i++)
            {
                MistakeMadeByChart.Series["MistakeMadeBy"].Points.AddXY(FoundMistakemadeBy[i], FoundMistakes[i].ToString());
            }

            MistakeMadeByChart.Titles.Add("Mistakes Made By");
        }



        private void LoadStatsMistakeMadeByType()
        {

            MistakeMadeByTypeChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            List<string> FoundMistakemadeByType = new List<string>();

            List<int> FoundMistakeTypes = new List<int>();

            foreach (DataRow row in dt.Rows)
            {

                if (row["MistakeType"].ToString().Trim() != string.Empty)
                {
                    if (!FoundMistakemadeByType.Contains(row["MistakeType"].ToString().Trim()))
                    {
                        FoundMistakemadeByType.Add(row["MistakeType"].ToString().Trim());
                        FoundMistakeTypes.Add(0);

                    }

                }

                for (var i = 0; i < FoundMistakemadeByType.Count; i++)
                {
                    if (FoundMistakemadeByType[i].Equals(row["MistakeType"].ToString().Trim()))
                    {
                        FoundMistakeTypes[i]++;


                    }
                }
            }

            for (var i = 0; i < FoundMistakemadeByType.Count; i++)
            {
                MistakeMadeByTypeChart.Series["MistakeTypes"].Points.AddXY(FoundMistakemadeByType[i], FoundMistakeTypes[i].ToString());
            }

            MistakeMadeByTypeChart.Titles.Add("Mistakes By Type");
        }




        List<string> FoundDates = new List<string>();
        List<Int32> FoundInquiries = new List<Int32>();
        List<TimeSpan> FoundSolveTimes = new List<TimeSpan>();


        private void LoadStatsTimeTracking()
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
                TimeTrackingChart.Series["Average Solve Time"].Points.AddXY(FoundDates[i], decimal.Round(AverageSolveTime, 1));
            }
        }












        private void UpdateButton_Click(object sender, EventArgs e)
        {
            AnalyzingDashBoard AnalyzingDashBoardForm = new AnalyzingDashBoard(FromDateDateTimePicker, EndDateDateTimePicker);
            AnalyzingDashBoardForm.Show();
            this.Close();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            FromDateDateTimePicker.Value = DateTime.Now.AddDays(0);
            EndDateDateTimePicker.Value = DateTime.Now.AddDays(1);
            AnalyzingDashBoard AnalyzingDashBoardForm = new AnalyzingDashBoard(FromDateDateTimePicker, EndDateDateTimePicker);
            AnalyzingDashBoardForm.Show();
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            FromDateDateTimePicker.Value = FromDateDateTimePicker.Value.AddDays(-1);
            EndDateDateTimePicker.Value = EndDateDateTimePicker.Value.AddDays(-1);
            AnalyzingDashBoard AnalyzingDashBoardForm = new AnalyzingDashBoard(FromDateDateTimePicker, EndDateDateTimePicker);
            AnalyzingDashBoardForm.Show();
            this.Close();
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            FromDateDateTimePicker.Value = FromDateDateTimePicker.Value.AddDays(1);
            EndDateDateTimePicker.Value = EndDateDateTimePicker.Value.AddDays(1);
            AnalyzingDashBoard AnalyzingDashBoardForm = new AnalyzingDashBoard(FromDateDateTimePicker, EndDateDateTimePicker);
            AnalyzingDashBoardForm.Show();
            this.Close();
        }







    }
}
