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
    public partial class Registry : Form
    {
        private List<Termek> termekek { get; set; }

        public Registry(List<Termek> termekek)
        {
            InitializeComponent();
            this.termekek = termekek;
        }

        private void Registry_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = termekek;
        }
    }
}
