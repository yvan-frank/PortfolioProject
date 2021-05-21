using System;
using System.Windows.Forms;
using Views.HomeForm.HomeAdmin.FormAdmin;
namespace Views.HomeForm.HomeAdmin
{
    public partial class HomeAdministrator : Form
    {
        
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
            LabelStatus("Gérer vos utilisateurs");
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
            LabelStatus("Vous êtes à l'accueil  :)");
        }

        private void BtnDeconnexion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vraiment sortir?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGesProjet_Click(object sender, EventArgs e)
        {
        }
    }
}
