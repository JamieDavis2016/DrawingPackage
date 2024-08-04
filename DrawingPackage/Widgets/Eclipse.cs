namespace DrawingPackage.Widgets
{
    public class Eclipse : Shape, IWidget
    {
        public Eclipse(int x, int y, int diameterH, int diameterV) : base(x, y)
        {
            DiameterH = diameterH;
            DiameterV = diameterV;
        }

        public int DiameterH { get; private set; }
        public int DiameterV { get; private set; }

        public override string Print()
        {
            return $"Eclipse ({X},{Y}) diameterH = {DiameterH} diameterV = {DiameterV}";
        }
    }
}
