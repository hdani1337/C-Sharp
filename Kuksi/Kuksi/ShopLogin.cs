using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Kuksi
{
    public partial class ShopLogin : Form
    {
        public static List<User> users;
        public ShopLogin()
        {
            InitializeComponent();
            beolvas();
        }

        private void beolvas()
        {
            //Felhasználónevek és jelszavak beolvasása
            users = new List<User>();
            try
            {
                string[] sorok = File.ReadAllLines("users.csv", Encoding.Default);
                foreach (string sor in sorok) users.Add(new User(sor));
                
            }
            catch (Exception e)
            {
                File.AppendAllText(@"..\..\users.csv","");
                File.AppendAllText("users.csv","");
                //MessageBox.Show("users.csv fájl nem található, létrehoztam egy újat.");
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            //Regisztráció ablak megnyitása
            Visible = false;
            ShopRegister shopRegister = new ShopRegister(this);
            shopRegister.ShowDialog();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            beolvas();
            User tempUser = new User(username.Text, password.Text);
            bool vanUser = false;
            bool vanPass = false;

            //Felhasználónév és jelszó ellenőrzése
            if (username.Text == "") MessageBox.Show("Kérem adja meg a felhasználónevét!");
            else if (password.Text == "") MessageBox.Show("Kérem adja meg a jelszavát!");
            else
            {
                
                foreach (User user in users)
                {
                    //Helyes felhasználónév és jelszó vizsgálata
                    if (user.username == tempUser.username) vanUser = true;
                    if (vanUser && user.password == tempUser.password) vanPass = true;
                }

                if (vanUser && vanPass)
                {
                    //Sikeres belépés
                    this.Close();
                    Shop shop = new Shop(tempUser);
                    shop.ShowDialog();
                }
                else if (vanUser && !vanPass)
                {
                    //Helytelen jelszó
                    MessageBox.Show("A megadott jelszó hibás. Próbálja újra!");
                }
                else if (!vanUser)
                {
                    //Nincs ilyen felhasználónév
                    MessageBox.Show("Nincs ilyen felhasználónév az adatbázisban, kérem regisztráljon!");
                }
            }
        }
    }
}