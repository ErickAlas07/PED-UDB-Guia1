using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        enum Posicion
        {
            izquierda, derecha, arriba, abajo
        }

        private List<Point> gusano;
        private Posicion objposicion;
        private Point comida;
        private int longitudGusano; // Contador de tamaño del gusano

        public Form1()
        {
            InitializeComponent();
            gusano = new List<Point>();
            gusano.Add(new Point(50, 50));
            objposicion = Posicion.derecha;

            Random random = new Random();
            comida = new Point(random.Next(0, this.ClientRectangle.Width - 10), random.Next(0, this.ClientRectangle.Height - 10));

            timermov.Interval = 100;
            timermov.Start();

            longitudGusano = 1; //Inicializar el contador
            contador();
        }

        private void timermov_Tick(object sender, EventArgs e)
        {
            MoverGusano();

            if (ColisionConBordes() || ColisionConCuerpo())
            {
                timermov.Stop();
                MessageBox.Show($"¡Juego Terminado! Longitud del gusano: {longitudGusano}");
                reiniciar();

            }

            // Verificar si la cabeza del gusano ha alcanzado la comida
            if (gusano[0].X >= comida.X && gusano[0].X < comida.X + 10 &&
                gusano[0].Y >= comida.Y && gusano[0].Y < comida.Y + 10)
            {
                // Incrementar la longitud del gusano y generar nueva posición de la comida
                gusano.Add(new Point(-10, -10));
                longitudGusano++;
                GenerarNuevaComida();
                contador();
            }

            Invalidate();
        }

        private void contador()
        {
            this.Text = $"Juego - Record: {longitudGusano}";
        }

        private void MoverGusano()
        {
            for (int i = gusano.Count - 1; i > 0; i--)
            {
                gusano[i] = gusano[i - 1];
            }

            if (objposicion == Posicion.derecha)
                gusano[0] = new Point(gusano[0].X + 10, gusano[0].Y);
            else if (objposicion == Posicion.izquierda)
                gusano[0] = new Point(gusano[0].X - 10, gusano[0].Y);
            else if (objposicion == Posicion.arriba)
                gusano[0] = new Point(gusano[0].X, gusano[0].Y - 10);
            else if (objposicion == Posicion.abajo)
                gusano[0] = new Point(gusano[0].X, gusano[0].Y + 10);
        }

        private bool ColisionConBordes()
        {
            return gusano[0].X < 0 || gusano[0].X >= this.ClientRectangle.Width ||
                   gusano[0].Y < 0 || gusano[0].Y >= this.ClientRectangle.Height;
        }

        private bool ColisionConCuerpo()
        {
            for (int i = 1; i < gusano.Count; i++)
            {
                if (gusano[0].Equals(gusano[i]))
                    return true;
            }
            return false;
        }

        private void GenerarNuevaComida()
        {
            Random random = new Random();
            comida = new Point(random.Next(0, this.ClientRectangle.Width - 10), random.Next(0, this.ClientRectangle.Height - 10));

            // Agregar un nuevo segmento al final del gusano
            gusano.Add(new Point(-10, -10));
        }

        private void reiniciar()
        {
            // Reiniciar variables y estado del juego
            gusano.Clear();
            gusano.Add(new Point(50, 50));
            objposicion = Posicion.derecha;

            Random random = new Random();
            comida = new Point(random.Next(0, this.ClientRectangle.Width - 10), random.Next(0, this.ClientRectangle.Height - 10));

            longitudGusano = 1; // Reiniciar contador 
            contador(); // Actualizar el título del formulario con la longitud inicial

            timermov.Start(); 
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && objposicion != Posicion.derecha)
            {
                objposicion = Posicion.izquierda;
            }
            else if (e.KeyCode == Keys.Right && objposicion != Posicion.izquierda)
            {
                objposicion = Posicion.derecha;
            }
            else if (e.KeyCode == Keys.Up && objposicion != Posicion.abajo)
            {
                objposicion = Posicion.arriba;
            }
            else if (e.KeyCode == Keys.Down && objposicion != Posicion.arriba)
            {
                objposicion = Posicion.abajo;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < gusano.Count; i++)
            {
                e.Graphics.FillRectangle(Brushes.Blue, new Rectangle(gusano[i].X, gusano[i].Y, 10, 10));
            }
            e.Graphics.FillEllipse(Brushes.Red, new Rectangle(comida.X, comida.Y, 10, 10));
        }
    }
}
