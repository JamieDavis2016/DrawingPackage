using DrawingPackage.Widgets;
using FluentAssertions;
using Xunit;

namespace DrawingPackage.tests
{
    public class WidgetTests
    {
        [Fact]
        public void Add_items_to_widget()
        {
            //arrange
            var x = 2;
            var y = 3;
            var width = 30;
            var height = 40;
            var size = 35;
            var diameterH = 300;
            var diameterV = 200;
            var text = "sample";

            var rectangle = new Rectangle(x, y, width, height);
            var square = new Square(x, y, size);
            var eclipse = new Eclipse(x, y, diameterH, diameterV);
            var circle = new Circle(x, y, size);
            var textbox = new Textbox(x, y, width, height, text);

            //act
            var sut = new List<IWidget> { rectangle, square, eclipse, circle, textbox };

            //arrange
            sut.Count.Should().Be(5);
        }

        [Fact]
        public void Print_all_widgets()
        {
            //arrange
            var x = 2;
            var y = 3;
            var width = 30;
            var height = 40;
            var size = 35;
            var diameterH = 300;
            var diameterV = 200;
            var text = "sample";

            var rectangle = new Rectangle(x, y, width, height);
            var square = new Square(x, y, size);
            var eclipse = new Eclipse(x, y, diameterH, diameterV);
            var circle = new Circle(x, y, size);
            var textbox = new Textbox(x, y, width, height, text);

            //act
            var sut = new List<IWidget> { rectangle, square, eclipse, circle, textbox };

            //arrange
            var listOfPrints = new List<string>();
            foreach (var item in sut)
            {
                listOfPrints.Add(item.Print());
            }

            listOfPrints.Count.Should().Be(5);
        }

        [Fact]
        public void Add_rectangle_to_widget()
        {
            //arrange
            var x = 2;
            var y = 3;
            var width = 30;
            var height = 40;
            var rectangle = new Rectangle(x, y, width, height);
           
            //act
            var sut  = new List<IWidget> { rectangle };

            //assert
            sut.Count.Should().Be(1);
        }

        [Fact]
        public void Add_square_to_widget()
        {
            //arrange
            var x = 2;
            var y = 3;
            var size = 35;
            var square = new Square(x, y, size);

            //act
            var sut = new List<IWidget> { square };

            //assert
            sut.Count.Should().Be(1);
        }

        [Fact]
        public void Add_eclipse_to_widget()
        {
            //arrange
            var x = 2;
            var y = 3;
            var diameterH = 300;
            var diameterV = 200;
            var eclipse= new Eclipse(x, y, diameterH, diameterV);

            //act
            var sut = new List<IWidget> { eclipse };

            //assert
            sut.Count.Should().Be(1);
        }

        [Fact]
        public void Add_circle_to_widget()
        {
            //arrange
            var x = 2;
            var y = 3;
            var size = 300;
            var circle = new Circle(x, y, size);

            //act
            var sut = new List<IWidget> { circle };

            //assert
            sut.Count.Should().Be(1);
        }

        [Fact]
        public void Add_textbox_to_widget()
        {
            //arrange
            var x = 2;
            var y = 3;
            var width = 30;
            var height = 40;
            var text = "sample text";
            var textbox = new Textbox(x, y, width, height, text);

            //act
            var sut = new List<IWidget> { textbox };

            //assert
            sut.Count.Should().Be(1);
        }

    }
}
