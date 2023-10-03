using System;
using System.Collections.Generic;
using System.Text;

namespace var3_task1
{
    class Rectangle
    {
        private float[] sides;

        public bool Exist(float a, float b)
        {
            if (sides.Length == 2 && sides[0] > 0 && sides[1] > 0)
            {
                return true;
            }
            else
            {
                sides[0] = 0;
                sides[1] = 0;
                Console.WriteLine("Incorrect values");
                return false;
            }
        }
        public Rectangle(params float[] sides)
        {
            this.sides = new float[2];
            if (Exist(this.sides[0], this.sides[1]))
            {
                this.sides[0] = sides[0];
                this.sides[1] = sides[1];
            }
        }

        public float this[int i]
        {
            get
            {
                if (i >= 0 && i < 2)
                {
                    return sides[i];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                if (i >= 0 && i < 2 && i == 1 && Exist(sides[0], value))
                {
                    sides[i] = value;
                }
                else if (i >= 0 && i < 2 && i == 0 && Exist(sides[1], value))
                {
                    sides[i] = value;
                }
            }
        }

        public void Set_sides(params float[] Sides)
        {
            sides = new float[2];
            if (Exist(Sides[0], Sides[1]))
            {
                this.sides[0] = Sides[0];
                this.sides[1] = Sides[1];
            }
        }

        public float[] Get_Sides()
        {
            return sides;
        }

        public float Perimeter()
        {
            return 2 * (sides[0] + sides[1]);
        }

        public float Area()
        {
            return sides[0] * sides[1];
        }
    }
}
