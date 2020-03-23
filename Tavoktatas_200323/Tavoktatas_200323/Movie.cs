using System;

namespace Tavoktatas_200323
{
    public class Movie
    {
        public string cim { get; set; }
        public int tipusId { get; set; }
        public int hosszPercben { get; set; }
        public int megjelenesiEv{ get; set; }
        public int kategoriaId { get; set; }
        public int ar { get; set; }

        public Movie()
        {
            
        }

        public Movie(string sor)
        {
            int temp = 0;

            cim = sor.Split(';')[0];
            
            Int32.TryParse(sor.Split(';')[1],out temp);
            tipusId = temp;
            
            Int32.TryParse(sor.Split(';')[2],out temp);
            hosszPercben = temp;
            
            Int32.TryParse(sor.Split(';')[3],out temp);
            megjelenesiEv = temp;
            
            Int32.TryParse(sor.Split(';')[4],out temp);
            kategoriaId = temp;
            
            Int32.TryParse(sor.Split(';')[5],out temp);
            ar = temp;
        }

        public override string ToString()
        {
            return $"{cim} - {megjelenesiEv} - {ar}";
        }
    }
}