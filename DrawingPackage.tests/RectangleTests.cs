using DrawingPackage.Widgets;
using FluentAssertions;
using Xunit;

namespace DrawingPackage.tests
{
    public sealed class RectangleTests
    {
        [Fact]
        public void Print_rectangle()
        {
            //arrange
            var x = 2;
            var y = 3;
            var width = 30;
            var height = 40;
            var rectangle = new Rectangle(x, y, width, height);

            //act
            var sut = rectangle.Print();

            //assert
            sut.Should().Be("Rectangle (2,3) width=30 height=40");
        }
    }
}
