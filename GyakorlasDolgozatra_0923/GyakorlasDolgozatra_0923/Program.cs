using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyakorlasDolgozatra_0923
{
    class Program
    {

        int[] global = new int[30];
        int userNumber;
        Random random = new Random();

        Program()
        {
            feltolt();//Globális tömb feltöltése kétjegyű random számokkal (1. feladat)
            minMax();//Minimum és maximum, köztük lévő távolság (1. feladat 1. pontja)
            Console.WriteLine("A tömb átlaga " + atlag() + "."); ;//A tömb átlaga (1. feladat 2. pontja)
            atlagAlattFelett();//Hány szám van az átlag alatt/felett, hol van több? (1. feladat 3. pontja)
            atlagPlusMinusFive();//Az átlagtól maximum 5-tel eltérő számok (1. feladat 4. pontja)
            printPrim();//Prímszámok kiiratása (1. feladat 5. pontja)
            readNumber();//Kétjegyű számjegy beolvasása (1. feladat 6. pontja)
            userSzerepel();//Benne van e a tömbben a felhasználó által megadott szám, ha igen, hányadik helyen (Felhasználóval kapcsolatos 1. feladat)
            userKisebbNagyobb();//Hány kisebb és nagyobb szám van a felhasználó számánál, illetve melyikből van több (Felhasználóval kapcsolatos 2. feladat)
            userOszto();//Azok a számok, amiknek ugyanannyi osztójuk van, mint a felhasználó számának (Felhasználóval kapcsolatos 3. feladat)
            userAltagKoze();//A felhasználó száma és az átlag közé eső számok (Felhasználóval kapcsolatos 4. feladat)
            userVegzodik();//A felhasználó számának utolsó számjegyére végződő számok (Felhasználóval kapcsolatos 5. feladat)
            userRelativPrim();//A felhasználó számával relatív prímek (Felhasználóval kapcsolatos 6. feladat)
        }

        void feltolt()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("A tömb elemei: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < global.Length; i++)
            {
                global[i] = random.Next(10, 100);
                if(i<global.Length-1) Console.Write(global[i] + ", ");
                else Console.Write(global[i] + "\n");
            }
        }

        int atlag()
        {
            int atlagTemp = 0;
            for (int i = 0; i < global.Length; i++)
            {
                atlagTemp += global[i];
            }
      
            return (atlagTemp / global.Length);
        }

        void atlagAlattFelett()
        {
            int alatt = 0;
            int felett = 0;
            int egyenlo = 0;

            for (int i = 0; i < global.Length; i++)
            {
                if (global[i] < atlag()) alatt++;
                else if (global[i] > atlag()) felett++;
                else egyenlo++;
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(alatt + " szám van az átlag alatt, " + felett + " van az átlag felett, illetve " + egyenlo + " egyenlő az átlaggal.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (alatt>felett) Console.WriteLine("Több szám van az átlag alatt, mint felett.");
            else if (alatt<felett) Console.WriteLine("Több szám van az átlag felett, mint alatt.");
            else Console.WriteLine("Egyenlő mennyiségű átlag alatti és feletti szám van.");

        }

        void atlagPlusMinusFive()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Az átlagtól maximum 5-tel eltérő számok a következők: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < global.Length; i++)
            {
                if (Math.Abs(atlag() - global[i]) <= 5) Console.Write(global[i] + ", ");
            }
            Console.WriteLine();
        }

        void minMax()
        {
            int min = global.Min();
            int max = global.Max();
            int tavolsag = Math.Abs(min - max);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("A tömb legkisebb eleme a(z) " + min + ", a legnagyobb eleme a(z) " + max + ", s az ezek közti távolság " + tavolsag + ".");
        }

        void printPrim()
        {
            bool isPrim = true;
            bool voltPrim = false;

            Console.Write("A prímszámok a következőek: ");
            for (int i = 0; i < global.Length; i++)
            {
                for (int j = 2; j < global[i]; j++)
                {
                    if (global[i] % 2 == 0) isPrim = false;
                }
                if (isPrim)
                {
                    Console.Write(global[i] + ", ");
                    voltPrim = true;
                }
            }
            if (!voltPrim)
            {
                Console.Write("A tömbben nem fordult elő egyetlen prímszám sem!");
            }
            Console.WriteLine();
        }

        void readNumber()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Kérem adjon meg egy kétjegyű számot: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Int32.TryParse(Console.ReadLine(), out userNumber);
            if (userNumber < 10 || userNumber > 99)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hibás szám! Újra: ");
                readNumber();
            }
        }

        void userSzerepel()
        {
            int elofordulasokSzama = 0;
            for (int i = 0; i < global.Length; i++)
            {
                if (userNumber == global[i]) elofordulasokSzama++;
            }

            int[] helyek = new int[elofordulasokSzama];
            int helyekIndex = 0;

            for (int i = 0; i < global.Length; i++)
            {
                if (userNumber == global[i]) helyek[helyekIndex++] = i;
            }

            if (elofordulasokSzama == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Az ön által megadott szám nem szerepel a tömbben!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Az ön által megadott szám a következő helye(ke)n szerepel: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                for (int i = 0; i < helyek.Length; i++)
                {
                    if (i < helyek.Length - 1) Console.Write(helyek[i] + ", ");
                    else Console.Write(helyek[i] + "\n");
                }
            }
        }

        void userKisebbNagyobb()
        {
            int kisebb = 0;
            int nagyobb = 0;
            int egyenlo = 0;

            for (int i = 0; i < global.Length; i++)
            {
                if (global[i] > userNumber) nagyobb++;
                else if (global[i] < userNumber) kisebb++;
                else egyenlo++;
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("A felhasználó számánál (" + userNumber + ") " + kisebb + " kisebb, " + nagyobb + " nagyobb, illetve " + egyenlo + " egyenlő szám van.");

            Console.ForegroundColor = ConsoleColor.Yellow;
            if (kisebb > nagyobb) Console.WriteLine("Több szám van a felhasználó száma alatt, mint felett.");
            else if (kisebb < nagyobb) Console.WriteLine("Több szám van a felhasználó száma felett, mint alatt.");
            else Console.WriteLine("Egyenlő mennyiségű felhasználó száma alatti és feletti szám van.");
        }

        void userAltagKoze()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (userNumber == atlag()) Console.WriteLine("A felhasználó száma megegyezik az átlaggal!");
            else if (userNumber > atlag())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("A felhasználó száma és az átlag közé eső számok: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                for (int i = 0; i < global.Length; i++)
                {
                    if (global[i] > atlag() && global[i] < userNumber) Console.Write(global[i] + ", ");
                }
            }
            else if (userNumber < atlag())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("A felhasználó száma és az átlag közé eső számok: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                for (int i = 0; i < global.Length; i++)
                {
                    if (global[i] < atlag() && global[i] > userNumber) Console.Write(global[i] + ", ");
                }
            }

            Console.WriteLine();
        }

        void userOszto()
        {
            int userOsztoCount = 0;
            int currentOsztoCount = 0;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Ugyanannyi közös osztóval rendelkező számok, mint a felhasználó száma: ");
            Console.ForegroundColor = ConsoleColor.Cyan;

            for (int i = 2; i < userNumber; i++)
            {
                if (userNumber % i == 0) userOsztoCount++;
            }

            for (int i = 0; i < global.Length; i++)
            {
                for (int j = 2; j < global[i]; j++)
                {
                    if (global[i] % j == 0) currentOsztoCount++;
                }

                if (currentOsztoCount == userOsztoCount) Console.Write(global[i] + ", ");
                currentOsztoCount = 0;
            }

            Console.WriteLine();
        }

        void userVegzodik()
        {
            int userUtolso = userNumber % 10;
            int counter = 0;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("A felhasználó által megadott szám végére (" + userUtolso + ") végződő számok: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < global.Length; i++)
            {
                if (global[i] % 10 == userUtolso)
                {
                    Console.Write(global[i] + ", ");
                    counter++;
                }
              
            }
            Console.Write("azaz " + counter + " darab ilyen szám van.");
            Console.WriteLine();
        }

        void userRelativPrim()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("A felhasználó számával relatív prímek: ");
            Console.ForegroundColor = ConsoleColor.Cyan;

            bool isRelativPrim = true;
            bool voltRelativPrim = false;

            for (int i = 0; i < global.Length; i++)
            {
                for (int j = 2; j < global[i]; j++)
                {
                    if (global[i] % j == 0 && userNumber % j == 0)
                    {
                        isRelativPrim = false;
                        break;
                    }
                    if (isRelativPrim)
                    {
                        Console.Write(global[i] + ", ");
                        voltRelativPrim = true;
                        break;
                    }
                }
                if (!voltRelativPrim)
                {
                    Console.Write("A tömbben nem fordult elő egyetlen felhasználó számával relatív prímszám sem!");
                    break;
                }

            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Gyakorlás a dolgozatra";
            Console.WindowWidth = 134;
            new Program();
            Console.ReadKey();
        }
    }
}
