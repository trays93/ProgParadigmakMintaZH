using System;

namespace Feladat_3
{
    class Program
    {
        static void Main(string[] args)
        {
            uint korokSzama = 0;

            do
            {
                try
                {
                    Console.Write("Add meg mennyi kört szeretnél: ");
                    korokSzama = uint.Parse(Console.ReadLine());

                    if (korokSzama < 3)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Hiba! 2-nél nagyobb egész számot adj meg!");
                }
            } while (korokSzama < 3);

            Console.WriteLine();
            Kor[] korok = new Kor[korokSzama];

            for (int i = 0; i < korokSzama; i++)
            {
                Console.Write($"{i + 1}. kör x koordinátája: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write($"{i + 1}. kör y koordinátája: ");
                int y = int.Parse(Console.ReadLine());
                Console.Write($"{i + 1}. kör sugara: ");
                int r = int.Parse(Console.ReadLine());

                korok[i] = new Kor(x, y, r);
            }

            Array.Sort(korok);

            Kor legtavolabbAzOrigotol = korok[0];
            foreach (Kor kor in korok)
            {
                Console.WriteLine(kor);
                if (kor.OrigoTavolsag() > legtavolabbAzOrigotol.OrigoTavolsag())
                {
                    legtavolabbAzOrigotol = kor;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Legtávolabbi kör az origótol: {legtavolabbAzOrigotol}");

            Console.ReadLine();
        }
    }
}
