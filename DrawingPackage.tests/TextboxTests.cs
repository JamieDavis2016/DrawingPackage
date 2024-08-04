using DrawingPackage.Widgets;
using FluentAssertions;
using Xunit;

namespace DrawingPackage.tests
{
    public class TextboxTests
    {
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
