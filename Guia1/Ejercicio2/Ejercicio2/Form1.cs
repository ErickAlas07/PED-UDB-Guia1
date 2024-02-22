using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {

        Graphics area; //Area de trabajo

        public Form1()
        {
            InitializeComponent();
            area = picDibujo.CreateGraphics(); //Establecer el área de dibujo en el pictureBox  
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Pen lapicero = new Pen(Color.Black);

            switch(cmbColor.SelectedIndex)
            {
                case 0: lapicero = new Pen(Color.Yellow); break;
                case 1: lapicero = new Pen(Color.Red); break;
                case 2: lapicero = new Pen(Color.Blue); break;
                case 3: lapicero = new Pen(Color.Black); break;
            }

            int iteraciones = int.Parse(txtCantidad.Text); //Cantidad de líneas a dibujar
            int espacio = int.Parse(txtEspaciado.Text); //Espaciado asignado (en píxeles).

            area.Clear(Color.White); //Limpiar área, es decir, lo pinta de color blanco

            int puntoInicio = 50; //Inicia en un valor de y = 50

            for(int i = 0; i < iteraciones; i++)
            {
                //Dibuja línea por línea de acuerdo al color dado, en x van de 20 a 300 y en "y" varía según iteración.
                area.DrawLine(lapicero, 20, puntoInicio + (espacio * 1), 300, puntoInicio + (espacio * 1));
            }

        }
    }
}
