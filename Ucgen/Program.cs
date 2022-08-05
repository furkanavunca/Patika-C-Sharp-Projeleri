using System;

namespace Ucgen
{
    class Program
    {
        static void Main(string[] args)
        {
            Metotlar metots = new Metotlar();
            Console.Write("Üçgenin Yüksekliğini Giriniz :");
            int h = int.Parse(Console.ReadLine());
            metots.ucgeniCiz(h);
            Console.ReadKey();
        }
    }

    public class Metotlar
    {
        public void ucgeniCiz(int h)
        {
            for (int i = 1; i <= h; i++)
            {
                for (int j = 0; j < h-i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
