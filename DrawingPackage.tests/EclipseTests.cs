using DrawingPackage.Widgets;
using FluentAssertions;
using Xunit;
using static FluentAssertions.FluentActions;

namespace DrawingPackage.tests
{
    public sealed class EclipseTests
    {
        [Theory]
        [InlineData(2, 3, 200, 300)]
        public void Can_create_eclipse(int x, int y, int diameterH, int diameterV)
        {
            //arrange
            //act
            var sut = new Eclipse(x, y, diameterH, diameterV);

            //assert
            sut.Should().NotBeNull();
        }

        [Theory]
        [InlineData(-1, 3, 200, 300)]
        [InlineData(2, -1, 200, 300)]
        [InlineData(2, 3, -10, 300)]
        [InlineData(2, 3, 200, -10)]

        public void creating_eclipse_throws_error(int x, int y, int diameterH, int diameterV)
        {
            //arrange
            //act
            //assert
            Invoking(() => new Eclipse(x, y, diameterH, diameterV))
                .Should().Throw<ArgumentOutOfRangeException>();
        }

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
