using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        int x, y; //Variables para determinar ubicación del clic

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Point punto = new Point(e.X, e.Y);
            x = punto.X;
            y = punto.Y;
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Pen lapiz = new Pen(Color.Black);
            Random random = new Random();
            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            int randomSize = random.Next(50, 100);

            if (listBox1.SelectedIndex == 0)
            {
                SolidBrush sb = new SolidBrush(randomColor);
                g.DrawEllipse(lapiz, x - 50, y - 50, randomSize, randomSize);
                g.FillEllipse(sb, x - 50, y - 50, randomSize, randomSize);
            }

            else if (listBox1.SelectedIndex == 1)
            {
                SolidBrush sb = new SolidBrush(randomColor);
                g.DrawRectangle(lapiz, x - 50, y - 50, randomSize, randomSize);
                g.FillRectangle(sb, x - 50, y - 50, randomSize, randomSize);
            }

            else if (listBox1.SelectedIndex == 2)
            {
                SolidBrush sb = new SolidBrush(randomColor);

                //Array de puntos para representar los vértices del polígono
                Point[] points = new Point[4];
                points[0] = new Point(x + randomSize, y - randomSize);
                points[1] = new Point(x - randomSize, y + randomSize);
                points[2] = new Point(x + randomSize, y + randomSize);
                points[3] = new Point(x + randomSize, y - 50);

                // Dibujar y rellenar el polígono
                g.DrawPolygon(lapiz, points);
                g.FillPolygon(sb, points);
            }

            else if (listBox1.SelectedIndex == 3)
            {
                SolidBrush sb = new SolidBrush(randomColor);

                // Array de puntos para representar los vértices de la curva
                Point[] points = new Point[4];
                points[0] = new Point(x - randomSize, y - randomSize);
                points[1] = new Point(x - randomSize, y + randomSize);
                points[2] = new Point(x + randomSize, y + randomSize);
                points[3] = new Point(x + randomSize, y - randomSize);

                // Dibujar y rellenar la curva
                g.DrawCurve(lapiz, points);
                g.FillClosedCurve(sb, points);
            }
        }


    }
}
