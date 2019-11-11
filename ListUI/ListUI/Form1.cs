using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int count = 0;

            foreach (var k in tlpTop.Controls)
            {
                if (k is Button)
                {
                    count++;
                    (k as Button).BackColor = Color.Green;
                    (k as Button).Name = "btnFeladat_" + count;
                    (k as Button).Text = count + ". gomb";
                }
                
            }
        }

        private void tlpMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
