using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace лаба3
{
    class Circle : Figure
    {
        double r;

        public Circle(double R)
        {
            this.r = R;
            this.Type = "Круг";
        }

        public override double Area()
        {
            return Math.PI * this.r * this.r;
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }

    }
}
