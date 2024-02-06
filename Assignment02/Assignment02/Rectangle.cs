namespace Assignment02
{
    public class Rectangle
    {
        private int length;
        private int width;

        public Rectangle() //Default
        {
            length = 1;
            width = 1;
        }

        public Rectangle(int initialLength, int initialWidth) //Non-Default
        {
            SetLength(initialLength);
            SetWidth(initialWidth);
        }

        public int GetLength()
        {
            return length;
        }

        public int SetLength(int newLength)
        {
            if (newLength < 1)
                length = 1;
            else if (newLength > 1100)
                length = 1100;
            else
                length = newLength;

            return length;
        }

        public int GetWidth()
        {
            return width;
        }

        public int SetWidth(int newWidth)
        {
            if (newWidth < 1)
                width = 1;
            else if (newWidth > 1100)
                width = 1100;
            else
                width = newWidth;

            return width;
        }

        public int GetPerimeter()
        {
            return 2 * (length + width);
        }

        public int GetArea()
        {
            return length * width;
        }
    }
}
