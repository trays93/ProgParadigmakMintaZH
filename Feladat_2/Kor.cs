namespace Feladat_2
{
    public struct Kor
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
    }
}
