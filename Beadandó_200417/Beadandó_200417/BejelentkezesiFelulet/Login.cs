using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Beadandó_200417
{
    /// <summary>
    /// A program bejelentkezési felülete
    /// Az érettségi feladatok bejelentkezés után tekinthetők meg
    /// Ha nincs felhasználói fiókod, percek alatt regisztrálhatsz egyet
    /// Az adatok az AppData/Roaming mappában kerülnek mentésre
    /// </summary>
    public partial class Login : Form
    {
        //A Roaming mappába mentjük el az adatokat, így nem fog összevissza keveredni
        private string roamingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        
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
                string[] sorok = File.ReadAllLines(roamingDirectory + @"\hdani1337-Erettsegi_users.csv", Encoding.Default);
                foreach (string sor in sorok) users.Add(new User(sor));
            }
            catch (Exception e)
            {
                //Ha nincs ilyen fájl, hozzunk létre egy újat
                File.AppendAllText(roamingDirectory + @"\hdani1337-Erettsegi_users.csv","");
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            beolvas();//Újra beolvassuk az adatokat, mert közben regisztrálhattak is
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

                string msg = DateTime.Now + ": ";//Log üzenet
                
                if (vanUser && vanPass)
                {
                    //Sikeres belépés
                    msg += usernameBox.Text + " sikeresen bejelentkezett.";
                    File.AppendAllText(roamingDirectory + @"\hdani1337-Erettsegi_log.txt",msg + "\n");
                    Erettsegi erettsegi = new Erettsegi(this);
                    erettsegi.ShowDialog();
                }
                else if (vanUser && !vanPass)
                {
                    //Helytelen jelszó
                    MessageBox.Show("A megadott jelszó hibás. Próbálja újra!");
                    msg += usernameBox.Text + " hibás jelszóval próbált bejelentkezni.";
                    File.AppendAllText(roamingDirectory + @"\hdani1337-Erettsegi_log.txt",msg + "\n");
                }
                else if (!vanUser)
                {
                    //Nincs ilyen felhasználónév
                    MessageBox.Show("Nincs ilyen felhasználónév az adatbázisban, kérem regisztráljon!");
                    msg += "Nem létező fiókkal próbáltak bejelentkezni.";
                    File.AppendAllText(roamingDirectory + @"\hdani1337-Erettsegi_log.txt",msg + "\n");
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