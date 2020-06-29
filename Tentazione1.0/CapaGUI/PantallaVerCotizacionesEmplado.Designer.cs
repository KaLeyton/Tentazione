namespace CapaGUI
{
    partial class PantallaVerCotizacionesEmplado
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
            this.lblVerCotizaciones = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnListarCotizaciones = new System.Windows.Forms.Button();
            this.btnRespoderCotizacion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(118, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(347, 241);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblVerCotizaciones
            // 
            this.lblVerCotizaciones.AutoSize = true;
            this.lblVerCotizaciones.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerCotizaciones.Location = new System.Drawing.Point(114, 21);
            this.lblVerCotizaciones.Name = "lblVerCotizaciones";
            this.lblVerCotizaciones.Size = new System.Drawing.Size(351, 59);
            this.lblVerCotizaciones.TabIndex = 1;
            this.lblVerCotizaciones.Text = "Ver Cotizaciones";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(522, 21);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(76, 44);
            this.btnCerrarSesion.TabIndex = 2;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnListarCotizaciones
            // 
            this.btnListarCotizaciones.Location = new System.Drawing.Point(66, 387);
            this.btnListarCotizaciones.Name = "btnListarCotizaciones";
            this.btnListarCotizaciones.Size = new System.Drawing.Size(75, 23);
            this.btnListarCotizaciones.TabIndex = 3;
            this.btnListarCotizaciones.Text = "Listar";
            this.btnListarCotizaciones.UseVisualStyleBackColor = true;
            // 
            // btnRespoderCotizacion
            // 
            this.btnRespoderCotizacion.Location = new System.Drawing.Point(245, 387);
            this.btnRespoderCotizacion.Name = "btnRespoderCotizacion";
            this.btnRespoderCotizacion.Size = new System.Drawing.Size(100, 23);
            this.btnRespoderCotizacion.TabIndex = 4;
            this.btnRespoderCotizacion.Text = "Responder";
            this.btnRespoderCotizacion.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(469, 387);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormVerCotizacionesEmplado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 469);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRespoderCotizacion);
            this.Controls.Add(this.btnListarCotizaciones);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.lblVerCotizaciones);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormVerCotizacionesEmplado";
            this.Text = "FormVerCotizacionesEmplado";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblVerCotizaciones;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnListarCotizaciones;
        private System.Windows.Forms.Button btnRespoderCotizacion;
        private System.Windows.Forms.Button btnSalir;
    }
}