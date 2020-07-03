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
            this.btnPantAdminCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnPantAdminProductos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnPantRevisarCotizaciones = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEditarPerfil = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCerrarSesion = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // btnPantAdminCliente
            // 
            this.btnPantAdminCliente.Depth = 0;
            this.btnPantAdminCliente.Location = new System.Drawing.Point(92, 121);
            this.btnPantAdminCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPantAdminCliente.Name = "btnPantAdminCliente";
            this.btnPantAdminCliente.Primary = true;
            this.btnPantAdminCliente.Size = new System.Drawing.Size(166, 55);
            this.btnPantAdminCliente.TabIndex = 7;
            this.btnPantAdminCliente.Text = "Administrar Cliente";
            this.btnPantAdminCliente.UseVisualStyleBackColor = true;
            this.btnPantAdminCliente.Click += new System.EventHandler(this.btnPantAdminCliente_Click);
            // 
            // btnPantAdminProductos
            // 
            this.btnPantAdminProductos.Depth = 0;
            this.btnPantAdminProductos.Location = new System.Drawing.Point(92, 193);
            this.btnPantAdminProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPantAdminProductos.Name = "btnPantAdminProductos";
            this.btnPantAdminProductos.Primary = true;
            this.btnPantAdminProductos.Size = new System.Drawing.Size(166, 48);
            this.btnPantAdminProductos.TabIndex = 8;
            this.btnPantAdminProductos.Text = "Administrar Productos";
            this.btnPantAdminProductos.UseVisualStyleBackColor = true;
            this.btnPantAdminProductos.Click += new System.EventHandler(this.btnPantAdminProductos_Click);
            // 
            // btnPantRevisarCotizaciones
            // 
            this.btnPantRevisarCotizaciones.Depth = 0;
            this.btnPantRevisarCotizaciones.Location = new System.Drawing.Point(92, 258);
            this.btnPantRevisarCotizaciones.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPantRevisarCotizaciones.Name = "btnPantRevisarCotizaciones";
            this.btnPantRevisarCotizaciones.Primary = true;
            this.btnPantRevisarCotizaciones.Size = new System.Drawing.Size(166, 47);
            this.btnPantRevisarCotizaciones.TabIndex = 9;
            this.btnPantRevisarCotizaciones.Text = "Revisar Cotizaciones";
            this.btnPantRevisarCotizaciones.UseVisualStyleBackColor = true;
            this.btnPantRevisarCotizaciones.Click += new System.EventHandler(this.btnPantRevisarCotizaciones_Click);
            // 
            // btnEditarPerfil
            // 
            this.btnEditarPerfil.Depth = 0;
            this.btnEditarPerfil.Location = new System.Drawing.Point(92, 322);
            this.btnEditarPerfil.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarPerfil.Name = "btnEditarPerfil";
            this.btnEditarPerfil.Primary = true;
            this.btnEditarPerfil.Size = new System.Drawing.Size(166, 45);
            this.btnEditarPerfil.TabIndex = 10;
            this.btnEditarPerfil.Text = "Editar Perfil";
            this.btnEditarPerfil.UseVisualStyleBackColor = true;
            this.btnEditarPerfil.Click += new System.EventHandler(this.btnEditarPerfil_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Depth = 0;
            this.btnCerrarSesion.Location = new System.Drawing.Point(92, 384);
            this.btnCerrarSesion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Primary = true;
            this.btnCerrarSesion.Size = new System.Drawing.Size(166, 47);
            this.btnCerrarSesion.TabIndex = 11;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(92, 448);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(166, 48);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // MenuEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 546);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnEditarPerfil);
            this.Controls.Add(this.btnPantRevisarCotizaciones);
            this.Controls.Add(this.btnPantAdminProductos);
            this.Controls.Add(this.btnPantAdminCliente);
            this.Name = "MenuEmpleado";
            this.Text = "MenúEmpleado";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnPantAdminCliente;
        private MaterialSkin.Controls.MaterialRaisedButton btnPantAdminProductos;
        private MaterialSkin.Controls.MaterialRaisedButton btnPantRevisarCotizaciones;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditarPerfil;
        private MaterialSkin.Controls.MaterialRaisedButton btnCerrarSesion;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
    }
}