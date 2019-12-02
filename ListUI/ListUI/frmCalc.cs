using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ListUI
{
    public partial class frmCalc : Form
    {
        public frmCalc()
        {
            InitializeComponent();
        }

        //Ami kell még
        //Plusz-minusz gomb
        //Műveletek tört számokkal

        string elsoSzam = "";
        string muvelet = "";
        string masodikSzam = "";

        private void tlpMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEq_Click(object sender, EventArgs e)
        {
            btnPlu.BackColor = DefaultBackColor;
            btnMin.BackColor = DefaultBackColor;
            btnMult.BackColor = DefaultBackColor;
            btnDiv.BackColor = DefaultBackColor;

            string output = "";
            if (elsoSzam != "" && masodikSzam != "")
            {               
                 if (muvelet == "+") output = Convert.ToDouble(elsoSzam) + Convert.ToDouble(masodikSzam) + "";
                 else if (muvelet == "-") output = Convert.ToDouble(elsoSzam) - Convert.ToDouble(masodikSzam) + "";
                 else if (muvelet == "*") output = Convert.ToDouble(elsoSzam) * Convert.ToDouble(masodikSzam) + "";
                 else if (muvelet == "/") output = Convert.ToDouble(elsoSzam) / Convert.ToDouble(masodikSzam) + "";                
            }

            if (output != "")
            {
                fajlbaIras(output);
                txtValue.Text = output;
                muvelet = "";
                elsoSzam = output;
                masodikSzam = "";             
            }

            vesszo = false;
        }

        private void fajlbaIras(string output)
        {
            try
            {
                File.WriteAllText("muveletek.txt", (File.ReadAllText("muveletek.txt", Encoding.UTF8)) + "\n" + elsoSzam + " " + muvelet + " " + masodikSzam + " = " + output + "\n", Encoding.UTF8);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void btnPlu_Click(object sender, EventArgs e)
        {
            muvelet = "+";
            btnPlu.BackColor = Color.Orange;          
            btnMin.BackColor = DefaultBackColor;
            btnMult.BackColor = DefaultBackColor;
            btnDiv.BackColor = DefaultBackColor;
            vesszo = false;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            muvelet = "-";
            btnMin.BackColor = Color.Orange;
            btnPlu.BackColor = DefaultBackColor;
            btnMult.BackColor = DefaultBackColor;
            btnDiv.BackColor = DefaultBackColor;
            vesszo = false;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            muvelet = "*";
            btnMult.BackColor = Color.Orange;
            btnPlu.BackColor = DefaultBackColor;
            btnMin.BackColor = DefaultBackColor;
            btnDiv.BackColor = DefaultBackColor;
            vesszo = false;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            muvelet = "/";
            btnDiv.BackColor = Color.Orange;
            btnPlu.BackColor = DefaultBackColor;
            btnMin.BackColor = DefaultBackColor;
            btnMult.BackColor = DefaultBackColor;
            vesszo = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (muvelet == "")
            {
                elsoSzam += "1";
                txtValue.Text = elsoSzam;
            }
            else
            {
                masodikSzam += "1";
                txtValue.Text = masodikSzam;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (muvelet == "")
            {
                elsoSzam += "2";
                txtValue.Text = elsoSzam;
            }
            else
            {
                masodikSzam += "2";
                txtValue.Text = masodikSzam;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (muvelet == "")
            {
                elsoSzam += "3";
                txtValue.Text = elsoSzam;
            }
            else
            {
                masodikSzam += "3";
                txtValue.Text = masodikSzam;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (muvelet == "")
            {
                elsoSzam += "4";
                txtValue.Text = elsoSzam;
            }
            else
            {
                masodikSzam += "4";
                txtValue.Text = masodikSzam;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (muvelet == "")
            {
                elsoSzam += "5";
                txtValue.Text = elsoSzam;
            }
            else
            {
                masodikSzam += "5";
                txtValue.Text = masodikSzam;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (muvelet == "")
            {
                elsoSzam += "6";
                txtValue.Text = elsoSzam;
            }
            else
            {
                masodikSzam += "6";
                txtValue.Text = masodikSzam;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (muvelet == "")
            {
                elsoSzam += "7";
                txtValue.Text = elsoSzam;
            }
            else
            {
                masodikSzam += "7";
                txtValue.Text = masodikSzam;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (muvelet == "")
            {
                elsoSzam += "8";
                txtValue.Text = elsoSzam;
            }
            else
            {
                masodikSzam += "8";
                txtValue.Text = masodikSzam;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (muvelet == "")
            {
                elsoSzam += "9";
                txtValue.Text = elsoSzam;
            }
            else
            {
                masodikSzam += "9";
                txtValue.Text = masodikSzam;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (muvelet == "" && elsoSzam.Length != 0)
            {
                elsoSzam += "0";
                txtValue.Text = elsoSzam;
            }
            else
            {
                masodikSzam += "0";
                txtValue.Text = masodikSzam;
            }
           
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            if (muvelet == "")
            {
                elsoSzam = "";
                txtValue.Text = elsoSzam;
            }
            else
            {
                masodikSzam = "";
                txtValue.Text = masodikSzam;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            elsoSzam = "";
            muvelet = "";
            masodikSzam = "";
            txtValue.Text = "";
            btnPlu.BackColor = DefaultBackColor;
            btnMin.BackColor = DefaultBackColor;
            btnMult.BackColor = DefaultBackColor;
            btnDiv.BackColor = DefaultBackColor;
        }

        private bool vesszo = false;

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!vesszo)
            {
                if (muvelet == "")
                {
                    elsoSzam += ",";
                    txtValue.Text = elsoSzam;
                }
                else
                {
                    masodikSzam += ",";
                    txtValue.Text = masodikSzam;
                }

                vesszo = true;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (muvelet == "")
            {
                elsoSzam = elsoSzam.Substring(0, elsoSzam.Length - 1);
                txtValue.Text = elsoSzam;
            }
            else
            {
                masodikSzam = masodikSzam.Substring(0, masodikSzam.Length - 1);
                txtValue.Text = masodikSzam;
            }
        }

        private void buttonPluMin_Click(object sender, EventArgs e)
        {
            if (masodikSzam == "")
            {
                if (!elsoSzam.Contains('-')) elsoSzam = "-" + elsoSzam;
                else elsoSzam = elsoSzam.Remove(0,1);
                txtValue.Text = elsoSzam;
            }
            else
            {
                if (!masodikSzam.Contains('-')) masodikSzam = "-" + masodikSzam;
                else masodikSzam = masodikSzam.Remove(0,1);
                txtValue.Text = masodikSzam;
            }
        }
    }
}
