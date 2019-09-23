using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlat0923
{
    class Program
    {
        //hosszú mondat bekérése
        //hány különböző karakter és darabszámuk
        int[] karakterekDb;//Ebben tároljuk az előfordulások számát
        int karakterekId = 0;//Éppen vizsgált karakter indexe
        int karakterCount = 0;//Vizsgált karakter előfordulási száma
        char[] karakterek;//Egyedi karakterek

        Program()
        {
            bekeres();//Bekérünk egy mondatot
        }

        void bekeres()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Írjon be egy mondatot ==> ");
            Console.ForegroundColor = ConsoleColor.Green;
            string answer = Console.ReadLine();

            egyediElemek(answer);//Kiválogatjuk az egyedi elemeket
            egyediElemekSzamlalasa(answer);//Megszámoljuk az egyedi elemeket
           
            kiir();//Kiiratunk mindent a konzolablakra
        }

        void egyediElemek(string answer)
        {
            karakterek = new char[answer.Length];//Először akkorára csináljuk a tömböt, mint a mondat hossza
            for (int i = 0; i < answer.Length; i++)
            {
                if (!karakterek.Contains(answer[i]) && !answer[i].Equals(' '))
                {
                    karakterek[karakterekId] = answer[i];
                    karakterekId++;
                }//Először megtöltöm az egyedi elemekkel, hogy ez alapján megcsináljam a tömbök hosszát az IndexOutOfRangeException miatt
            }

            karakterek = new char[karakterekId];//Megvan, hogy hány egyedi karakter van, ezért ilyen hosszú lesz a tömb
            karakterekId = 0;//Majd lenullázom ezt a számlálót

            for (int i = 0; i < answer.Length; i++)
            {
                if (!karakterek.Contains(answer[i]) && !answer[i].Equals(' '))
                {
                    karakterek[karakterekId] = answer[i];
                    karakterekId++;
                }//Most is kiválogatom az egyedi elemeket, de most felk is töltöm velük a tömböt
            }

            karakterekDb = new int[karakterek.Length];//Majd az előfordulások számát tároló tömb hosszát is beállítjuk a megfelelő értékre
        }

        void egyediElemekSzamlalasa(string answer)
        {
            for (int i = 0; i < karakterek.Length; i++)
            {//Végigmegyünk minden egyes egyedi karakteren
                karakterCount = 0;//Lenullázzuk a számlálót, ebben lesz az előfordulás gyakorisága minden egyes karakternél
                for (int j = 0; j < answer.Length; j++)
                {//Végigmegyünk a mondaton
                    if (karakterek[i].Equals(answer[j]))
                    {//Ha a vizsgált karakterünk megegyezik a j-dik karakterrel a mondatból
                        karakterCount++;//Akkor növeljük a darabszámot
                    }
                }
                karakterekDb[i] = karakterCount;//Majd az egyedi karakter előfordulását bedobjuk a gyakoriságot tároló tömbbe
            }
        }

        void kiir()
        {
            int temp;//Azért kell, hogy megállapítsuk az adott karakter típusát (betű vagy szám)

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nA mondat betűi és előfordulásaik száma:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < karakterek.Length; i++)
            {
                Int32.TryParse(karakterek[i].ToString(), out temp);//Számmá alakítjuk a karaktert
                if (temp!=0) Console.WriteLine("A(z) ,," + karakterek[i] + "'' szám " + karakterekDb[i] + " alkalommal fordult elő a mondatban.");//Ha nem 0, akkor szám, mivel betűnél 0-s értéket fog kapni a temp
                else Console.WriteLine("A(z) ,," + karakterek[i] + "'' betű " + karakterekDb[i] + " alkalommal fordult elő a mondatban.");//Ha pedig 0, akkor ez egy betű, DE a 0-t is betűnek fogja írni
            }
            Console.WriteLine();

            again();//Megkérdezzük a felhasználót, hogy megad e egy másik mondatot
        }

        void again()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Megad egy másik mondatot? (Igen/Nem) ==> ");
            Console.ForegroundColor = ConsoleColor.Green;
            string answer = Console.ReadLine();

            if (answer.ToLower().Equals("igen"))
            {
                karakterekId = 0;//Éppen vizsgált karakter indexe
                karakterCount = 0;//Vizsgált karakter előfordulási száma
                bekeres();//Ha igent mond, akkor újrakezdjük a programot
            }
            else if (answer.ToLower().Equals("nem"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Köszönöm a választ! A program pillanatokon belül leáll.");
                System.Threading.Thread.Sleep(2500);//2.5 másodperc szünet, hogy a felhasználó elolvashassa az üzenetet
                Environment.Exit(0);//Ha nemet mond, akkor leállítjuk a programot
            }
            else
            {
                //Ha pedig annyira értetlen, hogy nem tud normális választ adni, akkor addig kérdezzük, amíg helyes választ nem ad
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hibás válasz! Kérem adja meg újra!");
                again();
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Egyedi karakter számláló";
            new Program();
            Console.ReadKey();
        }
    }
}
