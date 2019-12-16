using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emelt_1810
{
    public class Kerites
    {
        public bool paros { get; set; }
        public int szelesseg { get; set; }
        public string szin { get; set; }

        public Kerites(string sor)
        {
            if (sor.Split(' ')[0] == "0") paros = true;
            else paros = false;

            int temp;
            Int32.TryParse(sor.Split(' ')[1], out temp);
            szelesseg = temp;

            szin = sor.Split(' ')[2];
        }
    }
}
