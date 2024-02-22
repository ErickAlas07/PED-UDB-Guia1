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
            Graphics g = panel1.CreateGraphics(); //Zona para el dibujo
            Pen lapiz = new Pen(Color.Black); //Declarar color del Pen a usar

            //En caso de seleccionar círculo
            if(listBox1.SelectedIndex == 0)
            {
                SolidBrush sb = new SolidBrush(Color.Red); //Brush en rojo 
                //Dibujará una elipse usando el Pen, en posiciones x,y - 50; y dimensiones 100
                g.DrawEllipse(lapiz, x - 50, y - 50, 100, 100);
                g.FillEllipse(sb, x - 50, y - 50, 100, 100); //Rellenar la elipse de color rojo 
            }

            //En caso de seleccionar rectángulo
            if (listBox1.SelectedIndex == 1)
            {
                SolidBrush sb = new SolidBrush(Color.Green); //Brush en verde
                //Dibujará rectángulo usando el Pen, en posiciones x,y - 50; y dimensiones 100
                g.DrawRectangle(lapiz, x - 50, y - 50, 100, 100);
                g.FillRectangle(sb, x - 50, y - 50, 100, 100); //Rellenar el rectángulo de color verde
            }
        }
    }
}
