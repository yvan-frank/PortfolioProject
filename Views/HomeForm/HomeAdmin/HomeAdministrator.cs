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
using Views.HomeForm.HomeMembreProjet.Form;

namespace Views.HomeForm.HomeAdmin
{
    public partial class HomeAdministrator : Form
    {
        private delegate void ActualizseLog(EventArgs e);
        public HomeAdministrator()
        {
            InitializeComponent();
        }


        private void HomeAdministrator_Load(object sender, EventArgs e)
        {
            lblAdmin.Text = Environment.UserName;
        }

        private Form activForm = null;
        private void OnChildForm(Form childForm)
        {
            if (activForm != null)
            {
                activForm.Close();
            }

            activForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void BtnGestUsers_Click(object sender, EventArgs e)
        {
            OnChildForm(new UserGroup());
            LabelStatus("Gestion d'utilisateur");
        }

        private void LabelStatus(string comment)
        {
            lblStatusButton.Text = comment;
            lblStatusButton.Visible = true;
        }

        private void PanelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            LabelStatus("Accueil");
        }

    }
}
