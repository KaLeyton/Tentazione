namespace CapaGUI
{
    partial class MenuCliente
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
            this.lblMenuCliente = new System.Windows.Forms.Label();
            this.btnPantGenerarCotizacion = new System.Windows.Forms.Button();
            this.btnPantRevisarCotizaciones = new System.Windows.Forms.Button();
            this.btnEditarPerfil = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenuCliente
            // 
            this.lblMenuCliente.AutoSize = true;
            this.lblMenuCliente.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuCliente.Location = new System.Drawing.Point(30, 25);
            this.lblMenuCliente.Name = "lblMenuCliente";
            this.lblMenuCliente.Size = new System.Drawing.Size(293, 59);
            this.lblMenuCliente.TabIndex = 0;
            this.lblMenuCliente.Text = "Menú Cliente";
            // 
            // btnPantGenerarCotizacion
            // 
            this.btnPantGenerarCotizacion.Location = new System.Drawing.Point(117, 108);
            this.btnPantGenerarCotizacion.Name = "btnPantGenerarCotizacion";
            this.btnPantGenerarCotizacion.Size = new System.Drawing.Size(113, 43);
            this.btnPantGenerarCotizacion.TabIndex = 1;
            this.btnPantGenerarCotizacion.Text = "Generar Cotización";
            this.btnPantGenerarCotizacion.UseVisualStyleBackColor = true;
            this.btnPantGenerarCotizacion.Click += new System.EventHandler(this.btnPantGenerarCotizacion_Click);
            // 
            // btnPantRevisarCotizaciones
            // 
            this.btnPantRevisarCotizaciones.Location = new System.Drawing.Point(117, 158);
            this.btnPantRevisarCotizaciones.Name = "btnPantRevisarCotizaciones";
            this.btnPantRevisarCotizaciones.Size = new System.Drawing.Size(113, 43);
            this.btnPantRevisarCotizaciones.TabIndex = 2;
            this.btnPantRevisarCotizaciones.Text = "Revisar Cotizaciones";
            this.btnPantRevisarCotizaciones.UseVisualStyleBackColor = true;
            this.btnPantRevisarCotizaciones.Click += new System.EventHandler(this.btnPantRevisarCotizaciones_Click);
            // 
            // btnEditarPerfil
            // 
            this.btnEditarPerfil.Location = new System.Drawing.Point(117, 208);
            this.btnEditarPerfil.Name = "btnEditarPerfil";
            this.btnEditarPerfil.Size = new System.Drawing.Size(113, 43);
            this.btnEditarPerfil.TabIndex = 3;
            this.btnEditarPerfil.Text = "Editar Perfil";
            this.btnEditarPerfil.UseVisualStyleBackColor = true;
            this.btnEditarPerfil.Click += new System.EventHandler(this.btnEditarPerfil_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(117, 258);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(113, 43);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(117, 308);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(113, 43);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // MenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 384);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnEditarPerfil);
            this.Controls.Add(this.btnPantRevisarCotizaciones);
            this.Controls.Add(this.btnPantGenerarCotizacion);
            this.Controls.Add(this.lblMenuCliente);
            this.Name = "MenuCliente";
            this.Text = "MenuCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuCliente;
        private System.Windows.Forms.Button btnPantGenerarCotizacion;
        private System.Windows.Forms.Button btnPantRevisarCotizaciones;
        private System.Windows.Forms.Button btnEditarPerfil;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnSalir;
    }
}