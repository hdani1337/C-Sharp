using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Beadandó_200417
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            if (nameBox.Text.Length < 4 || !nameBox.Text.Contains(" "))
                namePanel.BackColor = Color.Red;
            else namePanel.BackColor = Color.GreenYellow;
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {
            if (usernameBox.Text.Length < 4)
                usernamePanel.BackColor = Color.Red;
            else
            {
                bool error = false;
            
                //Foglalt felhasználónév vizsgálata
                foreach (User user in Login.users)
                {
                    if (user.username == usernameBox.Text)
                    {
                        usernamePanel.BackColor = Color.Red;
                        error = true;
                        break;
                    }
                }

                //Ha szabad a név
                if (!error)
                    usernamePanel.BackColor = Color.GreenYellow;
            }
        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {
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
                        if (passwordBox.Text[i].Equals('?') || passwordBox.Text[i].Equals('.') || passwordBox.Text[i].Equals('!') || passwordBox.Text[i].Equals(':') || passwordBox.Text[i].Equals(';'))
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

        private void registerButton_Click(object sender, EventArgs e)
        {
            //Minden adat helyes
            if (usernamePanel.BackColor == Color.GreenYellow &&
                namePanel.BackColor == Color.GreenYellow &&
                emailPanel.BackColor == Color.GreenYellow &&
                passwordPanel.BackColor == Color.GreenYellow)
            {
                File.AppendAllText(@"..\..\users.csv", usernameBox.Text + ";" + passwordBox.Text + "\n");
                File.AppendAllText("users.csv", usernameBox.Text + ";" + passwordBox.Text + "\n");
                MessageBox.Show("Sikeres regisztráció!");
                this.Close();
            }
        }
    }
}