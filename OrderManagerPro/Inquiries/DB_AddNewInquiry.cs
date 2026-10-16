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
    public partial class DB_AddNewInquiry : Form
    {
        string SendUserName = string.Empty;
        string SendUserLanguage = string.Empty;

        public DB_AddNewInquiry(string CurrentUserName , string CurrentUserLanguage)
        {
            InitializeComponent();
            SendUserName=CurrentUserName;
            SendUserLanguage = CurrentUserLanguage;
        }

        private void DB_AddNewInquiry_Load(object sender, EventArgs e)
        {
            SetLanguage();

            NameCreatorTextBox.Text = SendUserName;
        }


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
                SupplierLabel.Text = "Supplier";
                OrderNumberLabel.Text = "Order Number";
                DeliveryNumberLabel.Text = "Delivery Number";
                ProductNumberLabel.Text = "Product Number";
                OrderAmountLabel.Text = "Order Amount";
                ProductPriceLabel.Text = "Product Price";
                ProblemTypeLabel.Text = "Problem Type";
                ProblemAmountLabel.Text = "Problem Amount";
                NameCreatorLabel.Text = "Youre Name";
                CommentLabel.Text = "Comment";

                InquiryOrderLabel.Text = "Inquiry Order";

                ProblemStateLabel.Text = "Problem State";

                CheckInquiryButton.Text = "Check";
                AddButton.Text = "Add";

            }
            else if (LanguageComboBox.Text.Equals("NL"))
            {
                SupplierLabel.Text = "Leverancier";
                OrderNumberLabel.Text = "Bestelnummer";
                DeliveryNumberLabel.Text = "Leveringsnummer";
                ProductNumberLabel.Text = "Productnummer";
                OrderAmountLabel.Text = "Bestelaantal";
                ProductPriceLabel.Text = "Productprijs";
                ProblemTypeLabel.Text = "Probleem Soort";
                ProblemAmountLabel.Text = "Probleem Aantal";
                NameCreatorLabel.Text = "Je Naam";
                CommentLabel.Text = "Kommentaar";

                InquiryOrderLabel.Text = "Aanvraag Opdracht";

                ProblemStateLabel.Text = "Probleemstatus";

                CheckInquiryButton.Text = "Controleer";
                AddButton.Text = "Toevoegen";

            }
            else if (LanguageComboBox.Text.Equals("DE"))
            {
                SupplierLabel.Text = "Lieferant";
                OrderNumberLabel.Text = "Bestellnummer";
                DeliveryNumberLabel.Text = "Anliefernummer";
                ProductNumberLabel.Text = "Produktnummer";
                OrderAmountLabel.Text = "Bestellmenge";
                ProductPriceLabel.Text = "Produkt Preis";
                ProblemTypeLabel.Text = "Problemtyp";
                ProblemAmountLabel.Text = "Problemmenge";
                NameCreatorLabel.Text = "Dein Name";
                CommentLabel.Text = "Kommentar";

                InquiryOrderLabel.Text = "Anfrageauftrag";

                ProblemStateLabel.Text = "Problemstatus";

                CheckInquiryButton.Text = "Überprüfen";
                AddButton.Text = "Hinzufügen";

            }
        }

        private void LanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyLanguage();
        }
        #endregion





        private void AddButton_Click(object sender, EventArgs e)
        {
            String ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\DataBase\DatabaseOrderManagerPro.mdf; Integrated Security = True; Connect Timeout = 30";
            using (var connection = new SqlConnection(ConnectionString))

            using (var command = connection.CreateCommand())
            {

                command.CommandText = "insert into OrderProblems" +
                    "([DateAndTimeCreated],[NameCreator],[Supplier],[OrderNumber],[DeliveryNumber],[ProductNumber],[OrderAmount],[ProductPrice],[ProblemType],[ProblemAmount],[Comment],[ProblemState],[InquiryOrder])" +
                    " values " +
                    "(@DateAndTimeCreated,@NameCreator,@Supplier,@OrderNumber,@DeliveryNumber,@ProductNumber,@OrderAmount,@ProductPrice,@ProblemType,@ProblemAmount,@Comment,@ProblemState,@InquiryOrder)";

                command.Parameters.AddWithValue("@DateAndTimeCreated", DateTime.Now);
                command.Parameters.AddWithValue("@NameCreator", NameCreatorTextBox.Text);

                command.Parameters.AddWithValue("@Supplier", SupplierTextBox.Text);
                command.Parameters.AddWithValue("@OrderNumber", OrderNumberTextBox.Text);
                command.Parameters.AddWithValue("@DeliveryNumber", DeliveryNumberTextBox.Text);

                command.Parameters.AddWithValue("@ProductNumber", ProductNumberTextBox.Text);
                command.Parameters.AddWithValue("@OrderAmount", OrderAmountTextBox.Text);
                command.Parameters.AddWithValue("@ProductPrice", ProductPriceTextBox.Text);

                command.Parameters.AddWithValue("@ProblemType", ProblemTypeComboBox.Text);
                command.Parameters.AddWithValue("@ProblemAmount", ProblemAmountTextBox.Text);

                command.Parameters.AddWithValue("@Comment", CommentTextBox.Text);

                command.Parameters.AddWithValue("@ProblemState", ProblemStateComboBox.Text);
                command.Parameters.AddWithValue("@InquiryOrder", InquiryOrderComboBox.Text);

                
                connection.Open();

                command.ExecuteNonQuery();
                connection.Dispose();
                connection.Close();
            }
            MessageBox.Show("Aanvraag Toegevoegd");

            this.Close();
        }

        //private void DB_ItemAdd_Load(object sender, EventArgs e)
        //{
        //    LanguageComboBox.SelectedItem = "EN";
        //    //ProblemStateComboBox.SelectedItem = "Active";

            
        //}






        private void ProblemAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            DetermineInquiry();
        }
        private void OrderAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            DetermineInquiry();
        }
        private void ProductPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            DetermineInquiry();
        }




        private void DetermineInquiry()
        {
            string AmountTrim = ProblemAmountTextBox.Text.Trim();
            string PriceTrim = ProductPriceTextBox.Text.Trim();
            string OrderAmountTrim = OrderAmountTextBox.Text.Trim();
            if (AmountTrim != string.Empty 
                && PriceTrim != string.Empty 
                && OrderAmountTrim != string.Empty)
            {
                Decimal ProductPrice = Convert.ToDecimal(ProductPriceTextBox.Text);
                Decimal ProblemAmount = Convert.ToDecimal(ProblemAmountTextBox.Text);
                Decimal OrderAmount = Convert.ToDecimal(OrderAmountTextBox.Text);
                if (!ProductPriceTextBox.Equals(String.Empty) && !OrderAmountTextBox.Equals(String.Empty))
                {
                    if (ProblemAmount * ProductPrice < 50 && ProblemAmount / OrderAmount * 100 < 5)
                    {
                        InquiryOrderComboBox.SelectedIndex = 2;
                    }
                    else if (ProblemAmount * ProductPrice >= 50 | ProblemAmount / OrderAmount * 100 >= 5)
                    {
                        InquiryOrderComboBox.SelectedIndex = 1;
                    }
                }
            }
            else
            {
                InquiryOrderComboBox.SelectedIndex = 0;
                ProblemStateComboBox.SelectedIndex = 0;
            }

            if (InquiryOrderComboBox.SelectedIndex == 2)
            {
                ProblemStateComboBox.SelectedIndex = 2;
            }
            else if (InquiryOrderComboBox.SelectedIndex == 1)
            {
                ProblemStateComboBox.SelectedIndex = 1;
            }
        }



        private void CheckInquiryButton_Click(object sender, EventArgs e)
        {
            if (SupplierTextBox.Text.Trim() != "" 
                && OrderNumberTextBox.Text.Trim() != "" 
                && DeliveryNumberTextBox.Text.Trim() != "" 
                && ProductNumberTextBox.Text.Trim() != ""
                && OrderAmountTextBox.Text.Trim() != ""
                && ProductPriceTextBox.Text.Trim() != ""
                && ProblemTypeComboBox.Text.Trim() != ""
                && ProblemAmountTextBox.Text.Trim() != ""
                && NameCreatorTextBox.Text.Trim() != ""
                && InquiryOrderComboBox.Text.Trim() != ""
                && ProblemStateComboBox.Text.Trim() != "")
            {
                AddButton.Enabled = true;
                AddButton.BackColor = Color.LightGreen;
                CheckInquiryButton.Enabled = false;
                CheckInquiryButton.BackColor = Color.Gray;
                EditButton.Visible = true;

                SupplierTextBox.Enabled = false;
                OrderNumberTextBox.Enabled = false;
                DeliveryNumberTextBox.Enabled = false;
                ProductNumberTextBox.Enabled = false;
                OrderAmountTextBox.Enabled = false;
                ProductPriceTextBox.Enabled = false;
                ProblemTypeComboBox.Enabled = false;
                ProblemAmountTextBox.Enabled = false;
                NameCreatorTextBox.Enabled = false;
                InquiryOrderComboBox.Enabled = false;
                ProblemStateComboBox.Enabled = false;
                CommentTextBox.Enabled = false;
            }
            else
            {
                MessageBox.Show("Not all required fields have information");
            }











        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            CheckInquiryButton.Enabled = true;
            CheckInquiryButton.BackColor = Color.LightGreen;
            AddButton.Enabled = false;
            AddButton.BackColor = Color.Gray;
            EditButton.Visible = false;

            SupplierTextBox.Enabled = true;
            OrderNumberTextBox.Enabled = true;
            DeliveryNumberTextBox.Enabled = true;
            ProductNumberTextBox.Enabled = true;
            OrderAmountTextBox.Enabled = true;
            ProductPriceTextBox.Enabled = true;
            ProblemTypeComboBox.Enabled = true;
            ProblemAmountTextBox.Enabled = true;
            NameCreatorTextBox.Enabled = true;
            InquiryOrderComboBox.Enabled = true;
            ProblemStateComboBox.Enabled = true;
            CommentTextBox.Enabled = true;
        }





        private void InquiryOrderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InquiryOrderComboBox.SelectedIndex == 2)
            {
                ProblemStateComboBox.SelectedIndex = 2;
            }
            else if (InquiryOrderComboBox.SelectedIndex == 1)
            {
                ProblemStateComboBox.SelectedIndex = 1;
            }
            else
            {
                ProblemStateComboBox.SelectedIndex = -1;
            }
        }

        private void ProblemStateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProblemStateComboBox.SelectedIndex == 2)
            {
                InquiryOrderComboBox.SelectedIndex = 2;
            }
            else if (ProblemStateComboBox.SelectedIndex == 1)
            {
                InquiryOrderComboBox.SelectedIndex = 1;
            }
            else
            {
                InquiryOrderComboBox.SelectedIndex = -1;
            }
        }



























        //private void CheckForm()
        //{
        //    if (ProblemTypeComboBox.Text != string.Empty)
        //    {
        //        if (NameCreatorTextBox.Text != string.Empty)
        //        {
        //            if (OrderNumberTextBox.Text != string.Empty)
        //            {
        //                if (DeleverynumberextBox.Text != string.Empty)
        //                {
        //                    if (ProductNameTextBox.Text != string.Empty)
        //                    {
        //                        if (PZNTextBox.Text != string.Empty)
        //                        {
        //                            if (EANTextBox.Text != string.Empty)
        //                            {
        //                                if (MissingQuantityTextBox.Text != string.Empty)
        //                                {
        //                                    AddButton.Enabled = true;
        //                                }
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}












    }
}
