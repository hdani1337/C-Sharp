using System;

namespace Beadandó_200417
{
    public class Foglalkozas
    {
        public int szemelyAzonosito { get; set; }
        public string foglakozasNeve { get; set; }

        public Foglalkozas(string sor)
        {
            int temp = 0;
            
            Int32.TryParse(sor.Split('\t')[0], out temp);
            szemelyAzonosito = temp;

            foglakozasNeve = sor.Split('\t')[1];
        }
    }
}