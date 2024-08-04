using DrawingPackage.Widgets;
using FluentAssertions;
using Xunit;
using static FluentAssertions.FluentActions;

namespace DrawingPackage.tests
{
    public sealed class CircleTests
    {
        [Theory]
        [InlineData(2, 3, 300)]
        public void Can_create_circle(int x, int y, int size)
        {
            //arrange
            //act
            var sut = new Circle(x, y, size);

            //assert
            sut.Should().NotBeNull();
        }

        [Theory]
        [InlineData(-1, 3, 300)]
        [InlineData(2, -1, 300)]
        [InlineData(2, 3, -10)]

        public void creating_circle_throws_error(int x, int y, int size)
        {
            //arrange
            //act
            //assert
            Invoking(() => new Circle(x, y, size))
                .Should().Throw<ArgumentOutOfRangeException>();
        }

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
