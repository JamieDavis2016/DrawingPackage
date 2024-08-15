using EnsureThat;

namespace DrawingPackage.Widgets
{
    public class Rectangle : Shape, IWidget
    {
        public Rectangle(int x, int y, int width, int height) : base(x, y)
        {
            Width = EnsureArg.IsGt(width, 0);
            Height = EnsureArg.IsGt(height, 0);
            HistoryUpdates = new Stack<Action>();
        }

        public int Width { get; private set; }
        public int Height { get; private set; }
        public List<Action> HistoryUpdates { get; private set; }

        public override string Print()
        {
            return $"Rectangle ({X},{Y}) width={Width} height={Height}";
        }

        public void UpdateWidth(int width)
        {
            var original = Width;
            HistoryUpdates.Push(() => this.Width = original);
            Width = EnsureArg.IsGt(width, 0);
        }

        public void UpdateHeight(int height)
        {
            Height = EnsureArg.IsGt(height, 0);

            HistoryUpdates.Push(() => this.Height = height);
        }

        public void Undo()
        {
            if(HistoryUpdates.Count > 0)
            {
                HistoryUpdates.Pop().Invoke();
            }
        }
    }
}
