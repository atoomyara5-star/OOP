using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskday3
{
    internal class Program
    {
        interface shap
        {

            double Area();
            double size();

        }
        class square : shap
        {
            private double side;
            public square(double side)
            {
                this.side = side;
            }
            public double Area()
            {
                return side * side;
            }
            public double size()
            {
                return 4 * side;
            }
        }
            class rectangle : shap
            {
                private double length;
                private double width;
                public rectangle(double length, double width)
                {   this.length = length;
                    this.width = width;
                }
                public double Area()
                {
                    return length * width;
                }
                public double size()
                {
                    return 2 * (length + width);
                }

            }
        class circle : shap
        {
            private double r;
          
            public circle(double r)
            {
                this.r = r;
                
            }
            public double Area()
            {
                return (3.14 * r * r);
            }
            public double size()
            {
                return (2 * 3.14 * r);
            }

        }

        static void Main(string[] args)
        {
            shap s1 = new square(5);
            Console.WriteLine("Square Area = " + s1.Area());
            Console.WriteLine("Square Size = " + s1.size());

            Console.WriteLine("--------------------");
            shap r1 = new rectangle(6, 4);
            Console.WriteLine("Rectangle Area = " + r1.Area());
            Console.WriteLine("Rectangle Size = " + r1.size());
            Console.WriteLine("--------------------");
            shap c1 = new circle(2);
            Console.WriteLine("circle Area = " + c1.Area());
            Console.WriteLine("circle Size = " + c1.size());
        }
    }
}
