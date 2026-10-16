using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagerPro
{
    public partial class DB_ViewFinishedInquiries : Form
    {
        public DB_ViewFinishedInquiries()
        {
            InitializeComponent();
        }

        private void DB_ViewFinishedInquiries_Load(object sender, EventArgs e)
        {
            LoadGridView();
            SetGridViewHeaderStyle();
            SetGridviewRowColor();
        }


        #region LoadGridView
        private void LoadGridView()
        {
            string constring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\DataBase\DatabaseOrderManagerPro.mdf; Integrated Security = True; Connect Timeout = 30";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM OrderProblems WHERE ProblemState='" + "Finished" + "'", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            //dt.Columns.Add("Inquiry", typeof(Button));

                            ImportedDataGridView.DataSource = dt;

                            int CountsLocation = ImportedDataGridView.Columns["ID"].Index;
                            ImportedDataGridView.Sort(ImportedDataGridView.Columns[CountsLocation], ListSortDirection.Descending);
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
        }

        #endregion





        private void ImportedDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 0)
                {
                    var RowId = Convert.ToInt64(ImportedDataGridView.Rows[e.RowIndex].Cells["InquiryColumn"].Value);
                    ViewFoundInquiry ViewFoundInquiryForm = new ViewFoundInquiry(RowId);
                    ViewFoundInquiryForm.Show();
                }
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

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            DB_ViewFinishedInquiries DB_ViewFinishedInquiriesForm = new DB_ViewFinishedInquiries();
            DB_ViewFinishedInquiriesForm.Show();
            this.Close();
        }

        private void ImportedDataGridView_Sorted(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ImportedDataGridView.Rows)
            {
                ImportedDataGridView.Rows[row.Index].Cells[0].Value = row.Cells[1].Value;
            }
        }
    }
}
