using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Kuksi
{
    public partial class Shop : Form
    {
        private User user;
        public Shop(User user)
        {
            InitializeComponent();
            this.user = user;
            userLabel.Text = "Felhasználó: " + user.username;
            dataGridView1.DataSource = frmMain.termekek;//Terméklista adatforrása a termékek lista
        }
        
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows) 
            {
                termekNevLabel.Text = row.Cells[2].Value.ToString();//Kiválasztott terméknév frissítése
                priceLabel.Text = "Ár: " + row.Cells[3].Value + " Ft";//Árcímke frissítése
            }
        }

        private void toCart_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows) 
            {
                //Bármilyen exception elkapása, so professional
                try
                {
                    int megadottDarabszam = Convert.ToInt32(termekDarab.Text.Substring(0, 5).Trim());//Mennyit akar venni a felhasználó az adott termékből 
                    int kivalasztottDarabszama = Convert.ToInt32(row.Cells[4].Value.ToString());//Mennyi darab van a raktárban a kiválasztott termékből

                    if (megadottDarabszam <= kivalasztottDarabszama) 
                    {//Ha van elég termék a raktárban
                        kosarList.Items.Insert(kosarList.Items.Count, megadottDarabszam + "x " + row.Cells[2].Value);//Kosár listához hozzáadjuk a terméket és a darabszámot
                        frmMain.termekek[row.Cells[4].RowIndex].darabszam -= megadottDarabszam;//Frissítsük a darabszámot
                        dataGridView1.Refresh();//Terméklista frissítése
                    }
                    else MessageBox.Show("Nincs ennyi termék a raktárban!");//Ha nincs elég termék a raktárban akkor hibaüzenet
                    
                }
                catch (Exception)
                {
                    //Akkor van exception, hogyha a felhasználó nem adott meg darabszámot, hibaüzenet
                    MessageBox.Show("Kérem adjon meg egy érvényes darabszámot!");
                }
            }
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            if (kosarList.Items.Count != 0)
            {//Ha nem üres a kosár, akkor vesszük fel a rendelést
                List<string> vasarlas = new List<string>();//Ideiglenes tömb az adatoknak
                vasarlas.Add("Date: " + DateTime.Now);//Pontos idő mentése
                vasarlas.Add("User: " + user.username);//Felhasználónév mentése
                
                //Rendelt termékek mentése
                vasarlas.Add("Items:");
                foreach (string obj in kosarList.Items)
                {
                    vasarlas.Add(obj);
                }

                vasarlas.Add("----------\n");//Rendelés vége, sortörés
                File.AppendAllLines(@"..\..\Vasarlasok.csv", vasarlas);//Adatok mentése fájlba
                MessageBox.Show("A rendelés sikeresen felvéve!");//Felhasználó tájékoztatása a sikeres mentésről
                kosarList.Items.Clear();//Kosár kiürítése
            }
            else
            {//Ha üres a kosár, hibaüzenet
                MessageBox.Show("A rendelés elküldéséhez vegyen fel egy vagy több terméket a kosarába!");
            }
        }
    }
}