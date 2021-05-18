using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views.HomeForm.HomeAdmin;

namespace Views.LoginForm
{
    public partial class Login : Form
    {
        HomeAdministrator homeAdministrator = new HomeAdministrator();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "vans" && txtPassword.Text == "vans")
            {
                timer1.Start();
                loadingControl1.Visible = true;
                etatFormLogin();
                homeAdministrator.FormClosed += Logout;
            }
            else
            {
                loadingControl1.Visible = false;
                btnLogin.Visible = true;
            }
            
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            this.Show();
        }


        private void etatFormLogin()
        {
            
            btnLogin.Visible = false;
        }

        private void TxtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void TxtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == string.Empty)
            {
                txtUsername.Text = "Username";
            }
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = string.Empty;
            }
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == string.Empty)
            {
                txtPassword.Text = "Password";
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
                Thread.Sleep(200);
               
                homeAdministrator.Show();
                this.Hide();
            }
        }
    }
}
