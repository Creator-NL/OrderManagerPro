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
    public partial class DB_MistakesByType : Form
    {
        public DB_MistakesByType()
        {
            InitializeComponent();
        }

        DataTable dt;
        private void DB_MistakesByType_Load(object sender, EventArgs e)
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



            LoadStats();

            MainWindowChart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            MainWindowChart.ChartAreas[0].AxisX.Interval = 1;
        }


        private void LoadStats()
        {

            MainWindowChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

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
                MainWindowChart.Series["MistakeTypes"].Points.AddXY(FoundMistakemadeByType[i], FoundMistakeTypes[i].ToString());
            }
 
            MainWindowChart.Titles.Add("Mistakes By Type");
        }















    }
}
