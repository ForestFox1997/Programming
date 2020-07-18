using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Наследование_и_полиморфизм
{
    abstract public class Application_logic
    {
        public double n;
        public double d;

        public Application_logic(double new_n, double new_d)//Метод класса, принимающий значения для расчёта
        {
            n = new_n;
            d = new_d;
        }
        abstract public double Calc();

        public class Disk_Calc : Application_logic//Класс расчёта по диску, наслеованный от класса логики приложения
        {
            public Disk_Calc(double new_n, double new_d) : base(new_n, new_d)//Вызов конструктора класса-родителя
            {
            }

            public override double Calc()//Реализация расчёта
            {
                double s = (1 + n) * d;
                return s;
            }
            public override string ToString()//Вывод параметров экземпляра класса в строку
            {
                return "По диску: n=" + n.ToString() + "; " + "d=" + d.ToString() + ';';
            }
        }

        public class Width_Calc : Application_logic//Класс расчёта по ширине, наследованный от класса логики приложения
        {
            public double k;
            public Width_Calc(double new_n, double new_k, double new_d) : base(new_n, new_d)//Вызов конструктора класса-родителя
            {
                k = new_k;
            }
            public override double Calc()
            {
                double s = d + (2 * n * k);
                return s;
            }
            public override string ToString()//Вывод параметров экземпляра класса в строку
            {
                return "По ширине: n=" + n.ToString() + "; k=;" + k.ToString() + "; d=" + d.ToString() + ';';
            }
        }

        public class Diametr_Calc : Application_logic//Класс расчёта по дааметру, наследованный от класса логики приложения
        {
            public Diametr_Calc(double new_n, double new_d) : base(new_n, new_d)//Вызов конструктора класса-родителя
            {
            }
            public override double Calc()//Реализация расчёта
            {
                double s = d + 2 * n;
                return s;
            }
            public override string ToString()//Вывод параметров экземпляра класса в строку
            {
                return "По диаметру: n=" + n.ToString() + "; d=" + d.ToString() + ';';
            }
        }

        static public void Check_arguments(object textBox)//Метод проверки правильности введённых аргументов
        {
            var tB = textBox as TextBox;
            tB.Focus();
            if (tB.Text == string.Empty)
                throw new Exception("Не было введено числовое значение аргумента");
            double converted_number;
            bool convert_success = double.TryParse(tB.Text, out converted_number);
            if (convert_success == false)
                throw new FormatException("Ошибка введённых данных.\nАргумент должен быть числом.");
            if (!(converted_number > 0))
                throw new Exception("Ошибка введённых данных.\nАргумент должен иметь положительное значение.");
        }
    }
}
