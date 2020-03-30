using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Tavoktatas_200323
{
    public partial class FormKolcsonzes : Form
    {

        private List<Movie> filmek;
        private List<Movie> talalatok;
        public FormKolcsonzes(List<Movie> filmek)
        {
            InitializeComponent();
            this.filmek = filmek;
            this.talalatok = new List<Movie>();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dgwResults.DataSource = null;
                //Enter lenyomva, keresés
                var t = from x in filmek
                    where x.cim.ToLower().Contains(txtSearch.Text.ToLower())
                    select x;
                talalatok = t.ToList();
                dgwResults.DataSource = talalatok;
            }
        }

        private void dgwResults_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            listSelected.Items.Add(talalatok[e.RowIndex]);
        }

        private void idoDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(idoDrop.Text);
        }

        private void rentButton_Click(object sender, EventArgs e)
        {
            /**
             * Kiválasztott filmek betöltése egy ideiglenes listába
             **/
            List<Movie> temp = new List<Movie>();
            foreach (Object o in listSelected.Items) {//Kiválasztottak lista végigjárása
                if (o is Movie)//Ha a vizsgált objektum egy film
                    temp.Add((Movie) o);//Film típus kényszerítése, hozzáadás a listához
            }

            Kolcsonzes.filmek = temp;
            Kolcsonzes.datum = DateTime.Now;
            Kolcsonzes.idotartam = idoDrop.Text;
            //Kolcsonzes.azonosito = (GENERÁLNI)
        }
    }
}