using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuksi
{
    public partial class frmMain : Form
    {
        public float fontSize = 20;

        public frmMain()
        {
            InitializeComponent();
        }

        public List<Termek> termekek = new List<Termek>();

        private void adatokBetoltese() {
            try
            {
                List<string> sorok = File.ReadAllLines("Termekek.csv", Encoding.UTF8).ToList();
                foreach (string sor in sorok) termekek.Add(new Termek(sor));
            }
            catch (Exception e) {
                MessageBox.Show("Hiba: " + e.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            adatokBetoltese();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //REGISTER
            Registry registry = new Registry(termekek);
            registry.ShowDialog();
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            float w = Width;
            float h = Height;

            fontSize = ((w+h) / (450+220.0f)) * 24.0f;
            //Méretváltoztatás
            button1.Font = new Font("Comic Sans MS", fontSize);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ADD
        }
    }
}
