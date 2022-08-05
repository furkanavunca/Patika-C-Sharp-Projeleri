using System;

namespace karakderDegistirme
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin;
            string deger = "";
            int x=0;

            Console.WriteLine("Cümleyi girin");
            metin = Console.ReadLine();
            string[] Kelimeler = metin.Split(" ");
            string[] harf = new string[25];

            for (int i = 0; i < Kelimeler.Length; i++)
            {
                deger = Kelimeler[i];
                foreach (var item in deger.ToCharArray())
                {
                    harf[x] = item.ToString();
                    x++;
                }
                string ilk = harf[0];
                int sayac=0;
                foreach (var item in harf)
                {
                    if (item != null)
                    {
                        sayac++;
                    }
                }
                int son = sayac;
                sayac = 0;
                harf[0] = son.ToString();
                harf[son] = ilk;
                x = 0;
                for (int j = 1; j < harf.Length; j++)
                {
                    Console.Write(harf[j]);
                }
                Console.Write(" ");
            }
            Console.ReadKey();
        }
    }
}
