using System;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Views.HomeForm.HomeMembreProjet.Form;
using Views.LoginForm;

namespace Views.HomeForm.HomeMembreProjet
{
    public partial class MembreProjetForm : System.Windows.Forms.Form
    {

        public MembreProjetForm()
        {
            InitializeComponent();
            CustomizedPanLan();
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

            #region btnSidebar location

            btnHome.Location = new Point(8,230);
            btnTache.Location = new Point(8, 310);
            btnChat.Location = new Point(8, 390);
            btnSendMail.Location = new Point(8, 470);
            btnLangue.Location = new Point(8, 550);
            panLangue.Location = new Point(39, 593);

            #endregion

            btnLangue.Enabled = false;
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

            #region btnSidebar location

            btnHome.Location = new Point(8, 209);
            btnTache.Location = new Point(8, 253);
            btnChat.Location = new Point(8, 297);
            btnSendMail.Location = new Point(8, 341);
            btnLangue.Location = new Point(8, 408);
            panLangue.Location = new Point(39, 451);

            #endregion

            btnLangue.Enabled = true;
        }

        #endregion


        private void BtnTache_Click(object sender, EventArgs e)
        {
            HideSubmenu();
        }

        private void BtnChat_Click(object sender, EventArgs e)
        {
           HideSubmenu();
           if (btnMaximized.Enabled)
           {
               btnMaximized.Enabled = false;
           }
           else
               btnMaximized.Enabled = true;
           OnChildForm(new ChatForm());
        }

        private void BtnSendMail_Click(object sender, EventArgs e)
        {
            HideSubmenu();
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
            //ResourceManager rm = new ResourceManager("Views.ResourcesLanguage.String",
            //    Assembly.GetExecutingAssembly());
            //Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("en");
            //btnHome.Text = rm.GetString("Accueil", new CultureInfo("fr"));
            //MessageBox.Show(Thread.CurrentThread.CurrentUICulture.Name);
        }

        //customized panLange
        private void CustomizedPanLan()
        {
            panLangue.Visible = false;
        }

        //hide sous menu
        private void HideSubmenu()
        {
            if (panLangue.Visible)
                panLangue.Visible = false;

        }

        //show submenu
        private void ShowSubmenu(Panel subMenuName)
        {
            if (subMenuName.Visible == false)
            {
                HideSubmenu();
                subMenuName.Visible = true;
            }
            else
                subMenuName.Visible = false;
        }

        #region action bouton langue

        private void BtnLangue_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panLangue);
        }

        private void BtnFrancais_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr");
            this.Controls.Clear();
            InitializeComponent();
            HideSubmenu();
        }

        private void BtnAnglais_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            this.Controls.Clear();
            InitializeComponent();
            HideSubmenu();
        }

        #endregion

        private void BtnHome_Click(object sender, EventArgs e)
        {
            HideSubmenu();
            OnChildForm(new AccueilFormMember());
        }


        //method to open form in panel
        private System.Windows.Forms.Form activForm = null;
        private void OnChildForm(System.Windows.Forms.Form childForm)
        {
            if (activForm != null)
            {
                activForm.Close();
            }

            activForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void PanelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}