using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {

        string[] matrixTable = new string[100];//Veszünk egy üres tömböt, amiben később a pályát tároljuk. Defaultban ez egy 10x10-es pálya
        Random random = new Random();//Globális random változó
        string winner = "";//Ez jelzi majd, hogy ki nyert

        Program()
        {
            introduction();//Bevezetés metódus, a játék kezdése
        }

        void introduction()
        {//Egy kis rövidke felvezetés, amiben leírjuk a szabályokat és a játék lényegét
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Üdvözöllek a Mátrixban!");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Ebben az amőba szerű játékban a számítógéped ellen fogsz megküzdeni.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Játékszabályok:");
            Console.WriteLine(" - Átlósan, függőlegesen, vagy vízszintesen kell 5 meződnek lennie egymás mellet, hogy nyerhess");
            Console.WriteLine(" - A foglalt mezőket már nem választhatod");
            Console.WriteLine(" - Az ,,Exit'' paranccsal bármikor kiléphetsz a játékból");
            userData(false);//Mivel először játszik a felhasználó, ezért hamissal hívom meg           
        }

        string name;//Játékos neve
        int size;//Választott pályaméret 5 és 10 között (mezők száma = size^2)

        void userData(bool played)
        {//A felhasználótól elkérünk adatokat
            size = 0;//Mivel új játék, ezért lenullázzuk a pályaméretet
            steps = 0;//Mivel új játék, ezért lenullázzuk az eltelt körök számát
            winner = "";//Mivel új játék, ezért lenullázzuk a nyertest, különben ha egyszer nyerünk vagy vesztünk, nem tudjuk újrakezdeni a játékot
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Mekkora pályán szeretnél játszani? (5-10 között) ");
            Console.ForegroundColor = ConsoleColor.Green;
            Int32.TryParse(Console.ReadLine(), out size);//int-té alakítjuk a pályaméretet
            if (size < 5 || size > 10)
            {//Ha a játékos helytelen választ ad, kérje újra
                Console.Clear();//Töröljük a képernyőt az átláthatóság érdekében
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hibás érték!");
                userData(played);//Rekurzió saját paraméterrel
            }
            else matrixTable = new string[size*size];//Mivel négyzet alakú a pálya, ezért a tömb mérete a választott méret négyzete lesz
            if (!played)
            {//Ha újrakezdi a játékot, akkor ne kérje be megint a nevét
                name = "";//Mivel először játszik a felhasználó, ezért a nevet kiürítjük, mert ha játszott, akkor nem fogjuk újra bekérni
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Hogy szólíthatlak? ");
                Console.ForegroundColor = ConsoleColor.Green;
                name = Console.ReadLine();//Elkérjük a játékos nevét
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Köszönöm az adatokat!");//Illedelmesen megköszönünk neki mindent, mivel jófej fejlesztők vagyunk
            }//Éppen kávét ittam mikor írtam ezt a kommentet
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Nyomj egy gombot a kezdéshez!");
            Console.ReadKey();
            createEmptyMatrik();//Készítünk egy üres pályát
            stepMatrix();//Elkezdjük az első kört
        }

        void analyze()
        {
            //Víszzintes egyezés
            for (int i = 0; i < matrixTable.Length; i++)
            {
                if (matrixTable[i] == "O" && i <= Math.Sqrt(matrixTable.Length))
                {
                    if (matrixTable[i+1] == "O" && i <= Math.Sqrt(matrixTable.Length))
                    {
                        if (matrixTable[i+2] == "O" && i <= Math.Sqrt(matrixTable.Length))
                        {
                            if (matrixTable[i+3] == "O" && i <= Math.Sqrt(matrixTable.Length))
                            {
                                if (matrixTable[i+4] == "O" && i <= Math.Sqrt(matrixTable.Length))
                                {
                                    winner = "O";//Így vannak egymás mellett a mezők
                                }
                            }
                        }
                    }
                }

                if (matrixTable[i] == "X" && i <= Math.Sqrt(matrixTable.Length))
                {
                    if (matrixTable[i + 1] == "X" && i <= Math.Sqrt(matrixTable.Length))
                    {
                        if (matrixTable[i + 2] == "X" && i <= Math.Sqrt(matrixTable.Length))
                        {
                            if (matrixTable[i + 3] == "X" && i <= Math.Sqrt(matrixTable.Length))
                            {
                                if (matrixTable[i + 4] == "X" && i <= Math.Sqrt(matrixTable.Length))
                                {
                                    winner = "X";//ugyanez a gépre is
                                }
                            }
                        }
                    }
                }
            }
            try
            {
                //Függőleges egyezés
                for (int i = 0; i < matrixTable.Length; i++)
                {
                    if (matrixTable[i] == "O" && i <= Math.Sqrt(matrixTable.Length))
                    {
                        if (matrixTable[i + (int)Math.Sqrt(matrixTable.Length)] == "O")
                        {
                            if (matrixTable[i + (int)Math.Sqrt(matrixTable.Length) * 2] == "O")
                            {
                                if (matrixTable[i + (int)Math.Sqrt(matrixTable.Length) * 3] == "O")
                                {
                                    if (matrixTable[i + (int)Math.Sqrt(matrixTable.Length) * 4] == "O")
                                    {
                                        winner = "O";//Így vannak egymás alatt a mezők
                                    }
                                }
                            }
                        }
                    }

                    if (matrixTable[i] == "X" && i <= Math.Sqrt(matrixTable.Length))
                    {
                        if (matrixTable[i + (int)Math.Sqrt(matrixTable.Length)] == "X")
                        {
                            if (matrixTable[i + (int)Math.Sqrt(matrixTable.Length) * 2] == "X")
                            {
                                if (matrixTable[i + (int)Math.Sqrt(matrixTable.Length) * 3] == "X")
                                {
                                    if (matrixTable[i + (int)Math.Sqrt(matrixTable.Length) * 4] == "X")
                                    {
                                        winner = "X";//ugyanez a gépre is
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (IndexOutOfRangeException) {}//Nemtudom itt miért kapok exceptiont, de ha elkapom akkor tökéletesen működik

            //Főátlós egyezés
            for (int i = 0; i < matrixTable.Length; i++)
            {
                if (matrixTable[i] == "O" && i <= Math.Sqrt(matrixTable.Length))
                {
                    if (matrixTable[i + (int)Math.Sqrt(matrixTable.Length)+1] == "O")
                    {
                        if (matrixTable[i + (int)Math.Sqrt(matrixTable.Length) * 2 + 2] == "O")
                        {
                            if (matrixTable[i + (int)Math.Sqrt(matrixTable.Length) * 3 + 3] == "O")
                            {
                                if (matrixTable[i + (int)Math.Sqrt(matrixTable.Length) * 4 + 4] == "O")
                                {
                                    winner = "O";//Ugyanaz mintha egymás alatt lennének, csak eggyel kell jobbra lépni
                                }
                            }
                        }
                    }
                }

                if (matrixTable[i] == "X" && i <= Math.Sqrt(matrixTable.Length))
                {
                    if (matrixTable[i + (int)Math.Sqrt(matrixTable.Length)+1] == "X")
                    {
                        if (matrixTable[i + (int)Math.Sqrt(matrixTable.Length) * 2 + 2] == "X")
                        {
                            if (matrixTable[i + (int)Math.Sqrt(matrixTable.Length) * 3 + 3] == "X")
                            {
                                if (matrixTable[i + (int)Math.Sqrt(matrixTable.Length) * 4 + 4] == "X")
                                {
                                    winner = "X";//ugyanez a gépre is
                                }
                            }
                        }
                    }
                }
            }

            //Mellékátlós egyezés
            for (int i = 0; i < matrixTable.Length; i++)
            {
                if (matrixTable[i] == "O" && i <= Math.Sqrt(matrixTable.Length))
                {
                    if (matrixTable[i + (int)Math.Sqrt(matrixTable.Length) - 1] == "O")
                    {
                        if (matrixTable[i + (int)Math.Sqrt(matrixTable.Length) * 2 - 2] == "O")
                        {
                            if (matrixTable[i + (int)Math.Sqrt(matrixTable.Length) * 3 - 3] == "O")
                            {
                                if (matrixTable[i + (int)Math.Sqrt(matrixTable.Length) * 4 - 4] == "O")
                                {
                                    winner = "O";//Ugyanaz mintha egymás alatt lennének, csak eggyel kell balra lépni
                                }
                            }
                        }
                    }
                }

                if (matrixTable[i] == "X" && i <= Math.Sqrt(matrixTable.Length))
                {
                    if (matrixTable[i + (int)Math.Sqrt(matrixTable.Length) - 1] == "X")
                    {
                        if (matrixTable[i + (int)Math.Sqrt(matrixTable.Length) * 2 - 2] == "X")
                        {
                            if (matrixTable[i + (int)Math.Sqrt(matrixTable.Length) * 3 - 3] == "X")
                            {
                                if (matrixTable[i + (int)Math.Sqrt(matrixTable.Length) * 4 - 4] == "X")
                                {
                                    winner = "X";//ugyanez a gépre is
                                }
                            }
                        }
                    }
                }
            }
        }

        int steps = 0;//Eltelt körök száma

        void stepMatrix()
        {
            steps++;
            int idX = 0;//X koordináta
            int idY = 0;//Y koordináta
            int id = 0;//A koordinátákkal megadott szám helye a tömbben
            Console.Clear();//Töröljük a képernyőt, hogy átlátható legyen
            printMatrix();//Megjelenítjük a pályát
            analyze();//Megnézzük, hogy nyert e valaki
            if (matrixTable.Contains("_") && winner == "")
            {//Ha van a pályán üres mező...
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("\nHova szeretnél lépni? (X,Y): ");
                Console.ForegroundColor = ConsoleColor.Green;
                string answer = Console.ReadLine();
                answer.Trim();

                try
                {
                    if (answer.ToLower().Equals("exit"))
                    {//Ha a játékos kiszeretne lépni
                        Environment.Exit(0);
                    }
                    else
                    {
                        if (answer.Length > 1)
                        {
                            Int32.TryParse(answer.Substring(0, 1), out idX);//számmá alakítjuk az X koordinátát
                            Int32.TryParse(answer.Substring(answer.IndexOf(",") + 1), out idY);//számmá alakítjuk az Y koordinátát
                            id = idX * (int)Math.Sqrt(matrixTable.Length) + idY;
                            if (idY > Math.Sqrt(matrixTable.Length) && idX > Math.Sqrt(matrixTable.Length)) throw new IndexOutOfRangeException();
                        }
                        else throw new IndexOutOfRangeException();
                    }
                }
                catch (IndexOutOfRangeException)
                {

                    idX = 0;
                    idY = 0;
                    stepMatrix();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Hibás koordináta!");
                }

                try
                {
                    if (matrixTable[id] != "X" && matrixTable[id] != "O")
                    {
                        if (id <= matrixTable.Length)
                        {
                            if (idY < Math.Sqrt(matrixTable.Length) && idX < Math.Sqrt(matrixTable.Length))
                            {
                                matrixTable[id] = "O";
                                if (matrixTable.Contains("_"))
                                {
                                    botTurn();
                                    stepMatrix();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("A pálya betelt!");
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.Write("Újrakezded? (Igen/Nem) ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    string restart = Console.ReadLine().Trim().ToLower();
                                    if (restart == "igen") userData(true);
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Nyomj egy gombot a kilépéshez...");
                                    }
                                }
                            }
                            else throw new IndexOutOfRangeException();
                        }
                        else throw new IndexOutOfRangeException();
                    }
                    else if (matrixTable[id] == "X")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nEz a mező már foglalt a gép által!");
                        id = 0;
                        sleep();
                        stepMatrix();
                    }
                    else if (matrixTable[id] == "O")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nEz a mező már a tiéd!");
                        id = 0;
                        sleep();
                        stepMatrix();
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nHibás koordináta!");
                    idX = 0;
                    idY = 0;
                    sleep();
                    stepMatrix();
                }
            }
            else if (!matrixTable.Contains("_"))
            {//Ha betelt a pálya
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A pálya betelt!");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Újrakezded? (Igen/Nem) ");
                Console.ForegroundColor = ConsoleColor.Green;
                string restart = Console.ReadLine().Trim().ToLower();
                if (restart == "igen") new Program();
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Nyomj egy gombot a kilépéshez...");
                }
            }
            else if (winner != "")
            {
                if (winner == "O")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nGratulálok, győztél!");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Újrakezded? (Igen/Nem) ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    string restart = Console.ReadLine().Trim().ToLower();
                    if (restart == "igen") userData(true);
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Nyomj egy gombot a kilépéshez...");
                    }
                }

                else if (winner == "X")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nSajnálom, vesztettél!");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Újrakezded? (Igen/Nem) ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    string restart = Console.ReadLine().Trim().ToLower();
                    if (restart == "igen") userData(true);
                    else if (restart == "nem")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Nyomj egy gombot a kilépéshez...");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Megértem, ha mérges vagy, de legközelebb kérlek normálisan válaszolj!");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Nyomj egy gombot a kilépéshez...");
                    }
                }
            }
        }

        void sleep()
        {//3 másodpercig szünet visszaszámlálással
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Folytatás ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("3");
            Thread.Sleep(250);
            Console.Write(".");
            Thread.Sleep(250);
            Console.Write(".");
            Thread.Sleep(250);
            Console.Write(".");
            Thread.Sleep(250);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("2");
            Thread.Sleep(250);
            Console.Write(".");
            Thread.Sleep(250);
            Console.Write(".");
            Thread.Sleep(250);
            Console.Write(".");
            Thread.Sleep(250);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("1");
            Thread.Sleep(250);
            Console.Write(".");
            Thread.Sleep(250);
            Console.Write(".");
            Thread.Sleep(250);
            Console.Write(".");
            Thread.Sleep(250);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("0");
        }

        void botTurn()
        {//A bot random választ magának egy mezőt
            int botStep = random.Next(0, matrixTable.Length);
            while (matrixTable[botStep] != "_")
            {
                botStep = random.Next(0, matrixTable.Length);

            }
            matrixTable[botStep] = "X";
        }

        void createEmptyMatrik()
        {
            for (int i = 0; i < matrixTable.Length; i++)
            {
                matrixTable[i] = "_";//Feltöltjük a pályát üres mezőkkel
            }
        }

        void printMatrix()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Játékos neve: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(name);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Választott méret: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(size + "*" + size);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(steps + ".");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" kör ebben a játékmenetben");

            Console.WriteLine();
            int rowCount = 0;//Hányadik mezőnél járunk
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("   Y ");//Y tengely jelző
            for (int i = 0; i < Math.Sqrt(matrixTable.Length); i++)
            {
                Console.Write(i + " ");//Majd az Y koordináták kiírása
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("X| ");//X tengely jelző
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < Math.Sqrt(matrixTable.Length)+1; i++)
            {//Vonalak az Y számai alá
                Console.Write("¯" + " ");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("0|   ");//A 0-dik
            for (int i = 0; i < matrixTable.Length; i++)
            {
                rowCount++;//Mező számláló növelése
                if (matrixTable[i] == "X")
                {//Gép választásai
                    Console.ForegroundColor = ConsoleColor.Red;                    
                }
                else if (matrixTable[i] == "O")
                {//Játékos választásai
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else
                {//Üres mezők
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.Write(matrixTable[i] + " ");
                if (rowCount % Math.Sqrt(matrixTable.Length) == 0)
                {
                    Console.WriteLine();//minden tizedik mező után egy sortörés, így kapunk egy 10x10-es pályát
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (rowCount/ Math.Sqrt(matrixTable.Length) != 0 && rowCount/ Math.Sqrt(matrixTable.Length) != Math.Sqrt(matrixTable.Length)) Console.Write(rowCount/ Math.Sqrt(matrixTable.Length) + "|   ");
                }                
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "hdani1337-Matrix";
            new Program();           
            Console.ReadKey();
        }
    }
}
