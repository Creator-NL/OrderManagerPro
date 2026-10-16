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
    public partial class DB_ViewSeniorInquiries : Form
    {
        string SendUserName = "";
        string SendUserLanguage = "";
        public DB_ViewSeniorInquiries(string CurrentUserName , string CurrentUserLanguage)
        {
            InitializeComponent();
            SendUserName = CurrentUserName;
            SendUserLanguage = CurrentUserLanguage;
        }

        private void DB_ViewSeniorInquiries_Load(object sender, EventArgs e)
        {
            LoadGridView();

            SetGridViewHeaderStyle();
            SetGridviewRowColor();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {

        }

        #region LoadGridView
        private void LoadGridView()
        {
            string constring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\DataBase\DatabaseOrderManagerPro.mdf; Integrated Security = True; Connect Timeout = 30";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM OrderProblems WHERE ProblemState='" + "Active" + "' AND InquiryResult='" + "Senior Approval" + "'", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            //dt.Columns.Add("Inquiry", typeof(Button));
                            ImportedDataGridView.DataSource = dt;
                        }
                    }
                }
            }
            ImportedDataGridView.Columns["ID"].Visible = false;


            foreach (DataGridViewRow row in ImportedDataGridView.Rows)
            {
                ImportedDataGridView.Rows[row.Index].Cells[0].Value = row.Cells[1].Value;

            }

            ImportedDataGridView.Columns["InquiryColumn"].DisplayIndex = 13;





            //DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
            //bcol.HeaderText = "Inquiry";
            ////bcol.Text = "Click Me";
            //bcol.Name = "btnClickMe";
            //bcol.UseColumnTextForButtonValue = true;
            //ImportedDataGridView.Columns.Add(bcol);




            //CustomizeCellsInThirdColumn();

        }
        #endregion

        #region Set GridView Header Style
        private void SetGridViewHeaderStyle()
        {
            //ImportedDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromName("#663399");
            ImportedDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(171, 171, 171);
            ImportedDataGridView.EnableHeadersVisualStyles = false;


            //ImportedDataGridView.Rows[i].Cells[8].Style.BackColor = Color.LightGoldenrodYellow;


        }
        #endregion

        #region SetGridViewRowColor
        private void SetGridviewRowColor()
        {
            int SetLineCol = 1;
            for (int i = 0; i < ImportedDataGridView.Rows.Count; i++)
            {
                if (SetLineCol.Equals(i))
                {
                    ImportedDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Beige;
                    SetLineCol = SetLineCol + 2;
                }
            }
            //TotalRowsLabel.Visible = true;
            //TotalRowsLabel.Text = Convert.ToString(ImportedDataGridView.Rows.Count - 1) + " rows";
        }



        #endregion

        private void ImportedDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var RowId = Convert.ToInt64(ImportedDataGridView.Rows[e.RowIndex].Cells["InquiryColumn"].Value);
                //MessageBox.Show(RowId.ToString());


                DB_ViewActiveInquiry DB_ViewActiveInquiryForm = new DB_ViewActiveInquiry(RowId , SendUserName, SendUserLanguage);
                DB_ViewActiveInquiryForm.Show();



            }
        }
    }
}
