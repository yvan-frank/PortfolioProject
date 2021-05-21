using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.Controls.AlertControl
{
    public partial class MessageBoxCustom : Form
    {
        private static string lbl_msg;
        private static string lblTire;
        public MessageBoxCustom()
        {
            InitializeComponent();
            lbl_message.Text = lbl_msg;
            lbl_title.Text = lblTire;
        }

        private void Btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal static void Show(string message, string title)
        {
            lbl_msg = message;
            lblTire = title;


            MessageBoxCustom box = new MessageBoxCustom();
            box.Show();
        }
    }
}
