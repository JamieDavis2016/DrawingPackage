using EnsureThat;

namespace DrawingPackage.Widgets
{
    public abstract class Shape
    {
        public Shape(int x, int y)
        {
            X = EnsureArg.IsGt(x, 0);
            Y = EnsureArg.IsGt(y, 0);
            //X = x;
            //Y = y;
        }

        public int X { get; private set; }
        public int Y { get; private set; }

        public virtual string Print()
        {
            return $"Shape ({X},{Y}) height=40";
        }
    }
}
