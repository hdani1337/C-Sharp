using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masodik
{
    class Program
    {
        public Program() {
            elsoMetodus();
        }

        public void elsoMetodus() {
            bool k = oszthato(5, 2);
            Console.WriteLine("Osztható e az 5 a kettővel? " + k);

            int szam = helyiSzam(123, 0);
            Console.WriteLine("123 0-dik értéke: " + szam);

            int hossz = szamHossza(1782);
            Console.WriteLine("1782 hossza: " + hossz);

            int szam2 = helyiSzam2(1782, 2);
            Console.WriteLine("1782 2-dik értéke: " + szam2);

            int forditott = forditSzam(17825);
            Console.WriteLine("17825-ös szám fordítva: " + forditott);

            Console.Write("\nKérek egy számot: ");
            int n;

            do {
                n = (Convert.ToInt32(Console.ReadLine()));
                if (!tukorSzam(n)) {
                    Console.WriteLine("Nem tükörszám!");
                    Console.Write("\nKérek egy számot: ");
                }
            } while (!tukorSzam(n));
            Console.WriteLine("Tükörszám!");
        }

        public void masodikMetodus() {

        }

        public bool tukorSzam(int szam) {
            bool p = false;

            if (szam == forditSzam(szam))
            {
                p = true;
            }

            return p;
        }

        public int helyiSzam(int szam, int hely) {
            int hossz = szam.ToString().Length;

            if (hossz < hely) {
                return -1;
            }

            return Convert.ToInt32(szam.ToString()[hely]+"");
        }

        public int helyiSzam2(int szam, int hely) {
            int temp = -1;

            if (szamHossza(szam) < hely) {
                return -1;
            }

            for (int i = 0; i <= hely; i++) {
                temp = szam % 10;
                szam = szam / 10;
            }

            return temp;
        }

        public int forditSzam(int szam)//csak háromjegyű szám esetén
        {
            int vegeredmeny = 0;
            int hossz = szamHossza(szam);
            
            /*
            int temp;
            int temp2;
            int temp3;
            int temp4;

            switch (hossz) {
                case 3: {//ha háromjegyű
                        temp = (szam % 10) * 100;//Százas
                        temp2 = ((szam % 100) / 10) * 10;//Tízes
                        temp3 = (szam / 100);//Egyes
                        vegeredmeny = temp + temp2 + temp3;
                        break;
                    }
                case 2: {//ha kétjegyű
                        temp = (szam % 10) * 10;//Egyesből tízes
                        temp2 = (szam / 10);//Tízesből egyes
                        vegeredmeny = temp + temp2;
                        break;
                    }
                case 4: {
                        temp = (int)(szam / 1000) * 1000;//Ezresből helyi értéke
                        temp2 = (int)(szam / 100) * 100 - temp;//Százas heyli értéke
                        temp3 = (int)(szam / 10) * 10 - temp2 - temp;//Tízes helyi értéke
                        temp4 = (int)(szam / 1) * 1 - temp3 - temp2 - temp;//Egyes helyi értéke
                        vegeredmeny = Convert.ToInt32(temp4 + "" + (temp3/10) + "" + (temp2 / 100) + "" + (temp / 1000));//Kiírás fordítva
                        break;
                    }
            }
            */

            for (int i = hossz-1; i >= 0; i--) {
                vegeredmeny += (szam % 10) * (int)Math.Pow(10, i);//Pow a szám négyzetre emelése, hatványozása
                szam /= 10;
            }

            return vegeredmeny;
        }

        public int szamHossza(int szam) {
            int hossz = 0;
            //int temp = -1;

            while (szam != 0) {
                szam /= 10; //szam = szam/10
                hossz++;
            }


            return hossz;
        }

        public bool oszthato(int a, int b) {
            bool o = true;

            o = (a%b==0);//egyszerűsített feltétel

            return o;
        }

        static void Main(string[] args)
        {
            new Program();
            Console.ReadKey();
        }
    }
}
