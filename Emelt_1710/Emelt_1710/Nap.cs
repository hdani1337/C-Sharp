using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emelt_1710
{
    public class Nap
    {
        public int honap { get; set; }
        public int nap { get; set; }
        public List<string> hianyzok { get; set; }

        public Nap(string napHonap)
        {
            int temp = 0;
            Int32.TryParse(napHonap.Substring(2, 2), out temp);
            honap = temp;

            Int32.TryParse(napHonap.Substring(5, 2), out temp);
            nap = temp;

            hianyzok = new List<string>();
        }

        public void addHianyzo(string sor)
        {
            hianyzok.Add(sor);
        }
    }
}
