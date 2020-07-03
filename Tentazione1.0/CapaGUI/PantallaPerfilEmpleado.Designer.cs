namespace CapaGUI
{
    partial class PantallaPerfilEmpleado
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
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.btnEditar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCerrarSesion = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtNombreCompleto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEdad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSexo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtIdEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(98, 146);
            this.lblEdad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(49, 19);
            this.lblEdad.TabIndex = 34;
            this.lblEdad.Text = "Edad :";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(100, 244);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(47, 19);
            this.lblSexo.TabIndex = 23;
            this.lblSexo.Text = "Sexo :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(94, 211);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 19);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "Email :";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(75, 179);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(73, 19);
            this.lblTelefono.TabIndex = 21;
            this.lblTelefono.Text = "Telefono :";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(13, 114);
            this.lblNombreCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(134, 19);
            this.lblNombreCliente.TabIndex = 20;
            this.lblNombreCliente.Text = "Nombre Completo :";
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCliente.Location = new System.Drawing.Point(69, 81);
            this.lblIdCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(79, 19);
            this.lblIdCliente.TabIndex = 19;
            this.lblIdCliente.Text = "Id Cliente :";
            // 
            // btnEditar
            // 
            this.btnEditar.Depth = 0;
            this.btnEditar.Location = new System.Drawing.Point(78, 276);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Primary = true;
            this.btnEditar.Size = new System.Drawing.Size(82, 34);
            this.btnEditar.TabIndex = 36;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Location = new System.Drawing.Point(190, 276);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(82, 34);
            this.btnGuardar.TabIndex = 37;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Location = new System.Drawing.Point(190, 321);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.Size = new System.Drawing.Size(82, 34);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(78, 321);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(82, 34);
            this.btnSalir.TabIndex = 39;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.AutoSize = true;
            this.btnCerrarSesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCerrarSesion.Depth = 0;
            this.btnCerrarSesion.Location = new System.Drawing.Point(190, 22);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCerrarSesion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Primary = false;
            this.btnCerrarSesion.Size = new System.Drawing.Size(114, 36);
            this.btnCerrarSesion.TabIndex = 40;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Depth = 0;
            this.txtNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCompleto.Hint = "";
            this.txtNombreCompleto.Location = new System.Drawing.Point(148, 110);
            this.txtNombreCompleto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreCompleto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.PasswordChar = '\0';
            this.txtNombreCompleto.SelectedText = "";
            this.txtNombreCompleto.SelectionLength = 0;
            this.txtNombreCompleto.SelectionStart = 0;
            this.txtNombreCompleto.Size = new System.Drawing.Size(147, 23);
            this.txtNombreCompleto.TabIndex = 41;
            this.txtNombreCompleto.Text = "Nombre Apellido";
            this.txtNombreCompleto.UseSystemPasswordChar = false;
            this.txtNombreCompleto.Click += new System.EventHandler(this.txtNombreCompleto_Click);
            // 
            // txtEdad
            // 
            this.txtEdad.Depth = 0;
            this.txtEdad.Hint = "";
            this.txtEdad.Location = new System.Drawing.Point(148, 145);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEdad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.PasswordChar = '\0';
            this.txtEdad.SelectedText = "";
            this.txtEdad.SelectionLength = 0;
            this.txtEdad.SelectionStart = 0;
            this.txtEdad.Size = new System.Drawing.Size(147, 23);
            this.txtEdad.TabIndex = 42;
            this.txtEdad.Text = "00";
            this.txtEdad.UseSystemPasswordChar = false;
            this.txtEdad.Click += new System.EventHandler(this.txtEdad_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Hint = "";
            this.txtTelefono.Location = new System.Drawing.Point(148, 176);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.Size = new System.Drawing.Size(147, 23);
            this.txtTelefono.TabIndex = 43;
            this.txtTelefono.Text = "987654321";
            this.txtTelefono.UseSystemPasswordChar = false;
            this.txtTelefono.Click += new System.EventHandler(this.txtTelefono_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "";
            this.txtEmail.Location = new System.Drawing.Point(148, 208);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(147, 23);
            this.txtEmail.TabIndex = 44;
            this.txtEmail.Text = "ejemplo@uwu.xd";
            this.txtEmail.UseSystemPasswordChar = false;
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // txtSexo
            // 
            this.txtSexo.Depth = 0;
            this.txtSexo.Hint = "";
            this.txtSexo.Location = new System.Drawing.Point(148, 240);
            this.txtSexo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSexo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.PasswordChar = '\0';
            this.txtSexo.SelectedText = "";
            this.txtSexo.SelectionLength = 0;
            this.txtSexo.SelectionStart = 0;
            this.txtSexo.Size = new System.Drawing.Size(147, 23);
            this.txtSexo.TabIndex = 45;
            this.txtSexo.Text = "fem - masc";
            this.txtSexo.UseSystemPasswordChar = false;
            this.txtSexo.Click += new System.EventHandler(this.txtSexo_Click);
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Depth = 0;
            this.txtIdEmpleado.Hint = "";
            this.txtIdEmpleado.Location = new System.Drawing.Point(148, 78);
            this.txtIdEmpleado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.PasswordChar = '\0';
            this.txtIdEmpleado.SelectedText = "";
            this.txtIdEmpleado.SelectionLength = 0;
            this.txtIdEmpleado.SelectionStart = 0;
            this.txtIdEmpleado.Size = new System.Drawing.Size(147, 23);
            this.txtIdEmpleado.TabIndex = 46;
            this.txtIdEmpleado.UseSystemPasswordChar = false;
            // 
            // PantallaPerfilEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 379);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.lblIdCliente);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PantallaPerfilEmpleado";
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.PantallaPerfilEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblIdCliente;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditar;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardar;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialFlatButton btnCerrarSesion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreCompleto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEdad;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSexo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdEmpleado;
    }
}