using System;

namespace Feladat_1
{
    class Program
    {
        static void Main(string[] args)
        {
            uint korokSzama = 0;

            try
            {
                Console.Write("Adja meg mennyi kört szeretne létrehozni: ");
                korokSzama = uint.Parse(Console.ReadLine());
                if (korokSzama == 0)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                korokSzama = 10;
                Console.WriteLine("Hiba! Nem Pozitív egész számot adott meg!");
                Console.WriteLine("Körök száma: 10");
            }

            KorStat korStat = new KorStat((int)korokSzama);

            Console.WriteLine();
            Console.WriteLine($"{korStat.BenneOrigo()} darab kör van ami tartalmazza az origót.");
            Console.WriteLine($"A körök területének összege: {korStat.TeruletOsszeg()}");
            korStat.LegtavolabbiKorok();

            Console.WriteLine();
            Console.WriteLine("Körök:");
            for (int i = 0; i < korokSzama; i++)
            {
                Console.WriteLine($"({korStat[i].X}, {korStat[i].Y}) - {korStat[i].R}");
            }

            Console.ReadLine();
        }
    }
}
