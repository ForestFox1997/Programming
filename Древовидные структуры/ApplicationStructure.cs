using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Древовидные_структуры
{
    class ApplicationStructure
    {
        public class City
        {
            /// <summary> Название города </summary>
            public string name;

            /// <summary> Наименование области </summary>
            public string state;

            /// <summary> Численность населения </summary>
            public int population;

            /// <summary> Список библиотек </summary>
            public List<Libraly> libraly_list;
        }

        public class Libraly
        {
            /// <summary> Название библиотеки </summary>
            public string name;

            /// <summary> Адрес библиотеки </summary>
            public string address;

            /// <summary> Количество экземпляров книг </summary>
            public int count_of_books;
        }
    }
}
