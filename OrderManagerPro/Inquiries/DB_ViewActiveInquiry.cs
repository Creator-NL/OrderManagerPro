using OrderManagerPro.Inquiries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagerPro
{
    public partial class DB_ViewActiveInquiry : Form
    {

        Int64 InquiryID = new int();
        string SendUserName = "";
        string SendUserLanguage = "";
        public DB_ViewActiveInquiry(Int64 SendInquiryID , string CurrentUserName , string CurrentUserLanguage)
        {
            InitializeComponent();
            InquiryID = SendInquiryID;
            SendUserName = CurrentUserName;
            SendUserLanguage = CurrentUserLanguage;
        }

        private void DB_ViewInquiry_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Convert.ToString(InquiryID));

            LoadInquiry();
            SetData();
            CheckForInquiryLinks();

            InquiryIdLabel.Text = InquiryID.ToString();

            //LanguageComboBox.SelectedItem = "EN";


            if(InvestigatedByTextBox.Text == string.Empty)
            {
                InvestigatedByTextBox.Text = SendUserName;
            }
            else
            {
                MessageBox.Show("Ïnquiry is getting solved by " + InvestigatedByTextBox.Text);
            }

            SetLanguage();
            ApplyLanguage();
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
                NameCreatorLabel.Text = "Added By";
                CommentLabel.Text = "Comment";



                InquiryResultLabel.Text = "Inquiry Result";
                MistakeTypeLabel.Text = "Mistake Type";
                AmountFoundLabel.Text = "Amount Found";
                FoundLocationLabel.Text = "Found Location";
                FoundHandlingUnitLabel.Text = "Found Handling Unit";
                InvenstigatorCommentLabel.Text = "Invenstigator Comment";
                MistakeMadeByLabel.Text = "Mistake Made By";
                InvestigatedByLabel.Text = "Investigated By";



                CheckInquiryButton.Text = "Check";
                ReadyButton.Text = "Ready";
                UpdateButton.Text = "Update";
                EditButton.Text = "Edit";





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
                NameCreatorLabel.Text = "Toegevoegd door";
                CommentLabel.Text = "Opmerking";



                InquiryResultLabel.Text = "Onderzoek resultaat";
                MistakeTypeLabel.Text = "Fout soort";
                AmountFoundLabel.Text = "Gevonden aantal";
                FoundLocationLabel.Text = "Gevonden Locatie";
                FoundHandlingUnitLabel.Text = "Gevonden Handling Unit";
                InvenstigatorCommentLabel.Text = "Opmerking";
                MistakeMadeByLabel.Text = "Fout gemaakt door";
                InvestigatedByLabel.Text = "Onderzocht door";




                CheckInquiryButton.Text = "Controleer";
                ReadyButton.Text = "Klaar";
                UpdateButton.Text = "Bijwerken";
                EditButton.Text = "Verbeter";


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
                NameCreatorLabel.Text = "Hinzugefügt von";
                CommentLabel.Text = "Kommentar";


                InquiryResultLabel.Text = "Anfrageergebnis";
                MistakeTypeLabel.Text = "Fehlertyp";
                AmountFoundLabel.Text = "Gefundene menge";
                FoundLocationLabel.Text = "Gefundene Platz";
                FoundHandlingUnitLabel.Text = "Gefunden Handling Unit";
                InvenstigatorCommentLabel.Text = "Kommentar";
                MistakeMadeByLabel.Text = "Fehler gemacht von";
                InvestigatedByLabel.Text = "Untersucht von";


                CheckInquiryButton.Text = "Überprüfen";
                ReadyButton.Text = "Fertig";
                UpdateButton.Text = "Aktualisieren";
                EditButton.Text = "Verbeser";



            }
        }


        private void LanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyLanguage();
        }
        #endregion


























































        DataTable dt;
        #region LoadInquiry
        private void LoadInquiry()
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


        DataTable DT_FoundInquiryLinks = new DataTable();
        private void CheckForInquiryLinks()
        {
            string OrderNumberFix = OrderNumberTextBox.Text;
            string constring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\DataBase\DatabaseOrderManagerPro.mdf; Integrated Security = True; Connect Timeout = 30";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM OrderProblems WHERE OrderNumber='" + Convert.ToString(OrderNumberFix) + "'", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (dt = new DataTable())
                        {
                            sda.Fill(DT_FoundInquiryLinks);
                            //dt.Columns.Add("Inquiry", typeof(Button));
                            //ImportedDataGridView.DataSource = dt;
                        }
                    }
                }
            }

            if (DT_FoundInquiryLinks.Rows.Count > 1)
            {
                FoundInquiryLinksButton.Visible = true;
            }
        }



        private void FoundInquiryLinksButton_Click(object sender, EventArgs e)
        {
            DB_FoundInquiryLinks DB_FoundInquiryLinksForm = new DB_FoundInquiryLinks(DT_FoundInquiryLinks , InquiryID);
            DB_FoundInquiryLinksForm.Show();
        }












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


        //private void FormCheck()
        //{
        //    //if ()
        //    //{

        //    //}





        //}





        private void CheckInquiryButton_Click(object sender, EventArgs e)
        {


            if (InquiryResultComboBox.Text.Trim() != ""
    && MistakeTypeComboBox.Text.Trim() != ""
    && AmountFoundTextBox.Text.Trim() != ""
    && FoundLocationTextBox.Text.Trim() != ""
    && FoundHandlingUnitTextBox.Text.Trim() != ""
    && MistakeMadeByTextBox.Text.Trim() != ""
    && InvestigatorCommentTextBox.Text.Trim() != ""
    && InvestigatedByTextBox.Text.Trim() != "")
            {
                ReadyButton.Enabled = true;
                ReadyButton.BackColor = Color.LightGreen;
                UpdateButton.Enabled = false;
                UpdateButton.BackColor = Color.Gray;
                CheckInquiryButton.Enabled = false;
                CheckInquiryButton.BackColor = Color.Gray;
                EditButton.Visible = true;


                InquiryResultComboBox.Enabled = false;
                MistakeTypeComboBox.Enabled = false;
                AmountFoundTextBox.Enabled = false;
                FoundLocationTextBox.Enabled = false;
                FoundHandlingUnitTextBox.Enabled = false;
                MistakeMadeByTextBox.Enabled = false;
                InvestigatorCommentTextBox.Enabled = false;
                InvestigatedByTextBox.Enabled = false;
            }
            else
            {
                MessageBox.Show("Not all required fields have information");
            }











        }


        private void EditButton_Click(object sender, EventArgs e)
        {
            ReadyButton.Enabled=false;
            ReadyButton.BackColor = Color.Gray;
            UpdateButton.Enabled=true;
            UpdateButton.BackColor = Color.LightGreen;
            CheckInquiryButton.Enabled=true;
            CheckInquiryButton.BackColor = Color.LightGreen;
            EditButton.Visible = false;



            InquiryResultComboBox.Enabled = true;
            MistakeTypeComboBox.Enabled = true;
            AmountFoundTextBox.Enabled = true;
            FoundLocationTextBox.Enabled = true;
            FoundHandlingUnitTextBox.Enabled = true;
            MistakeMadeByTextBox.Enabled = true;
            InvestigatorCommentTextBox.Enabled = true;
            InvestigatedByTextBox.Enabled = true;
        }


























        private void ReadyButton_Click(object sender, EventArgs e)
        {
            //FormCheck();

            String ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\DataBase\DatabaseOrderManagerPro.mdf; Integrated Security = True; Connect Timeout = 30";
            using (var connection = new SqlConnection(ConnectionString))

            using (var command = connection.CreateCommand())
            {
                command.CommandText = "UPDATE OrderProblems " +
                    "SET " +
                    "ProblemState = @ProblemState , " +
                    "DateAndTimeReady = @DateAndTimeReady , " +
                    "MistakeType = @MistakeType , " +
                    "MistakeMadeBy = @MistakeMadeBy , " +
                    "AmountFound = @AmountFound , " +
                    "FoundLocation = @FoundLocation , " +
                    "FoundHandlingUnit = @FoundHandlingUnit , " +
                    "InvestigatedBy = @InvestigatedBy , " +
                    "InvestigatorComment = @InvestigatorComment , " +
                    "InquiryResult = @InquiryResult " +
                    "WHERE ID='" + Convert.ToString(InquiryID) + "';";

                command.Parameters.AddWithValue("@ProblemState", "Ready");
                command.Parameters.AddWithValue("@DateAndTimeReady", DateTime.Now);
                command.Parameters.AddWithValue("@MistakeType", MistakeTypeComboBox.Text);
                command.Parameters.AddWithValue("@MistakeMadeBy", MistakeMadeByTextBox.Text);
                command.Parameters.AddWithValue("@AmountFound", AmountFoundTextBox.Text);
                command.Parameters.AddWithValue("@FoundLocation", FoundLocationTextBox.Text);
                command.Parameters.AddWithValue("@FoundHandlingUnit", FoundHandlingUnitTextBox.Text);
                command.Parameters.AddWithValue("@InvestigatedBy", InvestigatedByTextBox.Text);
                command.Parameters.AddWithValue("@InquiryResult", InquiryResultComboBox.Text);
                command.Parameters.AddWithValue("@InvestigatorComment", InvestigatorCommentTextBox.Text);

                
                connection.Open();

                command.ExecuteNonQuery();
                connection.Dispose();
                connection.Close();
            }
            MessageBox.Show("Inquiry Set to ready");







            //SendEmail();





            DB_ViewActiveInquiries obj = (DB_ViewActiveInquiries)Application.OpenForms["DB_ViewActiveInquiries"];
            obj.Close();

            DB_ViewActiveInquiries DB_ViewActiveInquiriesForm = new DB_ViewActiveInquiries(SendUserName, SendUserLanguage);
            DB_ViewActiveInquiriesForm.Show();





            this.Close();
        }






        private void UpdateButton_Click(object sender, EventArgs e)
        {
            String ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\DataBase\DatabaseOrderManagerPro.mdf; Integrated Security = True; Connect Timeout = 30";
            using (var connection = new SqlConnection(ConnectionString))

            using (var command = connection.CreateCommand())
            {
                command.CommandText = "UPDATE OrderProblems " +
                    "SET " +
                    "ProblemState = @ProblemState , " +
                    "MistakeType = @MistakeType , " +
                    "MistakeMadeBy = @MistakeMadeBy , " +
                    "AmountFound = @AmountFound , " +
                    "FoundLocation = @FoundLocation , " +
                    "FoundHandlingUnit = @FoundHandlingUnit , " +
                    "InvestigatedBy = @InvestigatedBy , " +
                    "InvestigatorComment = @InvestigatorComment , " +
                    "InquiryResult = @InquiryResult " +
                    "WHERE ID='" + Convert.ToString(InquiryID) + "';";

                command.Parameters.AddWithValue("@ProblemState", "Active");
                command.Parameters.AddWithValue("@MistakeType", MistakeTypeComboBox.Text);
                command.Parameters.AddWithValue("@MistakeMadeBy", MistakeMadeByTextBox.Text);
                command.Parameters.AddWithValue("@AmountFound", AmountFoundTextBox.Text);
                command.Parameters.AddWithValue("@FoundLocation", FoundLocationTextBox.Text);
                command.Parameters.AddWithValue("@FoundHandlingUnit", FoundHandlingUnitTextBox.Text);
                command.Parameters.AddWithValue("@InvestigatedBy", InvestigatedByTextBox.Text);
                command.Parameters.AddWithValue("@InquiryResult", InquiryResultComboBox.Text);
                command.Parameters.AddWithValue("@InvestigatorComment", InvestigatorCommentTextBox.Text);


                connection.Open();

                command.ExecuteNonQuery();
                connection.Dispose();
                connection.Close();

                MessageBox.Show("Information saved");
            }

        }






        //private void SendEmail()
        //{

        //    ////Builed The MSG
        //    //System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
        //    //msg.To.Add("gan@gmail.com");
        //    //msg.To.Add("ganesan@gmail.com");
        //    //msg.From = new MailAddress("ganesan@gmail.com");
        //    //msg.Subject = "Test mail using .net2.0";
        //    //msg.SubjectEncoding = System.Text.Encoding.UTF8;
        //    //msg.Body = "This is my msg Body";
        //    //msg.BodyEncoding = System.Text.Encoding.UTF8;
        //    //msg.IsBodyHtml = false;
        //    //msg.Priority = MailPriority.High;

        //    ////Add the Creddentials
        //    //SmtpClient client = new SmtpClient();
        //    //client.Credentials = new System.Net.NetworkCredential
        //    //    ("ganesan@gmail.com", "*******");
        //    //client.Port = 587;//or use 587            
        //    //client.Host = "smtp.gmail.com";
        //    //client.EnableSsl = true;
        //    //client.SendCompleted += new SendCompletedEventHandler(client_SendCompleted);
        //    //object userState = msg;
        //    //try
        //    //{
        //    //    //you can also call client.Send(msg)
        //    //    client.SendAsync(msg, userState);   // i am gettint error in this line........             
        //    //}
        //    //catch (System.Net.Mail.SmtpException ex)
        //    //{
        //    //    MessageBox.Show(ex.Message, "Send Mail Error");
        //    //}



        //    //void client_SendCompleted(object sender, AsyncCompletedEventArgs e)
        //    //{
        //    //    MailMessage mail = (MailMessage)e.UserState;
        //    //    string subject = mail.Subject;

        //    //    if (e.Cancelled)
        //    //    {
        //    //        string cancelled = string.Format("[{0}] Send canceled.", subject);
        //    //        MessageBox.Show(cancelled);
        //    //    }
        //    //    if (e.Error != null)
        //    //    {
        //    //        string error = String.Format("[{0}] {1}", subject, e.Error.ToString());
        //    //        MessageBox.Show(error);
        //    //    }
        //    //    else
        //    //    {
        //    //        MessageBox.Show("Message sent.");
        //    //    }
        //    //    mailSent = true;
        //    //}






























        //    //// Command-line argument must be the SMTP host.
        //    //SmtpClient client = new SmtpClient();
        //    //// Specify the email sender.
        //    //// Create a mailing address that includes a UTF8 character
        //    //// in the display name.
        //    //MailAddress from = new MailAddress("Test@contoso.com",
        //    //   "A " + (char)0xD8 + " W",
        //    //System.Text.Encoding.UTF8);
        //    //// Set destinations for the email message.
        //    //MailAddress to = new MailAddress("recipient@example.com");
        //    //// Specify the message content.
        //    //MailMessage message = new MailMessage(from, to);
        //    //message.Body = "This is a test email message sent by an application. ";
        //    //// Include some non-ASCII characters in body and subject.
        //    //string someArrows = new string(new char[] { '\u2190', '\u2191', '\u2192', '\u2193' });
        //    //message.Body += Environment.NewLine + someArrows;
        //    //message.BodyEncoding = System.Text.Encoding.UTF8;
        //    //message.Subject = "test message 1" + someArrows;
        //    //message.SubjectEncoding = System.Text.Encoding.UTF8;
        //    //// Set the method that is called back when the send operation ends.
        //    //client.SendCompleted += new
        //    //SendCompletedEventHandler(SendCompletedCallback);
        //    //// The userState can be any object that allows your callback
        //    //// method to identify this send operation.
        //    //// For this example, the userToken is a string constant.
        //    //string userState = "test message1";
        //    //client.SendAsync(message, userState);
        //    //Console.WriteLine("Sending message... press c to cancel mail. Press any other key to exit.");
        //    //string answer = Console.ReadLine();
        //    //// If the user canceled the send, and mail hasn't been sent yet,
        //    //// then cancel the pending operation.
        //    //if (answer.StartsWith("c") && mailSent == false)
        //    //{
        //    //    client.SendAsyncCancel();
        //    //}
        //    //// Clean up.
        //    //message.Dispose();
        //    //Console.WriteLine("Goodbye.");

        //}








        //static bool mailSent = false;
        //private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        //{
        //    // Get the unique identifier for this asynchronous operation.
        //    String token = (string)e.UserState;

        //    if (e.Cancelled)
        //    {
        //        Console.WriteLine("[{0}] Send canceled.", token);
        //    }
        //    if (e.Error != null)
        //    {
        //        Console.WriteLine("[{0}] {1}", token, e.Error.ToString());
        //    }
        //    else
        //    {
        //        Console.WriteLine("Message sent.");
        //    }
        //    mailSent = true;
        //}





    }
}
