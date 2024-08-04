using DrawingPackage.Widgets;
using FluentAssertions;
using Xunit;
using static FluentAssertions.FluentActions;

namespace DrawingPackage.tests
{
    public sealed class SquareTests
    {
        [Theory]
        [InlineData(2, 3, 200)]
        public void Can_create_square(int x, int y, int size)
        {
            //arrange
            //act
            var sut = new Square(x, y, size);

            //assert
            sut.Should().NotBeNull();
        }

        [Theory]
        [InlineData(-1, 3, 200)]
        [InlineData(2, -1, 200)]
        [InlineData(2, 3, -10)]

        public void creating_square_throws_error(int x, int y, int size)
        {
            //arrange
            //act
            //assert
            Invoking(() => new Square(x, y, size))
                .Should().Throw<ArgumentOutOfRangeException>();
        }

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
