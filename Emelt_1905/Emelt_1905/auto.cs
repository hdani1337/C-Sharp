using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emelt_1905
{
    public class auto
    {
        public int nap { get; set; }
        public string ido { get; set; }
        public string rendszam { get; set; }
        public int azonosito { get; set; }
        public int km { get; set; }
        public bool kibe { get; set; }

        private string[] adatok;
        private int temp;

        public auto(string sor)
        {
            adatok = sor.Split(' ');

            temp = 0;
            Int32.TryParse(adatok[0], out temp);
            nap = temp;
            temp = 0;

            ido = adatok[1];
            rendszam = adatok[2];

            Int32.TryParse(adatok[3], out temp);
            azonosito = temp;
            temp = 0;

            Int32.TryParse(adatok[4], out temp);
            km = temp;
            temp = 0;

            if (adatok[5] == "0") kibe = false;
            else kibe = true;
        }

        public override string ToString()
        {
            string s = kibe ? "be" : "ki";
            return ido + " " + rendszam + " " + azonosito + " " + s;
        }
    }
}
