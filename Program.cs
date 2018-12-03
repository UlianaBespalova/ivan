using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;

namespace лаба3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(3, 4);  //создали объект класса Прямоугольник размером 3на4 и так далее
            Square sq = new Square(4);
            Circle circle = new Circle(3);

            rect.Print(); //вывели ответ
            sq.Print();
            circle.Print();



            ArrayList arr = new ArrayList(); //пустая коллекция
            arr.Add(rect);
            arr.Add(circle);
            arr.Add(sq);

            arr.Sort(); //отсортировали

            Console.WriteLine("\n\nОтсортированный ArrayList:\n");
            foreach (Figure ivan in arr) //все элементы имеют тип Figure
            {
                Console.WriteLine(ivan);
            }



            List<Figure> list = new List<Figure>();
            list.Add(rect);
            list.Add(circle);
            list.Add(sq);

            list.Sort();

            Console.WriteLine("\n\nОтсортированный List:\n");
            foreach (Figure ivan in list)
            {
                Console.WriteLine(ivan);
            }



            Console.WriteLine("\n\nМатрица:\n");

            Matrix<Figure> cube = new Matrix<Figure>(2, 2, 2, null); //создали кубик с ребром 2 ячейки
            cube[0, 0, 1] = rect;
            cube[0, 1, 1] = sq;
            cube[1, 1, 1] = circle;

            Console.WriteLine(cube.ToString());



            

            SimpleList<Figure> sl = new SimpleList<Figure>
            {
                rect, circle, sq
            };

            sl.Sort();
            Console.WriteLine("\nОтсортированный SimpleList\n");
            foreach (var i in sl)
            {
                Console.WriteLine(i.ToString());
            }


           
            SimpleStack<Figure> st = new SimpleStack<Figure>();
            st.Push(rect);
            st.Push(circle);
            st.Push(sq);
            Console.WriteLine("\nSimpleStack\n");
            foreach (var s in st)
            {
                Console.WriteLine(s.ToString());
            }



            Figure P = st.Pop();
            Console.WriteLine("\nУдалено " + P.ToString() + "\n");
            foreach (var s in st)
            {
                Console.WriteLine(s.ToString());
            }



            Console.ReadLine();
        }
    }


}