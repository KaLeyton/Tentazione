namespace CapaGUI
{
    partial class PantallaListarProductos
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
            this.dataGridViewListaProductos = new System.Windows.Forms.DataGridView();
            this.btnListar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnLogIn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscarProducto = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscarProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListaProductos
            // 
            this.dataGridViewListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaProductos.Location = new System.Drawing.Point(50, 110);
            this.dataGridViewListaProductos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewListaProductos.Name = "dataGridViewListaProductos";
            this.dataGridViewListaProductos.RowHeadersWidth = 51;
            this.dataGridViewListaProductos.RowTemplate.Height = 24;
            this.dataGridViewListaProductos.Size = new System.Drawing.Size(390, 176);
            this.dataGridViewListaProductos.TabIndex = 0;
            // 
            // btnListar
            // 
            this.btnListar.Depth = 0;
            this.btnListar.Location = new System.Drawing.Point(10, 249);
            this.btnListar.Margin = new System.Windows.Forms.Padding(2);
            this.btnListar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnListar.Name = "btnListar";
            this.btnListar.Primary = true;
            this.btnListar.Size = new System.Drawing.Size(44, 26);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Depth = 0;
            this.btnLogIn.Location = new System.Drawing.Point(205, 306);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Primary = true;
            this.btnLogIn.Size = new System.Drawing.Size(81, 32);
            this.btnLogIn.TabIndex = 8;
            this.btnLogIn.Text = "LogIn";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(359, 306);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(81, 32);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Depth = 0;
            this.btnBuscarProducto.Location = new System.Drawing.Point(375, 72);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Primary = true;
            this.btnBuscarProducto.Size = new System.Drawing.Size(65, 26);
            this.btnBuscarProducto.TabIndex = 10;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Depth = 0;
            this.txtBuscarProducto.Hint = "";
            this.txtBuscarProducto.Location = new System.Drawing.Point(241, 76);
            this.txtBuscarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.PasswordChar = '\0';
            this.txtBuscarProducto.SelectedText = "";
            this.txtBuscarProducto.SelectionLength = 0;
            this.txtBuscarProducto.SelectionStart = 0;
            this.txtBuscarProducto.Size = new System.Drawing.Size(130, 23);
            this.txtBuscarProducto.TabIndex = 11;
            this.txtBuscarProducto.Text = "Nombre Producto";
            this.txtBuscarProducto.UseSystemPasswordChar = false;
            this.txtBuscarProducto.Click += new System.EventHandler(this.txtBuscarProducto_Click);
            // 
            // PantallaListarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 368);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dataGridViewListaProductos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PantallaListarProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.PantallaListarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListaProductos;
        private MaterialSkin.Controls.MaterialRaisedButton btnListar;
        private MaterialSkin.Controls.MaterialRaisedButton btnLogIn;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarProducto;
    }
}