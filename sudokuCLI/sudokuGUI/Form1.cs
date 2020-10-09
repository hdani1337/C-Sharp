using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudokuGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int kiirtMeret = 4;

        private void Form1_Load(object sender, EventArgs e)
        {
            meret.Text = kiirtMeret+"";
        }

        private void meret_TextChanged(object sender, EventArgs e)
        {

        }

        private void plus_Click(object sender, EventArgs e)
        {
            if(kiirtMeret<9) kiirtMeret++;
            meret.Text = kiirtMeret + "";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if(kiirtMeret>4) kiirtMeret--;
            meret.Text = kiirtMeret + "";
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text.Length == kiirtMeret * kiirtMeret)
            {
                MessageBox.Show("A feladvány megfelelő hosszúságú!");
            }
            else {
                if (richTextBox2.Text.Length > kiirtMeret * kiirtMeret)
                {
                    MessageBox.Show("A feladvány hosszú! Törlendő " + (richTextBox2.Text.Length - kiirtMeret * kiirtMeret) + " számjegy!");
                }
                else {
                    MessageBox.Show("A feladvány hosszú! Kell még " + (kiirtMeret * kiirtMeret - richTextBox2.Text.Length) + " számjegy!");
                }
            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            hosszLabel.Text = "Hossz: " + richTextBox2.Text.Length;
        }
    }
}
