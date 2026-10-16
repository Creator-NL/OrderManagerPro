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
    public partial class DB_ViewActiveInquiries : Form
    {


        string SendUserName = "";
        string SendUserLanguage = "";
        public DB_ViewActiveInquiries(string CurrentUserName , string CurrentUserLanguage)
        {
            InitializeComponent();
            SendUserName = CurrentUserName;
            SendUserLanguage = CurrentUserLanguage;
        }


        #region Page Load
        private void DB_ViewActiveInquiries_Load(object sender, EventArgs e)
        {
            LoadGridView();

            SetGridViewHeaderStyle();
            SetGridviewRowColor();




            SetGridViewCellColor();
        }
        #endregion

        #region LoadGridView
        private void LoadGridView()
        {
            string constring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\DataBase\DatabaseOrderManagerPro.mdf; Integrated Security = True; Connect Timeout = 30";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM OrderProblems WHERE ProblemState='" + "Active" + "'", con))
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
            ImportedDataGridView.Columns["DateAndTimeCreated"].Visible = false;
            ImportedDataGridView.Columns["Supplier"].Visible = false;
            ImportedDataGridView.Columns["ProblemState"].Visible = false;

            ImportedDataGridView.Columns["AmountFound"].Visible = false;
            ImportedDataGridView.Columns["FoundLocation"].Visible = false;
            ImportedDataGridView.Columns["FoundHandlingUnit"].Visible = false;
            ImportedDataGridView.Columns["InvestigatedBy"].Visible = false;

            ImportedDataGridView.Columns["MistakeType"].Visible = false;
            ImportedDataGridView.Columns["MistakeMadeBy"].Visible = false;
            ImportedDataGridView.Columns["DateAndTimeReady"].Visible = false;
            ImportedDataGridView.Columns["DateAndTimeFinished"].Visible = false;
            ImportedDataGridView.Columns["InquiryOrder"].Visible = false;
            ImportedDataGridView.Columns["InquiryResult"].Visible = false;
            ImportedDataGridView.Columns["InvestigatorComment"].Visible = false;

            foreach (DataGridViewRow row in ImportedDataGridView.Rows)
            {
                ImportedDataGridView.Rows[row.Index].Cells[0].Value = row.Cells[1].Value;

                //if(ImportedDataGridView.Rows[row.Index].Cells[14].Value.ToString() != string.Empty)
                //{

                //    //row.Cells[2].InquiryColumn.Style.BackColor = System.Drawing.Color.Red;

                //    ////DataGridViewButtonColumn c = (DataGridViewButtonColumn)ImportedDataGridView.Columns["InquiryButton"];
                //    ////c.FlatStyle = FlatStyle.Popup;
                //    ////c.DefaultCellStyle.ForeColor = Color.Navy;
                //    ////c.DefaultCellStyle.BackColor = Color.Red;





                //    //ImportedDataGridView.Rows[row.Index].Cells[14].Style.BackColor = System.Drawing.Color.Red;
                //}

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


        //private void CustomizeCellsInThirdColumn()
        //{
        //    int thirdColumn = 2;
        //    DataGridViewColumn column = ImportedDataGridView.Columns[thirdColumn];
        //    DataGridViewCell cell = new DataGridViewTextBoxCell();

        //    cell.Style.BackColor = Color.Black;
        //    column.CellTemplate = cell;
        //}







        private void ImportedDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var RowId = Convert.ToInt64(ImportedDataGridView.Rows[e.RowIndex].Cells["InquiryColumn"].Value);
                //MessageBox.Show(RowId.ToString());


                DB_ViewActiveInquiry DB_ViewActiveInquiryForm = new DB_ViewActiveInquiry(RowId , SendUserName , SendUserLanguage);
                DB_ViewActiveInquiryForm.Show();
                


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

        private void SetButtonCollor()
        {


        }

        //private void AdjustColumnOrder()
        //{
        //    //ImportedDataGridView.Columns["CustomerID"].Visible = false;
        //    ImportedDataGridView.Columns["ID"].DisplayIndex = 12;
        //    //ImportedDataGridView.Columns["Inquiry"].CellType = typeof(Button);

        //}










        #region Set GridViewCellColor
        private void SetGridViewCellColor()
        {
            for (int i = 0; i < ImportedDataGridView.Rows.Count; i++)
            {
                if(ImportedDataGridView.Rows[i].Cells[17].Value.ToString() != string.Empty) 
                {
                    ImportedDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Orange;
                    ImportedDataGridView.Rows[i].Cells[0].ToolTipText = "This Inquiry is already being investigated by a other person";
                }
                if (ImportedDataGridView.Rows[i].Cells[14].Value.ToString() == "Senior Approval")
                {
                    ImportedDataGridView.Rows[i].Cells[0].Style.BackColor = Color.Red;
                    ImportedDataGridView.Rows[i].Cells[0].ToolTipText = "Waiting for Senior Approval";

                }
            }
        }
        #endregion




        //#region ImportedDataGridView_CellClick
        //private void ImportedDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.ColumnIndex == ImportedDataGridView.Columns.Count - 1 && e.RowIndex != -1)
        //    {
        //        DataGridViewCell CellTimeDiff = ImportedDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];

        //        if (CellTimeDiff.Style.BackColor == Color.Red)
        //        {
        //            CellTimeDiff.Style.BackColor = Color.White;
        //            CellTimeDiff.Selected = false;

        //        }
        //        else
        //        {
        //            CellTimeDiff.Style.BackColor = Color.Red;
        //            CellTimeDiff.Selected = false;
        //        }
        //        //else
        //        //{
        //        //    CellTimeDiff.Style.BackColor = Color.LightGray;
        //        //    CellTimeDiff.Selected = false;
        //        //}

        //        //int cellRate = Convert.ToInt32(DataAnalyzeGridView.Rows[e.RowIndex].Cells[4].Value);
        //        //int cellQty = Convert.ToInt32(DataAnalyzeGridView.Rows[e.RowIndex].Cells[5].Value);

        //        //int Result = (cellRate * 60) / cellQty;
        //        //cellAmount.Value = Result;
        //    }
        //}
        //#endregion







        private void ImportedDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(ImportedDataGridView.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + 4);
            }


        }






        //#region Set Gridview ColumnWitdh
        //private void SetGridviewColumnWitdh()
        //{
        //    try
        //    {
        //        ImportedDataGridView.Columns["Inventurstatus"].Width = 60;
        //        //ImportedDataGridView.Columns["Lagerplatz"].Width = 110;
        //        //ImportedDataGridView.Columns["Produkt"].Width = 75;
        //        //ImportedDataGridView.Columns["Buchmenge"].Width = 50;
        //        //ImportedDataGridView.Columns["Zählmenge"].Width = 50;
        //        //ImportedDataGridView.Columns["Differenzmenge"].Width = 50;
        //        //ImportedDataGridView.Columns["Belegjahr"].Width = 50;

        //        //ImportedDataGridView.Columns["Erstellungsdatum"].Width = 85;
        //        //ImportedDataGridView.Columns["Zähldatum"].Width = 85;
        //        //ImportedDataGridView.Columns["Zählzeit"].Width = 70;

        //        //ImportedDataGridView.Columns["Produktkurzbeschreibung"].Width = 210;
        //        //ImportedDataGridView.Columns["Lagerauftrag"].Width = 90;
        //        //ImportedDataGridView.Columns["Zähler"].Width = 100;
        //        //ImportedDataGridView.Columns["Pos."].Width = 50;
        //        //ImportedDataGridView.Columns["TimeDiff"].Width = 75;
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //    }
        //}
        //#endregion



        private void ImportedDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == ImportedDataGridView.Columns.Count - 1 && e.RowIndex != -1)
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                MessageBox.Show("OK");
            }
        }










        //private void AfterDataLoad()
        //{
        //    if (ImportedDataGridView != null)
        //    {




        //    }
        //}



        private void RefreshButton_Click(object sender, EventArgs e)
        {
            DB_ViewActiveInquiries DB_ViewActiveInquiriesForm = new DB_ViewActiveInquiries(SendUserName , SendUserLanguage);
            DB_ViewActiveInquiriesForm.Show();
            this.Close();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
