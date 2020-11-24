using System;

namespace Feladat_2
{
    class Program
    {
        static void Main(string[] args)
        {
            uint korokSzama = 0;

            try
            {
                Console.Write("Add meg mennyi kört szeretnél létrehozni: ");
                korokSzama = uint.Parse(Console.ReadLine());
                if (korokSzama == 0)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                korokSzama = 15;
                Console.WriteLine("Hiba! Nem pozitív egész számot adtál meg!");
                Console.WriteLine($"Körök száma: {korokSzama}");
            }

            Korok proba = new Korok((int)korokSzama);

            Console.WriteLine($"Tengelyen lévő körök száma: {proba.TengelyenK()}");

            Kor legtavolabbiKorAzOrigotol = proba.Legtávolabb();
            Console.WriteLine($"A legtávolabbi kör: ({legtavolabbiKorAzOrigotol.X}, {legtavolabbiKorAzOrigotol.Y}) - {legtavolabbiKorAzOrigotol.R}");
            
            int kicsiFeltetel = 5;
            int kicsikSzama = proba.Kicsik(kicsiFeltetel);
            if (kicsikSzama > 0)
            {
                Console.WriteLine($"A(z) {kicsiFeltetel}-nél kissebb sugarú körök száma: {kicsikSzama}");
            }
            else
            {
                Console.WriteLine("Nincsen kicsi kör");
            }

            Console.ReadLine();
        }
    }
}
