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
    public partial class FormCity : Form
    {
        public FormCity()
        {
            InitializeComponent();
        }

        private void FormCity_Shown(object sender, EventArgs e)
        {
            tb_CityName.Focus();
        }

        private void FormCity_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (tb_CityName.Text.Length < 2 || tb_CityName.Text.Length > 30)
                {
                    e.Cancel = true;
                    tb_CityName.Focus();
                    MessageBox.Show("Неправильно введено название города");
                }
                else if (tb_StateName.Text.Length < 10 || tb_StateName.Text.Length > 30)
                {
                    e.Cancel = true;
                    tb_StateName.Focus();
                    MessageBox.Show("Неправильно введено название области");
                }
                else if(nud_Population.Value < 2000 || nud_Population.Value > 15000000)
                {
                    e.Cancel = true;
                    nud_Population.Focus();
                    MessageBox.Show("Неправильно введено количество жителей");
                }
            }
        }
    }
}
