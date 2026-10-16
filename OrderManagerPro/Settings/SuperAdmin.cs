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
    public partial class SuperAdmin : Form
    {
        public SuperAdmin()
        {
            InitializeComponent();
        }

        private void SA_SetDataBaseButton_Click(object sender, EventArgs e)
        {
            DB_DataBaseSettings DB_DataBaseSettingsForm = new DB_DataBaseSettings();
            DB_DataBaseSettingsForm.ShowDialog();
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            DB_AddNewUser DB_AddNewUserForm = new DB_AddNewUser();
            DB_AddNewUserForm.ShowDialog();
        }
    }
}
