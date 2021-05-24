using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Controllers.Admin;
using Views.Controls.AlertControl;
using Views.HomeForm.HomeAdmin;

namespace Views.LoginForm
{
    public partial class Login : Form
    {
        HomeAdministrator homeAdministrator = new HomeAdministrator();
       // private AdminController adnAdminController = new AdminController();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                //var isLogin = adnAdminController.LoginAdmin(txtUsername.Text, txtPassword.Text);
                //if (isLogin)
                //{
                //    timer1.Start();
                //    pg.Visible = true;
                //    pg.AutoStart = true;
                //    EtatFormLogin();
                //    AlertBox.Show("Connexion reussie!\t:)", AlertBox.AlertType.Success);
                //    homeAdministrator.FormClosed += Logout;
                //}
                //else
                //{
                //   AlertBox.Show("Impossible d'acceder a votre compte, \n Veuillez reessayer", AlertBox.AlertType.Warning);
                //}
            }
            else
            {
                pg.Visible = false;
                btnLogin.Visible = true;
            }
           
            
        }
        //message essor\
        //private void MsgErro(string error)
        //{
        //    lblError.Text = error;
        //    lblError.Visible = true;
        //}
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
            pg.Visible = false;
            btnLogin.Enabled = true;
            timer1.Stop();
            this.Show();
        }


        private void EtatFormLogin()
        {
            
            btnLogin.Enabled = false;
        }

        private void TxtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Pseudo")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void TxtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == string.Empty)
            {
                txtUsername.Text = "Pseudo";
            }
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Mot de passe")
            {
                txtPassword.Text = string.Empty;
            }
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == string.Empty)
            {
                txtPassword.Text = "Mot de passe";
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != string.Empty)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value <= 99)
            {
                progressBar1.Value += 2;
            }

            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                homeAdministrator.Show();
                this.Hide();
            }
        }

        private void Btnfermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
