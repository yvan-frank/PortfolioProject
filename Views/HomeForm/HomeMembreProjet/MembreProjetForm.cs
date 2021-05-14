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
using Guna.UI2.WinForms.Enums;

namespace Views.HomeForm.HomeMembreProjet
{
    public partial class MembreProjetForm : Form
    {
        public MembreProjetForm()
        {
            InitializeComponent();
        }


        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        #region button de controle
        private void BtnDeco_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestore.Visible = true;
            btnMaximized.Visible = false;
        }

        private void BtnReduire_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximized.Visible = true;
            btnRestore.Visible = false;
        }

        #endregion


        private void BtnTache_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnChat_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnSendMail_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnClose_MouseDown(object sender, MouseEventArgs e)
        {
            btnClose.BackColor = Color.DarkRed;
        }

        private void PanbtnClo_MouseHover(object sender, EventArgs e)
        {
            panbtnClo.BackColor = Color.DarkRed;
        }

        private void PanbtnClo_MouseLeave(object sender, EventArgs e)
        {
            panbtnClo.BackColor = Color.White;
        }

        private void MembreProjetForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Thread.CurrentThread.CurrentUICulture.Name);
        }
    }
}
