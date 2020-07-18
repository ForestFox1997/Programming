using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Свойста_и_индексаторы
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgv_matrix_A.RowCount = Convert.ToInt32(nud_n.Value);
            dgv_matrix_A.ColumnCount = Convert.ToInt32(nud_m.Value);
        }

        private void numericUpDown_n_ValueChanged(object sender, EventArgs e)
        {
            dgv_matrix_A.RowCount = Convert.ToInt32(nud_n.Value);
        }

        private void numericUpDown_m_ValueChanged(object sender, EventArgs e)
        {
            dgv_matrix_A.ColumnCount = Convert.ToInt32(nud_m.Value);
        }

        private void button_GetArrayB_Click(object sender, EventArgs e)
        {
            var matrix = new Matrix(dgv_matrix_A.RowCount, dgv_matrix_A.ColumnCount);
            for (int i = 0; i < dgv_matrix_A.RowCount; i++)
                for (int j = 0; j < dgv_matrix_A.ColumnCount; j++)
                    matrix[i, j] = Convert.ToInt32(dgv_matrix_A[j, i].Value);

            var numbersArray = new NumbersArray(dgv_matrix_A.ColumnCount);
            for(int j = 0; j < dgv_matrix_A.ColumnCount; j++)
                numbersArray[j] = matrix[j];
            numbersArray.SortArray();
            
            tb_Array_B.Clear();
            for (int j = 0; j < dgv_matrix_A.ColumnCount; j++)
                tb_Array_B.Text += numbersArray[j].ToString() + ' ';
        }
    }
}
