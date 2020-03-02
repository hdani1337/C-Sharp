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
    public partial class Add : Form
    {
        public List<string> categories;

        public Add(List<string> categories)
        {
            InitializeComponent();
            this.categories = categories;
            this.categories.Sort();
            cboTipus.DataSource = this.categories;
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

        private void btnFelvetel_Click(object sender, EventArgs e)
        {
            string sor = "";

            bool hiba = false;

            //ELŐSZÖR MAJD AZ ID KELL
            sor += File.ReadAllLines("Termekek.csv", Encoding.UTF8).ToList().Count+1 + ";";

            //KIVÁLASZTOTT KATEGÓRIA
            sor += cboTipus.SelectedValue + ";";

            //TERMÉK NEVE
            sor += txtNev.Text + ";";
            if (txtNev.Text.Length == 0)
            {
                hiba = true;
                MessageBox.Show("Adja meg a termék nevét!");
            }
            else
            {
                //TERMÉK ÁRA
                sor += mtAr.Text + ";";

                //HIBAKERESÉS
                int temp = 0;
                Int32.TryParse(mtAr.Text.Trim().Substring(0,mtAr.Text.Trim().Length-2), out temp);

                if (temp == 0)
                {
                    hiba = true;
                    MessageBox.Show("Adja meg a termék árát!");                   
                }
                else
                {

                    //TERMÉK DARABSZÁMA
                    sor += mtRaktar.Text + ";";

                    //HIBAKERESÉS
                    Int32.TryParse(mtRaktar.Text.Trim().Substring(0, mtRaktar.Text.Trim().Length - 2), out temp);

                    if (temp == 0)
                    {
                        hiba = true;
                        MessageBox.Show("Adja meg a termék raktáron lévő darabszámát!");
                    }
                    else
                    {

                        //NAPLÓZÁS DÁTUMA
                        sor += mtDatum.Text;

                        File.AppendAllText("Termekek.csv", sor);
                        MessageBox.Show("A termék adatai sikeresen elmentve!");
                    }
                }
            }

           
        }
    }
}
