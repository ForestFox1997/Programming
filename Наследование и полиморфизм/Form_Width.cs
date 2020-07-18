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
    public partial class Form_Width : Form
    {
        public Form_Width()
        {
            InitializeComponent();
        }

        private void Form_Width_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    Check_arguments(textBox_n);
                    Check_arguments(textBox_k);
                    Check_arguments(textBox_d);
                }
                catch (FormatException E)
                {
                    e.Cancel = true;
                    MessageBox.Show(E.Message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception E)
                {
                    e.Cancel = true;
                    MessageBox.Show(E.Message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
