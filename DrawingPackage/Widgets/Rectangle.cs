using EnsureThat;

namespace DrawingPackage.Widgets
{
    public class Rectangle : Shape, IWidget
    {
        public Rectangle(int x, int y, int width, int height) : base(x, y)
        {
            Width = EnsureArg.IsGt(width, 0);
            Height = EnsureArg.IsGt(height, 0);
        }

        public int Width { get; private set; }
        public int Height { get; private set; }

        public override string Print()
        {
            return $"Rectangle ({X},{Y}) width={Width} height={Height}";
        }
    }
}
