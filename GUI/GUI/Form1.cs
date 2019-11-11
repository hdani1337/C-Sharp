using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class formMain : Form
    {
        int alpha, red, green, blue = 0;

        public formMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            lRed.Text = "Red: 0";
            lBlue.Text = "Blue: 0";
            lGreen.Text = "Green: 0";
            this.BackColor = Color.Black;
        }

        private void vscRed_Scroll(object sender, ScrollEventArgs e)
        {
            red = (255 - e.NewValue);            
            update();
        }

        private void vscGreen_Scroll(object sender, ScrollEventArgs e)
        {
            green = (255 - e.NewValue);            
            update();
        }

        private void vscRed_Scroll_1(object sender, ScrollEventArgs e)
        {
            blue = (255 - e.NewValue);          
            update();
        }

        private void update()
        {
            this.BackColor = Color.FromArgb(red, green, blue);
            lBlue.Text = "Blue: " + blue;
            lGreen.Text = "Green: " + green;
            lRed.Text = "Red: " + red;
        }
    }
}
