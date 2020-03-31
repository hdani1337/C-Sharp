using System;

namespace Beadandó_200417
{
    public class Kituntetes
    {
        public int azonosito { get; set; }
        public int szemelyAzonosito { get; set; }
        public int ev { get; set; }

        public Kituntetes(string sor)
        {
            int temp = 0;

            Int32.TryParse(sor.Split('\t')[0], out temp);
            azonosito = temp;
            
            Int32.TryParse(sor.Split('\t')[1], out temp);
            szemelyAzonosito = temp;
            
            Int32.TryParse(sor.Split('\t')[2], out temp);
            ev = temp;
        }
    }
}