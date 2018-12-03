using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба3
{
    class Rectangle : Figure//прямоугольник наследуется от фигуры (логично)
    {
        double A, B; //длина и высота

        public Rectangle(double a, double b)//конструктор. 
        {
            this.A = a;
            this.B = b;
            this.Type = "Прямоугольник";
        }

        public override double Area()//переопределенная функция суммы
        {
            return this.A * this.B;
        }

        public void Print()//реализация интерфейса
        {
            Console.WriteLine(this.ToString());
        }
    }


    class Square : Rectangle
    {
        public Square(double size) //присвоили значения сторонам с использованием базового конструктора
            : base(size, size)//использовали конструктор базового класса
        {
            this.Type = "Квадрат";
        }
    }
}
