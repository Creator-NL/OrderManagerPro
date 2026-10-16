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
    public partial class DB_EditUser : Form
    {
        public DB_EditUser()
        {
            InitializeComponent();
        }




        //DataTable dt;
        private void DB_EditUser_Load(object sender, EventArgs e)
        {
            LoadGridView();
            //dt = new DataTable();
            //EditUserDataGridView.DataSource = dt;
        }

        #region LoadGridView
        private void LoadGridView()
        {
            string constring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\DataBase\DatabaseOrderManagerPro.mdf; Integrated Security = True; Connect Timeout = 30";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Users", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            //dt.Columns.Add("Inquiry", typeof(Button));
                            EditUserDataGridView.DataSource = dt;
                        }
                    }
                }
            }


            EditUserDataGridView.Columns["ID"].Visible = false;


            foreach (DataGridViewRow row in EditUserDataGridView.Rows)
            {
                EditUserDataGridView.Rows[row.Index].Cells[0].Value = row.Cells[1].Value;

            }

            EditUserDataGridView.Columns["EditUserButton"].DisplayIndex = 5;




            //EditUserDataGridView.Columns["EditButton"].DisplayIndex = 3;
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




    }
}
