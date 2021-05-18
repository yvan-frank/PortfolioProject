using System;
using System.Drawing;
using System.Windows.Forms;
using Controllers.Admin;

namespace Views.HomeForm.HomeAdmin.FormAdmin
{
    public partial class UserGroup : Form
    {
        
        AdminController admin = new AdminController();
        
        public UserGroup()
        {
            InitializeComponent();
        }

        private void UserGroup_Load(object sender, EventArgs e)
        {
        }

        private void LblUtilsateur_Click(object sender, EventArgs e)
        {
            
        }


        //save users in database
        private void SaveUser()
        {
            if (txtNom.Text != string.Empty && txtPrenom.Text != string.Empty && txtEmail.Text != string.Empty &&
                txtTel.Text != string.Empty && txtAdress.Text != string.Empty && txtIdenti.Text != string.Empty &&
                txtMdp.Text != string.Empty)
            {
                try
                {
                    admin.AddUser(txtNom.Text, txtPrenom.Text, txtEmail.Text, txtTel.Text, txtAdress.Text,
                        txtIdenti.Text, txtMdp.Text, txtProfil.SelectedIndex + 1);
                    FieldInit();
                }
                catch (Exception e)
                {
                   MsgError(e.Message);
                }
            }
            else
            {
                MsgError("Fill all the field, please!");
            }
        }

        private void FieldInit()
        {
            txtNom.Text = string.Empty;
            txtPrenom.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtAdress.Text = string.Empty;
            txtIdenti.Text = string.Empty;
            txtMdp.Text = string.Empty;
            txtProfil.SelectedIndex = 0;
        }

        //method to show error message
        private void MsgError(string errorMess)
        {
            txterror.Text = errorMess;
            txterror.Visible = true;
            txterror.FillColor = Color.DarkRed;
            txterror.ForeColor = Color.AliceBlue;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveUser();
        }
    }
}
