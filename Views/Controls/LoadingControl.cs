using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.Controls
{
    public partial class LoadingControl : UserControl
    {
        public LoadingControl()
        {
            InitializeComponent();
        }

        private int dir;
        private void Tm_stretch_Tick(object sender, EventArgs e)
        {
            if (gunaCircleProgressBar1.Value >= 50)
            {
                //on reduit le preloader
                dir -= 2;
               

            }
            else if(gunaCircleProgressBar1.Value ==10)
            {
                dir += 2;//etendre le preloader
            }

            gunaCircleProgressBar1.Value += dir;
        }

        private void LoadingControl_Load(object sender, EventArgs e)
        {

        }
    }
}
