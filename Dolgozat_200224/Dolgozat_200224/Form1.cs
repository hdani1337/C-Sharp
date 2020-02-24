using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dolgozat_200224
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string Nev;
        public string Jelszo;

        private void loginButton_Click(object sender, EventArgs e)
        {
            //Klikk

            //Felhasználónév vizsgálata, 3 karakternél hosszabbnak kell lennie
            if (nameValue.Text.Length <= 3) MessageBox.Show("A név túl rövid!");

            //Ha jó a felhasználónév akkor folytatjuk a vizsgálást
            else {
                Nev = nameValue.Text;

                //Jelszó vizsgálata, 6 karakternek kell lennie
                if (passValue.Text.Length != 6) MessageBox.Show("A jelszó nem 6 karakter hosszú!");
                else
                {
                    Jelszo = passValue.Text;
                    //Ha megvan 6 karakter, tovább vizsgáljuk

                    //3 számnak kell lennie benne, 2 betűnek és egy különleges karakternek

                    int szamok = 0;
                    int betuk = 0;
                    int kulonleges = 0;

                    int tempNum = 0;

                    for (int i = 0; i < Jelszo.Length; i++)
                    {
                        Int32.TryParse(Jelszo[i] + "", out tempNum);

                        if (tempNum != 0)
                        {//A vizsgált karakter egy szám
                            szamok++;
                            tempNum = 0;
                        }
                        else
                        {//A vizsgált karakter egy betű
                            if (Jelszo[i].Equals('?') || Jelszo[i].Equals('.') || Jelszo[i].Equals('!') || Jelszo[i].Equals(':') || Jelszo[i].Equals(';'))
                            {
                                //Ha különleges karakter
                                kulonleges++;
                            }
                            else
                            {
                                //Ha egy közönséges betű
                                betuk++;
                            }
                        }

                    }

                    //Karakterválogatás kész

                    if (betuk == 2 && szamok == 3 && kulonleges == 1)
                    {
                        //Jó jelszó
                        MessageBox.Show("Felhasználónév és jelszó elmentve a belep.txt fájlba");

                        File.AppendAllText("belep.txt", "Felh: " + Nev + "; Jel: " + Jelszo + "\n");
                    }
                    else
                    {
                        //Rossz jelszó

                        string error = "Kell még ";
                        error += (2 - betuk) + " darab betű, ";
                        error += (3 - szamok) + " darab szám, ";
                        error += "egy darab különleges karakter.";

                        MessageBox.Show("Nem megfelelő jelszó!\nBetűk száma: " + betuk + "\nSzámok száma: " + szamok + "\nKülönleges karakterek száma: " + kulonleges + "\n" + error);
                    }
                }
            }        
        }
    }
}
