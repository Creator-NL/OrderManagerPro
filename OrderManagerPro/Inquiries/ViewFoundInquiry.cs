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
    public partial class ViewFoundInquiry : Form
    {
        Int64 InquiryID = new int();
        public ViewFoundInquiry(Int64 SendInquiryID)
        {
            InitializeComponent();
            InquiryID = SendInquiryID;
        }

        private void ViewFoundInquiry_Load(object sender, EventArgs e)
        {
            LoadGridView();

            SetData();
            InquiryIdLabel.Text = InquiryID.ToString();

            InquiryResultTextBox.Text = InquiryResultComboBox.Text;
            MistakeTypeTextBox.Text = MistakeTypeComboBox.Text;
        }


        DataTable dt;
        #region LoadGridView
        private void LoadGridView()
        {
            string constring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\DataBase\DatabaseOrderManagerPro.mdf; Integrated Security = True; Connect Timeout = 30";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM OrderProblems WHERE ID='" + Convert.ToString(InquiryID) + "'", con))
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




        }
        #endregion


        private void SetData()
        {

            SupplierTextBox.Text = dt.Rows[0]["Supplier"].ToString();
            OrderNumberTextBox.Text = dt.Rows[0]["OrderNumber"].ToString();
            DeliveryNumberTextBox.Text = dt.Rows[0]["DeliveryNumber"].ToString();
            ProductNumberTextBox.Text = dt.Rows[0]["ProductNumber"].ToString();
            OrderAmountTextBox.Text = dt.Rows[0]["OrderAmount"].ToString();
            ProductPriceTextBox.Text = dt.Rows[0]["ProductPrice"].ToString();
            ProblemTypeTextBox.Text = dt.Rows[0]["ProblemType"].ToString();
            ProblemAmountTextBox.Text = dt.Rows[0]["ProblemAmount"].ToString();

            NameCreatorTextBox.Text = dt.Rows[0]["NameCreator"].ToString();
            CommentTextBox.Text = dt.Rows[0]["Comment"].ToString();



            InquiryResultComboBox.Text = dt.Rows[0]["InquiryResult"].ToString();
            MistakeTypeComboBox.Text = dt.Rows[0]["MistakeType"].ToString();
            AmountFoundTextBox.Text = dt.Rows[0]["AmountFound"].ToString();
            FoundLocationTextBox.Text = dt.Rows[0]["FoundLocation"].ToString();
            FoundHandlingUnitTextBox.Text = dt.Rows[0]["FoundHandlingUnit"].ToString();
            InvestigatorCommentTextBox.Text = dt.Rows[0]["InvestigatorComment"].ToString();
            MistakeMadeByTextBox.Text = dt.Rows[0]["MistakeMadeBy"].ToString();
            InvestigatedByTextBox.Text = dt.Rows[0]["InvestigatedBy"].ToString();









        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            AdminButton.Visible = false;

            InquiryResultComboBox.Enabled = true;
            InquiryResultTextBox.Visible = false;

            InquiryOrderComboBox.Enabled = true;

            ProblemStateComboBox.Enabled = true;

        }
    }
}
