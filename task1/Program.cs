using System;

namespace var3_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(2, 4);

            rectangle[1] = 6;
            Console.WriteLine($"Sides of rectangle: {rectangle[0]}, {rectangle[1]}");

            rectangle.Set_sides(5, 8);
            Console.WriteLine($"Sides of rectangle: {string.Join(", ", rectangle.Get_Sides())}");

            Console.WriteLine($"The perimeter of the rectangle is equal to {rectangle.Perimeter()}");
            Console.WriteLine($"The area of the rectangle is equal to {rectangle.Area()}");
        }
    }
}
