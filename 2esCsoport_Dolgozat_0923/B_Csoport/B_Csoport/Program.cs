using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Csoport
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            Console.Title = "Programozás gyakorlat dolgozat - 2.es Csoport - B. feladatlap";
            //Minek a main-be hívogassak mindent???? Jólvan, nem vitatkozok
            nagySzamok();
            egyezes();
            Console.ReadKey();
        }

        static void nagySzamok()
        {
            int[] kurvaNagyTomb = new int[10000];

            for (int i = 0; i < kurvaNagyTomb.Length; i++)
            {
                kurvaNagyTomb[i] = random.Next(1, 10000);
            }

            int nagyobbMintAtlag = 0;

            for (int i = 0; i < kurvaNagyTomb.Length; i++)
            {
                if (kurvaNagyTomb[i] > kurvaNagyTomb.Average()) nagyobbMintAtlag++;
            }

            int[] egyediek = new int[10000];
            int mennyiEgyedi = 0;

            for (int i = 0; i < kurvaNagyTomb.Length; i++)
            {
                if (!egyediek.Contains(kurvaNagyTomb[i])) egyediek[mennyiEgyedi] = kurvaNagyTomb[i];
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(nagyobbMintAtlag + " szám nagyobb az átlagnál, illetve " + mennyiEgyedi + " egyedi szám fordult elő a tömbben.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Vége az első feladatnak.");
        }

        static void egyezes()
        {//Egyezés legyen a void neve, de a prímszámokat fogjuk megszámolni. Köszönöm tanárúr, nagyon hűvös!
            int[] userNumbers = new int[10];
            int currentNumber;
            int index = 0;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Kérek szépen 10 darab egyedi számot 1 és 50 között!");

            while (userNumbers[9] == 0)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Ide kérem a számot: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Int32.TryParse(Console.ReadLine(), out currentNumber);

                if (currentNumber > 0 && currentNumber < 51)
                {
                    if (!userNumbers.Contains(currentNumber)) userNumbers[index++] = currentNumber;
                    else {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ez a szám már volt. Újra!");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A szám nem tartozik bele az intervallumba. Újra!");
                }
            }

            primek(userNumbers);
        }

        static void primek(int[] array)
        {
            int mennyiseg = 0;
            bool isPrim;

            for (int i = 0; i < array.Length; i++)
            {
                isPrim = true;
                for (int j = 2; j < array[i]; j++)
                {
                    if (array[i] % j == 0 || array[i] == 1) isPrim = false; break;
                }
                if (isPrim) mennyiseg++;
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Ön " + mennyiseg + " darab prímszámot adott meg.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Nyomjon egy gombot a kilépéshez...");
        }
    }
}
