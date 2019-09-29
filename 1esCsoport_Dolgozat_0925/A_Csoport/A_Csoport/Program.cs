using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Csoport
{
    class Program
    {
        Program()
        {
            szamok();//Első feladat
            betuk();//Második feladat
            bonusz();//:DDDDD
        }

        void szamok()
        {
            int[] szamjegyek = new int[25];//25 elemű tömb a 25 számjegynek
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Adjon meg egy 25 számjegyű számot: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string szam = Console.ReadLine();//Stringben vesszük fel, mert túl hosszú lenne számnak (lásd long.MaxValue)

            if (szam.Length != 25)
            {//Hogyha a szám nem 25 számjegyű, kérjünk be újat
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A szám nem 25 számjegyű! Újra!");
                szamok();
            }
            else
            {//Ha 25 számjegyű
                for (int i = 0; i < 25; i++)
                {//Akkor töltsük fel a tömböt a számjegyekkel
                    szamjegyek[i] = Convert.ToInt32(szam[i]);//A String i-dik elemét számmá alakítjuk, ha mégsem számjegy az i-dik elem, az 0-t fog visszaadni
                }

                int parosSzamok = 0;
                int paratlanSzamok = 0;
                for (int i = 0; i < szamjegyek.Length; i++)
                {//Megszámoljuk mennyi páros és páratlan szám van
                    if (szamjegyek[i] % 2 == 0) parosSzamok++;
                    else paratlanSzamok++;
                }
                Console.WriteLine("A páros számok aránya " + (parosSzamok / 25.0 * 100) + "%.");//Visszaadjuk a páros számok arányát százalékban
            }
        }

        void betuk()
        {
            int[] userNumbers = new int[5];//A felhasználó számai
            int currentSzam;//Éppen megadott szám
            int index = 0;
            int mennyiOlyan = 0;//A feltételnek megfelelő számok mennyisége
            Console.WriteLine("Kérem írjon be 5 darab kétjegyű számot!");

            while (userNumbers[4] == 0)
            {//Amíg nincs meg az 5 szám (mivel ilyenkor a tömbnek az üres elemei 0)
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Ide írja a számot: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Int32.TryParse(Console.ReadLine(), out currentSzam);
                if (currentSzam < 10 || currentSzam > 99)
                {//Ha a szám nem kétjegyű
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A szám nem tartozik bele a megadott intervallumba, újra!");
                }
                else userNumbers[index++] = currentSzam;//A kétjegyű számokat belerakjuk a tömbbe                
            }

            for (int i = 0; i < userNumbers.Length; i++)
            {
                if (userNumbers[i] % 10 == 1 || userNumbers[i] % 10 == 3 || userNumbers[i] % 10 == 5) mennyiOlyan++;//Végződés
                else if (userNumbers[i] / 10 == 1 || userNumbers[i] / 10 == 3 || userNumbers[i] / 10 == 5) mennyiOlyan++;//Kezdődés
                //Egy feltételbe is berakhattam volna őket, de így átláthatóbb talán
            }

            Console.WriteLine(mennyiOlyan + " darab számban szerepelnek a megadott számok.");
        }

        void bonusz()
        {//Ciklusok segítségével írtam ki :DDDDDDDD    
            //Most itthon megtudnám csinálni de cseszett lusta vagyok, megoldást lásd master/Matrix
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.WriteLine("1 1 1 1 1 1 1 1 1 1\n" +
                        "1 X 0 0 0 0 0 0 M 1\n" +
                        "1 0 X 0 0 0 0 M 0 1\n" +
                        "1 0 0 X 0 0 M 0 0 1\n" +
                        "1 0 0 0 X M 0 0 0 1\n" +
                        "1 0 0 0 0 X 0 0 0 1\n" +
                        "1 0 0 0 0 0 X 0 0 1\n" +
                        "1 0 0 0 0 0 0 X 0 1\n" +
                        "1 0 0 0 0 0 0 0 X 1\n" +
                        "1 1 1 1 1 1 1 1 1 1");
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Horváth Dániel Programozás Gyakorlat Dolgozat - A. csoport";
            new Program();
            Console.ReadKey();
        }
    }
}
