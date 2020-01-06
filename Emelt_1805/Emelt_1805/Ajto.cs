using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emelt_1805
{
    public class Ajto
    {
        public int ora { get; set; }
        public int perc { get; set; }
        public int azonosito { get; set; }
        public bool athaladas { get; set; }

        public Ajto(string sor)
        {
            //ÓRA
            int temp = 0;
            Int32.TryParse(sor.Split(' ')[0], out temp);
            this.ora = temp;

            //PERC
            Int32.TryParse(sor.Split(' ')[1], out temp);
            this.perc = temp;

            //AZONOSÍTÓ
            Int32.TryParse(sor.Split(' ')[2], out temp);
            this.azonosito = temp;

            //ÁTHALADÁS
            if (sor.Split(' ')[3] == "be")
            {
                athaladas = true;
                Program.bentvannak++;
            }
            else
            {
                athaladas = false;
                Program.bentvannak--;
            }
        }
    }
}
