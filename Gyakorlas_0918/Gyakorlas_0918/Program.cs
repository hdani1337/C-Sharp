using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlas_0918
{
    class Program
    {

        Random random = new Random();

        Program()
        {
            BikaRobi();
        }

        void BikaRobi()
        {
            int suly = random.Next(60,160);
            int[] cipomeretek = new int[30];
            int a = 10, b = 16;

            for (int i = 0; i < cipomeretek.Length; i++)
            {
                //1-16
                //16-22
                //22-30
                //30-40
                //40-50

                //1. megoldás
                /*if (i / 5 >= 4)
                {
                    a = 40;
                    b = 50;
                }
                else if (i / 5 >= 3)
                {
                    a = 30;
                    b = 40;
                }
                else if (i / 5 >= 2)
                {
                    a = 22;
                    b = 30;
                }
                else if (i / 5 >= 1)
                {
                    a = 16;
                    b = 22;
                }
                else
                {
                    a = 10;
                    b = 16;
                }*/

                //2. megoldás
                if (i > 0)
                {
                    cipomeretek[i] = cipomeretek[i - 1] + random.Next(2, 4);
                }
                else
                {
                    cipomeretek[i] = random.Next(a, b);
                }
            }
            int ev = 1;
            Console.WriteLine("Robi cipőméretének alakulása az évek során: ");
            foreach (int n in cipomeretek)
            {
                if(ev>9) Console.Write("Év: " + ev++ + "   Cipőméret: " + n + "\n");
                else Console.Write("Év: " + ev++ + "    Cipőméret: " + n + "\n");
            }
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
