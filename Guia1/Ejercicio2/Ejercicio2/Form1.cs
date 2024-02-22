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
            area = picDibujo.CreateGraphics();
            //Elementos que dependerán de la inclinación
            txtInicio.Enabled = false;
            txtFinal.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Boolean invalid = false;
            Pen lapicero = new Pen(Color.Black);

            switch(cmbColor.SelectedIndex)
            {
                case 0: lapicero = new Pen(Color.Yellow); break;
                case 1: lapicero = new Pen(Color.Red); break;
                case 2: lapicero = new Pen(Color.Blue); break;
                case 3: lapicero = new Pen(Color.Black); break;
            }

            //Validaciones para el combobox de orientación de líneas
            if (cmbOrientacion.SelectedIndex == -1)
            {
                invalid = true;
                lblRequired.Text = "Campo requerido";
            }
            
            else
            {
                lblRequired.Text = "";
            }

            if (cmbOrientacion.SelectedIndex == 2)
            {
                if (string.IsNullOrWhiteSpace(txtInicio.Text))
                {
                    invalid = true;
                    lblError.Text = "Campo requerido";
                }
                else
                {
                    lblError.Text = "";
                }

                if (string.IsNullOrWhiteSpace(txtFinal.Text))
                {
                    invalid = true;
                    lblError.Text = "Campo requerido";
                }
                else
                {
                    lblError.Text = "";
                }
            }

            if (!invalid)
            {

                int iteraciones = int.Parse(txtCantidad.Text);
                int espacio = int.Parse(txtEspaciado.Text);
                int puntoinicio = 50, puntoFin = 50;

                if (cmbOrientacion.SelectedIndex == 2)
                {
                    puntoinicio = int.Parse(txtInicio.Text);
                    puntoFin = int.Parse(txtFinal.Text);
                }

                area.Clear(Color.White);

                for (int i = 0; i < iteraciones; i++)
                {
                    if (cmbOrientacion.SelectedIndex == 1)
                    {
                        area.DrawLine(lapicero, puntoinicio + (espacio * i), 20, puntoFin + (espacio * i), 200);
                    }
                    else
                    {
                        area.DrawLine(lapicero, 20, puntoinicio + (espacio * i), 200, puntoFin + (espacio * i));
                    }
                }
            }

        }

        private void cmbOrientacion_TextChanged(object sender, EventArgs e)
        {
            if (cmbOrientacion.SelectedIndex == 2)
            {
                txtInicio.Enabled = true;
                txtFinal.Enabled = true;
            }
            else
            {
                txtInicio.Enabled = false;
                txtFinal.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
