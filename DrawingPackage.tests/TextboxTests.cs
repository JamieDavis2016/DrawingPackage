using DrawingPackage.Widgets;
using FluentAssertions;
using Xunit;
using static FluentAssertions.FluentActions;

namespace DrawingPackage.tests
{
    public class TextboxTests
    {
        [Theory]
        [InlineData(2, 3, 200, 300, "sample text")]
        public void Can_create_textbox(int x, int y, int width, int height, string text)
        {
            //arrange
            //act
            var sut = new Textbox(x, y, width, height, text);

            //assert
            sut.Should().NotBeNull();
        }

        [Theory]
        [InlineData(-1, 3, 200, 300, "sample text")]
        [InlineData(2, -1, 200, 300, "sample text")]
        [InlineData(2, 3, -200, 300, "sample text")]
        [InlineData(2, 3, 200, -300, "")]

        public void creating_textbox_throws_error(int x, int y, int width, int height, string text)
        {
            //arrange
            //act
            //assert
            Invoking(() => new Textbox(x, y, width, height, text))
                .Should().Throw<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void Print_textbox()
        {
            //arrange
            var x = 2;
            var y = 3;
            var width = 30;
            var height = 40;
            var text = "sample text";
            var rectangle = new Textbox(x, y, width, height, text);

            //act
            var sut = rectangle.Print();

            //assert
            sut.Should().Be("Textbox (2,3) width=30 height=40 text=sample text");
        }
    }
}
