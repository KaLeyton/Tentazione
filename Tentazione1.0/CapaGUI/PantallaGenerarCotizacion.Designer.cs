namespace CapaGUI
{
    partial class PantallaGenerarCotizacion
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGenerarCotizacion = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnConfirmarCotizacion = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnListarProductos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscarProducto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCerrarSesion = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtBuscarProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(496, 328);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnGenerarCotizacion
            // 
            this.btnGenerarCotizacion.Depth = 0;
            this.btnGenerarCotizacion.Location = new System.Drawing.Point(552, 274);
            this.btnGenerarCotizacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerarCotizacion.Name = "btnGenerarCotizacion";
            this.btnGenerarCotizacion.Primary = true;
            this.btnGenerarCotizacion.Size = new System.Drawing.Size(117, 47);
            this.btnGenerarCotizacion.TabIndex = 10;
            this.btnGenerarCotizacion.Text = "Generar Cotización";
            this.btnGenerarCotizacion.UseVisualStyleBackColor = true;
            this.btnGenerarCotizacion.Click += new System.EventHandler(this.btnGenerarCotizacion_Click);
            // 
            // btnConfirmarCotizacion
            // 
            this.btnConfirmarCotizacion.Depth = 0;
            this.btnConfirmarCotizacion.Location = new System.Drawing.Point(552, 221);
            this.btnConfirmarCotizacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfirmarCotizacion.Name = "btnConfirmarCotizacion";
            this.btnConfirmarCotizacion.Primary = true;
            this.btnConfirmarCotizacion.Size = new System.Drawing.Size(117, 47);
            this.btnConfirmarCotizacion.TabIndex = 11;
            this.btnConfirmarCotizacion.Text = "Confirmar Productos";
            this.btnConfirmarCotizacion.UseVisualStyleBackColor = true;
            this.btnConfirmarCotizacion.Click += new System.EventHandler(this.btnConfirmarCotizacion_Click);
            // 
            // btnListarProductos
            // 
            this.btnListarProductos.Depth = 0;
            this.btnListarProductos.Location = new System.Drawing.Point(33, 522);
            this.btnListarProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnListarProductos.Name = "btnListarProductos";
            this.btnListarProductos.Primary = true;
            this.btnListarProductos.Size = new System.Drawing.Size(117, 47);
            this.btnListarProductos.TabIndex = 12;
            this.btnListarProductos.Text = "Listar";
            this.btnListarProductos.UseVisualStyleBackColor = true;
            this.btnListarProductos.Click += new System.EventHandler(this.btnListarProductos_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Location = new System.Drawing.Point(552, 441);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.Size = new System.Drawing.Size(117, 47);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(552, 522);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(117, 47);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Depth = 0;
            this.btnBuscarProducto.Location = new System.Drawing.Point(552, 99);
            this.btnBuscarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Primary = true;
            this.btnBuscarProducto.Size = new System.Drawing.Size(117, 47);
            this.btnBuscarProducto.TabIndex = 15;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCerrarSesion.Depth = 0;
            this.btnCerrarSesion.Location = new System.Drawing.Point(521, 30);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCerrarSesion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Primary = false;
            this.btnCerrarSesion.Size = new System.Drawing.Size(148, 27);
            this.btnCerrarSesion.TabIndex = 16;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Depth = 0;
            this.txtBuscarProducto.Hint = "";
            this.txtBuscarProducto.Location = new System.Drawing.Point(356, 118);
            this.txtBuscarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.PasswordChar = '\0';
            this.txtBuscarProducto.SelectedText = "";
            this.txtBuscarProducto.SelectionLength = 0;
            this.txtBuscarProducto.SelectionStart = 0;
            this.txtBuscarProducto.Size = new System.Drawing.Size(173, 28);
            this.txtBuscarProducto.TabIndex = 17;
            this.txtBuscarProducto.Text = "Nombre Producto";
            this.txtBuscarProducto.UseSystemPasswordChar = false;
            this.txtBuscarProducto.Click += new System.EventHandler(this.txtBuscarProducto_Click);
            // 
            // PantallaGenerarCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 617);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnListarProductos);
            this.Controls.Add(this.btnConfirmarCotizacion);
            this.Controls.Add(this.btnGenerarCotizacion);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PantallaGenerarCotizacion";
            this.Text = "Generar Cotización";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialRaisedButton btnGenerarCotizacion;
        private MaterialSkin.Controls.MaterialRaisedButton btnConfirmarCotizacion;
        private MaterialSkin.Controls.MaterialRaisedButton btnListarProductos;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarProducto;
        private MaterialSkin.Controls.MaterialFlatButton btnCerrarSesion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarProducto;
    }
}