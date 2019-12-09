using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Emelt_1905
{
    class Program
    {
        List<string> lista = new List<string>();
        List<auto> autok = new List<auto>();

        private void init()
        {
            try
            {
                lista = File.ReadAllLines("autok.txt", Encoding.UTF8).ToList();//Fájl beolvasása, első sor kihagyása, átalakítás listává

                foreach (string sor in lista)
                {
                    autok.Add(new auto(sor));
                }
            }

            catch (FileNotFoundException e)
            {
                Console.WriteLine("Hiba, fájl nem található: " + e.Message);
            }

            catch (Exception e)
            {
                Console.WriteLine("Hiba: " + e.Message);
            }

        }

        private void feladatok()
        {
            Console.WriteLine("2. feladat");
            var feladat2 = from x in autok
                           where x.kibe == false
                           select x;
            Console.WriteLine(feladat2.Last().nap + ".nap, rendszám: " + feladat2.Last().rendszam);

            Console.WriteLine("3. feladat");
            int nap = 0;
            Console.Write("Nap: ");
            Int32.TryParse(Console.ReadLine(), out nap);
            Console.WriteLine("Forgalom a(z) " + nap + ". napon:");
            var feladat3 = from x in autok
                           where x.nap == nap
                           select x;
            foreach (var item in feladat3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("4. feladat");
            int bement = 0;
            int kiment = 0;
            foreach (var item in autok)
            {
                if (item.kibe == true) kiment++;
                else bement++;
            }
            Console.WriteLine("A hónap végén " + (bement-kiment) + " autót nem hoztak vissza.");
        }

        private Program()
        {
            init();
            feladatok();
        }

        static void Main(string[] args)
        {
            new Program();
            Console.ReadKey();
        }
    }
}
