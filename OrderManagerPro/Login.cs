using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagerPro
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        //int LoginWrong = 0;

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // using System.Security.Cryptography
            SHA256 mySHA256 = SHA256Managed.Create();
            // convert string into bytes
            byte[] allBytesN = Encoding.UTF8.GetBytes(UserTextBox.Text);
            byte[] allBytesP = Encoding.UTF8.GetBytes(PasswordTextBox.Text);
            // compute the hash for the bytes provided
            byte[] hashBytesN = mySHA256.ComputeHash(allBytesN);
            byte[] hashBytesP = mySHA256.ComputeHash(allBytesP);
            // create a string of hex values for output
            StringBuilder outstringN = new StringBuilder();
            StringBuilder outstringP = new StringBuilder();
            foreach (byte b in hashBytesN)
            {
                outstringN.AppendFormat("{0:x2}", b);
            }
            foreach (byte b in hashBytesP)
            {
                outstringP.AppendFormat("{0:x2}", b);
            }




            //check db users
            DataTable dt;
            string constring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\DataBase\DatabaseOrderManagerPro.mdf; Integrated Security = True; Connect Timeout = 30";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Name='" + UserTextBox.Text + "'", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (dt = new DataTable())
                        {
                            sda.Fill(dt);
                        }
                    }
                }
            }

            if (dt.Rows.Count > 0)
            {
                if (outstringP.ToString() == dt.Rows[0]["Password"].ToString())
                {
                    if(dt.Rows[0]["Group"].ToString().Equals("Stock Control"))
                    {
                        MainWindow MainWindowForm = new MainWindow(dt.Rows[0]["Name"].ToString(), dt.Rows[0]["Group"].ToString(), dt.Rows[0]["UserLanguage"].ToString());
                        MainWindowForm.Show();
                        Close();
                    }
                    else if (dt.Rows[0]["Group"].ToString().Equals("Inbound"))
                    {
                        MainWindow MainWindowForm = new MainWindow(dt.Rows[0]["Name"].ToString(), dt.Rows[0]["Group"].ToString(), dt.Rows[0]["UserLanguage"].ToString());
                        MainWindowForm.Show();
                        Close();
                    }
                    else if (dt.Rows[0]["Group"].ToString().Equals("Admin"))
                    {
                        MainWindow MainWindowForm = new MainWindow(dt.Rows[0]["Name"].ToString(), dt.Rows[0]["Group"].ToString() , dt.Rows[0]["UserLanguage"].ToString());
                        MainWindowForm.Show();
                        Close();
                    }
                    else if (dt.Rows[0]["Group"].ToString().Equals("Super Admin"))
                    {
                        SuperAdmin SuperAdminForm = new SuperAdmin();
                        SuperAdminForm.Show();
                        Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Wrong");
            }

            if (outstringN.ToString() == "f94d3a61fc4b322de134ab222d849e50f4a407f68d201ddd1ff44e57ee20339d" && outstringP.ToString() == "d398b29d3dbbb9bf201d4c7e1c19ff9d43c15fd45a0cec46fbe9885ec3f6e97f")
            {
                SuperAdmin SuperAdminForm = new SuperAdmin();
                SuperAdminForm.Show();
                Close();
            }


            //if (outstringN.ToString() == "260f7f68928c0d526c1bdf2b4f5cd8372ec81f349f64e14d0b414d09f8643643" && outstringP.ToString() == "bf4510ce4a3604b6d602e640d5020f15e4120d46afa9aa4a29c44ea60ee9e770")
            //{
            //    MainWindow MainWindowForm = new MainWindow();
            //    MainWindowForm.Show();
            //    Close();
            //}
            //else if (outstringN.ToString() == "d17a5bdde70e7dba4a6b3cde3e7838c04a70b4d2ec8ce14cbb3d1949a99c2d63" && outstringP.ToString() == "ba60189bde95a962a293a006099fe1fd3d02e8f451f514d8aa4220527755a3fc")
            //{
            //    MainWindow MainWindowForm = new MainWindow();
            //    MainWindowForm.Show();
            //    Close();
            //}
            //else if (outstringN.ToString() == "d821669e5ab0896f7dcba17a4592955b10e98661fc7f8b2a669cea089b9c925b" && outstringP.ToString() == "ba60189bde95a962a293a006099fe1fd3d02e8f451f514d8aa4220527755a3fc")
            //{
            //    MainWindow MainWindowForm = new MainWindow();
            //    MainWindowForm.Show();
            //    Close();
            //}
            //else if (outstringN.ToString() == "6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b" && outstringP.ToString() == "6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b")
            //{
            //    MainWindow MainWindowForm = new MainWindow();
            //    MainWindowForm.Show();
            //    Close();
            //}
            //else if(outstringN.ToString() == "f94d3a61fc4b322de134ab222d849e50f4a407f68d201ddd1ff44e57ee20339d" && outstringP.ToString() == "6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b")
            //{
            //    SuperAdmin SuperAdminForm = new SuperAdmin();
            //    SuperAdminForm.Show();
            //    Close();
            //}
            //else
            //{
            //    LoginWrong++;
            //    int TriesLeft = 3 - LoginWrong;
            //    MessageBox.Show("Wrong Login info - " + TriesLeft + " Tries Left");
            //}
            //if (LoginWrong == 3)
            //{
            //    this.Close();
            //}

        }




        private void UserTextBox_TextChanged(object sender, EventArgs e)
        {
            if (UserTextBox.Text == string.Empty)
            {
                UserTextBox.Text = "User name";
                UserTextBox.ForeColor = Color.Gray;
            }
            else
            {
                UserTextBox.ForeColor = Color.Black;
            }
        }

        private void UserTextBox_Enter(object sender, EventArgs e)
        {
            UserTextBox.SelectAll();
            UserTextBox.Focus();
        }



        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == string.Empty)
            {
                PasswordTextBox.Text = "Password";
                PasswordTextBox.ForeColor = Color.Gray;
                PasswordTextBox.PasswordChar = default;
            }
            else
            {
                PasswordTextBox.ForeColor = Color.Black;
                PasswordTextBox.PasswordChar = '*';
            }
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            PasswordTextBox.SelectAll();
            PasswordTextBox.Focus();
        }



        //#region LoginTextBoxChecker
        //private void LoginTextBoxLeaveChecker(object sender, EventArgs e)
        //{
        //    TextBox textBox = (TextBox)sender;
        //    if (textBox.Text.Equals(string.Empty))
        //    {
        //        if (textBox.Name.Equals("UserTextBox"))
        //        {
        //            textBox.Text = "User name";
        //            textBox.ForeColor = Color.Gray;
        //        }
        //        else
        //        {
        //            textBox.Text = "Password";
        //            textBox.ForeColor = Color.Gray;
        //            textBox.PasswordChar = '\0';
        //        }
        //    }
        //}

        //#endregion






    }
}
