using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Многооконность_и_доп.элементы_интерфейса
{
    public partial class Dialog_window : Form
    {
        public Dialog_window()
        {
            InitializeComponent();
        }

        private void Dialog_window_Shown(object sender, EventArgs e)
        {
            CarMark_Value.Focus();
        }

        private void Dialog_window_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult == DialogResult.OK)
                try
                {
                    if(CarMark_Value.Text.Trim() == "")
                    {
                        CarMark_Value.Focus();
                        throw new Exception("Вы не ввели наименование марки");
                    }
                    if(CarManufacturer_Value.Text.Trim() == "")
                    {
                        CarManufacturer_Value.Focus();
                        throw new Exception("Вы не ввели фирму-производитель");
                    }
                    double Fuel_rate = Convert.ToDouble(FuelRate_Value.Text);
                    if (Fuel_rate < 2.0 || Fuel_rate > 80.0)
                    {
                        FuelRate_Value.Focus();
                        throw new Exception("Расход топлива на 100км должен быть в диапозоне от 2 до 80 литров");
                    }
                    int Car_weight = Convert.ToInt32(CarWeight_Value.Text);
                    if (Car_weight < 100 || Car_weight > 5000)
                    {
                        CarWeight_Value.Focus();
                        throw new Exception("Вес автомобиля должен быть в диапозоне от 100 до 5000 килограмм");
                    }
                }
                catch(Exception E)
                {
                    e.Cancel = true;
                    MessageBox.Show(E.Message, "Ошибка");
                }
        }
    }
}
