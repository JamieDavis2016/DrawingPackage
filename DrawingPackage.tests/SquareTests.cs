using DrawingPackage.Widgets;
using FluentAssertions;
using Xunit;

namespace DrawingPackage.tests
{
    public sealed class SquareTests
    {
        [Fact]
        public void Print_square()
        {
            //arrange
            var x = 2;
            var y = 3;
            var size = 30;
            var square = new Square(x, y, size);

            //act
            var sut = square.Print();

            //assert
            sut.Should().Be("Square (2,3) size=30");
        }
    }
}
