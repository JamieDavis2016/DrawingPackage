﻿using DrawingPackage.Widgets;
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

        [Fact]
        public void Update_width_of_rectangle()
        {
            //arrange
            var x = 2;
            var y = 3;
            var width = 30;
            var updatedWidth = 50;
            var height = 40;
            var sut = new Rectangle(x, y, width, height);

            //act
            sut.UpdateWidth(updatedWidth);


            //assert
            sut.Width.Should().Be(updatedWidth);
        }

        [Fact]
        public void Update_height_of_rectangle()
        {
            //arrange
            var x = 2;
            var y = 3;
            var width = 30;
            var updatedHeight = 50;
            var height = 40;
            var sut = new Rectangle(x, y, width, height);

            //act
            sut.UpdateHeight(updatedHeight);

            //assert
            sut.Height.Should().Be(updatedHeight);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Update_width_of_rectangle_should_be_positive(int updatedWidth)
        {
            //arrange
            var x = 2;
            var y = 3;
            var width = 50;
            var height = 40;
            var sut = new Rectangle(x, y, width, height);

            //act
            //assert
            Invoking(() => sut.UpdateWidth(updatedWidth))
                .Should().Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Update_height_of_rectangle_should_be_positive(int updatedHeight)
        {
            //arrange
            var x = 2;
            var y = 3;
            var width = 50;
            var height = 40;
            var sut = new Rectangle(x, y, width, height);

            //act
            //assert
            Invoking(() => sut.UpdateHeight(updatedHeight))
                .Should().Throw<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void Undo_last_update_of_rectangle()
        {
            //arrange
            var x = 2;
            var y = 3;
            var width = 30;
            var updatedWidth = 50;
            var height = 40;
            var sut = new Rectangle(x, y, width, height);

            sut.UpdateWidth(updatedWidth);
            sut.Width.Should().Be(updatedWidth);

            //act
            sut.Undo();

            //assert
            sut.Width.Should().Be(width);
            sut.HistoryUpdates.Count.Should().Be(0);
        }

        //[Fact]
        //public void Undo_last_update_with_height_and_width_of_rectangle()
        //{
        //    //arrange
        //    var x = 2;
        //    var y = 3;
        //    var width = 30;
        //    var updatedWidth = 50;
        //    var height = 40;
        //    var sut = new Rectangle(x, y, width, height);

        //    sut.UpdateWidth(updatedWidth);
        //    sut.UpdateHeight(updatedWidth);
        //    sut.Height.Should().Be(updatedWidth);

        //    //act
        //    sut.Undo();

        //    //assert
        //    sut.Height.Should().Be(width);
        //    sut.HistoryUpdates.Count.Should().Be(1);
        //}
    }
}
