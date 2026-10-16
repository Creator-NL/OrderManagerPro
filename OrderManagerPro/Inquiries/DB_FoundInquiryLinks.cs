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

namespace OrderManagerPro.Inquiries
{
    public partial class DB_FoundInquiryLinks : Form
    {
        DataTable SendFoundInquiryLinks = new DataTable();
        Int64 SendInquiryId = 0;
        public DB_FoundInquiryLinks(DataTable CurrentFoundInquiryLinks , Int64 CurrentInquiryId)
        {
            InitializeComponent();
            SendFoundInquiryLinks = CurrentFoundInquiryLinks;
            SendInquiryId = CurrentInquiryId;
        }

        private void DB_FoundInquiryLinks_Load(object sender, EventArgs e)
        {
            ImportedDataGridView.DataSource = SendFoundInquiryLinks;

            ImportedDataGridView.Columns["ID"].Visible = false;
            ImportedDataGridView.Columns["NameCreator"].Visible = false;
            ImportedDataGridView.Columns["ProductPrice"].Visible = false;
            ImportedDataGridView.Columns["OrderAmount"].Visible = false;
            ImportedDataGridView.Columns["ProblemType"].Visible = false;
            //ImportedDataGridView.Columns["ProblemAmount"].Visible = false;
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
        }

        private void ImportedDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 0)
                {

                    var RowId = Convert.ToInt64(ImportedDataGridView.Rows[e.RowIndex].Cells["InquiryColumn"].Value);

                    if (RowId == SendInquiryId)
                    {
                        MessageBox.Show("This Inquiry is already open!");
                    }
                    else
                    {
                        DB_ViewReadyInquiry DB_ViewReadyInquiryForm = new DB_ViewReadyInquiry(RowId);
                        DB_ViewReadyInquiryForm.Show();
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


                            //if (Convert.ToInt64(row.Cells[1].Value) != SendInquiryId)
                            //{
                            ImportedDataGridView.Rows[row.Index].Cells[0].Value = row.Cells[1].Value;
                            //}

                        }
                    }
                }
            }
        }












    }
}
