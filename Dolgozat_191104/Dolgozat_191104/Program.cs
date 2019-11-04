using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_191104
{
    class Program
    {
        List<int> faluA = new List<int> { };
        List<int> faluB = new List<int> { };
        Random random = new Random();
        int evek = 0;
        int kockaSzama;
        int randomLakos;
        int faluAPlus = 20;
        int faluBPlus = 30;

        Program()
        {
            this.beKoltozes();//Faluk lakosai beköltöznek
            this.idoMulas();//A program elkezdése
        }

        void beKoltozes()
        {
            for (int i = 1; i < 21; i++)
            {
                this.faluA.Add(i);
            }

            for (int i = 21; i < 51; i++)
            {
                this.faluB.Add(i);
            }
        }

        void idoMulas()
        {
            this.evek++;
            this.atKoltozes();//Feldobjuk a kockát, átköltözés        
            this.haromEvente();//Három évente beköltözik 1-1 ember
            this.kevesebbMint15();//Ha valamelyik faluban 15-nél kevesebb ember van, akkor kettő átköltözik a másikból
            this.eltelt30();//Ha letelik a 30 év, akkor megállunk és kiírunk mindent
        }

        void atKoltozes()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            this.kockaSzama = this.random.Next(1, 6);

            if (this.kockaSzama > 3)
            {
                this.randomLakos = this.random.Next(0, this.faluA.Count);
                this.faluB.Add(this.faluA[this.randomLakos]);//B faluba átköltözik egy ember
                this.faluA.Remove(this.faluA[this.randomLakos]);//A faluból kiköltözik ugyanaz az ember
                Console.WriteLine(this.faluB[this.randomLakos] + ". számú lakos átköltözött a B faluba.");
            }

            this.faluA.Sort();
            this.faluB.Sort();
        }

        void eltelt30()
        {
            if (this.evek < 30) this.idoMulas();

            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("A falu lakossága: ");

                for (int i = 0; i < this.faluA.Count; i++)
                {
                    Console.Write(this.faluA[i] + " ");
                }

                Console.WriteLine("(" + this.faluA.Count + " darab lakos)");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("B falu lakossága: ");

                for (int i = 0; i < this.faluB.Count; i++)
                {
                    Console.Write(this.faluB[i] + " ");
                }

                Console.WriteLine("(" + this.faluB.Count + " darab lakos)");
            }
        }

        void haromEvente()
        {
            if (this.evek % 3 == 0)
            {
                this.faluA.Add(faluAPlus++);
                this.faluB.Add(faluBPlus++);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Beköltözött 1-1 lakos.");
            }
        }

        void kevesebbMint15()
        {
            int random1;
            int random2;

            if (this.faluA.Count < 15)
            {
                random1 = random.Next(0, faluB.Count);
                random2 = random.Next(0, faluB.Count);

                this.faluA.Add(this.faluB[random1]);
                this.faluA.Add(this.faluB[random2]);

                this.faluB.Remove(this.faluB[random1]);
                this.faluB.Remove(this.faluB[random2]);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(random1 + ". és " + random2 + ". lakosok átköltöztek B faluból A faluba.");
            }

            else if (this.faluB.Count < 15)
            {
                random1 = random.Next(0, faluA.Count);
                random2 = random.Next(0, faluA.Count);

                this.faluB.Add(this.faluA[random1]);
                this.faluB.Add(faluA[random2]);

                this.faluA.Remove(this.faluA[random1]);
                this.faluA.Remove(this.faluA[random2]);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(random1 + ". és " + random2 + ". lakosok átköltöztek A faluból B faluba.");
            }
        }

        static void Main(string[] args)
        {
            new Program();
            Console.WriteLine("Nyomj egy gombot a kilépéshez...");
            Console.ReadKey();
        }
    }
}
