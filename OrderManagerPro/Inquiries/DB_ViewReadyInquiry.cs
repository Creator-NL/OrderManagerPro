using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagerPro
{
    public partial class DB_ViewReadyInquiry : Form
    {

        Int64 InquiryID = new int();

        public DB_ViewReadyInquiry(Int64 SendInquiryID)
        {
            InitializeComponent();
            InquiryID = SendInquiryID;
        }

        private void DB_ViewReadyInquiry_Load(object sender, EventArgs e)
        {
            LoadGridView();
            SetData();
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



            InquiryResultTextBox.Text = dt.Rows[0]["InquiryResult"].ToString();
            MistakeTypeTextBox.Text = dt.Rows[0]["MistakeType"].ToString();
            AmountFoundTextBox.Text = dt.Rows[0]["AmountFound"].ToString();
            FoundLocationTextBox.Text = dt.Rows[0]["FoundLocation"].ToString();
            FoundHandlingUnitTextBox.Text = dt.Rows[0]["FoundHandlingUnit"].ToString();
            InvestigatorCommentTextBox.Text = dt.Rows[0]["InvestigatorComment"].ToString();
            MistakeMadeByTextBox.Text = dt.Rows[0]["MistakeMadeBy"].ToString();
            InvestigatedByTextBox.Text = dt.Rows[0]["InvestigatedBy"].ToString();









        }

        private void ReadyButton_Click(object sender, EventArgs e)
        {
            String ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\DataBase\DatabaseOrderManagerPro.mdf; Integrated Security = True; Connect Timeout = 30";
            using (var connection = new SqlConnection(ConnectionString))

            using (var command = connection.CreateCommand())
            {
                command.CommandText = "UPDATE OrderProblems " +
                    "SET " +
                    "DateAndTimeFinished = @DateAndTimeFinished , " +
                    "ProblemState = @ProblemState " +
                    "WHERE ID='" + Convert.ToString(InquiryID) + "';";

                command.Parameters.AddWithValue("@DateAndTimeFinished", DateTime.Now);
                command.Parameters.AddWithValue("@ProblemState", "Finished");

                connection.Open();

                command.ExecuteNonQuery();
                connection.Dispose();
                connection.Close();
            }
            MessageBox.Show("Inquiry Set to Finished");

            //DB_ViewReadyInquiries.ActiveForm.Refresh();
            //SendEmail();
            DB_ViewReadyInquiries obj = (DB_ViewReadyInquiries)Application.OpenForms["DB_ViewReadyInquiries"];
            obj.Close();

            DB_ViewReadyInquiries DB_ViewReadyInquiriesForm = new DB_ViewReadyInquiries();
            DB_ViewReadyInquiriesForm.Show();

            this.Close();
        }



        //private void SendEmail()
        //{
        //    // Command-line argument must be the SMTP host.
        //    SmtpClient client = new SmtpClient();
        //    // Specify the email sender.
        //    // Create a mailing address that includes a UTF8 character
        //    // in the display name.
        //    MailAddress from = new MailAddress("Test@contoso.com",
        //       "A " + (char)0xD8 + " W",
        //    System.Text.Encoding.UTF8);
        //    // Set destinations for the email message.
        //    MailAddress to = new MailAddress("recipient@example.com");
        //    // Specify the message content.
        //    MailMessage message = new MailMessage(from, to);
        //    message.Body = "This is a test email message sent by an application. ";
        //    // Include some non-ASCII characters in body and subject.
        //    string someArrows = new string(new char[] { '\u2190', '\u2191', '\u2192', '\u2193' });
        //    message.Body += Environment.NewLine + someArrows;
        //    message.BodyEncoding = System.Text.Encoding.UTF8;
        //    message.Subject = "test message 1" + someArrows;
        //    message.SubjectEncoding = System.Text.Encoding.UTF8;
        //    // Set the method that is called back when the send operation ends.
        //    client.SendCompleted += new
        //    SendCompletedEventHandler(SendCompletedCallback);
        //    // The userState can be any object that allows your callback
        //    // method to identify this send operation.
        //    // For this example, the userToken is a string constant.
        //    string userState = "test message1";
        //    client.SendAsync(message, userState);
        //    Console.WriteLine("Sending message... press c to cancel mail. Press any other key to exit.");
        //    string answer = Console.ReadLine();
        //    // If the user canceled the send, and mail hasn't been sent yet,
        //    // then cancel the pending operation.
        //    if (answer.StartsWith("c") && mailSent == false)
        //    {
        //        client.SendAsyncCancel();
        //    }
        //    // Clean up.
        //    message.Dispose();
        //    Console.WriteLine("Goodbye.");

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
