using DrawingPackage.Widgets;
using FluentAssertions;
using Xunit;

namespace DrawingPackage.tests
{
    public sealed class CircleTests
    {
        [Fact]
        public void Print_circle()
        {
            //arrange
            var x = 2;
            var y = 3;
            var size = 300;
            var circle = new Circle(x, y, size);

            //act
            var sut = circle.Print();

            //assert
            sut.Should().Be("Circle (2,3) size = 300");
        }
    }
}
