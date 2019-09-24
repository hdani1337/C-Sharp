using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Csoport
{
    class Program
    {
        static int[] elsoTomb;
        static Random random = new Random();

        static void globalis()
        {
            int a;
            int b;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Kérem írjon be egy számot 1 és 1000 között: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Int32.TryParse(Console.ReadLine(), out a);//Amúgy a feladatban tuti emiatt van 1 és 1000 között az intervallum, mivel ha betűt adunk meg ez 0-t ad vissza nyenyere
            if (a >= 1 && a <= 1000)
            {//Ha A jó
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Kérem írjon be egy másik számot 1 és 1000 között, ami nagyobb az előző számnál: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Int32.TryParse(Console.ReadLine(), out b);
                if (b >= 1 && b <= 1000)
                {//Ha B jó
                    if (b > a)
                    {//Ha A kisebb, mint B, akkor helyesek az értékek
                        afterSzamokFeldolgozva(a,b);
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("A szám nem tartozik bele a megadott intervallumba. Újra!");
                    globalis();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A szám nem tartozik bele a megadott intervallumba. Újra!");
                globalis();
            }
        }

        static void afterSzamokFeldolgozva(int a, int b)
        {
            elsoTomb = new int[100];

            for (int i = 0; i < elsoTomb.Length; i++)
            {
                elsoTomb[i] = random.Next(a, b);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("A random számokkal feltöltött tömb feladatban kért értékei a következők:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Legkisebb szám: " + elsoTomb.Min());
            Console.WriteLine("Legnagyobb szám: " + elsoTomb.Max());
            Console.WriteLine("A tömb átlaga: " + elsoTomb.Average());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Véget ért az első feladat.");
            egyezes();
        }

        static void egyezes()
        {
            int[] userNumbers = new int[10];
            int currentNumber;
            int index = 0;

            Console.WriteLine("Kérek szépen 10 darab egyedi számot 1 és 1000 között.");

            while (userNumbers[9] == 0)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Ide kérem a számot: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Int32.TryParse(Console.ReadLine(), out currentNumber);

                if (currentNumber > 0 && currentNumber < 1001)
                {
                    if (userNumbers.Contains(currentNumber))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ez a szám már volt!");
                    }
                    else
                    {
                        userNumbers[index] = currentNumber;
                        index++;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ez a szám nem tartozik bele a megadott intervallumba!");
                }
            }

            osszehasonlitas(elsoTomb,userNumbers);
        }

        static void osszehasonlitas(int[] array0, int[] array1)
        {
            int[] metszet;
            int mennyiKozos = 0;

            for (int i = 0; i < array0.Length; i++)
            {
                for (int j = 0; j < array1.Length; j++)
                {
                    if (array0[i] == array1[j]) mennyiKozos++;
                }
            }

            if (mennyiKozos > 0)
            {
                metszet = new int[mennyiKozos];
                int index = 0;

                for (int i = 0; i < array0.Length; i++)
                {
                    for (int j = 0; j < array1.Length; j++)
                    {
                        if (array0[i] == array1[j]) metszet[index++] = array1[j];
                    }
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("A felhasználó és a gép közös számai: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                for (int i = 0; i < metszet.Length; i++)
                {
                    if (i < metszet.Length - 1) Console.Write(metszet[i] + ", ");
                    else Console.Write(metszet[i]);
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nNyomjon egy gombot a program bezárásához...");                
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nem volt közös szám a felhasználó számai és a gép számai között!");
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Programozás gyakorlat dolgozat - 2.es csoport - A. feladatlap";
            globalis();//De miért a Mainbe hívjuk meg pls ez így olyan ronda :(
            Console.ReadKey();
        }
    }
}
