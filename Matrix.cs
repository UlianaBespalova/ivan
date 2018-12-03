using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба3
{
    public class Matrix<T>
    {
        Dictionary<string, T> _matrix = new Dictionary<string, T>(); //словарь для хранения значений

        int maxX; //максимальное колво столбцов
        int maxY; //максимальное колво строк
        int maxZ; //максимальное колво ..понятно чего

        T nullEl;

        public Matrix(int px, int py, int pz, T param)
        {
            this.maxX = px;
            this.maxY = py;
            this.maxZ = pz;
            this.nullEl = param;
        }

        public T this[int x, int y, int z]
        {
            get
            {
                CheckBounds(x, y, z);
                string key = FormKey(x, y, z);
                if (this._matrix.ContainsKey(key))
                {

                    return this._matrix[key];
                }
                else
                {
                    return this.nullEl;
                }
            }

            set
            {
                CheckBounds(x, y, z);
                string key = FormKey(x, y, z);

                this._matrix.Add(key, value);
            }
        }

        void CheckBounds(int x, int y, int z)//проверка выхода за границы
        {
            if (x < 0 || x >= this.maxX) throw new Exception("x=" + x + " выходит за границы");
            if (y < 0 || y >= this.maxY) throw new Exception("y=" + y + " выходит за границы");
            if (z < 0 || z >= this.maxZ) throw new Exception("z=" + z + " выходит за границы");
        }

        string FormKey(int x, int y, int z) //формирование ключа
        {
            return x.ToString() + "_" + y.ToString() + "_" + z.ToString();
        }


        public override string ToString()//приведение к строке 
        {
            StringBuilder b = new StringBuilder();
            for (int k = 0; k < this.maxZ; k++)
            {
                b.Append("[");
                for (int j = 0; j < this.maxY; j++)
                {
                    for (int i = 0; i < this.maxX; i++)
                    {
                        if (i > 0)
                            b.Append("\t"); //пробел
                        if (this[i, j, k] != null) b.Append(this[i, j, k].ToString());
                    }
                }
                b.Append("]\n");
            }
            return b.ToString();
        }
    }
}
