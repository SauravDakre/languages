namespace TryClass
{
    class Point
    {
        public int X;

        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point pt)
        {
            if (pt == null)
            {
                throw new ArgumentNullException("Point object must not be null");
            }
            Move(pt.X, pt.Y);
        }

        public override string ToString()
        {
            return $"({this.X}, {this.Y})";
        }
    }
}
