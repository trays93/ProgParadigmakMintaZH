using System;

namespace Feladat_3
{
    public class Kor : IComparable
    {
        private int x;
        private int y;
        private int r;

        public Kor(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }

        public int X { get { return x; } }
        public int Y { get { return y; } }
        public int R { get { return r; } }

        public int CompareTo(object obj)
        {
            Kor masik = (Kor)obj;
            double sajatTavolsag = this.OrigoTavolsag();
            double masikTavolsag = masik.OrigoTavolsag();

            if (sajatTavolsag > masikTavolsag)
            {
                return 1;
            }

            if (sajatTavolsag < masikTavolsag)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"K({X},{Y}) - R({R})";
        }

        public double OrigoTavolsag() => Math.Sqrt((X * X) + (Y * Y)) - R;
    }
}
