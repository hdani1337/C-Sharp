using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Házi_20190509
{
    class Program
    {

        Program()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Melyik feladatot szeretnéd megnézni? (1/2/Kilépés) ==> ");
            choosing();
        }

        public void choosing()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "1":
                    {
                        aHelyettSpace();
                        break;
                    }

                case "2":
                    {
                        szorendForditas();
                        break;
                    }

                case "kilépés":
                case "Kilépés":
                    {
                        break;
                    }

                default:
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Helytelen válasz!");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(" Melyik feladatot szeretnéd megnézni? (1/2/Kilépés) ==> ");
                        choosing();
                        break;
                    }
            }
        }

        public void aHelyettSpace()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Írj be egy tetszőleges hosszúságú szöveget ==> ");
            Console.ForegroundColor = ConsoleColor.Green;
            string answer = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Most a szövegedből kitörlöm az összes ,,a'' betűt, s helyette spacet rakok! A végeredmény:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(answer.Replace('a', ' '));//rohadt bonyolult
            new Program();
        }

        public void szorendForditas()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Írj be egy tetszőleges hosszúságú szöveget ==> ");
            Console.ForegroundColor = ConsoleColor.Green;
            string answer = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Most a szöveged szórendjét megfordítom! A végeredmény:");
            Console.ForegroundColor = ConsoleColor.Cyan;

            string[] szavak = new string[] {};//üres string tömb
            string temp = "";

            for (int i = 0; i < answer.Length; i++)
            {
                if (answer[i] == ' ')
                {
                    szavak = new List<string>(szavak) { temp }.ToArray();//mivel az i-dik elem space, ezért ez egy külön szó, amit belerakunk a tömbbe
                    temp = "";//majd üresen hagyjuk a tempet
                }

                else temp += answer[i];//ha nincs space, akkor a temphez hozzáadjuk a betűt
            }

            int count = szavak.Length - 1;//tömb hossza - 1...

            temp += " ";//az első szó alapból benne lesz, ezért spacet rakunk

            while (count >= 0)//visszafelé járjuk be a tömböt
            {
                temp += szavak[count];//visszafele írjuk ki a szavakat
                temp += " ";//space az elválasztás miatt
                count--;//csökkentjük a számlálót/indexet, mivel hátulról megyünk előre
            }//miután vége a ciklusnak, a tempben lesz a beírt szöveg visszafelé    

            Console.WriteLine(temp);
            new Program();
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
