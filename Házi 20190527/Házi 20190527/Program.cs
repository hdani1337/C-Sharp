using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Házi_20190527
{
    class Program
    {
        /*
        *   Programozás feladat 2
        *   Kérj be a felhasználótól két(s1 és s2) mondatot! 
        *   Kérdések:
        *   1. Van-e benne kérdőmondatat, ha igen, melyik az?
        *   2. írd ki, hogy hány darab többjegyű betű szerepel(pl.: sz, cs, gy, dzs) a mondatokban?
        *   3. Hány olyan szó van a mondatokban, amiben egymás után szerepelnek mássalhangzók, melyikben van a legtöbb?
        */

        Program()
        {
            feladat();
        }

        string s1;
        string s2;

        int melyikKerdo;

        int s1Massal = 0;
        int s2Massal = 0;

        int s1EgymasUtan = 0;
        int s2EgymasUtan = 0;

        string massalhangzok = "bcdfghjklmnpqrstvxyz";
        string[] tobbjegyu = { "cs", "dz", "dzs", "gy", "ty", "sz", "zs", "ny" };//gyk ez egy tömb

        void feladat()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Kérek egy mondatot ==> ");
            Console.ForegroundColor = ConsoleColor.Green;
            s1 = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Kérek még egy mondatot ==> ");
            Console.ForegroundColor = ConsoleColor.Green;
            s2 = Console.ReadLine();
         
            melyikKerdoMondat();//1. feladat
            tobbjegyuMassalhangzok();//2. feladat
            egymasUtan();//3. feladat

            kiirasok();
        }

        void kiirasok()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Végeredmény\n");
            Console.ForegroundColor = ConsoleColor.Yellow;

            switch (melyikKerdo)
            {
                case 0:
                    {
                        Console.WriteLine("Egyik sem kérdő mondat.");
                        break;
                    }

                case 1:
                    {
                        Console.WriteLine("Az első mondat kérdő.");
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("A második mondat kérdő.");
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine("Mindkét mondat kérdő.");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Első feladat hibás.");
                        break;
                    }
            }

            Console.WriteLine("Az első mondatban " + s1Massal + " többjegyű mássalhangzó van.");
            Console.WriteLine("Az második mondatban " + s2Massal + " többjegyű mássalhangzó van.");

            Console.WriteLine("Az első mondatban " + s1EgymasUtan + " olyan szó van, ahol több mássalhangzó szerepel egymás után.");
            Console.WriteLine("Az második mondatban " + s2EgymasUtan + " olyan szó van, ahol több mássalhangzó szerepel egymás után.");

            if (s1EgymasUtan > s2EgymasUtan) Console.WriteLine("Az első mondatban több ilyen szó van.");
            else if (s1EgymasUtan < s2EgymasUtan) Console.WriteLine("Az második mondatban több ilyen szó van.");
            else if (s1EgymasUtan == s2EgymasUtan) Console.WriteLine("Mindkét mondatban ugyanennyi ilyen szó van.");
        }

        void egymasUtan()
        {//kicsit bonyolult, de működik      
            string temp = "";

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == ' ' || i == s1.Length-1)
                {//ugyanúgy szavanként vizsgálunk meg mindent
                    if (i == s1.Length-1) temp += s1.ToLower()[i];//hogyha a mondat végére értünk, akkor adjuk hozzá az utolsó betűt, mert az else ág nem fut le

                    for (int k = 0; k < temp.Length; k++)
                    {//magát a szót járjuk be
                        if (k < temp.Length - 1)
                        {//ha nem az utolsó betűnél vagyunk
                            if (massalhangzok.Contains(temp[k]))//ha a k-dik betű mássalhangzó
                                if (massalhangzok.Contains(temp[k+1]))//ha a k utáni betű is mássalhangzó
                                {//ez a többjegyű mássalhangzókat is belefogja számolni
                                    s1EgymasUtan++;
                                    break;//kilépés a ciklusból, nincs értelme tovább futtatni, mivel csak a szavak száma kell
                                }                            
                        }                       
                    }

                    temp = "";
                }

                else temp += s1.ToLower()[i];
            }

            temp = "";

            for (int i = 0; i < s2.Length; i++)
            {
                if (i == s2.Length - 1) temp += s2.ToLower()[i];

                if (s2[i] == ' ' || i == s2.Length - 1)
                {
                    for (int k = 0; k < temp.Length; k++)
                    {
                        if (k < temp.Length-1)
                        {
                            if (massalhangzok.Contains(temp[k]))
                                if (massalhangzok.Contains(temp[k+1]))
                                {                                  
                                    s2EgymasUtan++;
                                    break;
                                }
                        }                       
                    }

                    temp = "";
                }

                else temp += s2.ToLower()[i];
            }

        }

        void tobbjegyuMassalhangzok()
        {//sokkal egyszerűbb tömbbel...
            for (int i = 0; i < tobbjegyu.Length; i++)
            {
                if (s1.ToLower().Contains(tobbjegyu[i])) s1Massal++;
                else if (s2.ToLower().Contains(tobbjegyu[i])) s2Massal++;
            }
        }

        void melyikKerdoMondat()
        {//még esetleg a kérdőszavakat is meglehet vizsgálni, például ki, milyen, hány, stb..         
            if (s1.Contains('?') && !s2.Contains('?')) melyikKerdo = 1;
            else if (!s1.Contains('?') && s2.Contains('?')) melyikKerdo = 2;
            else if (s1.Contains('?') && s2.Contains('?')) melyikKerdo = 3;
            else melyikKerdo = 0;
        }

        static void Main(string[] args)
        {
            new Program();
            Console.WriteLine("\nNyomj egy gombot a kilépéshez...");
            Console.ReadKey();
        }
    }
}
