using System;

namespace tersyazi
{
    class Program
    {
        static void Main(string[] args)
        {
            Metotlar metots = new Metotlar();
            Console.WriteLine("Ter çevirmek istediğiniz cümleyi girin : ");
            string metin = Console.ReadLine();
            metots.tersYaz(metin);
            Console.ReadKey();
        }
    }

    class Metotlar
    {
        public void tersYaz(string metin)
        {
            string[] cumle = new string[150];
            int sayac = 0;
            foreach (var item in metin.ToCharArray())
            {
                cumle[sayac] = item.ToString();
                sayac++;
            }
            Array.Reverse(cumle);
            foreach (var item in cumle)
            {
                Console.Write(item);
            }
        }
    }
}
