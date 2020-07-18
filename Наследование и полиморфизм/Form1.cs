using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Наследование_и_полиморфизм.Application_logic;

namespace Наследование_и_полиморфизм
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox_elements_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_elements.SelectedIndex >= 0)
            {
                button_change.Enabled = true;
                button_delete.Enabled = true;
                if (listBox_elements.SelectedItem is Disk_Calc)
                {
                    var item = listBox_elements.SelectedItem as Disk_Calc;
                    textBox_result.Text = item.Calc().ToString();
                }
                else if(listBox_elements.SelectedItem is Width_Calc)
                {
                    var item = listBox_elements.SelectedItem as Width_Calc;
                    textBox_result.Text = item.Calc().ToString();
                }
                else if(listBox_elements.SelectedItem is Diametr_Calc)
                {
                    var item = listBox_elements.SelectedItem as Diametr_Calc;
                    textBox_result.Text = item.Calc().ToString();
                }
            }
            else
            {
                button_change.Enabled = false;
                button_delete.Enabled = false;
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {

            if (radioButton_choiceDisk.Checked)
            {
                var Dialog = new Form_Disk();
                Dialog.Text = "Добавление расчёта по диску";
                if(Dialog.ShowDialog() == DialogResult.OK)
                {
                    var Calc = new Disk_Calc(Convert.ToDouble(Dialog.textBox_n.Text), Convert.ToDouble(Dialog.textBox_d.Text));
                    listBox_elements.Items.Add(Calc);
                }
            }
            else if (radioButton_choiceWidth.Checked)
            {
                var Dialog = new Form_Width();
                Dialog.Text = "Добавление расчёта по ширине";
                if (Dialog.ShowDialog() == DialogResult.OK)
                {
                    var Calc = new Width_Calc(Convert.ToDouble(Dialog.textBox_n.Text), Convert.ToDouble(Dialog.textBox_k.Text), Convert.ToDouble(Dialog.textBox_d.Text));
                    listBox_elements.Items.Add(Calc);
                }
            }
            else if (radioButton_choiceDiameter.Checked)
            {
                var Dialog = new Form_Diametr();
                Dialog.Text = "Добавление расчёта по диаметру";
                if (Dialog.ShowDialog() == DialogResult.OK)
                {
                    var Calc = new Diametr_Calc(Convert.ToDouble(Dialog.textBox_n.Text), Convert.ToDouble(Dialog.textBox_d.Text));
                    listBox_elements.Items.Add(Calc);
                }
            }
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            if (listBox_elements.SelectedIndex >= 0)
            {
                if (listBox_elements.SelectedItem is Disk_Calc)
                {
                    var item = listBox_elements.SelectedItem as Disk_Calc;
                    var Dialog = new Form_Disk();
                    Dialog.Text = "Изменение расчёта по диску";
                    Dialog.textBox_n.Text = item.n.ToString();
                    Dialog.textBox_d.Text = item.d.ToString();
                    if(Dialog.ShowDialog() == DialogResult.OK)
                    {
                        item.n = Convert.ToInt32(Dialog.textBox_n.Text);
                        item.d = Convert.ToInt32(Dialog.textBox_d.Text);
                        listBox_elements.Items[listBox_elements.SelectedIndex] = item;
                        textBox_result.Text = item.Calc().ToString();
                    }
                }
                else if (listBox_elements.SelectedItem is Width_Calc)
                {
                    var item = listBox_elements.SelectedItem as Width_Calc;
                    var Dialog = new Form_Width();
                    Dialog.Text = "Изменение расчёта по ширине";
                    Dialog.textBox_n.Text = item.n.ToString();
                    Dialog.textBox_k.Text = item.k.ToString();
                    Dialog.textBox_d.Text = item.d.ToString();
                    if (Dialog.ShowDialog() == DialogResult.OK)
                    {
                        item.n = Convert.ToInt32(Dialog.textBox_n.Text);
                        item.k = Convert.ToInt32(Dialog.textBox_k.Text);
                        item.d = Convert.ToInt32(Dialog.textBox_d.Text);
                        listBox_elements.Items[listBox_elements.SelectedIndex] = item;
                        textBox_result.Text = item.Calc().ToString();
                    }
                }
                else if (listBox_elements.SelectedItem is Diametr_Calc)
                {
                    var item = listBox_elements.SelectedItem as Diametr_Calc;
                    var Dialog = new Form_Diametr();
                    Dialog.Text = "Изменение расчёта по диаметру";
                    Dialog.textBox_n.Text = item.n.ToString();
                    Dialog.textBox_d.Text = item.d.ToString();
                    if (Dialog.ShowDialog() == DialogResult.OK)
                    {
                        item.n = Convert.ToInt32(Dialog.textBox_n.Text);
                        item.d = Convert.ToInt32(Dialog.textBox_d.Text);
                        listBox_elements.Items[listBox_elements.SelectedIndex] = item;
                        textBox_result.Text = item.Calc().ToString();
                    }
                }
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (listBox_elements.SelectedIndex >= 0)
            {
                listBox_elements.Items.Remove(listBox_elements.SelectedItem);
                textBox_result.Text = "";
            }
            else
                MessageBox.Show("Не выбран элемент в списке");
        }
    }
}
