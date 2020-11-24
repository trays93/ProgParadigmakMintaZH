namespace Feladat_1
{
    public struct EgyKor
    {
        private int x;
        private int y;
        private int r;

        public EgyKor(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }

        public int X { get { return x; } }
        public int Y { get { return y; } }
        public int R {  get { return r; } }
    }
}
