namespace DrawingPackage.Widgets
{
    public abstract class Shape
    {
        public Shape(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; private set; }
        public int Y { get; private set; }

        public virtual string Print()
        {
            return $"Shape ({X},{Y}) height=40";
        }
    }
}
