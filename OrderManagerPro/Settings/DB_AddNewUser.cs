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
    public partial class DB_AddNewUser : Form
    {
        public DB_AddNewUser()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // using System.Security.Cryptography
            SHA256 mySHA256 = SHA256Managed.Create();
            // convert string into bytes
            byte[] allBytesP = Encoding.UTF8.GetBytes(PasswordTextBox.Text);
            // compute the hash for the bytes provided
            byte[] hashBytesP = mySHA256.ComputeHash(allBytesP);
            // create a string of hex values for output
            StringBuilder outstringP = new StringBuilder();

            foreach (byte b in hashBytesP)
            {
                outstringP.AppendFormat("{0:x2}", b);
            }


            String ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\DataBase\DatabaseOrderManagerPro.mdf; Integrated Security = True; Connect Timeout = 30";
            using (var connection = new SqlConnection(ConnectionString))

            using (var command = connection.CreateCommand())
            {

                command.CommandText = "insert into Users" +
                    "([Name],[Group],[Password])" +
                    " values " +
                    "(@Name,@Group,@Password)";

                //command.Parameters.AddWithValue("@DateAndTimeCreated", DateTime.Now);
                command.Parameters.AddWithValue("@Name", UserNameTextBox.Text);
                command.Parameters.AddWithValue("@Group", GroupTextBox.Text);
                command.Parameters.AddWithValue("@Password", outstringP.ToString());



                connection.Open();

                command.ExecuteNonQuery();
                connection.Dispose();
                connection.Close();

                MessageBox.Show("New User Added");


            }
        }






















    }
}
