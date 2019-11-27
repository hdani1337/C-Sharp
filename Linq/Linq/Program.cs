using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Linq
{
    class Program
    {
        List<string> lista = new List<string>();

        Program()
        {
            bevezetes();
        }

        void bevezetes()
        {
            try
            {
                lista = File.ReadAllLines("szinesz.txt", Encoding.UTF8).Skip(1).ToList();//Fájl beolvasása, első sor kihagyása, átalakítás listává
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Hiba, fájl nem található: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Hiba: " + e.Message);
            }

            if (lista.Count > 0)
            {
                //Hány budapesti van?
                var feladat1 = (from x in lista
                               where x.Contains("Budapest")
                               select x).Count();

                Console.WriteLine(feladat1);

                //Színészek neve abc szerint
                var feladat2 = from y in lista
                               orderby y.Substring(y.IndexOf("\t") + 1, y.IndexOf("\t", y.IndexOf("\t") + 1) - y.IndexOf("\t", 0) + 1)
                               select y.Substring(y.IndexOf("\t") + 1, y.IndexOf("\t", y.IndexOf("\t") + 1) - y.IndexOf("\t", 0));
                foreach (var k in feladat2)
                {
                    Console.WriteLine(k);
                }
            }
        }

        static void Main(string[] args)
        {
            new Program();
            Console.ReadKey();
        }
    }
}
