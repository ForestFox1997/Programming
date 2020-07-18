using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Свойста_и_индексаторы
{
    /// <summary> Числовой массив </summary>
    class NumbersArray
    {
        private int[] numbersArray;

        /// <summary> Инициализация числового массива </summary>
        /// <param name="numbers_count"> количество чисел в массиве </param>
        public NumbersArray(int numbers_count)
        {
            if (numbers_count < 2)
                throw new Exception("Неправильное количество элементов массива");
            else
                numbersArray = new int[numbers_count];
        }

        /// <summary> Элемент числового массива </summary>
        /// <param name="element_number"> номер элемента </param>
        public int this[int element_number]
        {
            get
            {
                if (element_number > numbersArray.Length || element_number < 0)
                    throw new Exception("Индекс имеет недопустимое значение");
                else
                    return numbersArray[element_number];
            }
            set
            {
                if (element_number > numbersArray.Length || element_number < 0)
                    throw new Exception("Индекс имеет недопустимое значение");
                numbersArray[element_number] = value;
            }
        }

        /// <summary> Сортировки числового массива </summary>
        public void SortArray()
        {
            Array.Sort(numbersArray);
        }
    }
}
