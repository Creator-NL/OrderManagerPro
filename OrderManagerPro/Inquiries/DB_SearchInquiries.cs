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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace OrderManagerPro
{
    public partial class DB_SearchInquiries : Form
    {

        string SendUserLanguage = string.Empty;
        public DB_SearchInquiries(string CurrentUserLanguage)
        {
            InitializeComponent();

            SendUserLanguage = CurrentUserLanguage;
        }

        private void DB_SearchInquiries_Load(object sender, EventArgs e)
        {
            LoadDataTable();



            SetLanguage();
        }

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
                OrderNumberLabel.Text = "Order Number";
                DeliveryNumberLabel.Text = "Delivery Number";
                ProductNumberLabel.Text = "Product Number";

                ProblemTypeLabel.Text = "Problem Type";
                ProblemAmountLabel.Text = "Problem Amount";

                SearchButton.Text = "Search";
                RowsFoundLabel.Text = "Rows Found :";
            }
            else if (LanguageComboBox.Text.Equals("NL"))
            {
                OrderNumberLabel.Text = "Bestelnummer";
                DeliveryNumberLabel.Text = "Leveringsnummer";
                ProductNumberLabel.Text = "Productnummer";

                ProblemTypeLabel.Text = "Probleem Soort";
                ProblemAmountLabel.Text = "Probleem Aantal";

                SearchButton.Text = "Zoeken";
                RowsFoundLabel.Text = "Gevonde regels :";

            }
            else if (LanguageComboBox.Text.Equals("DE"))
            {
                OrderNumberLabel.Text = "Bestellnummer";
                DeliveryNumberLabel.Text = "Anliefernummer";
                ProductNumberLabel.Text = "Produktnummer";

                ProblemTypeLabel.Text = "Problemtyp";
                ProblemAmountLabel.Text = "Problemmenge";

                SearchButton.Text = "Suchen";
                RowsFoundLabel.Text = "Gefundene Zeilen :";
            }
        }

        private void LanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyLanguage();
        }


























        DataTable dt;
        #region LoadDataTable
        private void LoadDataTable()
        {
            string constring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\DataBase\DatabaseOrderManagerPro.mdf; Integrated Security = True; Connect Timeout = 30";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM OrderProblems", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (dt = new DataTable())
                        {
                            sda.Fill(dt);
                            //dt.Columns.Add("Inquiry", typeof(Button));
                            //ImportedDataGridView.DataSource = dt;
                        }
                    }
                }
            }
            //ImportedDataGridView.Columns["ID"].Visible = false;


            //foreach (DataGridViewRow row in ImportedDataGridView.Rows)
            //{
            //    ImportedDataGridView.Rows[row.Index].Cells[0].Value = row.Cells[1].Value;

            //}

            //ImportedDataGridView.Columns["InquiryColumn"].DisplayIndex = 13;





            //DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
            //bcol.HeaderText = "Inquiry";
            ////bcol.Text = "Click Me";
            //bcol.Name = "btnClickMe";
            //bcol.UseColumnTextForButtonValue = true;
            //ImportedDataGridView.Columns.Add(bcol);




            //CustomizeCellsInThirdColumn();

        }
        #endregion

        #region Is Dirty

        Boolean OrderNumberIsDirty = false;
        Boolean DeliveryNumberIsDirty = false;
        Boolean ProductNumberIsDirty = false;
        Boolean ProblemTypeIsDirty = false;
        Boolean ProblemAmountIsDirty = false;
        Boolean IDIsDirty = false;
        //Boolean IsDirty = false;
        //Boolean IsDirty = false;
        //Boolean IsDirty = false;
        //Boolean IsDirty = false;
        //Boolean IsDirty = false;
        #endregion

        #region Search
        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            string VDSearchString = string.Empty;
            string VDSearchStringFix = string.Empty;
            if (OrderNumberIsDirty)
            {
                VDSearchString += " OrderNumber LIKE '%" + OrderNumberTextBox.Text + "%' ";
                VDSearchStringFix = "AND";
            }
            if (DeliveryNumberIsDirty)
            {
                VDSearchString += VDSearchStringFix + " DeliveryNumber LIKE '%" + DeliveryNumberTextBox.Text + "%' ";
                VDSearchStringFix = "AND";
            }
            if (ProductNumberIsDirty)
            {
                VDSearchString += VDSearchStringFix + " ProductNumber LIKE '%" + ProductNumberTextBox.Text + "%' ";
                VDSearchStringFix = "AND";
            }
            if (ProblemTypeIsDirty)
            {
                VDSearchString += VDSearchStringFix + " ProblemType LIKE '%" + ProblemTypeComboBox.Text + "%' ";
                VDSearchStringFix = "AND";
            }
            if (ProblemAmountIsDirty)
            {
                VDSearchString += VDSearchStringFix + " ProblemAmount LIKE '%" + ProblemAmountTextBox.Text + "%' ";
                VDSearchStringFix = "AND";
            }
            if (IDIsDirty)
            {
                VDSearchString += VDSearchStringFix + " Id IN('" + IDTextBox.Text + "')";
            }

            dv.RowFilter = VDSearchString;

            SearchResultGridView.DataSource = dv;

            SearchResultGridView.Columns["ID"].Visible = false;

            foreach (DataGridViewRow row in SearchResultGridView.Rows)
            {
                SearchResultGridView.Rows[row.Index].Cells[0].Value = row.Cells[1].Value;

            }
            SearchResultGridView.Columns["InquiryColumn"].DisplayIndex = 13;


            //dv.RowFilter = " OrderNumber LIKE '%" + OrderNumberTextBox.Text + "%' " +
            //    "AND ProductNumber LIKE '%" + ProductNumberTextBox.Text + "%' " +
            //    "AND DeliveryNumber LIKE '%" + DeliveryNumberTextBox.Text + "%' " +
            //    "AND ProblemType LIKE '%" + ProblemTypeComboBox.Text + "%' " +
            //    "AND ProblemAmount LIKE '%" + ProblemAmountTextBox.Text + "%' ";







            //dv.RowFilter = " OrderNumber LIKE '%" + OrderNumberTextBox.Text + "%' " +
            //    //"AND ProductNumber =" + ProductNumberTextBox.Text +
            //    "AND DeliveryNumber LIKE '%" + DeliveryNumberTextBox.Text + "%' " +
            //    "AND ProblemType LIKE '%" + ProblemTypeComboBox.Text + "%' " +
            //    "AND ProblemAmount LIKE '%" + ProblemAmountTextBox.Text + "%' " +
            //    "AND Id IN(" + IDTextBox.Text + ")";





            //DataTable dtSearch = new DataTable();
            //dtSearch = dt.Copy();


            //dv = new DataView(dt, "OrderNumber LIKE '%" + OrderNumberTextBox.Text + "%'", "DateAndTimeCreated Desc", DataViewRowState.CurrentRows);


            //dv = new DataView(ds.Tables[0], "Product_Price < = 3000", "Product_Name", DataViewRowState.CurrentRows);





            //SelectedGridView.Columns["nazv"].HeaderText = "Исполнитель";
        }
        #endregion

        #region Search Fiels Text Changed
        private void SearchFields_TextChanged(object sender, EventArgs e)
        {

            if (OrderNumberTextBox.Text.Trim() != string.Empty)
            {
                OrderNumberIsDirty = true;
            }
            else
            {
                OrderNumberIsDirty = false;
            }


            if (DeliveryNumberTextBox.Text.Trim() != string.Empty)
            {
                DeliveryNumberIsDirty = true;
            }
            else
            {
                DeliveryNumberIsDirty = false;
            }

            if (ProductNumberTextBox.Text.Trim() != string.Empty)
            {
                ProductNumberIsDirty = true;
            }
            else
            {
                ProductNumberIsDirty = false;
            }

            if (ProblemTypeComboBox.Text.Trim() != string.Empty)
            {
                ProblemTypeIsDirty = true;
            }
            else
            {
                ProblemTypeIsDirty = false;
            }

            if (ProblemAmountTextBox.Text.Trim() != string.Empty)
            {
                ProblemAmountIsDirty = true;
            }
            else
            {
                ProblemAmountIsDirty = false;
            }



            if (IDTextBox.Text.Trim() != string.Empty)
            {
                IDIsDirty = true;
            }
            else
            {
                IDIsDirty = false;
            }
        }


        #endregion

        private void SearchResultGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var RowId = Convert.ToInt64(SearchResultGridView.Rows[e.RowIndex].Cells["InquiryColumn"].Value);
                //MessageBox.Show(RowId.ToString());

                ViewFoundInquiry ViewFoundInquiryForm = new ViewFoundInquiry(RowId);
                ViewFoundInquiryForm.Show();
            }
        }


    }
}
