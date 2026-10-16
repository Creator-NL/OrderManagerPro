using OrderManagerPro.Analyzing;
using OrderManagerPro.Properties;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace OrderManagerPro
{
    public partial class MainWindow : Form
    {
        string SendUserName = string.Empty;
        string SendGroup = string.Empty;
        string SendUserLanguage = string.Empty;
        public MainWindow(string CurrentUserName , string CurrentUserGroup , string CurrentUserLanguage)
        {
            InitializeComponent();
            SendUserName = CurrentUserName;
            SendGroup = CurrentUserGroup;
            SendUserLanguage = CurrentUserLanguage;
        }

        ToolTip toolTip1 = new ToolTip();
        DataTable dt;
        #region Main Window Load
        private void MainWindow_Load(object sender, EventArgs e)
        {





            this.Icon = Properties.Resources.OrderIcon;
            string StartDate = DateTime.Now.AddDays(-14).ToString("yyyy-MM-dd");
            //string EndtDate = DateTime.Now.ToString("yyyy-MM-dd");


            //string Test = Properties.Resources.DataBaseConnectionString;
            //string constring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\DataBase\DatabaseOrderManagerPro.mdf; Integrated Security = True; Connect Timeout = 30";
            string constring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + Settings.Default.DataBaseLocationString + "; Integrated Security = True; Connect Timeout = 30";
            using (SqlConnection con = new SqlConnection(constring))
            {
                //using (SqlCommand cmd = new SqlCommand("SELECT * FROM OrderProblems WHERE DateAndTimeCreated between '" + "2023-05-01" + "' and '" + "2023-05-31" + "';", con))
                //using (SqlCommand cmd = new SqlCommand("SELECT * FROM OrderProblems WHERE DateAndTimeCreated between '" + StartDate + "' and '" + EndtDate + "'", con))
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM OrderProblems WHERE DateAndTimeCreated > '" + StartDate + "'", con))
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
            MainWindowChart.ChartAreas[0].AxisY.Interval = 10;
            //MainWindowChart.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            MainWindowChart.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular);



            GreetingsLabel.Text = "User " + SendUserName;

            SetLanguage();
            SetToolTips();
            SetItemVisibility();
        }
        #endregion


        #region Language
        private void SetLanguage()
        {

            if (SendUserLanguage == "English")
            {
                LanguageComboBox.SelectedText = "EN";
            }
            else if (SendUserLanguage == "Nederlands")
            {
                LanguageComboBox.SelectedText = "NL";
            }
            else if (SendUserLanguage == "Deutsch")
            {
                LanguageComboBox.SelectedText = "DE";
            }

            ApplyLanguage();
        }
        private void ApplyLanguage()
        {
            if (LanguageComboBox.Text.Equals("EN"))
            {
                MainWindowChart.Series[0].Name = "Inquiries";
                MainWindowChart.Series[1].Name = "Found";
                MainWindowChart.Series[2].Name = "Not Found";




                SendUserLanguage = "English";
                RefreshButton.Text = "Referesh";
                SettingsDropDownButton.Text = "Settings";
                AnalyzingDropDownButton.Text = "Analyzing";
                UsersButton.Text = "Users";
                DataBaseButton.Text = "DataBase";
                MistakesMadeByButton.Text = "Mistakes Made By";
                MistakesByTypeButton.Text = "Mistakes By Type";

                InboundAddNewInquiryButton.Text = "Add New Inquiry";
                InboundSearchInquiryButton.Text = "Search Inquiry";
                SearchInquiryButton.Text = "Search Inquiry";
                ViewReadyInquiriesButton.Text = "View Ready Inquiries";
                ViewFinishedInquiriesButton.Text = "View Finished Inquiries";

                StockControlViewActiveInquiriesButton.Text = "View Active inquiries";
                StockControlViewSeniorInquiriesButton.Text = "View Senior Inquiries";
                StockControlViewFinishedInquiriesButton.Text = "View Finished Inquiries";


                MainWindowChart.Titles.Clear();
                MainWindowChart.Titles.Add("Inquiry Statistics");
            }
            else if (LanguageComboBox.Text.Equals("NL"))
            {


                //MainWindowChart.Series.Add("Aanvragen");
                MainWindowChart.Series[0].Name = "Aanvragen";
                MainWindowChart.Series[1].Name = "Gevonden";
                MainWindowChart.Series[2].Name = "Niet Gevonden";

                SendUserLanguage = "Nederlands";
                RefreshButton.Text = "Vernieuwen";
                SettingsDropDownButton.Text = "Instellingen";
                AnalyzingDropDownButton.Text = "Analyseren";
                UsersButton.Text = "Gebruikers";
                DataBaseButton.Text = "DataBase";
                MistakesMadeByButton.Text = "Fout gemaakt door";
                MistakesByTypeButton.Text = "Fout soort";

                InboundAddNewInquiryButton.Text = "Nieuwe aanvraag toevoegen";
                InboundSearchInquiryButton.Text = "Aanvraag zoeken";
                SearchInquiryButton.Text = "Aanvraag zoeken";
                ViewReadyInquiriesButton.Text = "Bekijk complete aanvragen";
                ViewFinishedInquiriesButton.Text = "Bekijk afgeronde aanvragen";


                StockControlViewActiveInquiriesButton.Text = "Bekijk actieve aanvragen";
                StockControlViewSeniorInquiriesButton.Text = "Bekijk Senior aanvragen";
                StockControlViewFinishedInquiriesButton.Text = "Bekijk afgeronde aanvragen";




                MainWindowChart.Titles.Clear();
                MainWindowChart.Titles.Add("Aanvraag Statistieken");

            }
            else if (LanguageComboBox.Text.Equals("DE"))
            {
                MainWindowChart.Series[0].Name = "Anfragen";
                MainWindowChart.Series[1].Name = "Gefunden";
                MainWindowChart.Series[2].Name = "Nicht gefunden";


                SendUserLanguage = "Deutsch";
                RefreshButton.Text = "Aktualisier";
                SettingsDropDownButton.Text = "Einstellungen";
                AnalyzingDropDownButton.Text = "Analysieren";
                UsersButton.Text = "Benutzer";
                DataBaseButton.Text = "Datenbank";
                MistakesMadeByButton.Text = "Fehler gemacht von";
                MistakesByTypeButton.Text = "Fehler nach Typ";

                InboundAddNewInquiryButton.Text = "Neue Anfrage hinzufügen";
                InboundSearchInquiryButton.Text = "Suchanfrage";
                SearchInquiryButton.Text = "Suchanfrage";
                ViewReadyInquiriesButton.Text = "Vollständige Anfragen anzeigen";
                ViewFinishedInquiriesButton.Text = "Abgeschlossene Anfragen anzeigen";


                StockControlViewActiveInquiriesButton.Text = "Aktive Anfragen anzeigen";
                StockControlViewSeniorInquiriesButton.Text = "Senior Anfragen anzeigen";
                StockControlViewFinishedInquiriesButton.Text = "Abgeschlossene Anfragen anzeigen";




                MainWindowChart.Titles.Clear();
                MainWindowChart.Titles.Add("Anfragestatistik");
            }
        }

        private void LanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyLanguage();
        }
        #endregion









        private void SetToolTips()
        {
            toolTip1.SetToolTip(LanguageComboBox, "Language setting for this session");
        }

        private void SetItemVisibility()
        {
            if (SendGroup == "Inbound")
            {
                StockControlDropDownButton.Visible = false;
                AnalyzingDropDownButton.Visible = false;
                SettingsDropDownButton.Visible = false;
            }
            if (SendGroup == "Stock Control")
            {
                InboundDropDownButton.Visible = false;
                AnalyzingDropDownButton.Visible = false;
                SettingsDropDownButton.Visible = false;
            }
            if (SendGroup == "Admin")
            {
                //SettingsDropDownButton.Visible = false;
            }
        }


        #region Load Stats
        private void LoadStats()
        {



            MainWindowChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            MainWindowChart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            MainWindowChart.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;



            List<string> FoundDates = new List<string>();
            List<int> FoundInquiries = new List<int>();

            List<int> FoundSolved = new List<int>();
            List<int> FoundNotSolved = new List<int>();

            List<int> FoundOpenInquiries = new List<int>();

            foreach (DataRow row in dt.Rows) 
            {
                string FoundDate = row["DateAndtimeCreated"].ToString().Trim();
                string[] FoundDateArry = FoundDate.Split(' ');




                if (!FoundDates.Contains(FoundDateArry[0]))
                {
                    FoundDates.Add(FoundDateArry[0]);
                    FoundInquiries.Add(0);
                    FoundSolved.Add(0);
                    FoundNotSolved.Add(0);
                    FoundOpenInquiries.Add(0);
                }





                for (var i = 0; i < FoundDates.Count; i++)
                {
                    if (FoundDates[i].Equals(FoundDateArry[0]))
                    {
                        FoundInquiries[i]++;

                        if (row["InquiryResult"].ToString().Trim().Equals("Found"))
                        {
                            FoundSolved[i]++;
                        }
                        else if (row["InquiryResult"].ToString().Trim().Equals("Not Found"))
                        {
                            FoundNotSolved[i]++;
                        }
                        else 
                        {
                            FoundOpenInquiries[i]++;
                        }
                    }
                    //Console.WriteLine("Amount is {0} and type is {1}", myMoney[i].amount, myMoney[i].type);
                }
            }
            
            for (var i = 0; i < FoundDates.Count; i++)
            {
                MainWindowChart.Series["Inquiries"].Points.AddXY(FoundDates[i], FoundInquiries[i].ToString());
                MainWindowChart.Series["Found"].Points.AddXY(FoundDates[i], FoundSolved[i].ToString());
                MainWindowChart.Series["Not Found"].Points.AddXY(FoundDates[i], FoundNotSolved[i].ToString());
            }

            MainWindowChart.Titles.Add("Inquiry Statistics");

            TotalInquiriesResultLabel.Text = Convert.ToString(FoundInquiries.Sum());
            TotalFoundResultLabel.Text = Convert.ToString(FoundSolved.Sum());
            TotalNotFoundResultLabel.Text = Convert.ToString(FoundNotSolved.Sum());
            decimal aaa = Convert.ToDecimal(FoundInquiries.Sum());
            decimal bbb = Convert.ToDecimal(FoundSolved.Sum());
            decimal ABResult = aaa > 0 ? (bbb / aaa * 100) : 0;
            TotalFoundProcentLabel.Text = ABResult.ToString("0.#") + "%";















            //AddXY value in chart1 in series named as Salary  
            //MainWindowChart.Series["Inquiries"].Points.AddXY(FoundDates[0], FoundInquiries[0].ToString());
            //MainWindowChart.Series["Inquiries"].Points.AddXY(FoundDates[1], FoundInquiries[1].ToString());
            //MainWindowChart.Series["Inquiries"].Points.AddXY(FoundDates[2], FoundInquiries[2].ToString());
            //MainWindowChart.Series["Inquiries"].Points.AddXY(FoundDates[3], FoundInquiries[3].ToString());
            //MainWindowChart.Series["Inquiries"].Points.AddXY(FoundDates[4], FoundInquiries[4].ToString());
            //MainWindowChart.Series["Inquiries"].Points.AddXY(FoundDates[5], FoundInquiries[5].ToString());
            //MainWindowChart.Series["Inquiries"].Points.AddXY(FoundDates[6], FoundInquiries[6].ToString());

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
        }
        #endregion




        //public DataTable GetData()
        //{
        //    // create a datatable
        //    DataTable dt = new DataTable("Inquiry Stats");

        //    // add columns to the datatable
        //    dt.Columns.Add("Beverages", typeof(string));
        //    dt.Columns.Add("Unit Price", typeof(int));
        //    dt.Columns.Add("Units In Stock", typeof(int));
        //    dt.Columns.Add("Units On Order", typeof(int));

        //    // add rows to the datatable
        //    dt.Rows.Add("Tea", 18, 39, 40);
        //    dt.Rows.Add("Coffee", 19, 17, 70);
        //    dt.Rows.Add("Cocktail", 10, 13, 30);
        //    dt.Rows.Add("Mock Tail", 22, 53, 20);
        //    dt.Rows.Add("Soft Drink", 21, 120, 70);
        //    dt.Rows.Add("Mineral Water", 25, 90, 40);

        //    return dt;
        //}


        #region Toolstrip Main
        private void DataBaseButton_Click(object sender, EventArgs e)
        {
            DB_DataBaseSettings DB_DataBaseSettingsForm = new DB_DataBaseSettings();
            DB_DataBaseSettingsForm.Show();
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            DB_Users DB_UsersForm = new DB_Users();
            DB_UsersForm.Show();
        }

        private void TimeTrackingButton_Click(object sender, EventArgs e)
        {
            TimeTracking TimeTrackingForm = new TimeTracking();
            TimeTrackingForm.Show();
        }



        #region Search Inquiry Buttons
        private void InboundSearchInquiryButton_Click(object sender, EventArgs e)
        {
            DB_SearchInquiries DB_SearchInquiriesForm = new DB_SearchInquiries(SendUserLanguage);
            DB_SearchInquiriesForm.Show();
        }
        private void SearchInquiryButton_Click(object sender, EventArgs e)
        {
            DB_SearchInquiries DB_SearchInquiriesForm = new DB_SearchInquiries(SendUserLanguage);
            DB_SearchInquiriesForm.Show();
        }
        #endregion


        private void RefreshButton_Click(object sender, EventArgs e)
        {
            MainWindow MainWindowForm = new MainWindow(SendUserName, SendGroup , SendUserLanguage);
            MainWindowForm.Show();
            this.Close();
        }


        #endregion

        #region Inbound
        private void InboundAddNewInquiryButton_Click(object sender, EventArgs e)
        {
            DB_AddNewInquiry DB_AddNewInquiryForm = new DB_AddNewInquiry(SendUserName,SendUserLanguage);
            DB_AddNewInquiryForm.Show();
        }

        private void ViewReadyInquiriesButton_Click(object sender, EventArgs e)
        {
            DB_ViewReadyInquiries DB_ViewReadyInquiriesForm = new DB_ViewReadyInquiries();
            DB_ViewReadyInquiriesForm.Show();
        }

        private void ViewFinishedInquiriesButton_Click(object sender, EventArgs e)
        {
            DB_ViewFinishedInquiries DB_ViewFinishedInquiriesForm = new DB_ViewFinishedInquiries();
            DB_ViewFinishedInquiriesForm.Show();
        }
        #endregion

        #region Stock Control
        private void StockControlViewActiveInquiriesButton_Click(object sender, EventArgs e)
        {
            DB_ViewActiveInquiries DB_ViewActiveInquiriesForm = new DB_ViewActiveInquiries(SendUserName, SendUserLanguage);
            DB_ViewActiveInquiriesForm.Show();
        }









        #endregion

        #region Administration

        private void MistakesMadeByButton_Click(object sender, EventArgs e)
        {
            DateTimePicker StartDate = new DateTimePicker();
            DateTimePicker EndDate = new DateTimePicker();
            StartDate.Value = DateTime.Now.AddDays(-14);
            EndDate.Value = DateTime.Now.AddDays(0);
            DB_MistakesMadeBy DB_MistakesMadeByForm = new DB_MistakesMadeBy(StartDate, EndDate);
            DB_MistakesMadeByForm.Show();

        }

        private void MistakesByTypeButton_Click(object sender, EventArgs e)
        {
            DB_MistakesByType DB_MistakesByTypeForm = new DB_MistakesByType();
            DB_MistakesByTypeForm.Show();
        }


        #endregion

        private void StockControlViewSeniorInquiriesButton_Click(object sender, EventArgs e)
        {
            DB_ViewSeniorInquiries DB_ViewSeniorInquiriesForm = new DB_ViewSeniorInquiries(SendUserName, SendUserLanguage);
            DB_ViewSeniorInquiriesForm.Show();
        }

        private void MainWindowChart_Click(object sender, EventArgs e)
        {

        }

        private void DashBoardButton_Click(object sender, EventArgs e)
        {
            DateTimePicker StartDate = new DateTimePicker();
            DateTimePicker EndDate = new DateTimePicker();
            StartDate.Value = DateTime.Now.AddDays(-14);
            EndDate.Value = DateTime.Now.AddDays(0);
            AnalyzingDashBoard AnalyzingDashBoardForm = new AnalyzingDashBoard(StartDate, EndDate);
            AnalyzingDashBoardForm.Show();
        }
    }
}
