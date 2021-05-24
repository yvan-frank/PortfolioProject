using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views.HomeForm.HomeAdmin.FormAdmin;

namespace Views.HomeForm.HomeAdmin
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }


        private Form _activForm = null;
        private void OnChildForm(Form childForm)
        {
            if (_activForm != null)
            {
                _activForm.Close();
            }

            _activForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panContainer.Controls.Add(childForm);
            panContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void BtnGesuser_Click(object sender, EventArgs e)
        {
            OnChildForm(new GestionUser());
        }

        private void BtnAccueil_Click(object sender, EventArgs e)
        {
            OnChildForm(new AccueilFormAdmin());
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            OnChildForm(new AccueilFormAdmin());
        }
    }
}
