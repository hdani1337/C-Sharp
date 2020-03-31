using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Beadandó_200417
{
    /// <summary>
    /// A 2018-as májusi emelt érettségi Access feladatai C#-ban
    /// Csak azért sem használtam Linq-t sehol
    /// Minden egyes gomb 1-1 feladatot jelöl, ahogy az magától értetendő
    /// A feladatok számát eggyel csúsztattam hátra, mivel az első feladat a fájlok beolvasása, ami inkább nulladik feladat, mert olyan alapszintű
    /// </summary>
    public partial class Erettsegi : Form
    {
        public List<Foglalkozas> foglalkozasok;
        public List<Kituntetes> kituntetesesek;
        public List<Szemely> szemelyek;
        public Erettsegi(Login login)
        {
            InitializeComponent();
            beolvasas();
            login.Visible = false;
        }

        private void beolvasas()
        {
            List<string> sorok;
            
            foglalkozasok = new List<Foglalkozas>();
            kituntetesesek = new List<Kituntetes>();
            szemelyek = new List<Szemely>();

            try
            {
                //Foglalkozások beolvasása
                sorok = File.ReadAllLines("ErettsegiFeladatok/Forrasok/foglalkozas.txt", Encoding.UTF8).ToList();
                for (int i = 1; i < sorok.Count; i++)
                    foglalkozasok.Add(new Foglalkozas(sorok[i]));
                sorok = null;

                //Kitüntetések beolvasása
                sorok = File.ReadAllLines("ErettsegiFeladatok/Forrasok/kituntetes.txt", Encoding.UTF8).ToList();
                for (int i = 1; i < sorok.Count; i++)
                    kituntetesesek.Add(new Kituntetes(sorok[i]));
                sorok = null;

                //Kitüntetések beolvasása
                sorok = File.ReadAllLines("ErettsegiFeladatok/Forrasok/szemely.txt", Encoding.UTF8).ToList();
                for (int i = 1; i < sorok.Count; i++)
                    szemelyek.Add(new Szemely(sorok[i]));
                sorok = null;
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("Nem találtam meg a(z) " + e.FileName +
                                " fájlt. Ez a te hibád, nem a programozóé mert neki működött.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Hiba: " + e.Message + ". Megint elronttál valamit, tégy egy szivességet és inkább kapcsold ki a gépet.");
            }
        }

        private void elsoFeladat_Click(object sender, EventArgs e)
        {
            //Lekérdezés segítségével sorolja fel a 2016-ban kitüntetettek nevét!

            string nevek = "2016-ban díjazottak\n\n";
            
            //Végigmegyek az összes kitüntetésen
            foreach (Kituntetes k in kituntetesesek)
                //Ha az adott kitüntetést 2016-ban adták át, akkor a kiírandó üzenethez adjuk hozzá a díjazott nevét
                //A feladat nem írta, hogy betűrendben kell, szóval így tökéletes is lesz ez
                if (k.ev == 2016)
                    foreach (Szemely sz in szemelyek)
                        if (sz.azonosito == k.szemelyAzonosito)
                            nevek += sz.nev + "\n";
            
            outBox.Text = nevek;//Kiírás
        }

        private void masodikFeladat_Click(object sender, EventArgs e)
        {
            //A kritikával foglalkozó díjazottakra vagyunk kíváncsiak. Lekérdezés segítségével írassa ki
            //azoknak a nevét, akiknek a foglalkozási neve tartalmazza a „kritikus” szórészletet!
            //A listában ábécérendben minden név egyszer jelenjen meg! 

            List<string> nevek = new List<string>();//Ebben a listában lesznek a kritikusok nevei
            
            //Végigmegyünk az összes foglalkozáson
            foreach (Foglalkozas f in foglalkozasok)
                //Ha az adott foglalkozás pont a kritikus, akkor hozzáadjuk a foglalkozáshoz tartozó nevét a kritikusok listájába
                if (f.foglakozasNeve == "kritikus")
                    foreach (Szemely sz in szemelyek)
                        if (sz.azonosito == f.szemelyAzonosito)
                           nevek.Add(sz.nev);
            
            nevek.Sort();//A nevek ABC sorrendbe rendezése

            //Végül a nevek kiírása
            string output = "";
            foreach (string s in nevek)
                output += s + "\n";
            outBox.Text = "Díjazott kritikusok\n\n" + output;
        }

        private void harmadikFeladat_Click(object sender, EventArgs e)
        {
            //Készítsen lekérdezést, amely megadja, hogy kik kaptak legalább háromszor József Attila díjat és hányszor!
            
            string nevek = "Ők kaptak legalább háromszor József Attila Díjat\n\n";
            
            List<int> szemelyAzonositok = new List<int>();//Ebben a listában lesznek a személyek azonosítói
            List<int> szemelyAzonositokDarabszamai = new List<int>();//Ebben a listában lesznek a személyek díjainak száma
            
            //Kiválogatjuk a személyazonosítókat, mindegyiknek nullázzuk a darabszámát
            foreach (Szemely sz in szemelyek)
            {
                szemelyAzonositok.Add(sz.azonosito);
                szemelyAzonositokDarabszamai.Add(0);
            }

            //Végigmegyünk a személyazonosítókon
            for (int i = 0; i < szemelyAzonositok.Count; i++)
                //Azonosítónként nézzük végig a díjakat
                foreach (Kituntetes k in kituntetesesek)
                    //Ha az adott díjat a vizsgált személyazonosító kapta, akkor növeljük a díjainak számát
                    if (k.szemelyAzonosito == szemelyAzonositok[i])
                        szemelyAzonositokDarabszamai[i]++;
                    
            //Végigmegyünk a darabszámokon
            for (int i = 0; i < szemelyAzonositokDarabszamai.Count; i++)
                //Ha az adott személyazonosító legalább 3 díjat kapott, akkor adjuk hozzá a kiírandó szöveghez
                if (szemelyAzonositokDarabszamai[i] >= 3)
                    nevek += szemelyek[i].nev + "\n";
            
            outBox.Text = nevek;//Kiírás
        }

        private void negyedikFeladat_Click(object sender, EventArgs e)
        {
            //A József Attila-díjat sokféle foglalkozású ember kaphatja. Adja meg lekérdezés
            //segítségével az átadott összes díj alapján a leggyakoribb foglalkozásúak nevét!
            
            //Ez nagyon messy, igyál egy sört mielőtt ezt elkezded végignézni
            //De nyugi, mindent érthetően kommentezek, ezért nekem adhatod azt a sört
            
            List<string> egyediFoglalkozasokNeve = new List<string>();//Egyedi foglalkozások nevei
            List<string> egyediFoglalkozasokNeveSorted = new List<string>();//Ebbe kerülnek a foglalkozások nevei előfordulási sorrend szerint
            List<int> egyediekDarabszamai = new List<int>();//Egyedi foglalkozások hányszor szerepelnek
            List<int> egyediekDarabszamaiSorted;//Egyedi foglalkozások előfordulási száma növekvő sorrendben

            //Kiválogatom az egyedi foglalkozások neveit, először mindegyiknek 0 a darabszáma
            foreach (Foglalkozas f in foglalkozasok)
                if (!egyediFoglalkozasokNeve.Contains(f.foglakozasNeve))
                {
                    egyediFoglalkozasokNeve.Add(f.foglakozasNeve);
                    egyediekDarabszamai.Add(0);
                }
            
            
            //Megnézem melyik foglalkozás hányszor szerepel
            for (int i = 0; i < egyediFoglalkozasokNeve.Count; i++)
                foreach (Foglalkozas f in foglalkozasok)
                    if (egyediFoglalkozasokNeve[i] == f.foglakozasNeve)
                        egyediekDarabszamai[i]++;
            
            //Egy másik listában sorbaállítom ezeket a darabszámokat
            egyediekDarabszamaiSorted = egyediekDarabszamai;
            egyediekDarabszamaiSorted.Sort();

            //Az ismétlődések miatt egy harmadik listába kiválogatom az egyedi darabszámokat, amik már sorban vannak
            //Mivel növekvő sorrendben vannak ezért hátulról indulunk
            List<int> egyediRendezettDarabszamok = new List<int>();
            for (int i = egyediekDarabszamaiSorted.Count-1; i > 0; i--)
                if(!egyediRendezettDarabszamok.Contains(egyediekDarabszamaiSorted[i]))
                    egyediRendezettDarabszamok.Add(egyediekDarabszamaiSorted[i]);
            

            //Visszafele végigmegyünk az egyedi darabszámokon, a legnagyobbtól a legkisebbik
            //Ha valamelyik darabszámhoz egyezik egy vagy több foglalkozás neve, akkor azt hozzáadjuk MÉG EGY listához
            //Ebben a listában már sorban lesznek a foglalkozásnevek, amelyik a legtöbbször szerepelt az az elején, amelyik a legkevesebbszer, az a végén
            for (int i = egyediRendezettDarabszamok.Count-1; i > 0 ; i--)
                for (int k = 0; k < egyediekDarabszamai.Count; k++)
                    if (egyediekDarabszamai[k] == egyediRendezettDarabszamok[i])
                        egyediFoglalkozasokNeveSorted.Add(egyediFoglalkozasokNeve[k]);
            
            //Kiiratás, ez gondolom magától értetendő
            //Azt már biztos ki nem írom, hogy melyik hányszor volt
            string output = "Leggyakoribb foglalkozások\n\n";
            for (int i = 0; i < egyediFoglalkozasokNeveSorted.Count; i++)
                output += (i+1) + ". " + egyediFoglalkozasokNeveSorted[i] + "\n";
            outBox.Text = output;
        }

        private void otodikFeladat_Click(object sender, EventArgs e)
        {
            //Bertha Bulcsu több évben is részesült elismerésben. Sorolja fel lekérdezés segítségével
            //Bertha Bulcsu-val együtt azoknak a nevét, akik ezekben az években kaptak kitüntetést!
            //A név mellett a kitüntetés évét is jelenítse meg! 

            Szemely bertha = null;
            
            foreach (Szemely sz in szemelyek)
                if (sz.nev == "Bertha Bulcsu") {
                    bertha = sz;
                    break;
                }
            
            //Nullkezelés, előfordulhat hogy nincs bent az adatbázisban, ami lehetetlen, de azért biztosra kell menni
            if (bertha != null)
            {
                //Bertha ezekben az években kapott díjat
                List<int> berthaEvei = new List<int>();
                foreach (Kituntetes k in kituntetesesek)
                    if (k.szemelyAzonosito == bertha.azonosito)
                        if (!berthaEvei.Contains(k.ev))
                            berthaEvei.Add(k.ev);
                
                berthaEvei.Sort(); //Menjünk időrendben

                //Az egyidőben díjazottak nevei és évszámai
                List<string> dijazottNevei = new List<string>();
                List<int> dijazottEvei = new List<int>();

                //Szálljanak az évek...
                foreach (int ev in berthaEvei)
                    //Évenként végigmegyünk a kitüntéseken
                    foreach (Kituntetes k in kituntetesesek)
                        //Ha ugyanabban az évben adták át a díjat, amikor Bertha is kapta
                        if (k.ev == ev)
                        {
                            //Hozzáadjuk az évet és a személy nevét a listához
                            dijazottEvei.Add(ev);
                            foreach (Szemely sz in szemelyek)
                                if (sz.azonosito == k.szemelyAzonosito)
                                {
                                    dijazottNevei.Add(sz.nev);
                                    break;
                                }
                            
                        }
                
                //Kiiratás időrendben
                string output = "";
                for (int i = 0; i < dijazottNevei.Count; i++)
                    output += dijazottEvei[i] + ": " + dijazottNevei[i] + "\n";
                outBox.Text = output;
            }
        }

        private void hatodikFeladat_Click(object sender, EventArgs e)
        {
            //Készítsen jelentést arról, hogy a 21. évszázad első évtizedében (2001-2010) kik kaptak
            //József Attila-díjat! A listában az évszámok kiemelve, azon belül a nevek ábécérendben
            //jelenjenek meg! A jelentés létrehozását lekérdezéssel vagy ideiglenes táblával készítse elő!
            //A jelentés elkészítésekor a mintából a mezők sorrendjét, a címet és a mezőnevek
            //megjelenítését vegye figyelembe! A jelentés formázásában a mintától eltérhet.

            string output = "";

            List<string> temp;//Ideiglenes lista, ebben lesznek az adott év díjazottjai

            //Végigmegyünk a kétezres éveken
            for (int i = 2001; i < 2011; i++)
            {
                output += i + "\n";//Adott év hozzáfűzése a kííráshoz
                temp = new List<string>();//Ideiglenes lista nullázása
                foreach (Kituntetes k in kituntetesesek)
                    //Ha a kitüntetést ebben az évben adták át, akkor adjuk hozzá az ideiglenes listához a kitüntetett nevét
                    if (k.ev == i)
                        foreach (Szemely sz in szemelyek)
                            if (sz.azonosito == k.szemelyAzonosito)
                                temp.Add(sz.nev);
                
                temp.Sort();//Nevek ABC sorrendbe rendezése

                //Nevek hozzáfűzése a kííráshoz, plusz egy sortörés a végén az átláthatóság érdekében
                foreach (string s in temp)
                    output += s + "\n";
                output += "\n";
            }

            outBox.Text = output;//Kiírás
        }

        private void hetedikFeladat_Click(object sender, EventArgs e)
        {
            //Azon díjazottak nevét és foglalkozását kell megadnia, akiknek a foglalkozása ebben
            //a körben ritka, azaz kevesebb, mint 3 személynél szerepel az adatbázisban! Készítse el azt
            //a lekérdezést, amely az alábbi SQL-parancsba a zárójelek közé illesztve helyes megoldást
            //eredményez!
            
            List<string> egyediFoglalkozasokNeve = new List<string>();//Egyedi foglalkozások nevei
            List<int> egyediekDarabszamai = new List<int>();//Egyedi foglalkozások hányszor szerepelnek
            List<string> kevesebbMintHarom = new List<string>();//Azok a foglalkozások, amelyek háromnál kevesebbszer fordulnak elő
            
            //Kiválogatom az egyedi foglalkozások neveit, először mindegyiknek 0 a darabszáma
            foreach (Foglalkozas f in foglalkozasok)
                if (!egyediFoglalkozasokNeve.Contains(f.foglakozasNeve)) 
                {
                    egyediFoglalkozasokNeve.Add(f.foglakozasNeve);
                    egyediekDarabszamai.Add(0);
                }

            //Megnézem melyik foglalkozás hányszor szerepel
            for (int i = 0; i < egyediFoglalkozasokNeve.Count; i++)
                foreach (Foglalkozas f in foglalkozasok)
                    if (egyediFoglalkozasokNeve[i] == f.foglakozasNeve)
                        egyediekDarabszamai[i]++;
                
            //Kiválogatom azokat a foglakozásneveket, amelyek kevesebb, mint háromszor fordultak elő
            for (int i = 0; i < egyediekDarabszamai.Count; i++)
                if (egyediekDarabszamai[i] < 3)
                    kevesebbMintHarom.Add(egyediFoglalkozasokNeve[i]);

            //Kiiratás
            string output = "Ezek a foglalkozások szerepeltek 3-nál kevesebb alkalommal\n\n";
            foreach (string s in kevesebbMintHarom)
                output += s + "\n";
            outBox.Text = output;
        }
    }
}