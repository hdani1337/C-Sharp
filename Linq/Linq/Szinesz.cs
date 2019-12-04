using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Szinesz
    {
        public int id { get; set; }
        public string nev { get; set; }
        public string szuletesiNev { get; set; }
        public string valasztas { get; set; }
        public string szuletett { get; set; }
        public string szuletesiHely { get; set; }
        public string elhunyt { get; set; }
        public string halalozasiHely { get; set; }

        public Szinesz(string sor)
        {
            char v = '\v';
            if (sor.Split(v).Length == 8)
            {
                int temp = 0;
                Int32.TryParse(sor.Split(v)[0], out temp);
                id = temp;

                nev = sor.Split(v)[1];            
                szuletesiNev = sor.Split(v)[2];
                valasztas = sor.Split(v)[3];
                szuletett = sor.Split(v)[4];
                szuletesiHely = sor.Split(v)[5];
                elhunyt = sor.Split(v)[6];
                halalozasiHely = sor.Split(v)[7];
            }
        }
    }
}
