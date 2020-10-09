using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace sudokuCLI
{
    class Program
    {
        List<string> sorok = new List<string>();
        List<Feladvany> feladvanyok = new List<Feladvany>();
        List<Feladvany> kivalasztottak = new List<Feladvany>();

        static void Main(string[] args)
        {
            new Program();
            Console.ReadKey();
        }

        Program() {
            beolvasas();
            bekeres();
            randomFeladvany();
            mentes();
        }

        //3. feladat
        private void beolvasas() {
            try
            {
                sorok = File.ReadAllLines("feladvanyok.txt").ToList();
                Console.WriteLine("3. feladat: Beolvasva " + sorok.Count + " feladvány!");
                foreach (string s in sorok)
                {
                    feladvanyok.Add(new Feladvany(s));
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        //4. feladat
        private void bekeres() {
            Console.Write("Kérek a feladvány méretét 4 és 9 között! => ");
            string valasz = Console.ReadLine();

            int valaszToSzam = 0;
            Int32.TryParse(valasz, out valaszToSzam);

            if (valaszToSzam >= 3 && valaszToSzam <= 9)
            {
                //Siker
                int sum = 0;
                foreach (Feladvany f in feladvanyok){
                    if (f.Meret == valaszToSzam)
                    {
                        sum++;
                        kivalasztottak.Add(f);
                    }
                }
               
                Console.WriteLine(valaszToSzam+"x"+valaszToSzam+" méretű feladványból " + sum + " darab van tárolva.");
            }else bekeres();//Futtassuk le újra, mert rossz értéket adott
        }

        //5. feladat
        private void randomFeladvany() {
            Feladvany temp = null;
            try
            {
                temp = kivalasztottak[new Random().Next(0, kivalasztottak.Count)];
            }
            catch (Exception e) {
                temp = kivalasztottak[0];
            }
            Console.WriteLine("5. feladat: A kiválasztott feladvány:");
            Console.WriteLine(temp.Kezdo);
            kitoltottseg(temp);
        }

        //6. feladat
        private void kitoltottseg(Feladvany vizsgaltFeladvany) {
            int mennyiHianyzik = 0;
            foreach (char s in vizsgaltFeladvany.Kezdo) {
                if (s == '0') mennyiHianyzik++;
            }

            Console.WriteLine("6. feladat: A feladvány kitöltöttsége: " + Convert.ToInt32((mennyiHianyzik/(vizsgaltFeladvany.Kezdo.Length*1.0f))*100) + "%");
            kirajzolas(vizsgaltFeladvany);
        }

        //7. feladat
        private void kirajzolas(Feladvany kirajzolandoFeladvany) {
            Console.WriteLine("7. feladat: A feladvány kirajzolva:");
            kirajzolandoFeladvany.Kirajzol();
        }

        //8. feladat
        private void mentes() {
            string fajlnev = "sudoku" + kivalasztottak[0].Meret;
            string[] content = new string[kivalasztottak.Count];
            for (int i = 0; i < kivalasztottak.Count; i++)
            {
                content[i] = kivalasztottak[i].Kezdo;
            }
            File.WriteAllLines(fajlnev + ".txt", content);
            Console.WriteLine("8. feladat: " + fajlnev + ".txt állomány " + kivalasztottak.Count + " darab feladvánnyal létrehozva.");
        }
    }
}
