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

namespace Beadandó_200417
{
    //TODO: Code Cleanup
    public partial class Login : Form
    {
        public static List<User> users;
        public Login()
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

        private void loginButton_Click(object sender, EventArgs e)
        {
            beolvas();
            User tempUser = new User(usernameBox.Text, passwordBox.Text);
            bool vanUser = false;
            bool vanPass = false;

            //Felhasználónév és jelszó ellenőrzése
            if (usernameBox.Text == "") MessageBox.Show("Kérem adja meg a felhasználónevét!");
            else if (passwordBox.Text == "") MessageBox.Show("Kérem adja meg a jelszavát!");
            else
            {
                
                foreach (User user in users)
                {
                    //Helyes felhasználónév és jelszó vizsgálata
                    if (user.username == tempUser.username) vanUser = true;
                    if (vanUser && user.password == tempUser.password) vanPass = true;
                }

                string msg = DateTime.Now + ": ";
                
                if (vanUser && vanPass)
                {
                    //Sikeres belépés
                    msg += usernameBox.Text + " sikeresen bejelentkezett.";
                    File.AppendAllText(@"..\..\log.txt",msg + "\n");
                    File.AppendAllText("log.txt",msg + "\n");
                    Erettsegi erettsegi = new Erettsegi(this);
                    erettsegi.ShowDialog();
                }
                else if (vanUser && !vanPass)
                {
                    //Helytelen jelszó
                    MessageBox.Show("A megadott jelszó hibás. Próbálja újra!");
                    msg += usernameBox.Text + " hibás jelszóval próbált bejelentkezni.";
                    File.AppendAllText(@"..\..\log.txt",msg + "\n");
                    File.AppendAllText("log.txt",msg + "\n");
                }
                else if (!vanUser)
                {
                    //Nincs ilyen felhasználónév
                    MessageBox.Show("Nincs ilyen felhasználónév az adatbázisban, kérem regisztráljon!");
                    msg += "Nem létező fiókkal próbáltak bejelentkezni.";
                    File.AppendAllText(@"..\..\log.txt",msg + "\n");
                    File.AppendAllText("log.txt",msg + "\n");
                }
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }
    }
}