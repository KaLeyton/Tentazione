namespace CapaGUI
{
    partial class PantallaProductosCliente
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
            this.lblProductos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConfirmarCotizacion = new System.Windows.Forms.Button();
            this.btnGenerarCotizacion = new System.Windows.Forms.Button();
            this.btnListarProductos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(257, 9);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(281, 73);
            this.lblProductos.TabIndex = 0;
            this.lblProductos.Text = "Productos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(475, 284);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnConfirmarCotizacion
            // 
            this.btnConfirmarCotizacion.Location = new System.Drawing.Point(420, 422);
            this.btnConfirmarCotizacion.Name = "btnConfirmarCotizacion";
            this.btnConfirmarCotizacion.Size = new System.Drawing.Size(88, 44);
            this.btnConfirmarCotizacion.TabIndex = 2;
            this.btnConfirmarCotizacion.Text = "Confirmar Cotizacion";
            this.btnConfirmarCotizacion.UseVisualStyleBackColor = true;
            // 
            // btnGenerarCotizacion
            // 
            this.btnGenerarCotizacion.Location = new System.Drawing.Point(658, 333);
            this.btnGenerarCotizacion.Name = "btnGenerarCotizacion";
            this.btnGenerarCotizacion.Size = new System.Drawing.Size(88, 44);
            this.btnGenerarCotizacion.TabIndex = 3;
            this.btnGenerarCotizacion.Text = "Generar Cotizacion";
            this.btnGenerarCotizacion.UseVisualStyleBackColor = true;
            // 
            // btnListarProductos
            // 
            this.btnListarProductos.Location = new System.Drawing.Point(33, 422);
            this.btnListarProductos.Name = "btnListarProductos";
            this.btnListarProductos.Size = new System.Drawing.Size(88, 44);
            this.btnListarProductos.TabIndex = 4;
            this.btnListarProductos.Text = "Listar";
            this.btnListarProductos.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(699, 482);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 44);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(584, 150);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(100, 22);
            this.txtBuscarProducto.TabIndex = 6;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(712, 148);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProducto.TabIndex = 7;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // PantallaProductosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 551);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnListarProductos);
            this.Controls.Add(this.btnGenerarCotizacion);
            this.Controls.Add(this.btnConfirmarCotizacion);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblProductos);
            this.Name = "PantallaProductosCliente";
            this.Text = "PantallaProductosCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConfirmarCotizacion;
        private System.Windows.Forms.Button btnGenerarCotizacion;
        private System.Windows.Forms.Button btnListarProductos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
    }
}