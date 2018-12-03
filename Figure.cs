using System;

namespace лаба3
{

    abstract class Figure : IComparable //геометрическая фигура (+реализует интерфейс сравнения)
    {
        string _Type;//название типа
        public string Type  //свойство
        {
            get
            {
                return this._Type;
            }

            protected set
            {
                this._Type = value;
            }
        }

        public virtual double Area() { return 0; } //заготовка для площади


        public override string ToString() //вывод ответа
        {
            return ("Площадь " + this.Type + "а = " + this.Area().ToString());
        }


        interface IPrint //заготовка для интерфейса
        {
            void Print();
        }


        public int CompareTo(object o)
        {
            Figure c = (Figure)o;//приводим тип
            if (c != null)
            {
                return this.Area().CompareTo(c.Area());
            }
            else
                throw new Exception("Не удалось сравнить два объекта"); //ругаемся, если не удалось привести тип
        }

    }
}