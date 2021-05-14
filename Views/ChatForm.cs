using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class ChatForm : Form
    {
        public ChatForm()
        {
            InitializeComponent();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            Send();
        }

        void Send()
        {
            if (txtMessage.Text.Trim().Length == 0) return;
            MessageSortant(txtMessage.Text);
            txtMessage.Text = string.Empty;

            //get random message
            lblStatus.Text = $"Entrain d' écrire";
            timer1.Start();
        }

        private int cvrTop = 10;
        void MessageEntrant(string message)
        {
            var bubble = new Controls.MessageEntrant();
            panContainer.Controls.Add(bubble);
            //bubble.Top = cvrTop;//
            bubble.BringToFront();
            //bubble.Width = panContainer.Width - 10;//
            bubble.Dock = DockStyle.Top;
            bubble.Message = message;
           // cvrTop += bubble.Height;//
        }

        void MessageSortant(string message)
        {
            var bubble = new Controls.MessageSortant();
            panContainer.Controls.Add(bubble);
            //bubble.Top = cvrTop;//
            bubble.BringToFront();
            //bubble.Width = panContainer.Width - 20;//
            bubble.Dock = DockStyle.Top;
            bubble.Message = message;
            //cvrTop += bubble.Height;//
        }

        private void TxtMessage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Send();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            lblStatus.Text = "En ligne";
            //sample response
            MessageEntrant("Desole je ne peux te communiquer maintenant");
        }

        private void ChatForm_Shown(object sender, EventArgs e)
        {
            MessageEntrant("Hello " + Environment.UserName + " ,pose moi une question :).");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
