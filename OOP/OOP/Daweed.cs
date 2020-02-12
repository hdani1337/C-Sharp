using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    static class Daweed
    {

        public enum Nemek {
            FERFI, NO, EGYEB
        }

        public static string Nev { get; set; }
        public static byte Kor { get; set; }
        public static float Suly { get; set; }
        public static Nemek Nem { get; set; }
        public static byte Magassag { get; set; }

        private static bool Ehes()
        {
            if ((DateTime.Now.Hour > 7 && DateTime.Now.Hour < 9) || (DateTime.Now.Hour > 12 && DateTime.Now.Hour < 17)) return true;
            else return false;
        }

        public static void Eszik()
        {
            if (Ehes())
            {
                Suly += 0.5f;
            }
            else {
                Suly -= 0.2f;
            }
        }

        public static void Edzes()
        {
            if (Ehes()) Suly += 0.5f;
            else Suly += 0.2f;
        }

        public static double BMI(){
            return Suly / ((Magassag / 100.0) * (Magassag / 100.0));
        }

        public static void toString()
        {
            Console.WriteLine($"{Nev} {Kor} {Suly} {Nem} {Magassag}");
        }
    }
}
