using System;

namespace fibortalama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç adet sayı istendiğini giriniz: ");
            int adet = int.Parse(Console.ReadLine());
            Metotlar metots = new Metotlar();
            metots.hesapla(adet);
            Console.ReadKey();
        }
    }
    public class Metotlar
    {
        int x = 0;
        int y = 1;
        int z,toplam;
        public void hesapla(int adet)
        {
            Console.WriteLine("1");
            for (int i = 0; i < adet - 1; i++)
            {
                z = x + y;
                x = y;
                y = z;
                toplam += z;
                Console.WriteLine(z);
            }
            Console.WriteLine("Dizinin ortalaması : " + (toplam + 1 ) / adet);
        }
    }
}
