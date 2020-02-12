using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        Program()
        {
            gyakorlas();
        }

        static void Main(string[] args)
        {
            new Program();
            Console.ReadKey();
        }

        public void gyakorlas()
        {
            Daweed.Suly = 72;
            Daweed.Kor = 17;
            Daweed.Magassag = 178;
            Daweed.Nem = Daweed.Nemek.FERFI;
            Daweed.Nev = "Dávid";
            Daweed.Edzes();
            Console.WriteLine(Daweed.BMI());
            Daweed.toString();
        }
    }
}
