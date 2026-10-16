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
    public partial class DB_ViewReadyInquiries : Form
    {
        public DB_ViewReadyInquiries()
        {
            InitializeComponent();
        }

        private void DB_ViewReadyInquiries_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }


        #region LoadGridView
        private void LoadGridView()
        {
            string constring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\DataBase\DatabaseOrderManagerPro.mdf; Integrated Security = True; Connect Timeout = 30";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM OrderProblems WHERE ProblemState='" + "Ready" + "'", con))
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
            ImportedDataGridView.Columns["NameCreator"].Visible = false;
            ImportedDataGridView.Columns["ProductPrice"].Visible = false;
            ImportedDataGridView.Columns["OrderAmount"].Visible = false;
            ImportedDataGridView.Columns["ProblemType"].Visible = false;
            ImportedDataGridView.Columns["ProblemAmount"].Visible = false;
            ImportedDataGridView.Columns["Comment"].Visible = false;

            ImportedDataGridView.Columns["InquiryResult"].Visible = false;
            ImportedDataGridView.Columns["AmountFound"].Visible = false;
            ImportedDataGridView.Columns["FoundLocation"].Visible = false;
            ImportedDataGridView.Columns["InvestigatedBy"].Visible = false;

            ImportedDataGridView.Columns["FoundHandlingUnit"].Visible = false;
            ImportedDataGridView.Columns["MistakeType"].Visible = false;
            ImportedDataGridView.Columns["MistakeMadeBy"].Visible = false;
            ImportedDataGridView.Columns["DateAndTimeFinished"].Visible = false;

            ImportedDataGridView.Columns["InquiryOrder"].Visible = false;
            ImportedDataGridView.Columns["InvestigatorComment"].Visible = false;


            foreach (DataGridViewRow row in ImportedDataGridView.Rows)
            {
                ImportedDataGridView.Rows[row.Index].Cells[0].Value = row.Cells[1].Value;

            }

            ImportedDataGridView.Columns["InquiryColumn"].DisplayIndex = 13;
            ImportedDataGridView.Columns["InquiryColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;




            //DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
            //bcol.HeaderText = "Inquiry";
            ////bcol.Text = "Click Me";
            //bcol.Name = "btnClickMe";
            //bcol.UseColumnTextForButtonValue = true;
            //ImportedDataGridView.Columns.Add(bcol);




            //CustomizeCellsInThirdColumn();

        }



        #endregion

        private void ImportedDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if(e.ColumnIndex == 0)
                {
                    var RowId = Convert.ToInt64(ImportedDataGridView.Rows[e.RowIndex].Cells["InquiryColumn"].Value);
                    //MessageBox.Show(RowId.ToString());

                    DB_ViewReadyInquiry DB_ViewReadyInquiryForm = new DB_ViewReadyInquiry(RowId);
                    DB_ViewReadyInquiryForm.Show();
                }
                else if (e.RowIndex == -1)
                {
                    if (e.ColumnIndex == 0)
                    {
                        int CountsLocation = ImportedDataGridView.Columns["ID"].Index;
                        ImportedDataGridView.Sort(ImportedDataGridView.Columns[CountsLocation], ListSortDirection.Descending);

                        foreach (DataGridViewRow row in ImportedDataGridView.Rows)
                        {
                            ImportedDataGridView.Rows[row.Index].Cells[0].Value = row.Cells[1].Value;
                        }
                    }
                }
            }
        }

        private void ImportedDataGridView_Sorted(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ImportedDataGridView.Rows)
            {
                ImportedDataGridView.Rows[row.Index].Cells[0].Value = row.Cells[1].Value;
            }
        }








        //public void RefreshForm()
        //{
        //    DB_ViewReadyInquiries DB_ViewReadyInquiriesForm = new DB_ViewReadyInquiries();
        //    DB_ViewReadyInquiriesForm.Show();
        //    this.Close();
        //}







    }
}
