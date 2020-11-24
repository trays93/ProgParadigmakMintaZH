using System;

namespace Feladat_2
{
    public class Korok : IStatisztika
    {
        Kor[] korTmb;

        public Korok(int korokSzama)
        {
            korTmb = new Kor[korokSzama];
            Random random = new Random();

            for (int i = 0; i < korokSzama; i++)
            {
                int x = random.Next(-100, 101);
                int y = random.Next(-100, 101);
                int r = random.Next(0, 151);

                korTmb[i] = new Kor(x, y , r);
            }
        }

        public int TengelyenK()
        {
            int tengelyenKorokDarab = 0;

            for (int i = 0; i < korTmb.Length; i++)
            {
                if (korTmb[i].X == 0 || korTmb[i].Y == 0)
                {
                    tengelyenKorokDarab++;
                }
            }

            return tengelyenKorokDarab;
        }

        public Kor Legtávolabb()
        {
            Kor legtavolabbiKor = korTmb[0];
            double legtavolabbi = 0;

            for (int i = 0; i < korTmb.Length; i++)
            {
                double tavolsag = Math.Sqrt(
                    (korTmb[i].X * korTmb[i].X)
                    +
                    (korTmb[i].Y * korTmb[i].Y)
                ) - korTmb[i].R;

                if (tavolsag > legtavolabbi)
                {
                    legtavolabbi = tavolsag;
                    legtavolabbiKor = korTmb[i];
                }
            }

            return legtavolabbiKor;
        }

        public int Kicsik(int r)
        {
            int korokSzama = 0;

            foreach (Kor kor in korTmb)
            {
                if (kor.R < r)
                {
                    korokSzama++;
                }
            }

            return korokSzama;
        }
    }
}
