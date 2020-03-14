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
        public frmMain()
        {
            InitializeComponent();
        }

        public static List<Termek> termekek;

        private void adatokBetoltese() {
            try
            {
                termekek = new List<Termek>();
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

        private void button3_Click(object sender, EventArgs e)
        {
            //ADD
            List<string> categories = new List<string>();
            for (int i = 0; i < termekek.Count; i++)
            {
                if (!categories.Contains(termekek[i].kategoria)) categories.Add(termekek[i].kategoria);
            }
            Add add = new Add(categories);         
            add.ShowDialog();
            adatokBetoltese();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Visible = false;
            ShopLogin shopLogin = new ShopLogin();
            shopLogin.Show();
        }
    }
}
