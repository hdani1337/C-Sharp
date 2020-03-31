using System;

namespace Beadandó_200417
{
    public class Szemely
    {
        public int azonosito { get; set; }
        public string nev { get; set; }

        public Szemely(string sor)
        {
            int temp = 0;
            Int32.TryParse(sor.Split('\t')[0], out temp);
            azonosito = temp;

            nev = sor.Split('\t')[1];
        }
    }
}