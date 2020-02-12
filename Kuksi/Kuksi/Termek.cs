using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuksi
{
    public class Termek
    {
        string sor;

        public int id { get; set; }
        public string kategoria { get; set; }
        public string nev { get; set; }
        public int ar { get; set; }
        public int darabszam { get; set; }
        public string datum { get; set; }

        public Termek(string sor) {
            this.sor = sor;

            int temp = 0;
            Int32.TryParse(sor.Split(';')[0], out temp);
            id = temp;

            kategoria = sor.Split(';')[1];

            nev = sor.Split(';')[2];

            Int32.TryParse(sor.Split(';')[3], out temp);
            ar = temp;

            Int32.TryParse(sor.Split(';')[4], out temp);
            darabszam = temp;

            datum = sor.Split(';')[6];
        }
    }
}
