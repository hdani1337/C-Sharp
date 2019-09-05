using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ismetles
{
    class Program
    {
        Random random = new Random();

        Program()
        {
            tombok2();
        }

        public void tombok()
        {
            bool kilep = false;
            do
            {
                int[] tomb1 = new int[5];
                int[] tomb2 = new int[] { 35, 45, 2, 89, 68, 4 };
                tomb1 = feltolt(5, 1, 100);
                int[] kozos = metszet(tomb1, tomb2);
                tombKiir(tomb1, "Az első");
                tombKiir(tomb2, "A második");
                tombKiir(kozos, "A metszet");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("\nKilépsz a programból? (I/N) ");
                Console.ForegroundColor = ConsoleColor.Green;
                kilep = Console.ReadLine().ToLower().Equals("i");
            } while (!kilep);
            Environment.Exit(0);
        }

        public void tombok2()
        {
            long db = 0;
            int[] tomb1, tomb2;
            
            while (true)
            {
                tomb1 = new int[random.Next(1, 20)];
                tomb2 = new int[random.Next(1, 20)];
                tomb1 = feltolt(tomb1.Length, 1, 100);
                tomb2 = feltolt(tomb2.Length, 1, 100);
                db++;
                if (teliTalalat(tomb1, tomb2)) break;
            }

            tombKiir(tomb1, "Első");
            tombKiir(tomb2, "Második");
            Console.WriteLine(db + " próbálkozás volt a telitalálatig");
        }

        public void tombKiir(int[] tomb, string tombNev) {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(tombNev + " tömb elemei: ");
            int failCount = 0;

            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] != 0)
                {
                    if (i < tomb.Length - 1) Console.Write(tomb[i] + ", ");
                    else Console.Write(tomb[i] + "\n");
                }
                else failCount++;

                if (failCount == tomb.Length) Console.Write(tombNev + " tömb üres.\n");
            }
        }

        int teliCount = 0;
        int teliProbalkozasok = 0;

        public bool teliTalalat(int[] t1, int[] t2)
        {
            if (t1.Length == t2.Length)
            {
                int egyezes = 0;
                for (int i = 0; i < t1.Length; i++)
                {
                    for (int j = 0; j < t2.Length; j++)
                    {
                        if (t1[i] == t2[j])
                        {
                            egyezes++;
                            break;
                        }
                    }
                }
                if (egyezes == t1.Length) return true;
                else return false;
            }
            else return false;
        }       

        public int[] feltolt(int darab, int min, int max)
        {
            int[] temp = new int[darab];

            for (int i = 0; i < darab; i++)
            {
                temp[i] = random.Next(min, max);
            }

            return temp;
        }

        public int[] metszet(int[] t1, int[] t2)
        {
            int[] temp = new int[t1.Length+t2.Length];
            int index = 0;

            for (int i = 0; i < t1.Length; i++)
            {
                for (int j = 0; j < t2.Length; j++)
                {
                    if (t1[i] == t2[j])
                    {
                        temp[index++] = t1[i];
                    }
                }
            }

            return temp;
        }

        static void Main(string[] args)
        {
            new Program();
            Console.ReadKey();
        }
    }
}
