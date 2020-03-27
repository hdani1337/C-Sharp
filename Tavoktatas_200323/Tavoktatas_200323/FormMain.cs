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

namespace Tavoktatas_200323
{
    public partial class FormMain : Form
    {
        public List<Movie> filmek = null;
        public FormMain()
        {
            InitializeComponent();
            adatokBetoltese();
        }

        private void adatokBetoltese()
        {
            try
            {
                filmek = new List<Movie>();

                foreach (string sor in File.ReadAllLines("Movie.csv", Encoding.UTF8).ToList())
                    filmek.Add(new Movie(sor));

                if (filmek != null)
                {
                    dgwFilmek.DataSource = filmek;
                }
                else throw new NullReferenceException();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Movie.csv nem található!");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Az adatok beolvasása sikertelen volt.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormKolcsonzes formKolcsonzes = new FormKolcsonzes(filmek);
            formKolcsonzes.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}