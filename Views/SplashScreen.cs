using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using Views.LoginForm;


namespace Views
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
           timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            panSlide.Left += 2;
            if (panSlide.Left > 450)
            {
                
                panSlide.Left = 250;
                Thread.Sleep(3000);

            }

            if (panSlide.Left == 250)
            {
                timer1.Stop();
                Login login = new Login();
                login.Show();
                this.Hide();


            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
