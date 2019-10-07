using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listak
{
    class Program
    {
        Program()
        {
            bevezetes();
        }

        void bevezetes()
        {
            List<int> szamok = new List<int>();
            szamok.Add(15);
            szamok.Add(27);
            szamok.Add(16);
            szamok.Add(14);
            szamok.Add(12);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("A számok: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < szamok.Count; i++)
            {
                Console.Write(szamok[i] + " ");
            }

            Console.WriteLine();

            szamok.Sort();//Számok növekvő sorrendbe rendezése

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Rendezve: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var item in szamok)
            {
                Console.Write(item + " ");
            }

            szamok.Clear();//Lista törlése
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < 20; i++)
            {
                szamok.Add(i);              
                Console.WriteLine("Számláló: " + szamok.Count + ", Kapacitás: " + szamok.Capacity);
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            new Program();
            Console.WriteLine("Nyomj egy gombot a kilépéshez...");
            Console.ReadKey();
        }
    }
}
