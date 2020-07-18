using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Свойста_и_индексаторы
{
    /// <summary> Числовая матрица </summary>
    class Matrix
    {
        private int[,] numbers_array;

        /// <summary> Инициализации числовой матрицы </summary>
        /// <param name="row_count"> количество строк </param> <param name="column_count"> количество столбцов </param>
        public Matrix(int row_count, int column_count)
        {
            if (row_count < 2 || column_count < 2)
                throw new Exception("Неправильное количество элементов матрицы");
            else
                numbers_array = new int[row_count, column_count];
        }

        /// <summary> Значение элемента числовой матрицы </summary>
        /// <param name="i"> номер строки </param> <param name="j"> номер столбца </param>
        public int this[int i, int j]
        {
            get
            {
                if (i > numbers_array.GetLength(0) || i < 0)
                    throw new Exception("Первый индекс имеет недопустимое значение");
                else
                {
                    if (j > numbers_array.GetLength(1) || j < 0)
                        throw new Exception("Второй индекс имеет недопустимое значение");
                    else
                        return numbers_array[i, j];
                }
            }
            set
            {
                if (i > numbers_array.GetLength(0) || i < 0)
                    throw new Exception("Первый индекс имеет недопустимое значение");
                else
                {
                    if (j > numbers_array.GetLength(1) || j < 0)
                        throw new Exception("Второй индекс имеет недопустимое значение");
                    else
                        numbers_array[i, j] = value;
                }
            }
        }

        /// <summary> Получение наибольшего значения столбца матрицы </summary>
        /// <param name="column_number"> номер столбца </param>
        public int this [int column_number]
        {
            get
            {
                var max_value = numbers_array[0, column_number];
                for (int i = 0; i < numbers_array.GetLength(0); i++)
                    if (numbers_array[i, column_number] > max_value)
                        max_value = numbers_array[i, column_number];
                return max_value;
            }
        }
    }
}
