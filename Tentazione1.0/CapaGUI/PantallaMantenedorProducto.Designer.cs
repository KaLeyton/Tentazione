namespace CapaGUI
{
    partial class PantallaMantenedorProducto
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblCantidadUnidad = new System.Windows.Forms.Label();
            this.txtCantPaquete = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductoAdmin
            // 
            this.lblProductoAdmin.AutoSize = true;
            this.lblProductoAdmin.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoAdmin.Location = new System.Drawing.Point(39, 26);
            this.lblProductoAdmin.Name = "lblProductoAdmin";
            this.lblProductoAdmin.Size = new System.Drawing.Size(589, 73);
            this.lblProductoAdmin.TabIndex = 0;
            this.lblProductoAdmin.Text = "Administrar Productos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(339, 189);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnListarProducto
            // 
            this.btnListarProducto.Location = new System.Drawing.Point(45, 372);
            this.btnListarProducto.Name = "btnListarProducto";
            this.btnListarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnListarProducto.TabIndex = 2;
            this.btnListarProducto.Text = "Listar";
            this.btnListarProducto.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(234, 372);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarProducto.TabIndex = 3;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.Location = new System.Drawing.Point(393, 298);
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnEditarProducto.TabIndex = 4;
            this.btnEditarProducto.Text = "Editar";
            this.btnEditarProducto.UseVisualStyleBackColor = true;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(527, 173);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(119, 22);
            this.txtNombreProducto.TabIndex = 5;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(394, 175);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(127, 17);
            this.lblNombreProducto.TabIndex = 6;
            this.lblNombreProducto.Text = "Nombre Producto :";
            // 
            // lblSku
            // 
            this.lblSku.AutoSize = true;
            this.lblSku.Location = new System.Drawing.Point(481, 146);
            this.lblSku.Name = "lblSku";
            this.lblSku.Size = new System.Drawing.Size(40, 17);
            this.lblSku.TabIndex = 7;
            this.lblSku.Text = "Sku :";
            // 
            // lblValorProducto
            // 
            this.lblValorProducto.AutoSize = true;
            this.lblValorProducto.Location = new System.Drawing.Point(472, 204);
            this.lblValorProducto.Name = "lblValorProducto";
            this.lblValorProducto.Size = new System.Drawing.Size(49, 17);
            this.lblValorProducto.TabIndex = 8;
            this.lblValorProducto.Text = "Valor :";
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Location = new System.Drawing.Point(390, 262);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(131, 17);
            this.lblUnidadMedida.TabIndex = 9;
            this.lblUnidadMedida.Text = "Unidad de medida :";
            // 
            // txtSku
            // 
            this.txtSku.Location = new System.Drawing.Point(527, 145);
            this.txtSku.Name = "txtSku";
            this.txtSku.Size = new System.Drawing.Size(119, 22);
            this.txtSku.TabIndex = 10;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(527, 201);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(119, 22);
            this.txtValor.TabIndex = 11;
            // 
            // cbxUnidadMedida
            // 
            this.cbxUnidadMedida.FormattingEnabled = true;
            this.cbxUnidadMedida.Location = new System.Drawing.Point(527, 257);
            this.cbxUnidadMedida.Name = "cbxUnidadMedida";
            this.cbxUnidadMedida.Size = new System.Drawing.Size(119, 24);
            this.cbxUnidadMedida.TabIndex = 12;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(571, 297);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(571, 371);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblCantidadUnidad
            // 
            this.lblCantidadUnidad.AutoSize = true;
            this.lblCantidadUnidad.Location = new System.Drawing.Point(375, 233);
            this.lblCantidadUnidad.Name = "lblCantidadUnidad";
            this.lblCantidadUnidad.Size = new System.Drawing.Size(146, 17);
            this.lblCantidadUnidad.TabIndex = 15;
            this.lblCantidadUnidad.Text = "Cantidad por Unidad :";
            // 
            // txtCantPaquete
            // 
            this.txtCantPaquete.Location = new System.Drawing.Point(527, 229);
            this.txtCantPaquete.Name = "txtCantPaquete";
            this.txtCantPaquete.Size = new System.Drawing.Size(119, 22);
            this.txtCantPaquete.TabIndex = 16;
            // 
            // PantallaMantenedorProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 419);
            this.Controls.Add(this.txtCantPaquete);
            this.Controls.Add(this.lblCantidadUnidad);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblProductoAdmin);
            this.Name = "PantallaMantenedorProducto";
            this.Text = "PantallaMantenedorProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductoAdmin;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblCantidadUnidad;
        private System.Windows.Forms.TextBox txtCantPaquete;
    }
}