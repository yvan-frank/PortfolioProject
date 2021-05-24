using System;
using System.Windows.Forms;
using Views.Controls.FormAdminControls;

namespace Views.HomeForm.HomeAdmin.FormAdmin
{
    public partial class GestionUser : Form
    {
        public GestionUser()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var add = new AddUserForm();
            add.ShowDialog();
        }

        private void GestionUser_Load(object sender, EventArgs e)
        {
           
        }
    }
}
