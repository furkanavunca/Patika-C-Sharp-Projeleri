using System;
using System.Collections;
using System.Collections.Generic;

namespace ikiliToplam
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin;
            Console.WriteLine("N tane 2'li girin");
            metin = Console.ReadLine();
            string[] sayilar = metin.Split(" ");
            int[] sonucListesi = new int[20];
            
            int tf = 1;
            int sayi1,sayi2;

            while (tf == 1)
            {
                for (int i = 0; i < sayilar.Length; i+=2)
                {
                    sayi1 = int.Parse(sayilar[i]);
                    sayi2 = int.Parse(sayilar[i + 1]);

                    if (sayi1 != sayi2)
                    {
                        sonucListesi[i] = sayi1 + sayi2;
                    }
                    else
                    {
                        sonucListesi[i] = (sayi1 + sayi2) * (sayi1 + sayi2);
                    }
                }
                tf = 0;
            }

            foreach (var item in sonucListesi)
            {
                if (item != 0)
                {
                    Console.Write(item + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
