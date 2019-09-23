using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlat0923
{
    class Program
    {
        //hosszú mondat bekérése
        //hány különböző karakter és darabszámuk

        string abc = "aábcdefghiíjklmnoóöőpqrstuúüűvxywz";
        int[] karakterekDb = new int[] { };
        int karakterekId = 0;
        char[] karakterek = new char[] { };

        Program()
        {
            bekeres();
        }

        void bekeres()
        {
            Console.Write("Írjon be egy mondatot: ");
            string answer = Console.ReadLine();
            for (int i = 0; i < abc.Length; i++)
            {
                if (answer.Contains(abc[i]))
                {
                    karakterek[karakterekId] = abc[i];
                    while (answer.IndexOf(abc[i]) > -1)
                    {
                        karakterekDb[karakterekId]++;
                    }
                    karakterekId++;
                }
            }
        }

        void kiir()
        {

        }

        static void Main(string[] args)
        {
            new Program();
            Console.ReadKey();
        }
    }
}
