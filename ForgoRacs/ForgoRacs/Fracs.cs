using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ForgoRacs
{
    public class Fracs
    {
        public char[,] Kodlemez;
        public char[,] Titkositott;
        public string Titkositando { get; private set; }
        public string feldolgozandoFajlNeve;

        public Fracs(string feldolgozandoFajlNeve, string titkositandoSzoveg)
        {
            Titkositando = titkositandoSzoveg;
            this.feldolgozandoFajlNeve = feldolgozandoFajlNeve;
            createMatrix();
            Atalakit();
        }

        private void createMatrix()
        {
            Kodlemez = new char[8,8];
            Titkositott = new char[8,8];
            
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Kodlemez[i, j] = getKodLemez()[i*8+j];
                    Titkositott[i, j] = ' ';
                }
            }
        }

        private string getKodLemez()
        {
            try
            {
                List<string> tempList = File.ReadAllLines(this.feldolgozandoFajlNeve, Encoding.UTF8).ToList();
                string tempString = "";
                foreach (string sor in tempList)
                    foreach (char character in sor)
                        tempString += character;
                return tempString;
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public void Atalakit()
        {
            string titkos = "";

            foreach (char c in Titkositando)
                if (c != ' ' && c != ',' && c != '.')
                    titkos += c;

            if(titkos.Length > 64) 
                throw new Exception("Túl hosszú a titkosítandó szöveg!");
            else if (titkos.Length != 64)
                for (int i = 0; i <= (65 - titkos.Length); i++)
                    titkos += "X";
            
            Titkositando = titkos;
        }

        public void KiirKodlemez(Form1 parent)
        {
            parent.kiir(getKodLemez());
        }

        public char[,] ForgatKodlemez()
        {
            char[,] ujKodlemez = new char[8,8];

            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    ujKodlemez[7 - j, i] = Kodlemez[i, j];
            return ujKodlemez;
        }

        public void Titikosit()
        {
            int textIndex = 0;
            
            for (int i = 0; i < 4; i++)
            { 
                for (int j = 0; j < 8; j++)
                    for (int k = 0; k < 8; k++)
                        if (Kodlemez[k, j] == 'A')
                            Titkositott[k, j] = Titkositando[textIndex++];
                Kodlemez = ForgatKodlemez();
            }
        }
    }
}