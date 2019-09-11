using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elmélet0911
{
    class Program
    {

        Program()
        {
            amoba();
        }

        void matrix()
        {
            int[,] matrix = new int[3, 4];

            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    if (sor == oszlop || oszlop + sor == 9)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("O ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("X ");
                    }
                }
                Console.WriteLine();
            }
        }

        int[] userKoordinatak = new int[] { };
        int[] botKoordinatak = new int[] { };

        void amoba()
        {
            Console.WriteLine("Kérem a koordinátát (X,Y): ");
            string answer = Console.ReadLine();
            matrixKiir(Convert.ToInt16(answer.Substring(0, 1)), Convert.ToInt16(answer.Substring(2, 1)));
        }

        void matrixKiir(int msor, int moszlop)
        {
            int[] userSorok = new int[] { };
            int[] userOszlopok = new int[] { };
            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    if (msor == sor && moszlop == oszlop)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("_ ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            new Program();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nNyomj egy gombot a kilépéshez!");
            Console.ReadKey();
        }
    }
}
