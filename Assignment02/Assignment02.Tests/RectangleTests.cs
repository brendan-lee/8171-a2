namespace Assignment02.Tests
{
    public class RectangleTests
    {
        private Rectangle Rectangle { get; set; }

        [SetUp]
        public void Setup()
        {
            Rectangle = new Rectangle();
        }

        [Test]
        public void SetLength_WhenLt0_Return1()
        {
            // Arrange
            int length = -1;
            int expectedLength = 1;

            // Act
            int actualLength = Rectangle.SetLength(length);

            // Assert
            Assert.AreEqual(expectedLength, actualLength);
        }

        [Test]
        public void SetLength_WhenBetween0And1100_ReturnInput()
        {
            // Arrange
            int length = 550;
            int expectedLength = 550;

            // Act
            int actualLength = Rectangle.SetLength(length);

            // Assert
            Assert.AreEqual(expectedLength, actualLength);
        }

        [Test]
        public void SetLength_WhenGt1100_Return1100()
        {
            // Arrange
            int length = 1101;
            int expectedLength = 1100;

            // Act
            int actualLength = Rectangle.SetLength(length);

            // Assert
            Assert.AreEqual(expectedLength, actualLength);
        }

        [Test]
        public void GetLength_WhenLt0_Return1()
        {
            // Arrange
            int length = -1;
            int expectedLength = 1;

            // Act
            Rectangle.SetLength(length);

            // Assert
            Assert.AreEqual(expectedLength, Rectangle.GetLength());
        }

        [Test]
        public void GetLength_WhenBetween0And1100_ReturnInput()
        {
            // Arrange
            int length = 550;
            int expectedLength = 550;

            // Act
            Rectangle.SetLength(length);

            // Assert
            Assert.AreEqual(expectedLength, Rectangle.GetLength());
        }

        [Test]
        public void GetLength_WhenGt1100_Return1100()
        {
            // Arrange
            int length = 1101;
            int expectedLength = 1100;

            // Act
            Rectangle.SetLength(length);

            // Assert
            Assert.AreEqual(expectedLength, Rectangle.GetLength());
        }

        [Test]
        public void SetWidth_WhenLt0_Return1()
        {
            // Arrange
            int width = -1;
            int expectedWidth = 1;

            // Act
            int actualWidth = Rectangle.SetWidth(width);

            // Assert
            Assert.AreEqual(expectedWidth, actualWidth);
        }

        [Test]
        public void SetWidth_WhenBetween0And1100_ReturnInput()
        {
            // Arrange
            int width = 550;
            int expectedWidth = 550;

            // Act
            int actualWidth = Rectangle.SetWidth(width);

            // Assert
            Assert.AreEqual(expectedWidth, actualWidth);
        }

        [Test]
        public void SetWidth_WhenGt1100_Return1100()
        {
            // Arrange
            int width = 1101;
            int expectedWidth = 1100;

            // Act
            int actualWidth = Rectangle.SetWidth(width);

            // Assert
            Assert.AreEqual(expectedWidth, actualWidth);
        }

        [Test]
        public void GetWidth_WhenLt0_Return1()
        {
            // Arrange
            int width = -1;
            int expectedWidth = 1;

            // Act
            Rectangle.SetWidth(width);

            // Assert
            Assert.AreEqual(expectedWidth, Rectangle.GetWidth());
        }

        [Test]
        public void GetWidth_WhenBetween0And1100_ReturnInput()
        {
            // Arrange
            int width = 550;
            int expectedWidth = 550;

            // Act
            Rectangle.SetWidth(width);

            // Assert
            Assert.AreEqual(expectedWidth, Rectangle.GetWidth());
        }

        [Test]
        public void GetWidth_WhenGt1100_Return1100()
        {
            // Arrange
            int width = 1101;
            int expectedWidth = 1100;

            // Act
            Rectangle.SetWidth(width);

            // Assert
            Assert.AreEqual(expectedWidth, Rectangle.GetWidth());
        }

        [Test]
        public void GetPerimeter_WhenLengthValidAndWidthInvalid_CorrectWidthThenCalc()
        {
            // Arrange
            int length = 500;
            int width = -1;
            int expectedPerimeter = 1002;

            // Act
            Rectangle.SetLength(length);
            Rectangle.SetWidth(width);

            // Assert
            Assert.AreEqual(expectedPerimeter, Rectangle.GetPerimeter());
        }

        [Test]
        public void GetPerimeter_WhenBothLengthAndWidthValid_CalcCorrectly()
        {
            // Arrange
            int length = 300;
            int width = 500;
            int expectedPerimeter = 1600;

            // Act
            Rectangle.SetLength(length);
            Rectangle.SetWidth(width);

            // Assert
            Assert.AreEqual(expectedPerimeter, Rectangle.GetPerimeter());
        }

        [Test]
        public void GetPerimeter_WhenBothLengthAndWidthInvalid_CorrectBothThenCalc()
        {
            // Arrange
            int length = 1200;
            int width = -1;
            int expectedPerimeter = 2202;

            // Act
            Rectangle.SetLength(length);
            Rectangle.SetWidth(width);

            // Assert
            Assert.AreEqual(expectedPerimeter, Rectangle.GetPerimeter());
        }

        [Test]
        public void GetArea_WhenLengthValidAndWidthInvalid_CorrectWidthThenCalc()
        {
            // Arrange
            int length = 500;
            int width = -1;
            int expectedArea = 500;

            // Act
            Rectangle.SetLength(length);
            Rectangle.SetWidth(width);

            // Assert
            Assert.AreEqual(expectedArea, Rectangle.GetArea());
        }

        [Test]
        public void GetArea_WhenBothLengthAndWidthValid_CalcCorrectly()
        {
            // Arrange
            int length = 300;
            int width = 500;
            int expectedArea = 150_000;

            // Act
            Rectangle.SetLength(length);
            Rectangle.SetWidth(width);

            // Assert
            Assert.AreEqual(expectedArea, Rectangle.GetArea());
        }

        [Test]
        public void GetArea_WhenBothLengthAndWidthInvalid_CorrectBothThenCalc()
        {
            // Arrange
            int length = -1;
            int width = 1200;
            int expectedArea = 1100;

            // Act
            Rectangle.SetLength(length);
            Rectangle.SetWidth(width);

            // Assert
            Assert.AreEqual(expectedArea, Rectangle.GetArea());
        }
    }
}
