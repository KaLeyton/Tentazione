namespace CapaGUI
{
    partial class PantallaAdministrarProductos
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
            this.lblProductoAdmin = new System.Windows.Forms.Label();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.btnListarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnEditarProducto = new System.Windows.Forms.Button();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblSku = new System.Windows.Forms.Label();
            this.lblValorProducto = new System.Windows.Forms.Label();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.txtSku = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cbxUnidadMedida = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblCantidadUnidad = new System.Windows.Forms.Label();
            this.txtCantPaquete = new System.Windows.Forms.TextBox();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductoAdmin
            // 
            this.lblProductoAdmin.AutoSize = true;
            this.lblProductoAdmin.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoAdmin.Location = new System.Drawing.Point(10, 26);
            this.lblProductoAdmin.Name = "lblProductoAdmin";
            this.lblProductoAdmin.Size = new System.Drawing.Size(589, 73);
            this.lblProductoAdmin.TabIndex = 0;
            this.lblProductoAdmin.Text = "Administrar Productos";
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(23, 131);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.RowHeadersWidth = 51;
            this.dataGridViewProductos.RowTemplate.Height = 24;
            this.dataGridViewProductos.Size = new System.Drawing.Size(392, 279);
            this.dataGridViewProductos.TabIndex = 1;
            // 
            // btnListarProducto
            // 
            this.btnListarProducto.Location = new System.Drawing.Point(28, 438);
            this.btnListarProducto.Name = "btnListarProducto";
            this.btnListarProducto.Size = new System.Drawing.Size(91, 48);
            this.btnListarProducto.TabIndex = 2;
            this.btnListarProducto.Text = "Listar";
            this.btnListarProducto.UseVisualStyleBackColor = true;
            this.btnListarProducto.Click += new System.EventHandler(this.btnListarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(292, 438);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(91, 48);
            this.btnEliminarProducto.TabIndex = 3;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.Location = new System.Drawing.Point(156, 438);
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Size = new System.Drawing.Size(91, 48);
            this.btnEditarProducto.TabIndex = 4;
            this.btnEditarProducto.Text = "Editar";
            this.btnEditarProducto.UseVisualStyleBackColor = true;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(602, 226);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(119, 22);
            this.txtNombreProducto.TabIndex = 5;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(469, 228);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(127, 17);
            this.lblNombreProducto.TabIndex = 6;
            this.lblNombreProducto.Text = "Nombre Producto :";
            // 
            // lblSku
            // 
            this.lblSku.AutoSize = true;
            this.lblSku.Location = new System.Drawing.Point(556, 199);
            this.lblSku.Name = "lblSku";
            this.lblSku.Size = new System.Drawing.Size(40, 17);
            this.lblSku.TabIndex = 7;
            this.lblSku.Text = "Sku :";
            // 
            // lblValorProducto
            // 
            this.lblValorProducto.AutoSize = true;
            this.lblValorProducto.Location = new System.Drawing.Point(547, 257);
            this.lblValorProducto.Name = "lblValorProducto";
            this.lblValorProducto.Size = new System.Drawing.Size(49, 17);
            this.lblValorProducto.TabIndex = 8;
            this.lblValorProducto.Text = "Valor :";
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Location = new System.Drawing.Point(465, 315);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(131, 17);
            this.lblUnidadMedida.TabIndex = 9;
            this.lblUnidadMedida.Text = "Unidad de medida :";
            // 
            // txtSku
            // 
            this.txtSku.Location = new System.Drawing.Point(602, 198);
            this.txtSku.Name = "txtSku";
            this.txtSku.Size = new System.Drawing.Size(119, 22);
            this.txtSku.TabIndex = 10;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(602, 254);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(119, 22);
            this.txtValor.TabIndex = 11;
            // 
            // cbxUnidadMedida
            // 
            this.cbxUnidadMedida.FormattingEnabled = true;
            this.cbxUnidadMedida.Items.AddRange(new object[] {
            "Unidad",
            "Gramos ",
            "Mililitros"});
            this.cbxUnidadMedida.Location = new System.Drawing.Point(602, 310);
            this.cbxUnidadMedida.Name = "cbxUnidadMedida";
            this.cbxUnidadMedida.Size = new System.Drawing.Size(119, 24);
            this.cbxUnidadMedida.TabIndex = 12;
            this.cbxUnidadMedida.SelectedIndexChanged += new System.EventHandler(this.cbxUnidadMedida_SelectedIndexChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(630, 349);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 48);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(632, 438);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(91, 48);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblCantidadUnidad
            // 
            this.lblCantidadUnidad.AutoSize = true;
            this.lblCantidadUnidad.Location = new System.Drawing.Point(450, 286);
            this.lblCantidadUnidad.Name = "lblCantidadUnidad";
            this.lblCantidadUnidad.Size = new System.Drawing.Size(146, 17);
            this.lblCantidadUnidad.TabIndex = 15;
            this.lblCantidadUnidad.Text = "Cantidad por Unidad :";
            // 
            // txtCantPaquete
            // 
            this.txtCantPaquete.Location = new System.Drawing.Point(602, 282);
            this.txtCantPaquete.Name = "txtCantPaquete";
            this.txtCantPaquete.Size = new System.Drawing.Size(119, 22);
            this.txtCantPaquete.TabIndex = 16;
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Location = new System.Drawing.Point(453, 349);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(91, 48);
            this.btnNuevoProducto.TabIndex = 17;
            this.btnNuevoProducto.Text = "Nuevo Producto";
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(468, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 22);
            this.textBox1.TabIndex = 18;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(602, 163);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProducto.TabIndex = 19;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(618, 67);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(103, 23);
            this.btnCerrarSesion.TabIndex = 20;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(453, 438);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 47);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // PantallaAdministrarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 510);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnNuevoProducto);
            this.Controls.Add(this.txtCantPaquete);
            this.Controls.Add(this.lblCantidadUnidad);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbxUnidadMedida);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtSku);
            this.Controls.Add(this.lblUnidadMedida);
            this.Controls.Add(this.lblValorProducto);
            this.Controls.Add(this.lblSku);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.btnEditarProducto);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnListarProducto);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.lblProductoAdmin);
            this.Name = "PantallaAdministrarProductos";
            this.Text = "PantallaMantenedorProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductoAdmin;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.Button btnListarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnEditarProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblSku;
        private System.Windows.Forms.Label lblValorProducto;
        private System.Windows.Forms.Label lblUnidadMedida;
        private System.Windows.Forms.TextBox txtSku;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ComboBox cbxUnidadMedida;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblCantidadUnidad;
        private System.Windows.Forms.TextBox txtCantPaquete;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnCancelar;
    }
}