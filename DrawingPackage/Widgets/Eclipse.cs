using EnsureThat;

namespace DrawingPackage.Widgets
{
    public class Eclipse : Shape, IWidget
    {
        public Eclipse(int x, int y, int diameterH, int diameterV) : base(x, y)
        {
            DiameterH = EnsureArg.IsGt(diameterH, 0);
            DiameterV = EnsureArg.IsGt(diameterV, 0);
        }

        public int DiameterH { get; private set; }
        public int DiameterV { get; private set; }

        public override string Print()
        {
            return $"Eclipse ({X},{Y}) diameterH = {DiameterH} diameterV = {DiameterV}";
        }
    }
}
