using System;

namespace var3_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            TTriangle triangle1 = new TTriangle();
            Console.WriteLine(triangle1);

            TTriangle triangle2 = new TTriangle(4, 3, 5);
            Console.WriteLine(triangle2);

            TTriangle triangle3 = new TTriangle(triangle2);
            Console.WriteLine(triangle3);

            //Console.WriteLine(TTriangle.EqualityOfTriangles(triangle2, triangle3));
            if (triangle2 == triangle3)
            {
                Console.WriteLine("Triangles are equal");
            }
            else
            {
                Console.WriteLine("Triangles are  not equal");
            }

            if (triangle2 != triangle3)
            {
                Console.WriteLine("Triangles are not equal");
            }
            else
            {
                Console.WriteLine("Triangles are equal");
            }

            triangle1 = triangle2 * 2;
            triangle2 = 2 * triangle1;
            Console.WriteLine(triangle1);
            Console.WriteLine(triangle2);

            Console.WriteLine($"The perimeter of a triangle is equal to {triangle2.Perimeter()}");
            Console.WriteLine($"The area of a triangle is equal to {triangle2.Area()}");

            TTrianglePrizm trianglePrizm = new TTrianglePrizm(2, 4, 5, 8);
            trianglePrizm.A = 3;
            trianglePrizm.H = 7;
            Console.WriteLine("\n" + trianglePrizm);

            Console.WriteLine($"The area of a triangular prism is equal to {trianglePrizm.Area()}");
            Console.WriteLine($"The volume of a triangular prism is equal to {trianglePrizm.Volume()}");

        }
    }
}
