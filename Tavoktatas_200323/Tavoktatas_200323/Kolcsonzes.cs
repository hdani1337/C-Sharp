using System;
using System.Collections.Generic;

namespace Tavoktatas_200323
{
    public static class Kolcsonzes
    {
        public static string azonosito { get; set; }//Kölcsönző azonosítója
        public static List<Movie> filmek { get; set; }//Kölcsönzött filmek listája
        public static string idotartam { get; set; }//Kölcsönzés hossza
        public static int ar { get; set; }//Kölcsönzés ára
        public static DateTime datum { get; set; }//Kölcsönzés kezdete

        public static string ToString()
        {
            return null;
        }

        public static DateTime lejarat()
        {
            if (datum != null)
            {
                int nap = 0;
                
                Int32.TryParse(idotartam.Substring(0,1), out nap);

                if (idotartam.Substring(2,3).Equals("hét"))
                    nap *= 7;
                
                DateTime temp = datum;
                temp.AddDays(nap);
                return temp;
            }
            else throw new NullReferenceException();
        }
        
        public static bool isLejart(){
            return DateTime.Now > lejarat();
        }
    }
}