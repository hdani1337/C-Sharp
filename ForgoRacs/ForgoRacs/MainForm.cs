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

namespace ForgoRacs
{
    public partial class Form1 : Form
    {
        public string beolvasottSzoveg;
        public readonly string kodlemezFajl = "kodlemez.txt";
        public readonly string beolvasandoFajl = "szoveg.txt";
        public Fracs _Fracs;
        
        public Form1()
        {
            InitializeComponent();
            beolvasas();
            peldanyositas();
            rtbOutput.Text += "8. feladat: " + _Fracs.Titkositando + "\n\n";
        }

        //5. feladat
        public void beolvasas()
        {
            try
            {
                beolvasottSzoveg = File.ReadAllText(beolvasandoFajl, Encoding.UTF8);
            }
            catch (Exception e)
            {
                beolvasottSzoveg = "A fájl nem található! :c";
            }

            rtbOutput.Text += "5. feladat: " + beolvasottSzoveg + "\n\n";
        }

        //6. feladat
        public void peldanyositas()
        {
            _Fracs = new Fracs(kodlemezFajl, beolvasottSzoveg);
        }

        //64 karaktert kiír a formra
        public void kiir(string kiirando)
        {
            if (kiirando.Length == 64)
            {
                List<Label> labels = new List<Label>();

                foreach (var element in tlpKod.Controls)
                    if (element is Label)
                        labels.Add(element as Label);

                for (int i = 63; i >= 0; i--)
                    labels[i].Text = kiirando[(63 - i)] + "";
            }
        }

        //Titkosított szöveget kiírja a formra
        private void button2_Click(object sender, EventArgs e)
        {
            _Fracs.Titikosit();
            string titkositas = "";
            foreach (char c in _Fracs.Titkositott) 
                titkositas += c;
            kiir(titkositas);
        }

        //Kódlemezt kiírja a formra
        private void button1_Click(object sender, EventArgs e)
        {
            _Fracs.KiirKodlemez(this);
        }
    }
}