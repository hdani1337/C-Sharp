using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elsoC
{
    class Program
    {

        public Program() {//konstruktor
            Console.ForegroundColor = ConsoleColor.Gray;//Sárga betűszín
            //Hello World
            Console.WriteLine("Hello world!");

            #region hackNasa
            //Na$a hackelés
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPress the Enter key to hack Na$a!");
            Console.ReadLine();
            Console.WriteLine("You successfully hacked Na$a!");
            Console.ReadKey();
            #endregion           

            #region maxmin
            Console.ForegroundColor = ConsoleColor.Yellow;
            //Maximum és minimum értékek
            byte legkisebb = 0; //egy bájt típusú legkisebb elnevezéssel ellátott változó
            legkisebb = 25;
            Console.WriteLine("\nByte: \n - Minimum értéke: " + byte.MinValue + " \n - Maximum értéke: " + byte.MaxValue);
            short dupla = 0;//két bájton ábrázolt short típusú dupla elnevezéssel
            Console.WriteLine("Short: \n - Minimum értéke: " + short.MinValue + " \n - Maximum értéke: " + short.MaxValue);
            int n = 0;//négy bájton ábrázolt int típusú n elnevezéssel
            Console.WriteLine("Int: \n - Minimum értéke: " + int.MinValue + " \n - Maximum értéke: " + int.MaxValue);
            long m = 0;//nyolc bájton ábrázolt long típusú m elnevezéssel
            Console.WriteLine("Long: \n - Minimum értéke: " + long.MinValue + " \n - Maximum értéke: " + long.MaxValue);
            float f = (float)0.0;//4 bájt
            Console.WriteLine("Float: \n - Minimum értéke: " + float.MinValue + " \n - Maximum értéke: " + float.MaxValue);
            double d = (double)0.0;//8 bájt
            Console.WriteLine("Double: \n - Minimum értéke: " + double.MinValue + " \n - Maximum értéke: " + double.MaxValue);
            #endregion

            #region korvizsgálat
            //String válasz, kor vizsgálat
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nElmúltál már 18 éves?");
            string valasz = Console.ReadLine();

            if (valasz.Equals("igen")) {
                Console.WriteLine("Beléphetsz!");
            }

            if (valasz.Equals("nem")) {
                Console.WriteLine("\nNem léphetsz be!");
                Console.WriteLine("\nHány éves vagy?");
                short kor = short.Parse(Console.ReadLine());

                if (kor <= 17 && kor > 0)
                {
                    Console.WriteLine("Még kiskorú vagy. \n");

                    if (kor < 6) {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Ovis vagy még.");
                    }

                    if (kor < 14 && kor >= 6) {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Még általánosba jársz.");
                    }

                    if (kor >= 14) {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Már középsulis vagy.");
                    }

                    
                }

                else
                {
                    if (kor >= 18)
                    {
                        Console.WriteLine("Te már elmúltál 18.");
                    }

                    if (kor < 0) {
                        Console.WriteLine("A korod nem lehet kisebb, mint 0!");
                    }
                }
            }

            if (!valasz.Equals("nem") && !valasz.Equals("igen")) {
                Console.WriteLine("Helytelen válasz! Próbáld újra!");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;//Sárga betűszín
            #endregion

            #region myNumber
            //Én számom
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nAdj meg egy számot!");
            int szam = int.Parse(Console.ReadLine());
    
            if (szam < 5)
            {
                Console.WriteLine("A szám kisebb, mint 5!");
            }

            else
            {
                if (szam == 5)
                {
                    Console.WriteLine("A szám egyenlő 5-tel!");
                }
                else
                {
                    Console.WriteLine("A szám nagyobb, mint 5!");
                }
            }
            #endregion

            #region ciklusok
            Console.ForegroundColor = ConsoleColor.Green;
            //Elöltesztelős
            Console.WriteLine("\nElöltesztelős: ");
            byte x = 20;
            while (x > 0){
                Console.Write(x + ", ");
                x--;
            }

            Console.WriteLine("\n");

            //Hátultesztelős
            Console.WriteLine("Hátultesztelős: ");
            byte y = 20;
            do {
                Console.Write(y + ", ");
                y--;
            } while (y>0);

            Console.WriteLine("\n");

            //Számlálós ciklus
            Console.WriteLine("Számlálós: ");
            for (int i = 1; i <= 20; i++)
            {
                Console.Write(i + ", ");
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            #endregion

            #region hazi
            Console.WriteLine("\n\n3-al osztható páratlan számok: ");
            for (int z = 0; z < 100; z++) {
                if (z % 2 == 1 && z % 3 == 0) {
                    Console.Write(z + ", ");
                }
            }

            short darab = 0;

            Console.WriteLine("\n\n1-100 közötti páros és 5-tel osztható számok");
            for (int z = 1; z <= 100; z++) {
                
                if (z % 2 == 0 && z % 5 == 0) {
                    darab++;
                    Console.Write(z + ", ");
                }
            }
            Console.WriteLine("\n" + darab + " darab szám van.");
            #endregion

            #region robiAtlag
            Console.WriteLine("\n\nRobi magyar jegyeinek az átlaga:");
            Console.WriteLine("Írj be 8 jegyet! (1 és 5 között)!");
            for (int i = 0; i < 8; i++)
            {
                short jegy = Convert.ToInt16(Console.ReadLine());
            }
            #endregion

            #region programVege
            Console.WriteLine("\nNyomj meg egy gombot a kilépéshez.");
            Console.ReadKey();
            #endregion
        }

        static void Main(string[] args)
        {
            new Program();//konstruktor meghívása
        }    
    }
}
