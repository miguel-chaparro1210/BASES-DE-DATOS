namespace PL_WindowsFormsApp_Punto01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelValorRadio = new System.Windows.Forms.Label();
            this.textBoxRegistrodevalor = new System.Windows.Forms.TextBox();
            this.groupBoxSelecciónObjeto = new System.Windows.Forms.GroupBox();
            this.radioButtonRueda = new System.Windows.Forms.RadioButton();
            this.radioButtonMoneda = new System.Windows.Forms.RadioButton();
            this.buttonCapturarRadio = new System.Windows.Forms.Button();
            this.buttonCalcularPerimetro = new System.Windows.Forms.Button();
            this.buttonCalcularArea = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.labelNotificaciones = new System.Windows.Forms.Label();
            this.groupBoxSelecciónObjeto.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelValorRadio
            // 
            this.labelValorRadio.AutoSize = true;
            this.labelValorRadio.Location = new System.Drawing.Point(43, 51);
            this.labelValorRadio.Name = "labelValorRadio";
            this.labelValorRadio.Size = new System.Drawing.Size(149, 15);
            this.labelValorRadio.TabIndex = 0;
            this.labelValorRadio.Text = "Ingrese el valor del Radio:";
            // 
            // textBoxRegistrodevalor
            // 
            this.textBoxRegistrodevalor.Location = new System.Drawing.Point(198, 46);
            this.textBoxRegistrodevalor.Name = "textBoxRegistrodevalor";
            this.textBoxRegistrodevalor.Size = new System.Drawing.Size(264, 20);
            this.textBoxRegistrodevalor.TabIndex = 1;
            // 
            // groupBoxSelecciónObjeto
            // 
            this.groupBoxSelecciónObjeto.Controls.Add(this.radioButtonRueda);
            this.groupBoxSelecciónObjeto.Controls.Add(this.radioButtonMoneda);
            this.groupBoxSelecciónObjeto.Location = new System.Drawing.Point(46, 135);
            this.groupBoxSelecciónObjeto.Name = "groupBoxSelecciónObjeto";
            this.groupBoxSelecciónObjeto.Size = new System.Drawing.Size(146, 174);
            this.groupBoxSelecciónObjeto.TabIndex = 2;
            this.groupBoxSelecciónObjeto.TabStop = false;
            this.groupBoxSelecciónObjeto.Text = "Seleccione un objeto:";
            // 
            // radioButtonRueda
            // 
            this.radioButtonRueda.AutoSize = true;
            this.radioButtonRueda.Location = new System.Drawing.Point(20, 116);
            this.radioButtonRueda.Name = "radioButtonRueda";
            this.radioButtonRueda.Size = new System.Drawing.Size(62, 19);
            this.radioButtonRueda.TabIndex = 4;
            this.radioButtonRueda.TabStop = true;
            this.radioButtonRueda.Text = "Rueda";
            this.radioButtonRueda.UseVisualStyleBackColor = true;
            // 
            // radioButtonMoneda
            // 
            this.radioButtonMoneda.AutoSize = true;
            this.radioButtonMoneda.Location = new System.Drawing.Point(20, 52);
            this.radioButtonMoneda.Name = "radioButtonMoneda";
            this.radioButtonMoneda.Size = new System.Drawing.Size(71, 19);
            this.radioButtonMoneda.TabIndex = 3;
            this.radioButtonMoneda.TabStop = true;
            this.radioButtonMoneda.Text = "Moneda";
            this.radioButtonMoneda.UseVisualStyleBackColor = true;
            // 
            // buttonCapturarRadio
            // 
            this.buttonCapturarRadio.Location = new System.Drawing.Point(283, 118);
            this.buttonCapturarRadio.Name = "buttonCapturarRadio";
            this.buttonCapturarRadio.Size = new System.Drawing.Size(243, 34);
            this.buttonCapturarRadio.TabIndex = 3;
            this.buttonCapturarRadio.Text = "Capturar Radio";
            this.buttonCapturarRadio.UseVisualStyleBackColor = true;
            this.buttonCapturarRadio.Click += new System.EventHandler(this.buttonCapturarRadio_Click);
            // 
            // buttonCalcularPerimetro
            // 
            this.buttonCalcularPerimetro.Location = new System.Drawing.Point(283, 223);
            this.buttonCalcularPerimetro.Name = "buttonCalcularPerimetro";
            this.buttonCalcularPerimetro.Size = new System.Drawing.Size(243, 29);
            this.buttonCalcularPerimetro.TabIndex = 4;
            this.buttonCalcularPerimetro.Text = "Calcular Perimetro";
            this.buttonCalcularPerimetro.UseVisualStyleBackColor = true;
            this.buttonCalcularPerimetro.Click += new System.EventHandler(this.buttonCalcularPerimetro_Click);
            // 
            // buttonCalcularArea
            // 
            this.buttonCalcularArea.Location = new System.Drawing.Point(283, 171);
            this.buttonCalcularArea.Name = "buttonCalcularArea";
            this.buttonCalcularArea.Size = new System.Drawing.Size(243, 35);
            this.buttonCalcularArea.TabIndex = 5;
            this.buttonCalcularArea.Text = "Calcular Area";
            this.buttonCalcularArea.UseVisualStyleBackColor = true;
            this.buttonCalcularArea.Click += new System.EventHandler(this.buttonCalcularArea_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(283, 268);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(243, 41);
            this.buttonSalir.TabIndex = 6;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // labelNotificaciones
            // 
            this.labelNotificaciones.AutoSize = true;
            this.labelNotificaciones.Location = new System.Drawing.Point(126, 334);
            this.labelNotificaciones.Name = "labelNotificaciones";
            this.labelNotificaciones.Size = new System.Drawing.Size(0, 15);
            this.labelNotificaciones.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(567, 381);
            this.Controls.Add(this.labelNotificaciones);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonCalcularArea);
            this.Controls.Add(this.buttonCalcularPerimetro);
            this.Controls.Add(this.buttonCapturarRadio);
            this.Controls.Add(this.groupBoxSelecciónObjeto);
            this.Controls.Add(this.textBoxRegistrodevalor);
            this.Controls.Add(this.labelValorRadio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Laboratorio01-Punto01";
            this.groupBoxSelecciónObjeto.ResumeLayout(false);
            this.groupBoxSelecciónObjeto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelValorRadio;
        private System.Windows.Forms.TextBox textBoxRegistrodevalor;
        private System.Windows.Forms.GroupBox groupBoxSelecciónObjeto;
        private System.Windows.Forms.RadioButton radioButtonRueda;
        private System.Windows.Forms.RadioButton radioButtonMoneda;
        private System.Windows.Forms.Button buttonCapturarRadio;
        private System.Windows.Forms.Button buttonCalcularPerimetro;
        private System.Windows.Forms.Button buttonCalcularArea;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Label labelNotificaciones;
    }
}

