using System;
using System.Drawing;
using System.Windows.Forms;

namespace Графика
{
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();
        }

        TFigure Figure;

        private void Main_form_Load(object sender, EventArgs e)
        {
            int Temp = Image_PB.Width / 3;
            Image_PB.Image = new Bitmap(Image_PB.Width, Image_PB.Height);
            Figure = new TFigure(20, 180, Temp, Image_PB);
            Move_T.Enabled = true;
        }

        private void Main_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Move_T.Enabled = false;
        }

        private void Move_T_Tick(object sender, EventArgs e)
        {
            Figure.Move();
        }

        private void Image_PB_Click(object sender, EventArgs e)
        {
            if (Move_T.Enabled == true)
                Move_T.Enabled = false;
            else if(Move_T.Enabled == false)
                Move_T.Enabled = true;
        }
    }
}
