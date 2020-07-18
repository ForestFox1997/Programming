using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Компоненты_выбора
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Input_Data.RowCount = Convert.ToInt32(N_value.Value);
            Input_Data.ColumnCount = Convert.ToInt32(N_value.Value);
        }

        private void N_value_ValueChanged(object sender, EventArgs e)
        {
            Input_Data.RowCount = Convert.ToInt32(N_value.Value);
        }

        private void M_value_ValueChanged(object sender, EventArgs e)
        {
            Input_Data.ColumnCount = Convert.ToInt32(M_value.Value);
        }

        private void Button_Calc_Click(object sender, EventArgs e)
        {
            var average_counts = new double[0];
            if (Select_Columns.Checked)
                Array.Resize(ref average_counts, Convert.ToInt32(M_value.Value));
            else if (Select_Rows.Checked)
                Array.Resize(ref average_counts, Convert.ToInt32(N_value.Value));
            var selected_numbers = new List<double>();
            if (Select_Columns.Checked)
            {
                if(Select_Negative.Checked && Select_Positive.Checked)
                    for (int i = 0; i < Input_Data.ColumnCount; i++)
                    {
                        selected_numbers.Clear();
                        for (int j = 0; j < Input_Data.RowCount; j++)
                            selected_numbers.Add(Convert.ToDouble(Input_Data[i, j].Value));
                        if (selected_numbers.Count != 0)
                            average_counts[i] = selected_numbers.Average();
                        else
                            average_counts[i] = 0;
                    }
                else if (Select_Negative.Checked)
                {
                    for (int i = 0; i < Input_Data.ColumnCount; i++)
                    {
                        selected_numbers.Clear();
                        for (int j = 0; j < Input_Data.RowCount; j++)
                            if (Convert.ToDouble(Input_Data[i, j].Value) < 0)
                                selected_numbers.Add(Convert.ToDouble(Input_Data[i, j].Value));
                        if (selected_numbers.Count != 0)
                            average_counts[i] = selected_numbers.Average();
                        else
                            average_counts[i] = 0;
                    }
                }
                else if(Select_Positive.Checked)
                {
                    for (int i = 0; i < Input_Data.ColumnCount; i++)
                    {
                        selected_numbers.Clear();
                        for (int j = 0; j < Input_Data.RowCount; j++)
                            if (Convert.ToDouble(Input_Data[i, j].Value) >= 0)
                                selected_numbers.Add(Convert.ToDouble(Input_Data[i, j].Value));
                        if (selected_numbers.Count != 0)
                            average_counts[i] = selected_numbers.Average();
                        else
                            average_counts[i] = 0;
                    }
                }
            }
            else if (Select_Rows.Checked)
            {
                if (Select_Negative.Checked && Select_Positive.Checked)
                    for (int i = 0; i < Input_Data.RowCount; i++)
                    {
                        selected_numbers.Clear();
                        for (int j = 0; j < Input_Data.ColumnCount; j++)
                            selected_numbers.Add(Convert.ToDouble(Input_Data[j, i].Value));
                        if (selected_numbers.Count != 0)
                            average_counts[i] = selected_numbers.Average();
                        else
                            average_counts[i] = 0;
                    }
                else if (Select_Negative.Checked)
                    for (int i = 0; i < Input_Data.RowCount; i++)
                    {
                        selected_numbers.Clear();
                        for (int j = 0; j < Input_Data.ColumnCount; j++)
                            if(Convert.ToDouble(Input_Data[j, i].Value) < 0)
                                selected_numbers.Add(Convert.ToDouble(Input_Data[j, i].Value));
                        if (selected_numbers.Count != 0)
                            average_counts[i] = selected_numbers.Average();
                        else
                            average_counts[i] = 0;
                    }
                else if (Select_Positive.Checked)
                    for (int i = 0; i < Input_Data.RowCount; i++)
                    {
                        selected_numbers.Clear();
                        for (int j = 0; j < Input_Data.ColumnCount; j++)
                            if (Convert.ToDouble(Input_Data[j, i].Value) >= 0)
                                selected_numbers.Add(Convert.ToDouble(Input_Data[j, i].Value));
                        if (selected_numbers.Count != 0)
                            average_counts[i] = selected_numbers.Average();
                        else
                            average_counts[i] = 0;
                    }
            }
            Output_Data.Clear();
            if(Select_Columns.Checked)
                for (int i = 0; i < average_counts.Length; i++)
                    Output_Data.Text += average_counts[i].ToString() + ' ';
            else if (Select_Rows.Checked)
                for (int i = 0; i < average_counts.Length; i++)
                    Output_Data.Text += average_counts[i].ToString() + Environment.NewLine;
        }
    }
}
