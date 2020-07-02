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
            this.txtIdCotizacion = new System.Windows.Forms.TextBox();
            this.btnBuscarCotizacionId = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblCotizaciones = new System.Windows.Forms.Label();
            this.dataGridViewListaCotizaciones = new System.Windows.Forms.DataGridView();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaCotizaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdCotizacion
            // 
            this.txtIdCotizacion.Location = new System.Drawing.Point(142, 153);
            this.txtIdCotizacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdCotizacion.Name = "txtIdCotizacion";
            this.txtIdCotizacion.Size = new System.Drawing.Size(100, 22);
            this.txtIdCotizacion.TabIndex = 13;
            // 
            // btnBuscarCotizacionId
            // 
            this.btnBuscarCotizacionId.Location = new System.Drawing.Point(260, 148);
            this.btnBuscarCotizacionId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarCotizacionId.Name = "btnBuscarCotizacionId";
            this.btnBuscarCotizacionId.Size = new System.Drawing.Size(83, 33);
            this.btnBuscarCotizacionId.TabIndex = 12;
            this.btnBuscarCotizacionId.Text = "Buscar";
            this.btnBuscarCotizacionId.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(429, 438);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(79, 39);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(29, 440);
            this.btnListar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(79, 39);
            this.btnListar.TabIndex = 10;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // lblCotizaciones
            // 
            this.lblCotizaciones.AutoSize = true;
            this.lblCotizaciones.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCotizaciones.Location = new System.Drawing.Point(12, 9);
            this.lblCotizaciones.Name = "lblCotizaciones";
            this.lblCotizaciones.Size = new System.Drawing.Size(456, 97);
            this.lblCotizaciones.TabIndex = 8;
            this.lblCotizaciones.Text = "Cotizaciones";
            // 
            // dataGridViewListaCotizaciones
            // 
            this.dataGridViewListaCotizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaCotizaciones.Location = new System.Drawing.Point(77, 198);
            this.dataGridViewListaCotizaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewListaCotizaciones.Name = "dataGridViewListaCotizaciones";
            this.dataGridViewListaCotizaciones.RowHeadersWidth = 51;
            this.dataGridViewListaCotizaciones.RowTemplate.Height = 24;
            this.dataGridViewListaCotizaciones.Size = new System.Drawing.Size(391, 217);
            this.dataGridViewListaCotizaciones.TabIndex = 7;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(457, 41);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(79, 46);
            this.btnCerrarSesion.TabIndex = 9;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // PantallaRevisarCotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 516);
            this.Controls.Add(this.txtIdCotizacion);
            this.Controls.Add(this.btnBuscarCotizacionId);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.lblCotizaciones);
            this.Controls.Add(this.dataGridViewListaCotizaciones);
            this.Name = "PantallaRevisarCotizaciones";
            this.Text = "PantallaRevisarCotizaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaCotizaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdCotizacion;
        private System.Windows.Forms.Button btnBuscarCotizacionId;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblCotizaciones;
        private System.Windows.Forms.DataGridView dataGridViewListaCotizaciones;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}