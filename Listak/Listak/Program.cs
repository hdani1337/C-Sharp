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
            //bevezetes();
            uraim();
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

        Random random = new Random();
        List<int> lolka = new List<int>();//Lolka lapjai
        List<int> bolka = new List<int>();//Bolka lapjai
        bool isPlayerBolka;//Játékos Bolka e
        byte isPlayerRound;//Ki nyerte a kört (0-Döntetlen, 1-Játékos, 2-Gép)

        void uraim()
        {
            feltoltes();//Lapok feltöltve        
            karakter();//Karakterválasztás  
            round();//Első kör elkezdése
        }

        int jatekosSzama;//Játékos száma
        int roundCount = 1;//Körök száma

        void round()
        {//Új kör           
            Console.Title = "Játékos neve: " + getPlayerName() + " - " + roundCount + ". kör";//A címsor frissítése
            roundCount++;//Növeljük a körök számát, ez a címsorba van kiírva
            gepHuz();//A gép húz egy lapot
            jatekosHuz();//A játékos húz egy lapot
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(getPlayerName() + " száma: " + jatekosSzama);
            Console.WriteLine(getGepNev() + " száma: " + gepSzama);
            compare();//A lapok összehasonlítása
            shuffle();//Játékos lapjainak kiiratása
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(getPlayerArray().Count + " darab lapod maradt.");
            printLapok();//Játékos lapjainak kiírása     
            if (lolka.Count > 1 && bolka.Count > 1) round();//Hogyha a játékosoknak egynél több lapja van, új kör kezdődik
            else
            {//Ha valakinek csak egy lapja maradt
                Console.Clear();           
                if (lolka.Count == 1)
                {//Ha Lolka lapjai fogytak el
                    if(getPlayerName() == "Bolka") Console.ForegroundColor = ConsoleColor.Green;
                    else Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nBolka nyert!");
                }
                else if (bolka.Count == 1)
                {//Ha Bolka lapjai fogytak el
                    if (getPlayerName() == "Lolka") Console.ForegroundColor = ConsoleColor.Green;
                    else Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nLolka nyert!");
                }
            }
        }

        void printLapok()
        {//Játékos lapjainak kiiratása
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("A lapjaid: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            getPlayerArray().Sort();//A lapok sorbarendezése
            for (int i = 0; i < getPlayerArray().Count; i++)
            {
                if (i < getPlayerArray().Count-1) Console.Write(getPlayerArray()[i] + ", ");
                else Console.Write(getPlayerArray()[i] + ".\n");
            }
        }

        void jatekosHuz()
        {//A játékos húz egy lapot
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Kérlek add meg a választott lapod értékét: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Int32.TryParse(Console.ReadLine(), out jatekosSzama);
            if (!getPlayerArray().Contains(jatekosSzama))
            {//Ha a beírt érték nem szerepel a játékos lapjainak tömbjében
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nincs ilyen kártyád. Újra!");
                jatekosHuz();
            }
            Console.Clear();//A konzolablak kiürítése
        }

        void shuffle()
        {
            if (isPlayerRound == 1)
            {//Játékos nyerte a kört
                getPlayerArray().Add(gepSzama);//Odaadjuk a lapot a játékosnak
                getGepArray().RemoveAt(getGepArray().IndexOf(gepSzama));//Elvesszük a lapot a géptől
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Megkaptad " + getGepNev() + " számát, ami a " + gepSzama + ".");
            }
            else if (isPlayerRound == 2)
            {//Gép nyerte a kört
                getPlayerArray().RemoveAt(getPlayerArray().IndexOf(jatekosSzama));//Elvesszük a lapot a játékostól
                getGepArray().Add(jatekosSzama);//Odaadjuk a lapot a gépnek
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(getGepNev() + " megkapta a számodat, ami a " + jatekosSzama + ".");
            }
            else if (isPlayerRound == 0)
            {//Döntetlen
                getPlayerArray().RemoveAt(getPlayerArray().IndexOf(jatekosSzama));//Elvesszük a lapot a géptől
                getGepArray().RemoveAt(getGepArray().IndexOf(jatekosSzama));//Elvesszük a lapot a játékostól
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ez a kör döntetlen.");
            }
        }

        void compare()
        {//A lapok összehasonlítása
            if (jatekosSzama == gepSzama) isPlayerRound = 0;//Döntetlen
            else if (jatekosSzama > gepSzama) isPlayerRound = 1;//Játékos nyerte a kört
            else isPlayerRound = 2;//Gép nyerte a kört
        }

        void feltoltes()
        {//Kiosztjuk a játékosoknak a lapokat
            for (int i = 1; i <= 20; i++)
            {
                lolka.Add(i);
                bolka.Add(i);
            }
        }

        int gepSzama;//A gép száma

        void gepHuz()
        {//A gép húz egy lapot
            if (isPlayerBolka) gepSzama = lolka[random.Next(0, lolka.Count)];//Ha a játékos Bolka, akkor Lolkaként húzzon a gép
            else gepSzama = bolka[random.Next(0, bolka.Count)];//Ha a játékos nem Bolka, akkor Bolkaként húzzon a gép
        }

        void karakter()
        {//Karakterválasztás
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Lolka akarsz lenni, vagy Bolka?: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string answer = Console.ReadLine();
            if (answer.ToLower() == "lolka") isPlayerBolka = false;
            else if (answer.ToLower() == "bolka") isPlayerBolka = true;
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hibás válasz. Újra!");
                karakter();//Ha hibás az érték, újat kérünk
            }
        }

        string getPlayerName()
        {//Visszaadja a játékos nevét
            return isPlayerBolka ? "Bolka" : "Lolka";
        }

        string getGepNev()
        {//Visszaadja a gép nevét
            return getPlayerName() == "Lolka" ? "Bolka" : "Lolka";
        }

        List<int> getPlayerArray()
        {//Visszaadja a játékos lapjainak tömbjét
            return isPlayerBolka ? bolka : lolka;
        }

        List<int> getGepArray()
        {//Visszaadja a gép lapjainak tömbjét
            return getPlayerName() == "Lolka" ? bolka : lolka;
        }

        static void Main(string[] args)
        {
            new Program();
            Console.WriteLine("\nNyomj egy gombot a kilépéshez...");
            Console.ReadKey();
        }
    }
}
