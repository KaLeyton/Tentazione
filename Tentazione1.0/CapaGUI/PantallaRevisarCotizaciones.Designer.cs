namespace CapaGUI
{
    partial class PantallaRevisarCotizaciones
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
            this.dataGridViewListaCotizaciones = new System.Windows.Forms.DataGridView();
            this.btnCerrarSesion = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnBuscarCotizacionId = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtIdCotizacion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnListar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaCotizaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListaCotizaciones
            // 
            this.dataGridViewListaCotizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaCotizaciones.Location = new System.Drawing.Point(38, 143);
            this.dataGridViewListaCotizaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewListaCotizaciones.Name = "dataGridViewListaCotizaciones";
            this.dataGridViewListaCotizaciones.RowHeadersWidth = 51;
            this.dataGridViewListaCotizaciones.RowTemplate.Height = 24;
            this.dataGridViewListaCotizaciones.Size = new System.Drawing.Size(470, 267);
            this.dataGridViewListaCotizaciones.TabIndex = 7;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.AutoSize = true;
            this.btnCerrarSesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCerrarSesion.Depth = 0;
            this.btnCerrarSesion.Location = new System.Drawing.Point(367, 29);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCerrarSesion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Primary = false;
            this.btnCerrarSesion.Size = new System.Drawing.Size(141, 36);
            this.btnCerrarSesion.TabIndex = 14;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnBuscarCotizacionId
            // 
            this.btnBuscarCotizacionId.Depth = 0;
            this.btnBuscarCotizacionId.Location = new System.Drawing.Point(291, 106);
            this.btnBuscarCotizacionId.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarCotizacionId.Name = "btnBuscarCotizacionId";
            this.btnBuscarCotizacionId.Primary = true;
            this.btnBuscarCotizacionId.Size = new System.Drawing.Size(93, 32);
            this.btnBuscarCotizacionId.TabIndex = 15;
            this.btnBuscarCotizacionId.Text = "Buscar";
            this.btnBuscarCotizacionId.UseVisualStyleBackColor = true;
            // 
            // txtIdCotizacion
            // 
            this.txtIdCotizacion.Depth = 0;
            this.txtIdCotizacion.Hint = "";
            this.txtIdCotizacion.Location = new System.Drawing.Point(115, 110);
            this.txtIdCotizacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdCotizacion.Name = "txtIdCotizacion";
            this.txtIdCotizacion.PasswordChar = '\0';
            this.txtIdCotizacion.SelectedText = "";
            this.txtIdCotizacion.SelectionLength = 0;
            this.txtIdCotizacion.SelectionStart = 0;
            this.txtIdCotizacion.Size = new System.Drawing.Size(159, 28);
            this.txtIdCotizacion.TabIndex = 16;
            this.txtIdCotizacion.Text = "Id Cotización";
            this.txtIdCotizacion.UseSystemPasswordChar = false;
            this.txtIdCotizacion.Click += new System.EventHandler(this.txtIdCotizacion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(402, 431);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(115, 38);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnListar
            // 
            this.btnListar.Depth = 0;
            this.btnListar.Location = new System.Drawing.Point(38, 431);
            this.btnListar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnListar.Name = "btnListar";
            this.btnListar.Primary = true;
            this.btnListar.Size = new System.Drawing.Size(115, 38);
            this.btnListar.TabIndex = 18;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Location = new System.Drawing.Point(220, 431);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.Size = new System.Drawing.Size(115, 38);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // PantallaRevisarCotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 516);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtIdCotizacion);
            this.Controls.Add(this.btnBuscarCotizacionId);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.dataGridViewListaCotizaciones);
            this.Name = "PantallaRevisarCotizaciones";
            this.Text = "Revisar Cotizaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaCotizaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewListaCotizaciones;
        private MaterialSkin.Controls.MaterialFlatButton btnCerrarSesion;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarCotizacionId;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdCotizacion;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnListar;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
    }
}