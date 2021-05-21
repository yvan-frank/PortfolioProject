using System;
using System.Drawing;
using System.Windows.Forms;

namespace Views.Controls.AlertControl
{
    public partial class AlertBox : Form
    {
        public AlertBox(string message, AlertType type)
        {
            InitializeComponent();
            switch (type)
            {
                case AlertType.Success:
                    this.BackColor = Color.SeaGreen;
                    label1.Text = message;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.BackgroundImage = Image.FromFile("images/icons_success.png");
                    break;
                case AlertType.Info:
                    this.BackColor = Color.FromArgb(0, 188, 213);
                    label1.Text = message;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.BackgroundImage = Image.FromFile("images/icons_info.png");
                    break;
                case AlertType.Warning:
                    this.BackColor = Color.FromArgb(250, 129, 0);
                    label1.Text = message;
                    pictureBox1.BackgroundImage = Image.FromFile("images/icons_warning.png");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case AlertType.Error:
                    this.BackColor = Color.FromArgb(251, 23, 30);
                    label1.Text = message;
                    pictureBox1.BackgroundImage = Image.FromFile("images/icons_error.png");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
        }

        public enum AlertType
        {
            Success, Warning, Info, Error
        } 

        public new enum DialogResult
        {
            Yes = 0, YesNo = -1, No = 1
        }

       

        public static void Show(string message, AlertType type)
        {
            new AlertBox(message, type).Show();
        }
        private void AlertSucce_Load(object sender, EventArgs e)
        {
            this.Top = -1 * this.Height;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 60;

            tim_show.Start();
        }

        private int interval = 0;


        private void Timeout_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tim_show_Tick(object sender, EventArgs e)
        {
            if (this.Top < 60)
            {
                this.Top += interval;
                interval += 1;
            }
            else
            {
                tim_show.Stop();
            }
        }

        private void Tim_close_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.1;
            }
            else
            {
                this.Close();
            }
        }

        private void BtnCloseAlert_Click(object sender, EventArgs e)
        {
            tim_close.Start();
        }
    }
}
