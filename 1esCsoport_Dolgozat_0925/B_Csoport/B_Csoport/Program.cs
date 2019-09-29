using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Csoport
{
    class Program
    {

        Program()
        {
            primek();
            szamok();
        }

        Random random = new Random();

        void primek()
        {
            int[] szamok = new int[10000];//16 giga ramom nem lesz elég ekkora tömbhöz :D 
            int[] egyediek = new int[10000];
            int egyediekIndex = 0;
            int mennyiPrim = 0;
            int mennyiEgyedi = 0;

            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = random.Next(1, 10000);
                if (isPrim(szamok[i])) mennyiPrim++;
                if (!egyediek.Contains(szamok[i]))
                {
                    egyediek[egyediekIndex++] = szamok[i];
                    mennyiEgyedi++;
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("A random számok közül " + mennyiPrim + " darab volt prímszám, illetve " + mennyiEgyedi + " volt egyedi.");
        }

        bool isPrim(int szam)
        {
            for (int i = 2; i < szam; i++)
            {
                if (szam % i == 0) return false;
            }

            return true;
        }

        void szamok()
        {
            int[] tomb1 = new int[random.Next(10, 20)];
            int[] egyezoek = new int[tomb1.Length];
            int mennyiEgyezo = 0;
            int egyezoIndex = 0;

            for (int i = 0; i < tomb1.Length; i++)
            {
                tomb1[i] = random.Next(10, 99);
            }

            for (int i = 0; i < tomb1.Length; i++)
            {
                if (tomb1[i] % 10 == tomb1[i] / 10) mennyiEgyezo++;
            }

            egyezoek = new int[mennyiEgyezo];

            for (int i = 0; i < tomb1.Length; i++)
            {
                if (tomb1[i] % 10 == tomb1[i] / 10) egyezoek[egyezoIndex++] = tomb1[i];
            }

            Console.ForegroundColor = ConsoleColor.Yellow;

            if (egyezoek.Length > 0)
            {

                Console.Write("A feltételnek megegyező számok a következőek: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                for (int i = 0; i < egyezoek.Length; i++)
                {
                    if (i < egyezoek.Length - 1) Console.Write(egyezoek[i] + ", ");
                    else Console.Write(egyezoek[i] + ".");
                }
                Console.WriteLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A feltételnek egy szám sem felelt meg.");
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("A tömb legkisebb eleme a(z) " + tomb1.Min() + ", a legnagyobb pedig a(z) " + tomb1.Max() + ".");
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
