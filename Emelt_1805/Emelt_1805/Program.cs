using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Emelt_1805
{
    public class Program
    {
        List<string> sorok = new List<string>();
        List<Ajto> ajtok = new List<Ajto>();
        public static int bentvannak = 0;
        private int maxBentlevok = 0;

        Program()
        {
            beolvasas();//ELSŐ FELADAT
            elsoEsUtolso();//MÁSODIK FELADAT
            athaladasok();//HARMADIK FELADAT
            bentmaradtak();//NEGYEDIK FELADAT
            legtobben();//ÖTÖDIK FELADAT
            bekeres();//HATODIK FELADAT
            meddigVoltBent();//HETEDIK FELADAT
            egyediOsszegzese();//NYOLCADIK FELADAT
        }

        private void beolvasas()
        {
            Console.WriteLine("1. feladat");
            try
            {
                sorok = File.ReadAllLines("ajto.txt", Encoding.UTF8).ToList();
                Console.WriteLine("ajto.txt sikeresen beolvasva!");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("A fájl nem található!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            for (int i = 0; i < sorok.Count; i++)
            {
                ajtok.Add(new Ajto(sorok[i]));
                if (maxBentlevok < bentvannak) maxBentlevok = bentvannak;
            }

            Console.WriteLine();
        }

        private void elsoEsUtolso()
        {
            Console.WriteLine("2. feladat");
            //ELSŐ BELÉPŐ
            for (int i = 0; i < ajtok.Count; i++)
            {
                if (ajtok[i].athaladas)
                {
                    Console.WriteLine("Az első belépő: " + ajtok[i].azonosito);
                    break;
                }
            }

            //UTOLSÓ KILÉPŐ
            for (int i = ajtok.Count-1; i > 0; i--)
            {
                if (!ajtok[i].athaladas)
                {
                    Console.WriteLine("Az utolsó kilépő: " + ajtok[i].azonosito);
                    break;
                }
            }

            Console.WriteLine();
        }

        private void athaladasok()
        {
            Console.WriteLine("3. feladat");
            Console.WriteLine("athaladas.txt nevű fájlba sikeresen elmentettem az adatokat!");
            //EGYEDI AZONOSÍTÓK KISZŰRÉSE
            List<int> azonositok = new List<int>();
            for (int i = 0; i < ajtok.Count; i++)
                if (!azonositok.Contains(ajtok[i].azonosito)) azonositok.Add(ajtok[i].azonosito);

            azonositok.Sort();

            //ÁTHALADÁSOK SZÁMA
            List<int> athaladasokSzama = new List<int>();
            for (int i = 0; i < azonositok.Count; i++)
            {
                athaladasokSzama.Add(0);
                for (int j = 0; j < ajtok.Count; j++)
                {
                    if (ajtok[j].azonosito == azonositok[i]) athaladasokSzama[i] += 1;
                }
            }

            File.WriteAllText("athaladas.txt", getAthaladasok(azonositok, athaladasokSzama));
            Console.WriteLine();
        }

        private string getAthaladasok(List<int> az, List<int> at)
        {
            string s = "";

            for (int i = 0; i < az.Count; i++)
            {
                s += az[i] + " " + at[i] + "\n";
            }

            return s;
        }

        private void bentmaradtak()
        {
            Console.WriteLine("4. feladat");
            //EGYEDI AZONOSÍTÓK KISZŰRÉSE
            List<int> azonositok = new List<int>();
            for (int i = 0; i < ajtok.Count; i++)
                if (!azonositok.Contains(ajtok[i].azonosito)) azonositok.Add(ajtok[i].azonosito);

            //UTOLSÓ ÁTHALADÁSI ÁLLAPOT
            List<bool> utolsoStatusz = new List<bool>();
            for (int i = 0; i < azonositok.Count; i++)
            {
                utolsoStatusz.Add(false);
                for (int j = 0; j < ajtok.Count; j++)
                {
                    if (ajtok[j].azonosito == azonositok[i]) utolsoStatusz[i] = ajtok[j].athaladas;
                }
            }

            //KIIRATÁS
            List<int> beszoktek = new List<int>();
            Console.Write("A végén bentmaradtak: ");
            for (int i = 0; i < azonositok.Count; i++)
                if (utolsoStatusz[i]) beszoktek.Add(azonositok[i]);

            beszoktek.Sort();
            for (int i = 0; i < beszoktek.Count; i++)
            {
                if (i < beszoktek.Count - 1) Console.Write(beszoktek[i] + ", ");
                else Console.Write(beszoktek[i] + ".");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        private void legtobben()
        {
            Console.WriteLine("5. feladat");
            int jelenlegi = 0;

            for (int i = 0; i < ajtok.Count; i++)
            {
                if (ajtok[i].athaladas) jelenlegi++;
                else jelenlegi--;

                if (jelenlegi == maxBentlevok)
                {
                    Console.WriteLine("Ekkor voltak bent a legtöbben: " + ajtok[i].ora + ":" + ajtok[i].perc);
                    break;
                }
            }

            Console.WriteLine();
        }

        private int egyediAzonosito;

        private void bekeres()
        {
            Console.WriteLine("6. feladat");
            Console.Write("Kérem adjon meg egy azonosítót: ");
            Int32.TryParse(Console.ReadLine(), out egyediAzonosito);
            Console.WriteLine();
        }

        private void meddigVoltBent()
        {
            Console.WriteLine("7. feladat");
            string idopontok = "";

            for (int i = 0; i < ajtok.Count; i++)
            {
                if (ajtok[i].azonosito == egyediAzonosito)
                {
                    idopontok += ajtok[i].ora + ":" + ajtok[i].perc;
                    if (ajtok[i].athaladas) idopontok += " - ";                  
                    else idopontok += "\n";                   
                }
            }

            Console.WriteLine(idopontok);

            Console.WriteLine();
        }

        private void egyediOsszegzese()
        {
            Console.WriteLine("8. feladat");
            //BENT VOLT E A VÉGÉN
            bool vegenBentvolt = false;
            for (int i = 0; i < ajtok.Count; i++)
            {
                if (ajtok[i].azonosito == egyediAzonosito) vegenBentvolt = ajtok[i].athaladas;
            }

            int benttoltottPercek = 0;
            int belepesPercben = 0;
            for (int i = 0; i < ajtok.Count; i++)
            {
                if (ajtok[i].azonosito == egyediAzonosito)
                {
                    if (ajtok[i].athaladas) belepesPercben = ajtok[i].ora * 60 + ajtok[i].perc;                   
                    else benttoltottPercek += (ajtok[i].ora * 60 + ajtok[i].perc) - belepesPercben;
                }
            }

            if (vegenBentvolt) benttoltottPercek += (15 * 60) - belepesPercben;

            if (vegenBentvolt) Console.WriteLine("A(z) " + egyediAzonosito + ". személy összesen " + benttoltottPercek + " percet volt bent, a megfigyelés végén a társalgóban volt.");
            else Console.WriteLine("A(z) " + egyediAzonosito + ". személy összesen " + benttoltottPercek + " percet volt bent, a megfigyelés végén a társalgón kívül volt.");
        }

        static void Main(string[] args)
        {
            new Program();
            Console.ReadKey();
        }
    }
}
