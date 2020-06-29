namespace CapaGUI
{
    partial class MenuEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMenuEmpleado = new System.Windows.Forms.Label();
            this.btnPantAdminCliente = new System.Windows.Forms.Button();
            this.btnPantAdminProductos = new System.Windows.Forms.Button();
            this.btnPantRevisarCotizaciones = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenuEmpleado
            // 
            this.lblMenuEmpleado.AutoSize = true;
            this.lblMenuEmpleado.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuEmpleado.Location = new System.Drawing.Point(12, 9);
            this.lblMenuEmpleado.Name = "lblMenuEmpleado";
            this.lblMenuEmpleado.Size = new System.Drawing.Size(354, 59);
            this.lblMenuEmpleado.TabIndex = 0;
            this.lblMenuEmpleado.Text = "Menú Empleado";
            // 
            // btnPantAdminCliente
            // 
            this.btnPantAdminCliente.Location = new System.Drawing.Point(118, 106);
            this.btnPantAdminCliente.Name = "btnPantAdminCliente";
            this.btnPantAdminCliente.Size = new System.Drawing.Size(118, 42);
            this.btnPantAdminCliente.TabIndex = 1;
            this.btnPantAdminCliente.Text = "Administrar Usuarios";
            this.btnPantAdminCliente.UseVisualStyleBackColor = true;
            this.btnPantAdminCliente.Click += new System.EventHandler(this.btnPantAdminCliente_Click);
            // 
            // btnPantAdminProductos
            // 
            this.btnPantAdminProductos.Location = new System.Drawing.Point(118, 165);
            this.btnPantAdminProductos.Name = "btnPantAdminProductos";
            this.btnPantAdminProductos.Size = new System.Drawing.Size(118, 42);
            this.btnPantAdminProductos.TabIndex = 2;
            this.btnPantAdminProductos.Text = "Administrar Productos";
            this.btnPantAdminProductos.UseVisualStyleBackColor = true;
            this.btnPantAdminProductos.Click += new System.EventHandler(this.btnPantAdminProductos_Click);
            // 
            // btnPantRevisarCotizaciones
            // 
            this.btnPantRevisarCotizaciones.Location = new System.Drawing.Point(118, 224);
            this.btnPantRevisarCotizaciones.Name = "btnPantRevisarCotizaciones";
            this.btnPantRevisarCotizaciones.Size = new System.Drawing.Size(118, 42);
            this.btnPantRevisarCotizaciones.TabIndex = 3;
            this.btnPantRevisarCotizaciones.Text = "Revisar Cotizaciones";
            this.btnPantRevisarCotizaciones.UseVisualStyleBackColor = true;
            this.btnPantRevisarCotizaciones.Click += new System.EventHandler(this.btnPantRevisarCotizaciones_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(118, 283);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(118, 42);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(118, 342);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(118, 42);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // MenúEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 452);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnPantRevisarCotizaciones);
            this.Controls.Add(this.btnPantAdminProductos);
            this.Controls.Add(this.btnPantAdminCliente);
            this.Controls.Add(this.lblMenuEmpleado);
            this.Name = "MenúEmpleado";
            this.Text = "MenúEmpleado";
            this.Load += new System.EventHandler(this.MenúEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuEmpleado;
        private System.Windows.Forms.Button btnPantAdminCliente;
        private System.Windows.Forms.Button btnPantAdminProductos;
        private System.Windows.Forms.Button btnPantRevisarCotizaciones;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnSalir;
    }
}