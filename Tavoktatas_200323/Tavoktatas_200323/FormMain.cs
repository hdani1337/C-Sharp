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
    public partial class Form1 : Form
    {
        public List<Movie> filmek = null;
        public Form1()
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
                    for (int i = 0; i < 1000; i++)
                    {
                        lbMovie.Items.Add(filmek[i]);
                    }
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
    }
}