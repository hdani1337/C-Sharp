using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harmadik
{
    class Program
    {
        Program()
        {
            //elso();
            //szuletes()
            //oszto();
            //prim();
            elsoSzazPrim();
        }

        public void elso()
        {
            int aInt = 0;
            int bInt = 0;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nKérek két számot!");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nElső szám: ");
            Console.ForegroundColor = ConsoleColor.Red;
            string a = Console.ReadLine();
            aInt = KonvertSzamKeres(a);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Második szám: ");
            Console.ForegroundColor = ConsoleColor.Red;
            string b = Console.ReadLine();
            bInt = KonvertSzamKeres(b);
            Console.ForegroundColor = ConsoleColor.Yellow;
            kulonbseg(aInt,bInt);
        }

        public void kulonbseg(int a, int b)
        {
            if (a > b) Console.WriteLine("\nA két szám távolsága: " + (a-b));
            else if (a < b) Console.WriteLine("\nA két szám távolsága: " + (b-a));
            else if ((a - b) == 0) Console.WriteLine("\nA két szám ugyanaz!");
        } 

        public void szuletes()
        {
            int ev = 0;
            int honap = 0;
            int nap = 0;
            
            Console.WriteLine("Kérem szépen a születési idődet!");
            Console.Write("Év: ");
            do
            {
                ev = Konvert(Console.ReadLine(), 4);
            } while(ev <= 0);
            Console.Write("Hónap: ");
            do
            {
                honap = Konvert(Console.ReadLine(), 2, 1, 12);
            } while (honap <= 0);
            Console.Write("Nap: ");
            do
            {
                switch (honap)
                {
                    //31 naposak
                    case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                        nap = Konvert(Console.ReadLine(), 2, 1, 31);
                        break;

                    //Február
                    case 2:
                        nap = Konvert(Console.ReadLine(), 2, 1, 28);
                        break;
    
                    //30 naposak
                    default:
                        nap = Konvert(Console.ReadLine(), 2, 1, 30);
                        break;
                }      
            } while (nap <= 0);

            //születési idő dátumainak összege
            int ossz = 0;
            ossz += szamOsszeg(ev);
            ossz += szamOsszeg(honap);
            ossz += szamOsszeg(nap);

            if (ossz >= 10) ossz = szamOsszeg(ossz);

            Console.WriteLine("összeg: " + ossz); 
        }

        public void oszto()
        {
            byte sortores = 0;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Kérek egy egyik számot: ");
            Console.ForegroundColor = ConsoleColor.Green;
            long szam = KonvertLong(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Kérek egy másik számot: ");
            Console.ForegroundColor = ConsoleColor.Green;
            long szam2 = KonvertLong(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n" + szam + " osztói: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 1; i < szam; i++)
            {
                if (szam % i == 0)
                {
                    sortores++;
                    if (sortores == 10)
                    {
                        Console.Write("\n");
                        sortores = 0;
                    }
                    Console.Write(i + ", ");
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n" + szam2 + " osztói: ");
            Console.ForegroundColor = ConsoleColor.Cyan;

            sortores = 0;

            for (int i = 1; i < szam2; i++)
            {
                if (szam2 % i == 0)
                {
                    sortores++;
                    if (sortores == 10)
                    {
                        Console.Write("\n");
                        sortores = 0;
                    }
                    Console.Write(i + ", ");
                }
            }
        }

        public int szamOsszeg(int szam)
        {
            if (szam < 10) return szam; 

            int temp = szam;
            int ossz = 0;

            while (temp > 0)
            {
                ossz += temp % 10;
                temp /= 10;
            }

            //nincs rekurzió

            return ossz;
        }

        public void prim()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Kérek egy számot: ");
            Console.ForegroundColor = ConsoleColor.Green;
            int szam = Konvert(Console.ReadLine());

            if (isPrim(szam))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(szam + " prímszám!");
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(szam + " nem prímszám!");
            }      
        }

        public void elsoSzazPrim()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Az első 100 prímszám");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            int sortores = 20;
            int darab = 0;
            int n = 0;
            while (true)
            {
                if (isPrim(n))
                {
                    darab++;
                   
                    // if (darab % sortores == 0) Console.WriteLine();
                    Console.Write(n + ", ");
                    primekKulonbseg(darab, n);
                }
                n++;

                if (darab == 100) break;

            }
            Console.WriteLine();
        }

        int jelenlegi = 0;
        int elozo = 0;

        public void primekKulonbseg(int darab, int n)
        {           
            if (darab % 2 == 1)
            {
                elozo = n;
            }
            else if (darab % 2 == 0)
            {
                jelenlegi = n;
            }

            if (jelenlegi > 0 && elozo > 0)
            {
                kulonbseg(jelenlegi, elozo);
                jelenlegi = 0;
                elozo = 0;
            }
        }

        public bool isPrim(int szam)
        {
            if (szam < 2) return false;

            else
            {
                for (int i = 2; i < szam; i++)
                {
                    if (szam % i == 0)
                    {
                        return false;
                    }
                }

            return true;
            }
        }
        

        public int KonvertSzamKeres(String szam)
        {//Konvertálás a számkérőshöz
            int temp = 0;
            try
            {
                temp = Convert.ToInt32(szam);
            }

            catch (FormatException e)
            {//a felhasználó betűt ad meg
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nHibás adat!");
                Console.WriteLine();
                elso();
            }

            catch (OverflowException e)
            {//nagyobb a szám, mint az int maximum értéke
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A szám túl nagy!");
                Console.WriteLine();
                elso();
            }

            return temp;
        }

        public int Konvert(String szam) {
            int temp = -1;
            Int32.TryParse(szam, out temp);
            return temp;
        }

        public long KonvertLong(String szam)
        {
            long temp = -1;
            Int64.TryParse(szam, out temp);
            return temp;
        }

        public int Konvert(String szam, int hossz)
        {
            int n = this.Konvert(szam);

            if (n > 0 && szam.Length != hossz) return 0;
            else return n;
        }

        public int Konvert(String szam, int hossz, int min, int max)
        {
            int n = Konvert(szam, hossz);
            if (n >= min && n <= max) return n;
            else return 0;
        }

        static void Main(string[] args)
        {
            new Program();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nNyomj egy gombot a kilépéshez...");
            Console.ReadKey();
        }
    }
}
