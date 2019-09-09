using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tombok
{
    class Program
    {
        Random random = new Random();//Globális random
        int[] winNumb;//Nyerőszámok
        int[] userNumb;//Játékos számai
        //Mindkettőt a gép sorsolja ki

        Program()
        {
            //introduction();//Bevezetés
            lotto();
        }

        void introduction()
        {
            int[] arrayNumbers = new int[5];//Egész számokkal feltölttt tömb
            float[] arrayAverages = new float[5];//Tört számokkal feltöltött tömb
            char[] arrayCharacters = new char[5];//Karakterekkel feltöltött tömb
            string[] arrayWords = new string[5];//Szövegekkel feltöltött tömb
            bool[] arrayBools = new bool[5];//Bool-okkal feltöltött tömb

            object[] objects = new object[5];
            objects[0] = "alma";
            objects[1] = 12;
            objects[2] = true;
            objects[3] = 25.3;
            objects[4] = 'c';
        }

        //user: if(true)Felhasználó számait sorsoljuk, else a gép számait
        //option: 5 ötöslottó (1-90 között), 6 hatoslottó (1-45 között)
        void Picking(bool user, int option)
        {
            int maximum = (option == 5) ? 90 : (option == 6) ? 45 : 0;
            int[] temp = new int[option];
            int randomNumber = 0;

            for (int i = 0; i < option; i++)
            {
                do
                {
                    randomNumber = random.Next(1, maximum + 1);
                } while (temp.Contains(randomNumber));

                temp[i] = randomNumber;
            }

            if (user)
            {
                userNumb = temp;
            }
            else
            {
                winNumb = temp;
            }
        }

        void lotto()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Lottó program");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Ötös (5) vagy hatos (6) lottó? Kérem válasszon: ");

            int type = 0;
            int maximum = (type == 5) ? 90 : 45;

            Console.ForegroundColor = ConsoleColor.Green;
            Int32.TryParse(Console.ReadLine(), out type);
            Picking(false, type);
            Console.WriteLine("\nNyerőszámok legenerálva!\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Kérem adja meg az ön által választott számokat! {0} darabot és 1-{1} között! ", type,(type==5)?90:45);

            Console.ForegroundColor = ConsoleColor.Green;
            userNumb = new int[type];
            int temp = 0;
            for (int i = 0; i < type; i++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("\nKérem a következő számot: ");
                Console.ForegroundColor = ConsoleColor.Green;
                do
                {
                    Int32.TryParse(Console.ReadLine(), out temp);
                    if (userNumb.Contains(temp))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ezt a számot már megadta!");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\nKérem a következő számot: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    if (temp > maximum || temp < 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Hibás szám! A számnak 1 és {0} között kell lennie!", maximum);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\nKérem a következő számot: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                } while (userNumb.Contains(temp));

                userNumb[i] = temp;
            }
           
            arrayShow(userNumb, "Az ön által megadott számok: ");
            arrayShow(winNumb, "A gép által generált számok: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nTalálatok száma: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(countMatches(userNumb,winNumb));
        }

        int countMatches(int[] array, int[] array2)
        {
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int k = 0; k < array2.Length; k++)
                {
                    if (array[i] == array2[k]) counter++;
                }
            }

            return counter;
        }

        void arrayShow(int[] array, string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n"+text);
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < array.Length; i++)
            {
                if(i<array.Length-1) Console.Write(array[i]+", ");
                else Console.Write(array[i]);
            }
        }

        static void Main(string[] args)
        {
            new Program();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nNyomjon egy gombot a kilépéshez...");
            Console.ReadKey();
        }
    }
}
