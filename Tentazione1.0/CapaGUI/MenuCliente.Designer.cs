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
            this.btnPantGenerarCotizacion = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRevisarCotizaciones = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEditarPerfil = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCerrarSesion = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // btnPantGenerarCotizacion
            // 
            this.btnPantGenerarCotizacion.Depth = 0;
            this.btnPantGenerarCotizacion.Location = new System.Drawing.Point(81, 85);
            this.btnPantGenerarCotizacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPantGenerarCotizacion.Name = "btnPantGenerarCotizacion";
            this.btnPantGenerarCotizacion.Primary = true;
            this.btnPantGenerarCotizacion.Size = new System.Drawing.Size(165, 65);
            this.btnPantGenerarCotizacion.TabIndex = 6;
            this.btnPantGenerarCotizacion.Text = "Generar Cotización";
            this.btnPantGenerarCotizacion.UseVisualStyleBackColor = true;
            this.btnPantGenerarCotizacion.Click += new System.EventHandler(this.btnPantGenerarCotizacion_Click);
            // 
            // btnRevisarCotizaciones
            // 
            this.btnRevisarCotizaciones.Depth = 0;
            this.btnRevisarCotizaciones.Location = new System.Drawing.Point(81, 167);
            this.btnRevisarCotizaciones.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRevisarCotizaciones.Name = "btnRevisarCotizaciones";
            this.btnRevisarCotizaciones.Primary = true;
            this.btnRevisarCotizaciones.Size = new System.Drawing.Size(165, 65);
            this.btnRevisarCotizaciones.TabIndex = 7;
            this.btnRevisarCotizaciones.Text = "Revisar Cotizaciones";
            this.btnRevisarCotizaciones.UseVisualStyleBackColor = true;
            this.btnRevisarCotizaciones.Click += new System.EventHandler(this.btnRevisarCotizaciones_Click);
            // 
            // btnEditarPerfil
            // 
            this.btnEditarPerfil.Depth = 0;
            this.btnEditarPerfil.Location = new System.Drawing.Point(81, 249);
            this.btnEditarPerfil.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarPerfil.Name = "btnEditarPerfil";
            this.btnEditarPerfil.Primary = true;
            this.btnEditarPerfil.Size = new System.Drawing.Size(165, 65);
            this.btnEditarPerfil.TabIndex = 8;
            this.btnEditarPerfil.Text = "Editar Perfil";
            this.btnEditarPerfil.UseVisualStyleBackColor = true;
            this.btnEditarPerfil.Click += new System.EventHandler(this.btnEditarPerfil_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Depth = 0;
            this.btnCerrarSesion.Location = new System.Drawing.Point(81, 331);
            this.btnCerrarSesion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Primary = true;
            this.btnCerrarSesion.Size = new System.Drawing.Size(165, 65);
            this.btnCerrarSesion.TabIndex = 9;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(81, 413);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(165, 65);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // MenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 515);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnEditarPerfil);
            this.Controls.Add(this.btnRevisarCotizaciones);
            this.Controls.Add(this.btnPantGenerarCotizacion);
            this.Name = "MenuCliente";
            this.Text = "MenuCliente";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnPantGenerarCotizacion;
        private MaterialSkin.Controls.MaterialRaisedButton btnRevisarCotizaciones;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditarPerfil;
        private MaterialSkin.Controls.MaterialRaisedButton btnCerrarSesion;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
    }
}