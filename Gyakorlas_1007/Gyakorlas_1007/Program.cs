using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlas_1007
{
    class Program
    {
        Program()
        {
            printElsoSzazPrim();//Az első száz prímszám kiiratása
            printIkerPrimek();//Az első száz prímszám ikerprím számpárainak kiiratása
        }

        int[] primek = new int[100];//Prímszámok, azért száz mert az első száz darabot töltjük bele
        string[] ikerPrimek;//Ikerprím számpárok, a tárolás könnyítése miatt string tömb

        void printElsoSzazPrim()
        {            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Az első 100 prímszám:\n");
            Console.ForegroundColor = ConsoleColor.Yellow;

            int db = 0;//Darabszám
            int n = 1;//Jelenlegi szám

            do
            {
                if (isPrim(n))//Ha a jelenlegi szám prím
                {                    
                    Console.Write(n + " ");//Akkor írjuk ki
                    primek[db] = n;//Rakjuk be a prímek tömbbe
                    db++;//Növeljük a darabszámot
                }
                n++;//Növeljük a jelenleg számot
            } while (db <100);//Az első száz prímszám kell

            Console.WriteLine("\n");//Sortörés
        }

        void printIkerPrimek()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Az ikerprím számpárok:");
            Console.ForegroundColor = ConsoleColor.Yellow;

            int index = 0;

            for (int i = 0; i < primek.Length - 1; i++)
            {//Megszámoljuk, mennyi ikerprím van, majd ekkora tömböt hozunk létre (IndexOutOfRangeException)
                if (isIkerPrimek(primek[i], primek[i + 1]) && primek[i] > 0)
                    index++;//Darabszám növelése
            }

            ikerPrimek = new string[index];//Létrehozzuk a tömböt a fix hosszúsággal
            index = 0;//Lenullázzuk az indexet

            for (int i = 0; i < primek.Length - 1; i++)
            {//Feltöltjük a tömböt az ikerprím számpárokkal
                if (isIkerPrimek(primek[i], primek[i + 1]) && primek[i] > 0)
                    ikerPrimek[index++] = primek[i] + "-" + primek[i + 1];//Belerakjuk a két számot egy helyre köztük egy kötőjellel
            }

            for (int i = 0; i < ikerPrimek.Length; i++)
            {//Kiiratjuk a számpárokat
                Console.Write(ikerPrimek[i] + ", ");
            }

            Console.WriteLine("\n");//Sortörés
        }

        bool isIkerPrimek(int a, int b)
        {
            return Math.Abs(a - b) == 2;//A két prímszám közti különbségnek 2-nek kell lennie, ekkor ikerprímek
        }

        bool isPrim(int szam)
        {
            if (szam < 2) return false;//Ha a szám kisebb kettőnél, akkor nem prím
            for (int i = 2; i < szam; i++)
            {//Kettőtől kezdjük a ciklust, mivel minden szám osztható 1-el
                if (szam % i == 0) return false;//Ha a szám osztható bármivel 1-en és saját magán kívül, akkor sem prím
            }
            return true;//Ha csak magával és 1-el osztható, illetve nagyobb 2-nél akkor prím
        }

        static void Main(string[] args)
        {
            new Program();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Nyomj egy gombot a kilépéshez...");
            Console.ReadKey();
        }
    }
}
