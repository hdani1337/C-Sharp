using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Beadandó_200417
{ 
    /// <summary>
    /// Itt jobban csak stringkezelések vannak, nem sok kedvem van kikommentezni
    /// Milliószor vettük hogy nézzük meg a szöveg hosszát, speciális karaktereket, SubStringeket, stb...
    /// Ha meg nem érted akkor egy kicsit gond van mert egy hónap múlva érettségizünk ebből, állj neki tanulni
    /// </summary>
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            //Neve: minimum 4 karakter és teljes név kell.
            if (nameBox.Text.Length < 4 || !nameBox.Text.Contains(" "))
                namePanel.BackColor = Color.Red;
            else namePanel.BackColor = Color.GreenYellow;
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {
            //Felhasználó neve: minimum 4 karakter
            if (usernameBox.Text.Length < 4)
                usernamePanel.BackColor = Color.Red;
            else
            {
                bool error = false;//Volt e hiba
            
                //Foglalt felhasználónév vizsgálata
                foreach (User user in Login.users)
                    if (user.username == usernameBox.Text)
                    {
                        usernamePanel.BackColor = Color.Red;
                        error = true;
                        break;
                    }
                

                //Ha szabad a név
                if (!error)
                    usernamePanel.BackColor = Color.GreenYellow;
            }
        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {
            //Email cím: minimum 3 karakter @ minimum 3 karakter . 2 – 3 karakter
            if (emailBox.Text.Contains("@"))
            {
                string kukacElott = emailBox.Text.Substring(0, emailBox.Text.IndexOf("@", StringComparison.Ordinal));
                string kukacUtan = emailBox.Text.Substring(emailBox.Text.IndexOf("@", StringComparison.Ordinal) + 1);
                string pontUtan = "";
                string pontElott = "";

                if (kukacUtan.Contains("."))
                {
                    pontUtan = kukacUtan.Substring(kukacUtan.IndexOf(".", StringComparison.Ordinal) + 1);
                    pontElott = kukacUtan.Substring(0,kukacUtan.IndexOf(".", StringComparison.Ordinal));
                }
                else  
                    emailPanel.BackColor = Color.Red;

                if (kukacElott.Length < 3 || pontUtan.Length < 2 || pontElott.Length < 3)
                    emailPanel.BackColor = Color.Red;
                else emailPanel.BackColor = Color.GreenYellow;
            }
            else emailPanel.BackColor = Color.Red;
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            //Jelszó: 6 – 16 karakter között szám, karakter és egyéb karaktert is kell hogy tartalmazzon
            if (passwordBox.Text.Length > 6 && passwordBox.Text.Length <= 16)
            {
                int szamok = 0;
                int betuk = 0;
                int kulonleges = 0;

                int tempNum = 0;

                for (int i = 0; i < passwordBox.Text.Length; i++)
                {
                    Int32.TryParse(passwordBox.Text[i] + "", out tempNum);

                    if (tempNum != 0)
                    {//A vizsgált karakter egy szám
                        szamok++;
                        tempNum = 0;
                    }
                    else
                    {//A vizsgált karakter egy betű
                        if (passwordBox.Text[i].Equals('?') || 
                            passwordBox.Text[i].Equals('.') || 
                            passwordBox.Text[i].Equals('!') || 
                            passwordBox.Text[i].Equals(':') || 
                            passwordBox.Text[i].Equals(';'))
                            //Ha különleges karakter
                            kulonleges++;
                        else
                            //Ha egy közönséges betű
                            betuk++;
                        
                    }
                }

                //Fokozatosan állítjuk be a hibajelzőt
                int correctData = 0;

                if (szamok != 0) correctData++;
                if (betuk != 0) correctData++;
                if (kulonleges != 0) correctData++;

                switch (correctData)
                {
                    case 0:
                    {
                        passwordPanel.BackColor = Color.Red;
                        break;
                    }
                    
                    case 1:
                    {
                        passwordPanel.BackColor = Color.Orange;
                        break;
                    }
                    
                    case 2:
                    {
                        passwordPanel.BackColor = Color.Yellow;
                        break;
                    }
                    
                    case 3:
                    {
                        passwordPanel.BackColor = Color.GreenYellow;
                        break;
                    }
                }
            }
            else passwordPanel.BackColor = Color.Red;
        }

        private string roamingPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private void registerButton_Click(object sender, EventArgs e)
        {
            //Minden adat helyes
            if (usernamePanel.BackColor == Color.GreenYellow &&
                namePanel.BackColor == Color.GreenYellow &&
                emailPanel.BackColor == Color.GreenYellow &&
                passwordPanel.BackColor == Color.GreenYellow)
            {
                //Rögzítjük, hogy ki regisztrált milyen névvel
                string registerLog = DateTime.Now + ": " + nameBox.Text + " regisztrált a rendszerbe " + usernameBox.Text + " felhasználónéven." + "\n";
                
                //Elmentjük a bejelentkezési adatokat
                string registerSave = usernameBox.Text + ";" + passwordBox.Text + "\n";
                
                //Feljegyzések fáljba kiírása
                File.AppendAllText(roamingPath +  @"\hdani1337-Erettsegi_users.csv", registerSave);
                File.AppendAllText(roamingPath + @"\hdani1337-Erettsegi_log.txt", registerLog);
                
                MessageBox.Show("Sikeres regisztráció! Mostantól bejelentkezhet ezekkel az adatokkal.");
                Close();
            }
        }
    }
}