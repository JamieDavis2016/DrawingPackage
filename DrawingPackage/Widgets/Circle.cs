namespace DrawingPackage.Widgets
{
    public sealed class Circle : Shape, IWidget
    {
        public Circle(int x, int y, int size) : base(x, y)
        {
            Size = size;
        }

        public int Size { get; private set; }

        public override string Print()
        {
            return $"Circle ({X},{Y}) size = {Size}";
        }
    }
}
