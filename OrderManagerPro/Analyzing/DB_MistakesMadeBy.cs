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
using System.Windows.Forms.DataVisualization.Charting;

namespace OrderManagerPro
{
    public partial class DB_MistakesMadeBy : Form
    {
        DateTimePicker SendStartDate = new DateTimePicker();
        DateTimePicker SendEndDate = new DateTimePicker();
        public DB_MistakesMadeBy(DateTimePicker CurrentStartDate , DateTimePicker CurrentEndDate)
        {
            InitializeComponent();

            SendStartDate = CurrentStartDate;
            SendEndDate = CurrentEndDate;
        }

        DataTable dt;
        private void DB_MistakesMadeBy_Load(object sender, EventArgs e)
        {

            this.Icon = Properties.Resources.OrderIcon;

            FromDateDateTimePicker.Value = SendStartDate.Value;
            EndDateDateTimePicker.Value = SendEndDate.Value;

            string StartDate = SendStartDate.Value.ToString("yyyy-MM-dd");
            string EndtDate = SendEndDate.Value.ToString("yyyy-MM-dd");


            //string StartDate = FromDateDateTimePicker.Value.ToString("yyyy-MM-dd");
            //string EndtDate = TillDateDateTimePicker.Value.ToString("yyyy-MM-dd");
            //string StartDate = DateTime.Now.AddDays(-14).ToString("yyyy-MM-dd");
            //string EndtDate = DateTime.Now.ToString("yyyy-MM-dd");


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
            LoadStats();

            MainWindowChart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            MainWindowChart.ChartAreas[0].AxisX.Interval = 1;



        }


 
        private void LoadStats()
        {


            //var items = new Series
            //{
            //    Name = "Inquiries",
            //};
            //MainWindowChart.Series.Add(items);
            //var items2 = new Series
            //{
            //    Name = "Solved",
            //};
            //MainWindowChart.Series.Add(items2);
            //var items3 = new Series
            //{
            //    Name = "Not Solved",
            //};
            //MainWindowChart.Series.Add(items3);


            MainWindowChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //MainWindowChart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //MainWindowChart.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;



            List<string> FoundMistakemadeBy = new List<string>();


            List<int> FoundMistakes = new List<int>();

            //List<int> FoundSolved = new List<int>();
            //List<int> FoundNotSolved = new List<int>();

            foreach (DataRow row in dt.Rows)
            {

                if(row["MistakeMadeBy"].ToString().Trim() != string.Empty)
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
                MainWindowChart.Series["MistakeMadeBy"].Points.AddXY(FoundMistakemadeBy[i], FoundMistakes[i].ToString());
            }





            //AddXY value in chart1 in series named as Salary  
            //MainWindowChart.Series["MistakeMadeBy"].Points.AddXY(FoundMistakemadeBy[0], FoundMistakes[0].ToString());
            //MainWindowChart.Series["MistakeMadeBy"].Points.AddXY(FoundMistakemadeBy[1], FoundMistakes[1].ToString());
            //MainWindowChart.Series["MistakeMadeBy"].Points.AddXY(FoundMistakemadeBy[2], FoundMistakes[2].ToString());
            //MainWindowChart.Series["MistakeMadeBy"].Points.AddXY(FoundMistakemadeBy[3], FoundMistakes[3].ToString());
            //MainWindowChart.Series["MistakeMadeBy"].Points.AddXY(FoundMistakemadeBy[4], FoundMistakes[4].ToString());
            //MainWindowChart.Series["MistakeMadeBy"].Points.AddXY(FoundMistakemadeBy[5], FoundMistakes[5].ToString());
            //MainWindowChart.Series["MistakeMadeBy"].Points.AddXY(FoundMistakemadeBy[6], FoundMistakes[6].ToString());

            //MainWindowChart.Series["Found"].Points.AddXY(FoundDates[0], FoundSolved[0].ToString());
            //MainWindowChart.Series["Found"].Points.AddXY(FoundDates[1], FoundSolved[1].ToString());
            //MainWindowChart.Series["Found"].Points.AddXY(FoundDates[2], FoundSolved[2].ToString());
            //MainWindowChart.Series["Found"].Points.AddXY(FoundDates[3], FoundSolved[3].ToString());
            //MainWindowChart.Series["Found"].Points.AddXY(FoundDates[4], FoundSolved[4].ToString());
            //MainWindowChart.Series["Found"].Points.AddXY(FoundDates[5], FoundSolved[5].ToString());
            //MainWindowChart.Series["Found"].Points.AddXY(FoundDates[6], FoundSolved[6].ToString());

            //MainWindowChart.Series["Not Found"].Points.AddXY(FoundDates[0], FoundNotSolved[0].ToString());
            //MainWindowChart.Series["Not Found"].Points.AddXY(FoundDates[1], FoundNotSolved[1].ToString());
            //MainWindowChart.Series["Not Found"].Points.AddXY(FoundDates[2], FoundNotSolved[2].ToString());
            //MainWindowChart.Series["Not Found"].Points.AddXY(FoundDates[3], FoundNotSolved[3].ToString());
            //MainWindowChart.Series["Not Found"].Points.AddXY(FoundDates[4], FoundNotSolved[4].ToString());
            //MainWindowChart.Series["Not Found"].Points.AddXY(FoundDates[5], FoundNotSolved[5].ToString());
            //MainWindowChart.Series["Not Found"].Points.AddXY(FoundDates[6], FoundNotSolved[6].ToString());
            //chart title  
            MainWindowChart.Titles.Add("Mistakes Made By");




        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            DB_MistakesMadeBy DB_MistakesMadeByForm = new DB_MistakesMadeBy(FromDateDateTimePicker, EndDateDateTimePicker);
            DB_MistakesMadeByForm.Show();
            this.Close();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            FromDateDateTimePicker.Value = DateTime.Now.AddDays(0);
            EndDateDateTimePicker.Value = DateTime.Now.AddDays(1);
            DB_MistakesMadeBy DB_MistakesMadeByForm = new DB_MistakesMadeBy(FromDateDateTimePicker, EndDateDateTimePicker);
            DB_MistakesMadeByForm.Show();
            this.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            FromDateDateTimePicker.Value = FromDateDateTimePicker.Value.AddDays(-1);
            EndDateDateTimePicker.Value = EndDateDateTimePicker.Value.AddDays(-1);
            DB_MistakesMadeBy DB_MistakesMadeByForm = new DB_MistakesMadeBy(FromDateDateTimePicker, EndDateDateTimePicker);
            DB_MistakesMadeByForm.Show();
            this.Close();
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            FromDateDateTimePicker.Value = FromDateDateTimePicker.Value.AddDays(1);
            EndDateDateTimePicker.Value = EndDateDateTimePicker.Value.AddDays(1);
            DB_MistakesMadeBy DB_MistakesMadeByForm = new DB_MistakesMadeBy(FromDateDateTimePicker, EndDateDateTimePicker);
            DB_MistakesMadeByForm.Show();
            this.Close();
        }
    }
}
