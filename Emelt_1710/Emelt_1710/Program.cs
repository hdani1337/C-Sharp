using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Emelt_1710
{
    class Program
    {
        private Program()
        {
            beolvasas();//1. feladat
            osszesHianyzas();//2. feladat
            igazoltIgazolatlan();//3. feladat
            napBekeres();//5. feladat
            bekertNapHianyzasai();//6. feladat
            legtobbetHianyoztak();//7. feladat

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nNyomjon egy gombot a kilépéshez...");
        }

        private List<string> sorok = new List<string>();
        private List<Nap> napok = new List<Nap>();      

        private void beolvasas()
        {
            try
            {
                sorok = File.ReadAllLines("naplo.txt", Encoding.UTF8).ToList();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1. feladat:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("naplo.txt sorai beolvasva és eltárolva!");
                Console.WriteLine();
                napokSzetszedese();
            }
            catch (FileNotFoundException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("naplo.txt nem található!");
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        private void napokSzetszedese()
        {
            for (int i = 0; i < sorok.Count; i++)
            {
                if (sorok[i].Substring(0, 1) == "#") napok.Add(new Nap(sorok[i]));
                else napok.Last().addHianyzo(sorok[i]);
            }
        }

        private void osszesHianyzas()
        {
            int hianyzasok = 0;

            for (int i = 0; i < napok.Count; i++)
                hianyzasok += napok[i].hianyzok.Count;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("2. feladat:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("A naplóban összesen " + hianyzasok + " darab bejegyzés van.");
            Console.WriteLine();
        }

        private void igazoltIgazolatlan()
        {
            List<string> orak = new List<string>();

            for (int i = 0; i < napok.Count; i++)
            {
                for (int j = 0; j < napok[i].hianyzok.Count; j++)
                {
                    orak.Add(napok[i].hianyzok[j].Substring(napok[i].hianyzok[j].LastIndexOf(' ')+1));
                }
            }

            int igazolt = 0;
            int igazolatlan = 0;

            for (int oraszam = 0; oraszam < orak.Count; oraszam++)
            {
                for (int hianyzasTipus = 0; hianyzasTipus < orak[oraszam].Length; hianyzasTipus++)
                {
                    if (orak[oraszam][hianyzasTipus] == 'X') igazolt++;
                    else if (orak[oraszam][hianyzasTipus] == 'I') igazolatlan++;
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("3. feladat:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Az igazolt hiányzások száma" + igazolt + ", az igazolatlanoké " + igazolatlan + " óra.");
            Console.WriteLine();
        }

        private string melyikNap(int honap, int nap)
        {
            string[] napokNevei = { "vasárnap", "hétfő", "kedd", "szerda", "csütörtök", "péntek", "szombat" };
            int[] honapokKezdetei = { 0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 335 };

            int napsorszam = (honapokKezdetei[honap - 1] + nap) % 7;
              
            return napokNevei[napsorszam];
        }


        private List<Nap> melyikNap(string napNeve)
        {
            List<Nap> temp = new List<Nap>();

            for (int i = 0; i < napok.Count; i++)
            {
                if (melyikNap(napok[i].honap, napok[i].nap) == napNeve) temp.Add(napok[i]);
            }

            return temp;
        }

        private void bekertNapHianyzasai()
        {
            string napNeve;
            int oraSzama;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("6. feladat:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Kérek szépen egy napot: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            napNeve = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Kérek szépen egy óraszámot: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Int32.TryParse(Console.ReadLine(), out oraSzama);

            int hianyzasok = 0;

            List<Nap> arraEsoNapok = melyikNap(napNeve);

            for (int i = 0; i < arraEsoNapok.Count; i++)
            {
                for (int j = 0; j < arraEsoNapok[i].hianyzok.Count; j++)
                {
                    string ora = arraEsoNapok[i].hianyzok[j].Substring(arraEsoNapok[i].hianyzok[j].LastIndexOf(' ') + 1);
                    if (ora[oraSzama - 1] == 'X' || ora[oraSzama - 1] == 'I') hianyzasok++;
                }               
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("A " + napNeve + "i napokon összesen " + hianyzasok + " hiányzás történt.");
            Console.WriteLine();
        }

        private void napBekeres()
        {
            int nap;
            int honap;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("5. feladat");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Kérek szépen egy hónapot: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Int32.TryParse(Console.ReadLine(), out honap);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Köszönöm, most pedig kérek egy napot: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Int32.TryParse(Console.ReadLine(), out nap);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Az ön által megadott nap " + melyikNap(honap,nap) + "i napra esett.");
            Console.WriteLine();
        }

        private void legtobbetHianyoztak()
        {
            List<string> diakNevek = new List<string>();
            List<int> diakokHianyzasai = new List<int>();

            for (int i = 0; i < napok.Count; i++)
            {
                for (int j = 0; j < napok[i].hianyzok.Count; j++)
                {
                    string nev = napok[i].hianyzok[j].Substring(0, napok[i].hianyzok[j].LastIndexOf(' '));
                    if (!diakNevek.Contains(nev))
                    {
                        diakNevek.Add(nev);//Egyedi nevek kiszűrése
                        diakokHianyzasai.Add(0);//Kezdeti hiányzási érték
                    }
                }                
            }

            for (int jelenlegiDiak = 0; jelenlegiDiak < diakNevek.Count; jelenlegiDiak++)
            {
                for (int vizsgaltNap = 0; vizsgaltNap < napok.Count; vizsgaltNap++)
                {
                    for (int vizsgaltHianyzas = 0; vizsgaltHianyzas < napok[vizsgaltNap].hianyzok.Count; vizsgaltHianyzas++)
                    {
                        string nev = napok[vizsgaltNap].hianyzok[vizsgaltHianyzas].Substring(0, napok[vizsgaltNap].hianyzok[vizsgaltHianyzas].LastIndexOf(' '));
                        string hianyzasok = napok[vizsgaltNap].hianyzok[vizsgaltHianyzas].Substring(napok[vizsgaltNap].hianyzok[vizsgaltHianyzas].LastIndexOf(' '));

                        for (int orak = 0; orak < hianyzasok.Length; orak++)
                        {
                            if (nev == diakNevek[jelenlegiDiak])
                            {
                                if (hianyzasok[orak] == 'I' || hianyzasok[orak] == 'X') diakokHianyzasai[jelenlegiDiak]++;
                            }
                            else break;
                        }
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("7. feladat:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("A legtöbbet hiányzó tanulók a következők: ");

            Console.ForegroundColor = ConsoleColor.Cyan;
            List<int> maxIndexek = new List<int>();
            for (int i = 0; i < diakokHianyzasai.Count; i++)
                if (diakokHianyzasai[i] == diakokHianyzasai.Max()) maxIndexek.Add(i);

            for (int i = 0; i < maxIndexek.Count; i++)
                Console.WriteLine(diakNevek[maxIndexek[i]]);
            
        }

        static void Main(string[] args)
        {
            new Program();
            Console.ReadKey();
        }
    }
}
