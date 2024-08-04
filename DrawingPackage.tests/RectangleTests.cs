using DrawingPackage.Widgets;
using FluentAssertions;
using Xunit;
using static FluentAssertions.FluentActions;

namespace DrawingPackage.tests
{
    public sealed class RectangleTests
    {
        [Theory]
        [InlineData(2, 3, 200, 300)]
        public void Can_create_rectangle(int x, int y, int width, int height)
        {
            //arrange
            //act
            var sut = new Rectangle(x, y, width, height);

            //assert
            sut.Should().NotBeNull();
        }

        [Theory]
        [InlineData(-1, 3, 200, 300)]
        [InlineData(2, -1, 200, 300)]
        [InlineData(2, 3, -10, 300)]
        [InlineData(2, 3, 200, -10)]

        public void creating_rectangle_throws_error(int x, int y, int width, int height)
        {
            //arrange
            //act
            //assert
            Invoking(() => new Rectangle(x, y, width, height))
                .Should().Throw<ArgumentOutOfRangeException>();
        }

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
