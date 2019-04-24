using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negyedik
{
    class Program
    {

        Program()
        {
            //alapok();
            //fuggvenyek();
            feladat();
        }

        public void alapok()
        {
            String s = "";//Szöveg karakterek sorozata

            String nev = "Horváth Dániel";

            char karakter = 'M';//Egy karakter tárolása

            int hossz = nev.Length;//String hossza

            for (int i = 0; i < hossz; i++)
            {
                Console.WriteLine(nev[i]);//Név i-edik eleme
            }

            //Szöveg és karakter egyezőség vizsgálata
            String nev2 = nev;

            bool egyezes = (nev.Equals(nev2));
            Console.WriteLine(egyezes);

            //Karakter esetében az ASCII kódot vizsgálja
            char h = 'H';//72 ASCII-ben
            egyezes = (h == karakter);
            Console.WriteLine(egyezes);
        }

        public void fuggvenyek()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Kérek csúnyán egy mondatot, ami minimum 5 hosszú!");
            Console.Write("==> ");
            Console.ForegroundColor = ConsoleColor.Green;
            String valasz = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;

            //Hossz
            Console.WriteLine("Szöveg hossza: " + valasz.Length);

            //Kisbetűs
            Console.WriteLine("Szöveg kicsin: " + valasz.ToLower());

            //Nagybetűs
            Console.WriteLine("Szöveg nagyban: " + valasz.ToUpper());

            //Tartalmazza
            Console.WriteLine("Benne van a keksz? " + valasz.Contains("keksz"));

            //IndexOf
            Console.WriteLine("'Dániel' hányadik helyen: " + valasz.IndexOf("Dániel"));

            //Substring rész szöveg, szöveg levágása az x-edik karaktertől, második paraméter pedig az hogy milyen hosszan
            Console.WriteLine("Szöveg az ötödik karaktertől: " + valasz.Substring(5));
        }

        public void feladat()
        {
            //Mondat bekérése, majd minden 'a' és 'e' karakter helyett ':'-t írunk

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Kérek szépen egy mondatot!");
            Console.Write("==> ");

            Console.ForegroundColor = ConsoleColor.Green;
            String valasz = Console.ReadLine();

            String temp = "";

            for (int i = 0; i < valasz.Length; i++)
            {
                char aktualis = valasz[i];

                if (valasz[i] == 'a' || valasz[i] == 'e')
                {
                    aktualis = ':';
                }
                temp += aktualis;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("A válaszod 'a' és 'e' karakterei kicserélve");
            Console.Write("==> ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(temp);

            //Minden magánhangzó helyére *
            String maganh = "aáeéiíuúüűoóöő";

            temp = "";

            for (int i = 0; i < valasz.Length; i++)
            {

                if (maganh.Contains(valasz[i])) temp += '*';
                else temp += valasz[i];
            }

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("A válaszod magánhangzói kicserélve");
            Console.Write("==> ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(temp);

            //Minden mássalhangzó helyére kérdőjel

            temp = "";

            for (int i = 0; i < valasz.Length; i++)
            {

                if (!maganh.Contains(valasz[i]) && valasz[i] != ' ') temp += '?';
                else temp += valasz[i];
            }

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("A válaszod mássalhangzói kicserélve");
            Console.Write("==> ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(temp);
        }

        static void Main(string[] args)
        {
            new Program();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nNyomj egy gombot a kilépéshez...");
            Console.ReadKey();
        }
    }
}
