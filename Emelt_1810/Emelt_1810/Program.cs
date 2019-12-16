using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Emelt_1810
{
    class Program
    {
        private Program()
        {
            init();
            masodikFeladat();
            harmadikFeladat();
            negyedikFeladat();
            otodikFeladat();
            hatodikFeladat();
        }

        private List<string> keritesSorok = new List<string>();
        private List<Kerites> keritesek = new List<Kerites>();

        private void init()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1. feladat");
            Console.ForegroundColor = ConsoleColor.Yellow;
            try
            {
                keritesSorok = File.ReadAllLines("kerites.txt", Encoding.UTF8).ToList();             
                Console.WriteLine("Kerítések adatai sikeresen eltárolva!");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            for (int i = 0; i < keritesSorok.Count; i++)
            {
                keritesek.Add(new Kerites(keritesSorok[i]));
            }

            Console.WriteLine();
        }

        private void masodikFeladat()
        {
            int hazszam = 0;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("2. feladat");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(keritesek.Count + " darab telket adtak el az utcában.");
            Console.WriteLine();
            for (int i = 0; i < keritesek.Count-1; i++)
            {
                if (i == 0)
                {
                    if (keritesek[i].paros) hazszam += 2;
                    else hazszam++;
                }
                else
                {
                    if (keritesek[i].paros && !keritesek[i + 1].paros) hazszam++;
                    else if (!keritesek[i].paros && keritesek[i + 1].paros) hazszam++;
                 
                }
            }
            Console.WriteLine(hazszam);
        }

        private void harmadikFeladat()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("3. feladat");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string paros = "";
            if (keritesek.Last().paros) paros = "páros";
            else paros = "páratlan";

            Console.WriteLine("Az utolsó telek a " + paros + " oldalon van, a házszáma " + keritesek.Count + ".");
            Console.WriteLine();
        }

        private void negyedikFeladat()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("4. feladat");
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < keritesek.Count - 1; i++)
            {
                if (!keritesek[i].paros && !keritesek[i + 1].paros)
                {
                    if (keritesek[i].szin == keritesek[i + 1].szin)
                    {
                        if (keritesek[i].szin != "#" && keritesek[i + 1].szin != ":")
                        {
                            Console.WriteLine("A(z) " + i + ". számú és a(z) " + (i+1) + ". számú ház kerítés színe megegyezik, színe: " + keritesek[i].szin + ".");
                            break;
                        }
                    }
                }
            }
            Console.WriteLine();
        }

        private Random random = new Random();

        private void otodikFeladat()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("5. feladat");
            Console.ForegroundColor = ConsoleColor.Green;
            int valasztottSzam;
            Console.Write("Kérek egy házszámot: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Int32.TryParse(Console.ReadLine(), out valasztottSzam);
            Console.ForegroundColor = ConsoleColor.Yellow;
            string szin = "";
            if (keritesek[valasztottSzam - 1].szin == "#") szin = "Befestetlen";
            else if (keritesek[valasztottSzam - 1].szin == ":") szin = "Nincs kerítés";
            else szin = keritesek[valasztottSzam - 1].szin;

            Console.WriteLine("A választott ház kerítésének színe vagy állapota: " + szin);

            string[] szinpaletta = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z".Split(' ');
            string newPaletta = "";
       
            for (int i = 0; i < szinpaletta.Length; i++)
            {
                if (valasztottSzam > 1)
                {
                    if (szinpaletta[i] == keritesek[valasztottSzam - 1].szin || szinpaletta[i] == keritesek[valasztottSzam - 2].szin || szinpaletta[i] == keritesek[valasztottSzam].szin) szinpaletta[i] = "";
                    else newPaletta += szinpaletta[i] + " ";
                }
                else
                {
                    if (szinpaletta[i] == keritesek[valasztottSzam - 1].szin || szinpaletta[i] == keritesek[valasztottSzam].szin) szinpaletta[i] = "";
                    else newPaletta += szinpaletta[i] + " ";
                }
              
            }

            szinpaletta = newPaletta.Split(' ');

            Console.WriteLine("Egy lehetséges szín a kerítéshez: " + szinpaletta[random.Next(0,szinpaletta.Length)]);
            Console.WriteLine();
        }

        private void hatodikFeladat()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("6. feladat");
            Console.ForegroundColor = ConsoleColor.Yellow;

            string utcakepFelso = "";
            string utcakepAlso = "";
            for (int i = 0; i < keritesek.Count; i++)
            {
                if (keritesek[i].paros == false)
                {
                    utcakepAlso += i;
                    for (int j = 0; j < keritesek[i].szelesseg; j++)
                    {
                        utcakepFelso += keritesek[i].szin;
                        if (j < keritesek[i].szelesseg - i.ToString().Length) utcakepAlso += " ";
                    }
                }
            }

            File.WriteAllText("utcakep.txt", utcakepFelso);
            File.AppendAllText("utcakep.txt", "\n" + utcakepAlso);

            Console.WriteLine("Az utcakép sikeresen mentésre került a /bin/Debug/utcakep.txt fájlba.");
        }

        private static void Main(string[] args)
        {
            new Program();
            Console.ReadKey();
        }
    }
}
