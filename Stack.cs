using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба3
{
    class SimpleStack<T> : SimpleList<T> where T : IComparable
    {

        public void Push(T elem)
        {
            Add(elem);
        }

        public T Pop()
        {
            T Result = default(T); //null или 0
            if (Count == 0) //если элементов нет
            {
                return Result; //выводим 0
            }

            if (Count == 1) //если есть 1 элемент
            {
                Result = First.Data; //вывели
                First = null;//занулили
                Last = null;
            }

            else
            {
                SimpleListItem<T> NewLast = GetItem(Count - 2);
                Result = NewLast.Next.Data;
                Last = NewLast;
                NewLast.Next = null;
            }
            Count--;
            return Result;
        }

    }

}
