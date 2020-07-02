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
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblSku = new System.Windows.Forms.Label();
            this.lblValorProducto = new System.Windows.Forms.Label();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.cbxUnidadMedida = new System.Windows.Forms.ComboBox();
            this.lblCantidadUnidad = new System.Windows.Forms.Label();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.btnListarProducto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEditarProducto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEliminarProducto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevoProducto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscarProducto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCerrarSesion = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtNombreProucto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSku = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCantPaquete = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtValor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombreProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(22, 94);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.RowHeadersWidth = 51;
            this.dataGridViewProductos.RowTemplate.Height = 24;
            this.dataGridViewProductos.Size = new System.Drawing.Size(472, 325);
            this.dataGridViewProductos.TabIndex = 1;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.Location = new System.Drawing.Point(547, 205);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(169, 24);
            this.lblNombreProducto.TabIndex = 6;
            this.lblNombreProducto.Text = "Nombre Producto :";
            // 
            // lblSku
            // 
            this.lblSku.AutoSize = true;
            this.lblSku.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSku.Location = new System.Drawing.Point(667, 167);
            this.lblSku.Name = "lblSku";
            this.lblSku.Size = new System.Drawing.Size(49, 24);
            this.lblSku.TabIndex = 7;
            this.lblSku.Text = "Sku :";
            // 
            // lblValorProducto
            // 
            this.lblValorProducto.AutoSize = true;
            this.lblValorProducto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorProducto.Location = new System.Drawing.Point(653, 243);
            this.lblValorProducto.Name = "lblValorProducto";
            this.lblValorProducto.Size = new System.Drawing.Size(63, 24);
            this.lblValorProducto.TabIndex = 8;
            this.lblValorProducto.Text = "Valor :";
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadMedida.Location = new System.Drawing.Point(541, 319);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(175, 24);
            this.lblUnidadMedida.TabIndex = 9;
            this.lblUnidadMedida.Text = "Unidad de medida :";
            // 
            // cbxUnidadMedida
            // 
            this.cbxUnidadMedida.FormattingEnabled = true;
            this.cbxUnidadMedida.Items.AddRange(new object[] {
            "Unidad",
            "Gramos ",
            "Mililitros"});
            this.cbxUnidadMedida.Location = new System.Drawing.Point(734, 319);
            this.cbxUnidadMedida.Name = "cbxUnidadMedida";
            this.cbxUnidadMedida.Size = new System.Drawing.Size(154, 24);
            this.cbxUnidadMedida.TabIndex = 12;
            // 
            // lblCantidadUnidad
            // 
            this.lblCantidadUnidad.AutoSize = true;
            this.lblCantidadUnidad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadUnidad.Location = new System.Drawing.Point(521, 281);
            this.lblCantidadUnidad.Name = "lblCantidadUnidad";
            this.lblCantidadUnidad.Size = new System.Drawing.Size(195, 24);
            this.lblCantidadUnidad.TabIndex = 15;
            this.lblCantidadUnidad.Text = "Cantidad por Unidad :";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = null;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(0, 48);
            this.materialTabSelector1.TabIndex = 0;
            // 
            // btnListarProducto
            // 
            this.btnListarProducto.Depth = 0;
            this.btnListarProducto.Location = new System.Drawing.Point(23, 494);
            this.btnListarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnListarProducto.Name = "btnListarProducto";
            this.btnListarProducto.Primary = true;
            this.btnListarProducto.Size = new System.Drawing.Size(105, 42);
            this.btnListarProducto.TabIndex = 22;
            this.btnListarProducto.Text = "Listar";
            this.btnListarProducto.UseVisualStyleBackColor = true;
            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.Depth = 0;
            this.btnEditarProducto.Location = new System.Drawing.Point(206, 494);
            this.btnEditarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Primary = true;
            this.btnEditarProducto.Size = new System.Drawing.Size(105, 42);
            this.btnEditarProducto.TabIndex = 23;
            this.btnEditarProducto.Text = "Editar";
            this.btnEditarProducto.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Depth = 0;
            this.btnEliminarProducto.Location = new System.Drawing.Point(389, 494);
            this.btnEliminarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Primary = true;
            this.btnEliminarProducto.Size = new System.Drawing.Size(105, 42);
            this.btnEliminarProducto.TabIndex = 24;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Depth = 0;
            this.btnNuevoProducto.Location = new System.Drawing.Point(524, 370);
            this.btnNuevoProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Primary = true;
            this.btnNuevoProducto.Size = new System.Drawing.Size(109, 49);
            this.btnNuevoProducto.TabIndex = 25;
            this.btnNuevoProducto.Text = "Nuevo Producto";
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Location = new System.Drawing.Point(654, 370);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(117, 49);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Location = new System.Drawing.Point(792, 370);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.Size = new System.Drawing.Size(111, 46);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(781, 484);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(94, 39);
            this.btnSalir.TabIndex = 28;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Depth = 0;
            this.btnBuscarProducto.Location = new System.Drawing.Point(734, 98);
            this.btnBuscarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Primary = true;
            this.btnBuscarProducto.Size = new System.Drawing.Size(93, 43);
            this.btnBuscarProducto.TabIndex = 29;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.AutoSize = true;
            this.btnCerrarSesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCerrarSesion.Depth = 0;
            this.btnCerrarSesion.Location = new System.Drawing.Point(730, 27);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCerrarSesion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Primary = false;
            this.btnCerrarSesion.Size = new System.Drawing.Size(141, 36);
            this.btnCerrarSesion.TabIndex = 30;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // txtNombreProucto
            // 
            this.txtNombreProucto.Depth = 0;
            this.txtNombreProucto.Hint = "";
            this.txtNombreProucto.Location = new System.Drawing.Point(537, 113);
            this.txtNombreProucto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreProucto.Name = "txtNombreProucto";
            this.txtNombreProucto.PasswordChar = '\0';
            this.txtNombreProucto.SelectedText = "";
            this.txtNombreProucto.SelectionLength = 0;
            this.txtNombreProucto.SelectionStart = 0;
            this.txtNombreProucto.Size = new System.Drawing.Size(179, 28);
            this.txtNombreProucto.TabIndex = 31;
            this.txtNombreProucto.Text = "Nombre Producto";
            this.txtNombreProucto.UseSystemPasswordChar = false;
            this.txtNombreProucto.Click += new System.EventHandler(this.txtNombreProucto_Click);
            // 
            // txtSku
            // 
            this.txtSku.Depth = 0;
            this.txtSku.Hint = "";
            this.txtSku.Location = new System.Drawing.Point(734, 163);
            this.txtSku.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSku.Name = "txtSku";
            this.txtSku.PasswordChar = '\0';
            this.txtSku.SelectedText = "";
            this.txtSku.SelectionLength = 0;
            this.txtSku.SelectionStart = 0;
            this.txtSku.Size = new System.Drawing.Size(154, 28);
            this.txtSku.TabIndex = 32;
            this.txtSku.Text = "00000";
            this.txtSku.UseSystemPasswordChar = false;
            this.txtSku.Click += new System.EventHandler(this.txtSku_Click);
            // 
            // txtCantPaquete
            // 
            this.txtCantPaquete.Depth = 0;
            this.txtCantPaquete.Hint = "";
            this.txtCantPaquete.Location = new System.Drawing.Point(734, 278);
            this.txtCantPaquete.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCantPaquete.Name = "txtCantPaquete";
            this.txtCantPaquete.PasswordChar = '\0';
            this.txtCantPaquete.SelectedText = "";
            this.txtCantPaquete.SelectionLength = 0;
            this.txtCantPaquete.SelectionStart = 0;
            this.txtCantPaquete.Size = new System.Drawing.Size(154, 28);
            this.txtCantPaquete.TabIndex = 34;
            this.txtCantPaquete.UseSystemPasswordChar = false;
            this.txtCantPaquete.Click += new System.EventHandler(this.txtCantPaquete_Click);
            // 
            // txtValor
            // 
            this.txtValor.Depth = 0;
            this.txtValor.Hint = "";
            this.txtValor.Location = new System.Drawing.Point(734, 239);
            this.txtValor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtValor.Name = "txtValor";
            this.txtValor.PasswordChar = '\0';
            this.txtValor.SelectedText = "";
            this.txtValor.SelectionLength = 0;
            this.txtValor.SelectionStart = 0;
            this.txtValor.Size = new System.Drawing.Size(154, 28);
            this.txtValor.TabIndex = 35;
            this.txtValor.Text = "000.000";
            this.txtValor.UseSystemPasswordChar = false;
            this.txtValor.Click += new System.EventHandler(this.txtValor_Click);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Depth = 0;
            this.txtNombreProducto.Hint = "";
            this.txtNombreProducto.Location = new System.Drawing.Point(734, 201);
            this.txtNombreProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.PasswordChar = '\0';
            this.txtNombreProducto.SelectedText = "";
            this.txtNombreProducto.SelectionLength = 0;
            this.txtNombreProducto.SelectionStart = 0;
            this.txtNombreProducto.Size = new System.Drawing.Size(154, 28);
            this.txtNombreProducto.TabIndex = 36;
            this.txtNombreProducto.Text = "Nombre";
            this.txtNombreProducto.UseSystemPasswordChar = false;
            this.txtNombreProducto.Click += new System.EventHandler(this.txtNombreProducto_Click);
            // 
            // PantallaAdministrarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 577);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtCantPaquete);
            this.Controls.Add(this.txtSku);
            this.Controls.Add(this.txtNombreProucto);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevoProducto);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnEditarProducto);
            this.Controls.Add(this.btnListarProducto);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.lblCantidadUnidad);
            this.Controls.Add(this.cbxUnidadMedida);
            this.Controls.Add(this.lblUnidadMedida);
            this.Controls.Add(this.lblValorProducto);
            this.Controls.Add(this.lblSku);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.dataGridViewProductos);
            this.Name = "PantallaAdministrarProductos";
            this.Text = "Administrar Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label lblSku;
        private System.Windows.Forms.Label lblValorProducto;
        private System.Windows.Forms.Label lblUnidadMedida;
        private System.Windows.Forms.ComboBox cbxUnidadMedida;
        private System.Windows.Forms.Label lblCantidadUnidad;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialRaisedButton btnListarProducto;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditarProducto;
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminarProducto;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevoProducto;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardar;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarProducto;
        private MaterialSkin.Controls.MaterialFlatButton btnCerrarSesion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreProucto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSku;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCantPaquete;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtValor;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreProducto;
    }
}