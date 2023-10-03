using System;
using System.Collections.Generic;
using System.Text;

namespace var3_task2
{
    class TTrianglePrizm : TTriangle
    {
        protected float h;

        new public bool Exist(float a, float b, float c, float h)
        {
            base.Exist(a, b, c);
            if (h > 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Incorrect data");
                return false;
            }
        }

        public TTrianglePrizm(float a, float b, float c, float h) : base(a, b, c)
        {
            if (Exist(a, b, c, h))
            {
                this.h = h;
            }
        }

        public float H
        {
            get { return h; }
            set { if (value > 0) h = value; }
        }

        public override string ToString()
        {
            return base.ToString() + $", h={h}";
        }

        new public double Area()
        {
            //2Sосн + Sбіч (Sбіч = P * h)
            return 2 * base.Area() + Perimeter() * h;
        }

        public double Volume()
        {
            //S * h
            return Area() * h;
        }
    }
}
