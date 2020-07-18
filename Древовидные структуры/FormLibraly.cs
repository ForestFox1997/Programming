using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Древовидные_структуры
{
    public partial class FormLibraly : Form
    {
        public FormLibraly()
        {
            InitializeComponent();
        }

        private void FormLibraly_Shown(object sender, EventArgs e)
        {
            tb_LibralyName.Focus();
        }

        private void FormLibraly_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if(tb_LibralyName.Text.Length < 5 || tb_LibralyName.Text.Length > 50)
                {
                    e.Cancel = true;
                    tb_LibralyName.Focus();
                    MessageBox.Show("Неправильно введено название библиотеки");
                }
                else if (tb_LibralyAdress.Text.Length < 10 || tb_LibralyAdress.Text.Length > 100)
                {
                    e.Cancel = true;
                    tb_LibralyAdress.Focus();
                    MessageBox.Show("Неправильно указан адрес библиотеки");
                }
                else if(nud_CountOfBooks.Value < 1000 || nud_CountOfBooks.Value > 1000000)
                {
                    e.Cancel = true;
                    nud_CountOfBooks.Focus();
                    MessageBox.Show("Неправильно введено количество книг");
                }
            }
        }
    }
}
