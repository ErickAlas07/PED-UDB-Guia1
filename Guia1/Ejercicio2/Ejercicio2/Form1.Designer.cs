
namespace Ejercicio2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.picDibujo = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblEspacio = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtEspaciado = new System.Windows.Forms.TextBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.lblOrientacion = new System.Windows.Forms.Label();
            this.cmbOrientacion = new System.Windows.Forms.ComboBox();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.lblInicio = new System.Windows.Forms.Label();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblRequired = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDibujo)).BeginInit();
            this.SuspendLayout();
            // 
            // picDibujo
            // 
            this.picDibujo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picDibujo.Location = new System.Drawing.Point(355, 45);
            this.picDibujo.Name = "picDibujo";
            this.picDibujo.Size = new System.Drawing.Size(633, 425);
            this.picDibujo.TabIndex = 7;
            this.picDibujo.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Crimson;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Snow;
            this.btnSalir.Location = new System.Drawing.Point(892, 477);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 53);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(59, 50);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(68, 17);
            this.lblCantidad.TabIndex = 0;
            this.lblCantidad.Text = "Cantidad:";
            this.lblCantidad.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEspacio
            // 
            this.lblEspacio.AutoSize = true;
            this.lblEspacio.Location = new System.Drawing.Point(59, 113);
            this.lblEspacio.Name = "lblEspacio";
            this.lblEspacio.Size = new System.Drawing.Size(78, 17);
            this.lblEspacio.TabIndex = 1;
            this.lblEspacio.Text = "Espaciado:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(59, 167);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(45, 17);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Color:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(155, 45);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(130, 22);
            this.txtCantidad.TabIndex = 3;
            // 
            // txtEspaciado
            // 
            this.txtEspaciado.Location = new System.Drawing.Point(155, 110);
            this.txtEspaciado.Name = "txtEspaciado";
            this.txtEspaciado.Size = new System.Drawing.Size(130, 22);
            this.txtEspaciado.TabIndex = 4;
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "Amarillo",
            "Rojo",
            "Azul",
            "Negro"});
            this.cmbColor.Location = new System.Drawing.Point(155, 167);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(130, 24);
            this.cmbColor.TabIndex = 5;
            // 
            // btnDraw
            // 
            this.btnDraw.BackColor = System.Drawing.Color.Green;
            this.btnDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.ForeColor = System.Drawing.Color.Snow;
            this.btnDraw.Location = new System.Drawing.Point(119, 414);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(136, 56);
            this.btnDraw.TabIndex = 6;
            this.btnDraw.Text = "Dibujar líneas";
            this.btnDraw.UseVisualStyleBackColor = false;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // lblOrientacion
            // 
            this.lblOrientacion.AutoSize = true;
            this.lblOrientacion.Location = new System.Drawing.Point(59, 245);
            this.lblOrientacion.Name = "lblOrientacion";
            this.lblOrientacion.Size = new System.Drawing.Size(85, 17);
            this.lblOrientacion.TabIndex = 8;
            this.lblOrientacion.Text = "Orientación:";
            // 
            // cmbOrientacion
            // 
            this.cmbOrientacion.FormattingEnabled = true;
            this.cmbOrientacion.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical",
            "Inclinacion"});
            this.cmbOrientacion.Location = new System.Drawing.Point(155, 238);
            this.cmbOrientacion.Name = "cmbOrientacion";
            this.cmbOrientacion.Size = new System.Drawing.Size(130, 24);
            this.cmbOrientacion.TabIndex = 9;
            this.cmbOrientacion.TextChanged += new System.EventHandler(this.cmbOrientacion_TextChanged);
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(155, 297);
            this.txtInicio.Margin = new System.Windows.Forms.Padding(4);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(130, 22);
            this.txtInicio.TabIndex = 20;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(59, 302);
            this.lblInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(40, 17);
            this.lblInicio.TabIndex = 19;
            this.lblInicio.Text = "Inicio";
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(155, 357);
            this.txtFinal.Margin = new System.Windows.Forms.Padding(4);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(130, 22);
            this.txtFinal.TabIndex = 22;
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(59, 357);
            this.lblFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(38, 17);
            this.lblFinal.TabIndex = 21;
            this.lblFinal.Text = "Final";
            // 
            // lblRequired
            // 
            this.lblRequired.AutoSize = true;
            this.lblRequired.ForeColor = System.Drawing.Color.Red;
            this.lblRequired.Location = new System.Drawing.Point(152, 205);
            this.lblRequired.Name = "lblRequired";
            this.lblRequired.Size = new System.Drawing.Size(0, 17);
            this.lblRequired.TabIndex = 23;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(163, 323);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1000, 542);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblRequired);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.txtInicio);
            this.Controls.Add(this.cmbOrientacion);
            this.Controls.Add(this.lblOrientacion);
            this.Controls.Add(this.picDibujo);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.txtEspaciado);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblEspacio);
            this.Controls.Add(this.lblCantidad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDibujo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picDibujo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblEspacio;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtEspaciado;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Label lblOrientacion;
        private System.Windows.Forms.ComboBox cmbOrientacion;
        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblRequired;
        private System.Windows.Forms.Label lblError;
    }
}

