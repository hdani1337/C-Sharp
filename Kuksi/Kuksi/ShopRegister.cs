using System;
using System.IO;
using System.Windows.Forms;

namespace Kuksi
{
    public partial class ShopRegister : Form
    {
        public ShopRegister(ShopLogin shopLogin)
        {
            InitializeComponent();
            
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            bool error = false;
            
            //Foglalt felhasználónév vizsgálata
            foreach (User user in ShopLogin.users)
            {
                if (user.username == usernameReg.Text)
                {
                    MessageBox.Show("A felhasználónév már foglalt.");
                    error = true;
                    break;
                }
            }

            //Ha szabad a név, akkor regisztrálás
            if (!error)
            {
                File.AppendAllText(@"..\..\users.csv", usernameReg.Text + ";" + passwordReg.Text + "\n");
                File.AppendAllText("users.csv", usernameReg.Text + ";" + passwordReg.Text + "\n");
                MessageBox.Show("Sikeres regisztráció!");
                this.Close();
            }
        }
    }
}