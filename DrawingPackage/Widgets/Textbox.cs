namespace DrawingPackage.Widgets
{
    public class Textbox: Rectangle, IWidget
    {
        public Textbox(int x, int y, int width, int height, string text) : base(x, y, width, height)
        {
            Text = text;
        }

        public string Text { get; private set; }

        public override string Print()
        {
            return $"Textbox ({X},{Y}) width={Width} height={Height} text={Text}";
        }
    }
}
