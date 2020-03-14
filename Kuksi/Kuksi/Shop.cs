using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Kuksi
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
            dataGridView1.DataSource = frmMain.termekek;
            //kosarList.DataSource = kosar;
        }
        

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void kosarList_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            //termekNevLabel.Text
            foreach (DataGridViewRow row in dataGridView1.SelectedRows) 
            {
                termekNevLabel.Text = row.Cells[2].Value.ToString();
                priceLabel.Text = "Ár: " + row.Cells[3].Value + " Ft";
            }
        }

        private void toCart_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows) 
            {
                try
                {
                    if (userBox.Text == "")
                    {
                        MessageBox.Show("Kérem adja meg a felhasználónevét!");
                    }
                    else
                    {
                        int megadottDarabszam = Convert.ToInt32(termekDarab.Text.Substring(0, 5).Trim());
                        int kivalasztottDarabszama = Convert.ToInt32(row.Cells[4].Value.ToString());

                        if (megadottDarabszam <= kivalasztottDarabszama)
                        {
                            kosarList.Items.Insert(kosarList.Items.Count,
                                megadottDarabszam + "x " + row.Cells[2].Value);
                            frmMain.termekek[row.Cells[4].RowIndex].darabszam -= megadottDarabszam;
                            dataGridView1.Refresh();
                        }
                        else
                            MessageBox.Show("Nincs ennyi termék a raktárban!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Kérem adjon meg egy érvényes darabszámot!");
                }
            }
        }
    }
}