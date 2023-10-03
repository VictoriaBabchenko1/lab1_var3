using System;
using System.Collections.Generic;
using System.Text;

namespace var3_task2
{
    class TTriangle
    {
        protected float a;
        protected float b;
        protected float c;

        public bool Exist(double a, double b, double c)
        {
            if ((a > 0 && b > 0 && c > 0) && (a + b > c && a + c > b && b + c > a))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Incorrect data");
                return false;
            }
        }

        public TTriangle() { }

        public TTriangle(float a, float b, float c)
        {
            if (Exist(a, b, c))
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }

        public TTriangle(TTriangle previousTTriangle)
        {
            a = previousTTriangle.a;
            b = previousTTriangle.b;
            c = previousTTriangle.c;
        }

        public override string ToString()
        {
            return $"a={a}, b={b}, c={c}";
        }

        public float A
        {
            get { return a; }
            set
            {
                if (Exist(value, b, c)) a = value;
            }
        }

        public float B
        {
            get { return b; }
            set
            {
                if (Exist(a, value, c)) b = value;
            }
        }

        public float C
        {
            get { return c; }
            set
            {
                if (Exist(a, b, value)) c = value;
            }
        }

        public double Perimeter()
        {
            return a + b + c;
        }

        public double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        //public static string EqualityOfTriangles(TTriangle first, TTriangle second)
        //{
        //    if (first.a == second.a && first.b == second.b && first.c == second.c)
        //    {
        //        return "Triangles are equal";
        //    }
        //    else
        //    {
        //        return "Triangles are not equal";
        //    }
        //}

        public static bool operator ==(TTriangle first, TTriangle second)
        {
            if (first.a == second.a && first.b == second.b && first.c == second.c)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(TTriangle first, TTriangle second)
        {
            if (first.a != second.a && first.b != second.b && first.c != second.c)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static TTriangle operator *(TTriangle triangle, float num)
        {
            TTriangle temp = new TTriangle(triangle.a * num, triangle.b * num, triangle.c * num);
            return temp;
        }

        public static TTriangle operator *(float num, TTriangle triangle)
        {
            TTriangle temp = new TTriangle(triangle.a * num, triangle.b * num, triangle.c * num);
            return temp;
        }
    }
}
