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

        //private void SendPword()
        //{
        //    var sendPassword = admin.SendEmailPasswordToUser(txtEmail.Text,
        //        txtIdenti.Text, txtMdp.Text);
        //    MsgSuccess(sendPassword);
        //}

        //save users in database

        //save data
        private void SaveData()
        {
            try
            {
                JavaScript();
                if (txtNom.Text != "" && txtProfil.Text != "" && txtPrenom.Text != "" && 
                    txtEmail.Text != "" && txtAdress.Text != "" && txtFonction.Text != "" && 
                    txtTel.Text != "" && txtIdenti.Text != "" )
                {
                    admin.AddUser(txtNom.Text, txtPrenom.Text, txtEmail.Text,
                        txtTel.Text,
                        txtAdress.Text, txtIdenti.Text, txtMdp.Text,
                        txtProfil.SelectedIndex + 1);
                    //Thread thread = new Thread(new ThreadStart(Sendpword));
                    //thread.Start();
                    MsgError("insertion ok  ");
                    FieldInit();
                }
            }
            catch (Exception e)
            {
               MsgError(e.Message);
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
            txtProfil.SelectedIndex = -1;
        }

        //method to show error message
        private void MsgError(string errorMess)
        {
            txterror.Text = errorMess;
            txterror.Visible = true;
            txterror.BackColor = Color.DarkRed;
            txterror.ForeColor = Color.AliceBlue;
        }

        //javascript :) :)
        private void JavaScript()
        {
            txtNom.BorderColor = txtNom.Text == "" ? Color.DarkRed : Color.FromArgb(213, 218, 223);
            txtPrenom.BorderColor = txtPrenom.Text == "" ? Color.DarkRed : Color.FromArgb(213, 218, 223);
            txtEmail.BorderColor = txtEmail.Text == "" ? Color.DarkRed : Color.FromArgb(213, 218, 223);
            txtAdress.BorderColor = txtAdress.Text == "" ? Color.DarkRed : Color.FromArgb(213, 218, 223);
            txtTel.BorderColor = txtTel.Text == string.Empty ? Color.DarkRed : Color.FromArgb(213, 218, 223);
            txtFonction.BorderColor = txtFonction.Text == "" ? Color.DarkRed : Color.FromArgb(213, 218, 223);
            txtIdenti.BorderColor = txtIdenti.Text == "" ? Color.DarkRed : Color.FromArgb(213, 218, 223);
            txtProfil.BorderColor = txtProfil.Text == "" ? Color.DarkRed : Color.FromArgb(213, 218, 223);
        }


        //private void MsgSuccess(string errorMess)
        //{
        //    txterror.Text = errorMess;
        //    txterror.Visible = true;
        //    txterror.FillColor = Color.Aqua;
        //    txterror.ForeColor = Color.AliceBlue;
        //}

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void Txterror_Click(object sender, EventArgs e)
        {

        }
    }
}
