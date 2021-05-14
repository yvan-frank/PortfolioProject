using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views.Chat;

namespace Views.Controls
{
    public partial class MessageEntrant : UserControl
    {
        public MessageEntrant()
        {
            InitializeComponent();
        }

        public string Message
        {
            get => label1.Text;

            set
            {
                label1.Text = value;
                AjustHeight();
            }
        }

        void AjustHeight()
        {
            guna2CirclePictureBox1.Location = new Point(4, 3);
            label1.Height = Utiles.GetTextHeight(label1) + 10;

            panel1.Height = label1.Top + guna2CirclePictureBox1.Top + label1.Height;

            this.Height = panel1.Bottom + 10;
        }

        public Image Avatar { get => guna2CirclePictureBox1.Image; set => guna2CirclePictureBox1.Image = value; }

        private void MessageEntrant_Resize(object sender, EventArgs e)
        {
            AjustHeight();
        }
    }
}
