using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Многооконность_и_доп.элементы_интерфейса
{
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();
        }

        private void SearchCoolCar()
        {
            int Cars_count = Car_List.Items.Count;
            if (Cars_count != 0)
            {
                int Cool_car_index = 0;
                double Cool_level = 0;
                double Max_cool_level = double.MaxValue;
                for (int i = 0; i < Cars_count; i++)
                {
                    var Car = new TCar();
                    Car = Car_List.Items[i] as TCar;
                    Cool_level = Car.Fuel_rate / Car.Car_weight;
                    if (Cool_level < Max_cool_level)
                    {
                        Max_cool_level = Cool_level;
                        Cool_car_index = i;
                    }
                }
                var Cool_car = new TCar();
                Cool_car = Car_List.Items[Cool_car_index] as TCar;
                CoolCar_Value.Text = Cool_car.Car_mark + " / " + Cool_car.Car_manufacturer + " / " + Max_cool_level.ToString("0.0000");
            }
            else
                CoolCar_Value.Text = "Ответа нет";
        }

        private void ShowCarInfo()
        {
            if (Car_List.SelectedIndex != -1)
            {
                var Car = Car_List.SelectedItem as TCar;
                CarInfo_Value.Text = Car.Car_mark + " / " + Car.Car_manufacturer + " / " + Car.Fuel_rate.ToString() + " / " + Car.Car_weight.ToString();
            }
            else
                CarInfo_Value.Text = "";
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            var Dialog = new Dialog_window();
            Dialog.Text = "Добавление автомобиля";
            Dialog.CarMark_Value.Text = "";
            Dialog.CarManufacturer_Value.Text = "";
            Dialog.FuelRate_Value.Text = "";
            Dialog.CarWeight_Value.Text = "";
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                var Car = new TCar();
                Car.Car_mark = Dialog.CarMark_Value.Text.Trim();
                Car.Car_manufacturer = Dialog.CarManufacturer_Value.Text.Trim();
                Car.Fuel_rate = Convert.ToDouble(Dialog.FuelRate_Value.Text.Trim());
                Car.Car_weight = Convert.ToInt32(Dialog.CarWeight_Value.Text.Trim());
                Car_List.Items.Add(Car);
                SearchCoolCar();
                ShowCarInfo();
            }
        }

        private void Button_Change_Click(object sender, EventArgs e)
        {
            if (Car_List.SelectedIndex != -1)
            {
                var Dialog = new Dialog_window();
                Dialog.Text = "Изменение параметров автомобиля";
                var Car = Car_List.SelectedItem as TCar;
                Dialog.CarMark_Value.Text = Car.Car_mark;
                Dialog.CarManufacturer_Value.Text = Car.Car_manufacturer;
                Dialog.FuelRate_Value.Text = Car.Fuel_rate.ToString();
                Dialog.CarWeight_Value.Text = Car.Car_weight.ToString();
                if (Dialog.ShowDialog() == DialogResult.OK)
                {
                    Car.Car_mark = Dialog.CarMark_Value.Text.Trim();
                    Car.Car_manufacturer = Dialog.CarManufacturer_Value.Text.Trim();
                    Car.Fuel_rate = Convert.ToDouble(Dialog.FuelRate_Value.Text.Trim());
                    Car.Car_weight = Convert.ToInt32(Dialog.CarWeight_Value.Text.Trim());
                    Car_List.Items[Car_List.SelectedIndex] = Car;
                    SearchCoolCar();
                    ShowCarInfo();
                }
            }
            else
                MessageBox.Show("Не выбран элемент из списка");
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            if (Car_List.SelectedIndex != -1)
            {
                Car_List.Items.RemoveAt(Car_List.SelectedIndex);
                SearchCoolCar();
                ShowCarInfo();
            }
            else
                MessageBox.Show("Не выбран элемент из списка");
        }

        private void Menu_Save_Click(object sender, EventArgs e)
        {
            using (var SW = new StreamWriter("data.txt"))
            {
                SW.Write(Car_List.Items.Count.ToString() + Environment.NewLine);
                for (int i = 0; i < Car_List.Items.Count; i++)
                {
                    var Car = Car_List.Items[i] as TCar;
                    SW.Write(Car.Car_mark + Environment.NewLine);
                    SW.Write(Car.Car_manufacturer + Environment.NewLine);
                    SW.Write(Car.Fuel_rate.ToString() + Environment.NewLine);
                    SW.Write(Car.Car_weight.ToString() + Environment.NewLine);
                }
            }
        }

        private void Menu_Load_Click(object sender, EventArgs e)
        {
            Car_List.Items.Clear();
            using (var SR = new StreamReader("data.txt"))
            {
                int Items_count = Convert.ToInt32(SR.ReadLine());
                for(int i = 0; i < Items_count; i++)
                {
                    var Car = new TCar();
                    Car.Car_mark = SR.ReadLine();
                    Car.Car_manufacturer = SR.ReadLine();
                    Car.Fuel_rate = Convert.ToDouble(SR.ReadLine());
                    Car.Car_weight = Convert.ToInt32(SR.ReadLine());
                    Car_List.Items.Add(Car);
                }
            }
            SearchCoolCar();
        }

        private void Car_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowCarInfo();
        }
    }
}
