using System.Drawing;
using System.Windows.Forms;

namespace Графика
{
    class TFigure
    {
        int X, Y, dX, dY, Size;
        PictureBox PB;
        Pen Pen = new Pen(Color.Black, 2);
        SolidBrush SB = new SolidBrush(Color.Purple);

        public TFigure(int NewX, int NewY, int NewSize, PictureBox NewPictureBox)
        {
            /* Начальные характеристики фигуры */
            X = NewX;
            Y = NewY;
            dX = -1;
            dY = -1;
            Size = NewSize;
            PB = NewPictureBox;
            Show();
        }

        ~TFigure()
        {
            /* Разрушение объектов класса */
            Pen.Dispose();
            SB.Dispose();
        }

        public void Show()
        {
            SB.Color = Color.LightGray;
            var Graphic = Graphics.FromImage(PB.Image);

            /* Создание ромба и его заливка*/
            Graphic.DrawLine(Pen, X + Size / 2, Y - Size / 5, X + Size + Size / 5, Y + Size / 2);
            Graphic.DrawLine(Pen, X + Size + Size / 5, Y + Size / 2, X + Size / 2, Y + Size + Size / 5);
            Graphic.DrawLine(Pen, X + Size / 2, Y + Size + Size / 5, X - Size / 5, Y + Size / 2);
            Graphic.DrawLine(Pen, X - Size / 5, Y + Size / 2, X + Size / 2, Y - Size / 5);
            var point1 = new Point(X + Size / 2, Y - Size / 5);
            var point2 = new Point(X + Size + Size / 5, Y + Size / 2);
            var point3 = new Point(X + Size / 2, Y + Size + Size / 5);
            var point4 = new Point(X - Size / 5, Y + Size / 2);
            Point[] points_array = { point1, point2, point3, point4 };
            Graphic.FillPolygon(SB, points_array);

            /* Создание круга */
            SB.Color = Color.Black;
            int Ellipse_size = Size * 4 / 5;
            Graphic.DrawEllipse(Pen, X + 10, Y + 10, Ellipse_size, Ellipse_size);

            /* Создание полос внутри круга */
            SB.Color = Color.Black;
            var point = new Point(5, 5);
            Graphic.DrawLine(Pen, X + 85, Y + 70, X + 50, Y + 50);
            Graphic.DrawLine(Pen, X + 51, Y + 50, X + 50, Y + 10);
            Graphic.DrawLine(Pen, X + 16, Y + 70, X + 50, Y + 50);

            /* Закраска частей круга */
            SB.Color = Color.Red;
            Graphic.FillPie(SB, X + 11, Y + 10, Size * 4 / 5, Size * 4 / 5, 271, 118);
            SB.Color = Color.Green;
            Graphic.FillPie(SB, X + 10, Y + 10, Size * 4 / 5, Size * 4 / 5, 31, 117);
            SB.Color = Color.Blue;
            Graphic.FillPie(SB, X + 10, Y + 10, Size * 4 / 5, Size * 4 / 5, 151, 118);

            PB.Refresh();
            Graphic.Dispose();
        }

        public void Hide()
        {
            var cGraphics = Graphics.FromImage(PB.Image);
            cGraphics.Clear(Color.White);
        }

        public void Move()
        {
            Hide();
            int Temp = Y - Size / 5 + dY;
            if (Temp < 0)
                dX = 1;
            else if (Temp == 159)
                dX = -1;
            X -= dX;
            if (Temp < 0)
                dY = 1;
            else if (Temp == 159)
                dY = -1;
            Y += dY;
            Show();
        }
    }
}
