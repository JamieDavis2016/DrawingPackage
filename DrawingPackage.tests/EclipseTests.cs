using DrawingPackage.Widgets;
using FluentAssertions;
using Xunit;

namespace DrawingPackage.tests
{
    public sealed class EclipseTests
    {
        [Fact]
        public void Print_eclipse()
        {
            //arrange
            var x = 2;
            var y = 3;
            var diameterH = 300;
            var diameterV = 200;
            var eclipse = new Eclipse(x, y, diameterH, diameterV);

            //act
            var sut = eclipse.Print();

            //assert
            sut.Should().Be("Eclipse (2,3) diameterH = 300 diameterV = 200");
        }
    }
}
