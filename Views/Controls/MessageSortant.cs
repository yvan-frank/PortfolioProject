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
    public partial class MessageSortant : UserControl
    {
        public MessageSortant()
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
            label1.Height = Utiles.GetTextHeight(label1) + 10;

            panel1.Height = label1.Top + panel1.Top + label1.Height;

            this.Height = panel1.Bottom + 10;
        }

        private void MessageEntrant_Resize(object sender, EventArgs e)
        {
            AjustHeight();
        }
    }
}
