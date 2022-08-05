using System;

namespace MutlakKareAlma
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin;
            int kucukToplam = 0, buyukToplam = 0;
            Console.WriteLine("N tane 2'li girin");
            metin = Console.ReadLine();
            string[] sayilar = metin.Split(" ");
            int[] kucukler = new int[20];
            int[] buyukler = new int[20];

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (int.Parse(sayilar[i]) < 67)
                {
                    kucukler[i] = 67 - int.Parse(sayilar[i]);
                }
            }
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (int.Parse(sayilar[i]) >= 67)
                {
                    int islek = int.Parse(sayilar[i]) - 67;
                    buyukler[i] = islek * islek;
                }
            }

            foreach (var item in kucukler)
            {
                kucukToplam += item;
            }
            foreach (var item in buyukler)
            {
                buyukToplam += item;
            }

            Console.WriteLine(kucukToplam);
            Console.WriteLine(buyukToplam);
            Console.ReadKey();
        }
    }
}
