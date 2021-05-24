using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.Controls.FormAdminControls
{
    public partial class ShowUserControl : UserControl
    {
        public ShowUserControl()
        {
            InitializeComponent();
        }

        public string Nom
        {
            get => lblNom.Text;
            set => lblNom.Text = value;
        }

        public string Profile
        {
            get => lblProfil.Text;
            set => lblProfil.Text = value;
        }

        public Image PhotoProfile
        {
            get => pc_show_photo.Image;
            set => pc_show_photo.Image = value;
        }

        private void LblCountModule_Click(object sender, EventArgs e)
        {

        }
    }

   
}
