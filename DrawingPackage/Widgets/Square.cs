namespace DrawingPackage.Widgets
{
    public class Square : Shape, IWidget
    {
        public Square(int x, int y, int size) : base(x, y)
        {
            Size = size;
        }

        public int Size { get; private set; }

        public override string Print()
        {
            return $"Square ({X},{Y}) size={Size}";
        }
    }
}
