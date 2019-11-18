using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            int count = 0;

            foreach (var k in tlpTop.Controls)
            {
                if (k is Button)
                {
                    count++;
                    (k as Button).BackColor = Color.Green;
                    (k as Button).Name = "btnFeladat_" + count;
                    (k as Button).Text = count + ". gomb";
                }
                
            }
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
        List<int> randomSzamok2;
        List<int> indexek;

        private void setText()
        {
            String s = "";

            for (int i = 0; i < indexek.Count; i++)
            {
                if(randomSzamok[i] != 0) s += (i + 1) + ": " + randomSzamok[i] + "db\n";
            }

            rtbText.Font = new Font("Arial", 15, FontStyle.Bold);
            rtbText.Text = s;

        }

        private void setLists()
        {
            for (int i = 0; i < 150; i++)
            {
                randomSzamok.Add(random.Next(1, 21));
                if (i < 20)
                {
                    indexek.Add(0);
                    if (i < 10)
                    {
                        randomSzamok2.Add(random.Next(1, 21));                       
                    }
                }
            }

            for (int i = 0; i < randomSzamok.Count; i++)
            {
                for (int j = 0; j < randomSzamok2.Count; j++)
                {
                    if (randomSzamok[i] == randomSzamok2[j]) randomSzamok[i] = 0;
                }
            }
        }

        private void countDifferents()
        {
            for (int i = 0; i < randomSzamok.Count; i++)
            {
                for (int j = 0; j < indexek.Count; j++)
                {
                    if (randomSzamok[i] == j + 1) indexek[j]++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            randomSzamok = new List<int> { };
            randomSzamok2 = new List<int> { };
            indexek = new List<int> { };
            setLists();
            countDifferents();
            setText();
        }

        private void rtbText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
