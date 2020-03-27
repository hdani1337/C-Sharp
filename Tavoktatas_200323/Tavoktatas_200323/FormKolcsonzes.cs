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
    }
}