using System;
using System.Windows.Forms;

namespace Совокупность_объектов_пользовательсткого_класса
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var element = new TElement();
            element.firstValue = Convert.ToDouble(tb_FirstValue.Text);
            element.secondValue = Convert.ToDouble(tb_SecondValue.Text);
            lb_Elements.Items.Add(element);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (lb_Elements.SelectedIndex != -1)
                lb_Elements.Items.RemoveAt(lb_Elements.SelectedIndex);
            else
                MessageBox.Show("Не был выбран элемент из списка");
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            if (lb_Elements.Items.Count > 0)
            {
                double? result = null;
                for (int i = 0; i < lb_Elements.Items.Count; i++)
                {
                    var element = lb_Elements.Items[i] as TElement;
                    if ((element.secondValue - (Math.Truncate(element.secondValue))) < (element.firstValue - (Math.Truncate(element.firstValue)))) //Если дробная часть второго числа меньше дробной части первого числа
                        result = Convert.ToDouble(result) + (Math.Truncate(element.secondValue)); //Прибавить к результату целую часть второго числа
                }
                if (result == null)
                    tb_Result.Text = "Ответ не найден";
                else
                    tb_Result.Text = Convert.ToString(result);
            }
            else
                MessageBox.Show("Отсутствуют элементы в списке");
        }
    }
}
