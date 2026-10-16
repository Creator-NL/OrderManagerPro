using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagerPro
{
    public partial class DB_Users : Form
    {
        public DB_Users()
        {
            InitializeComponent();
        }

        private void AddNewUserButton_Click(object sender, EventArgs e)
        {
            DB_AddNewUser DB_AddNewUserForm = new DB_AddNewUser();
            DB_AddNewUserForm.Show();
        }

        private void EditUserButton_Click(object sender, EventArgs e)
        {
            DB_EditUser DB_EditUserForm = new DB_EditUser();
            DB_EditUserForm.Show();
        }
    }
}
