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

namespace ListUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*int count = 0;

            foreach (var k in tlpTop.Controls)
            {
                if (k is Button)
                {
                    count++;
                    (k as Button).BackColor = Color.Green;
                    (k as Button).Name = "btnFeladat_" + count;
                    (k as Button).Text = count + ". gomb";
                }
                
            }*/
        }

        private void tlpMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        Random random = new Random();
        List<int> randomSzamok;
        List<int> eltavolitandoSzamok;
        List<int> egyediek;

        private void setText()
        {
            String s = "";

            egyediek.Sort();

            for (int i = 0; i < egyediek.Count; i++)
            {
                s += egyediek[i] + " "; 
            }

            rtbText.Font = new Font("Arial", 15, FontStyle.Bold);
            rtbText.Text = s;

        }

        private void setLists()
        {
            for (int i = 0; i < 150; i++)
            {
                randomSzamok.Add(random.Next(1, 21));
                if (i < 10) eltavolitandoSzamok.Add(random.Next(1, 21));                     
            }

            removeWhile();
        }

        int index = 0;

        private void removeWhile()
        {
            while (true)
            {
                if (randomSzamok.Contains(eltavolitandoSzamok[index])) randomSzamok.RemoveAll(z => z == eltavolitandoSzamok[index]);
                if (++index == eltavolitandoSzamok.Count) break;
            }
        }

        private void removeDuplicates()
        {
            for (int i = 0; i < randomSzamok.Count; i++) if (!egyediek.Contains(randomSzamok[i])) egyediek.Add(randomSzamok[i]);          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            randomSzamok = new List<int> { };
            eltavolitandoSzamok = new List<int> { };
            egyediek = new List<int> { };
            index = 0;
            setLists();
            removeDuplicates();
            setText();
        }


        private string fajlbolKiolvasas()
        {
            string temp = "";

            try
            {
                temp = File.ReadAllText("muveletek.txt", Encoding.UTF8);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                temp = "A fájl nem található.";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                temp = "Hiba.";
            }

            return temp;
        }

        private void rtbText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCalc calc = new frmCalc();          
            calc.ShowDialog();
            rtbText.Text = "Műveletek:\n";
            rtbText.Text += fajlbolKiolvasas();
        }
    }
}
