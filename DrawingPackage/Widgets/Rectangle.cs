namespace DrawingPackage.Widgets
{
    public class Rectangle : Shape, IWidget
    {
        public Rectangle(int x, int y, int width, int height) : base(x, y)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; private set; }
        public int Height { get; private set; }

        public override string Print()
        {
            return $"Rectangle ({X},{Y}) width={Width} height={Height}";
        }
    }
}
