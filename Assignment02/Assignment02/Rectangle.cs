using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            length = initialLength;
            width = initialWidth;
        }

        public int GetLength()
        {
            return length;
        }

        public int SetLength(int newLength)
        {
            length = newLength;
            return length;
        }

        public int GetWidth()
        {
            return width;
        }

        public int SetWidth(int newWidth)
        {
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

        static void Main()
        {
            Rectangle defaultRectangle = new Rectangle();

            Console.WriteLine($"Default Length: {defaultRectangle.GetLength()}");
            Console.WriteLine($"Default Width: {defaultRectangle.GetWidth()}");
            Console.WriteLine($"Default Perimeter: {defaultRectangle.GetPerimeter()}");
            Console.WriteLine($"Default Area: {defaultRectangle.GetArea()}");

            Console.Write("Enter Length: ");
            int length = int.Parse(Console.ReadLine());

            Console.Write("Enter Width: ");
            int width = int.Parse(Console.ReadLine());

            Rectangle myRectangle = new Rectangle(length, width);

            Console.WriteLine($"Non Default Initial Perimeter: {myRectangle.GetPerimeter()}");
            Console.WriteLine($"Non Default Initial Area: {myRectangle.GetArea()}");

            Console.Write("Enter New Width: ");
            myRectangle.SetWidth(int.Parse(Console.ReadLine()));

            Console.Write("Enter New Length: ");
            myRectangle.SetLength(int.Parse(Console.ReadLine()));

            Console.WriteLine($"Updated Perimeter: {myRectangle.GetPerimeter()}");
            Console.WriteLine($"Updated Area: {myRectangle.GetArea()}");

            Console.ReadLine();
        }
    }

}
