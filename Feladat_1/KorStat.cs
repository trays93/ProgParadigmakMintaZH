using System;
using System.Collections.Generic;

namespace Feladat_1
{
    public class KorStat
    {
        private List<EgyKor> korList;

        public KorStat(int korokSzama)
        {
            this.korList = new List<EgyKor>();
            Random random = new Random();

            for (int i = 0; i < korokSzama; i++)
            {
                int x = random.Next(-20, 21);
                int y = random.Next(-20, 21);
                int r = random.Next(0, 11);
                korList.Add(new EgyKor(x, y, r));
            }
        }

        public EgyKor this[int i] { get { return korList[i]; } }

        public int BenneOrigo()
        {
            int benneOrigoDarab = 0;

            foreach (EgyKor kor in korList)
            {
                if (kor.R >= Math.Sqrt((kor.X * kor.X) + (kor.Y * kor.Y)))
                {
                    benneOrigoDarab++;
                }
            }

            return benneOrigoDarab;
        }

        public double TeruletOsszeg()
        {
            double teruletOsszeg = 0.0;

            foreach (EgyKor kor in korList)
            {
                teruletOsszeg += kor.R * kor.R * Math.PI;
            }

            return teruletOsszeg;
        }

        public void LegtavolabbiKorok()
        {
            // a köröket egymással össze kell hasonlítani
            // ezt két egymásba ágyazott ciklussal tehetjük meg

            int kor1Index = 0;
            int kor2Index = 0;
            double maxTavolsag = 0;

            for (int i = 0; i < korList.Count; i++)
            {
                for (int j = i; j < korList.Count; j++)
                {
                    // ki kell számolni a két kör távolságát,
                    // ha azok nagyobbak a jelenlegi távolságnál,
                    // akkor elmentjük az indexeket és a távolságot

                    double tavolsag = Math.Sqrt(
                        ((korList[i].X - korList[j].X) * (korList[i].X - korList[j].X))
                        +
                        ((korList[i].Y - korList[j].Y) * (korList[i].Y - korList[j].Y))
                    );

                    if (tavolsag > maxTavolsag)
                    {
                        kor1Index = i + 1;
                        kor2Index = j + 1;
                        maxTavolsag = Math.Round(tavolsag, 2);
                    }
                }
            }

            Console.WriteLine($"A(z) {kor1Index}. és a(z) {kor2Index}. kör körvonala van a legtávolabb!");
            Console.WriteLine($"Távolságuk: {maxTavolsag}");
        }
    }
}
