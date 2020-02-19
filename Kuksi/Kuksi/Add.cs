using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuksi
{
    public partial class Add : Form
    {
        public List<string> categories;

        public Add(List<string> categories)
        {
            InitializeComponent();
            this.categories = categories;
        }

        private void Add_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tlpAddMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
