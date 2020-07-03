namespace CapaGUI
{
    partial class PantallaAdministradorClientes
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
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.btnListarClientes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEditarCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEliminarCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevoCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnGuardarCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscarCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCerrarSesion = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtIdCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombrecompleto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEdad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSexo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(28, 86);
            this.dataGridViewClientes.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.RowHeadersWidth = 51;
            this.dataGridViewClientes.RowTemplate.Height = 24;
            this.dataGridViewClientes.Size = new System.Drawing.Size(580, 234);
            this.dataGridViewClientes.TabIndex = 1;
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCompleto.Location = new System.Drawing.Point(642, 127);
            this.lblNombreCompleto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(137, 24);
            this.lblNombreCompleto.TabIndex = 4;
            this.lblNombreCompleto.Text = "Nombre Completo :";
            // 
            // lblEdad
            // 
            this.lblEdad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(728, 156);
            this.lblEdad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(52, 24);
            this.lblEdad.TabIndex = 5;
            this.lblEdad.Text = "Edad :";
            // 
            // lblTelefono
            // 
            this.lblTelefono.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(710, 185);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(69, 24);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Teléfono :";
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(727, 214);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 24);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email :";
            // 
            // lblSexo
            // 
            this.lblSexo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(729, 244);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(50, 24);
            this.lblSexo.TabIndex = 8;
            this.lblSexo.Text = "Sexo :";
            // 
            // btnListarClientes
            // 
            this.btnListarClientes.Depth = 0;
            this.btnListarClientes.Location = new System.Drawing.Point(28, 349);
            this.btnListarClientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnListarClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnListarClientes.Name = "btnListarClientes";
            this.btnListarClientes.Primary = true;
            this.btnListarClientes.Size = new System.Drawing.Size(93, 35);
            this.btnListarClientes.TabIndex = 24;
            this.btnListarClientes.Text = "Listar";
            this.btnListarClientes.UseVisualStyleBackColor = true;
            this.btnListarClientes.Click += new System.EventHandler(this.btnListarClientes_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Depth = 0;
            this.btnEditarCliente.Location = new System.Drawing.Point(271, 349);
            this.btnEditarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Primary = true;
            this.btnEditarCliente.Size = new System.Drawing.Size(93, 35);
            this.btnEditarCliente.TabIndex = 25;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Depth = 0;
            this.btnEliminarCliente.Location = new System.Drawing.Point(514, 349);
            this.btnEliminarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Primary = true;
            this.btnEliminarCliente.Size = new System.Drawing.Size(93, 35);
            this.btnEliminarCliente.TabIndex = 26;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Depth = 0;
            this.btnNuevoCliente.Location = new System.Drawing.Point(634, 285);
            this.btnNuevoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevoCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Primary = true;
            this.btnNuevoCliente.Size = new System.Drawing.Size(105, 35);
            this.btnNuevoCliente.TabIndex = 27;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Location = new System.Drawing.Point(873, 285);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.Size = new System.Drawing.Size(77, 35);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.Depth = 0;
            this.btnGuardarCliente.Location = new System.Drawing.Point(765, 285);
            this.btnGuardarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Primary = true;
            this.btnGuardarCliente.Size = new System.Drawing.Size(77, 35);
            this.btnGuardarCliente.TabIndex = 29;
            this.btnGuardarCliente.Text = "Guardar";
            this.btnGuardarCliente.UseVisualStyleBackColor = true;
            this.btnGuardarCliente.Click += new System.EventHandler(this.btnGuardarCliente_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(873, 349);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(77, 35);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Depth = 0;
            this.btnBuscarCliente.Location = new System.Drawing.Point(800, 86);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Primary = true;
            this.btnBuscarCliente.Size = new System.Drawing.Size(92, 24);
            this.btnBuscarCliente.TabIndex = 31;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCerrarSesion.Depth = 0;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(836, 29);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCerrarSesion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Primary = false;
            this.btnCerrarSesion.Size = new System.Drawing.Size(114, 27);
            this.btnCerrarSesion.TabIndex = 32;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Depth = 0;
            this.txtIdCliente.Hint = "";
            this.txtIdCliente.Location = new System.Drawing.Point(634, 88);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.PasswordChar = '\0';
            this.txtIdCliente.SelectedText = "";
            this.txtIdCliente.SelectionLength = 0;
            this.txtIdCliente.SelectionStart = 0;
            this.txtIdCliente.Size = new System.Drawing.Size(146, 23);
            this.txtIdCliente.TabIndex = 33;
            this.txtIdCliente.Text = "Id Cliente";
            this.txtIdCliente.UseSystemPasswordChar = false;
            this.txtIdCliente.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // txtNombrecompleto
            // 
            this.txtNombrecompleto.Depth = 0;
            this.txtNombrecompleto.ForeColor = System.Drawing.Color.Gray;
            this.txtNombrecompleto.Hint = "";
            this.txtNombrecompleto.Location = new System.Drawing.Point(800, 127);
            this.txtNombrecompleto.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombrecompleto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombrecompleto.Name = "txtNombrecompleto";
            this.txtNombrecompleto.PasswordChar = '\0';
            this.txtNombrecompleto.SelectedText = "";
            this.txtNombrecompleto.SelectionLength = 0;
            this.txtNombrecompleto.SelectionStart = 0;
            this.txtNombrecompleto.Size = new System.Drawing.Size(150, 23);
            this.txtNombrecompleto.TabIndex = 34;
            this.txtNombrecompleto.Text = "Nombre Apellido";
            this.txtNombrecompleto.UseSystemPasswordChar = false;
            this.txtNombrecompleto.Click += new System.EventHandler(this.txtNombrecompleto_Click);
            // 
            // txtEdad
            // 
            this.txtEdad.Depth = 0;
            this.txtEdad.Hint = "";
            this.txtEdad.Location = new System.Drawing.Point(800, 157);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(2);
            this.txtEdad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.PasswordChar = '\0';
            this.txtEdad.SelectedText = "";
            this.txtEdad.SelectionLength = 0;
            this.txtEdad.SelectionStart = 0;
            this.txtEdad.Size = new System.Drawing.Size(150, 23);
            this.txtEdad.TabIndex = 35;
            this.txtEdad.Text = "00";
            this.txtEdad.UseSystemPasswordChar = false;
            this.txtEdad.Click += new System.EventHandler(this.txtEdad_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Hint = "";
            this.txtTelefono.Location = new System.Drawing.Point(800, 186);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.Size = new System.Drawing.Size(150, 23);
            this.txtTelefono.TabIndex = 36;
            this.txtTelefono.Text = "987654321";
            this.txtTelefono.UseSystemPasswordChar = false;
            this.txtTelefono.Click += new System.EventHandler(this.txtTelefono_Click);
            // 
            // txtSexo
            // 
            this.txtSexo.Depth = 0;
            this.txtSexo.Hint = "";
            this.txtSexo.Location = new System.Drawing.Point(800, 244);
            this.txtSexo.Margin = new System.Windows.Forms.Padding(2);
            this.txtSexo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.PasswordChar = '\0';
            this.txtSexo.SelectedText = "";
            this.txtSexo.SelectionLength = 0;
            this.txtSexo.SelectionStart = 0;
            this.txtSexo.Size = new System.Drawing.Size(150, 23);
            this.txtSexo.TabIndex = 37;
            this.txtSexo.Text = "fem - masc";
            this.txtSexo.UseSystemPasswordChar = false;
            this.txtSexo.Click += new System.EventHandler(this.txtSexo_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "";
            this.txtEmail.Location = new System.Drawing.Point(800, 215);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(150, 23);
            this.txtEmail.TabIndex = 38;
            this.txtEmail.Text = "ejemplo@uwu.xd";
            this.txtEmail.UseSystemPasswordChar = false;
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // PantallaAdministradorClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 423);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombrecompleto);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardarCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.btnListarClientes);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNombreCompleto);
            this.Controls.Add(this.dataGridViewClientes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PantallaAdministradorClientes";
            this.Text = "Administrar Clientes";
            this.Load += new System.EventHandler(this.PantallaAdministradorClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSexo;
        private MaterialSkin.Controls.MaterialRaisedButton btnListarClientes;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditarCliente;
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminarCliente;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevoCliente;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardarCliente;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarCliente;
        private MaterialSkin.Controls.MaterialFlatButton btnCerrarSesion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombrecompleto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEdad;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSexo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
    }
}