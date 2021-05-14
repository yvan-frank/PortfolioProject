using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using Guna.UI2.WinForms;

namespace Views.Chat
{
    class Utiles
    {
        public static int GetTextHeight(Label label)
        {
             
            using (Graphics g = label.CreateGraphics())
            {
                SizeF size = g.MeasureString(label.Text, label.Font, 495);
                return (int) Math.Ceiling(size.Height);
            }
        }
    }
}
