namespace CapaGUI
{
    partial class Login
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnLogin = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnVerProductos = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCrearUsuario = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtNombreUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtContrasena = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(58, 37);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(0, 37);
            this.lblLogin.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Depth = 0;
            this.btnLogin.Location = new System.Drawing.Point(47, 205);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Primary = false;
            this.btnLogin.Size = new System.Drawing.Size(64, 36);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // btnVerProductos
            // 
            this.btnVerProductos.AutoSize = true;
            this.btnVerProductos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerProductos.Depth = 0;
            this.btnVerProductos.Location = new System.Drawing.Point(47, 244);
            this.btnVerProductos.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnVerProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerProductos.Name = "btnVerProductos";
            this.btnVerProductos.Primary = false;
            this.btnVerProductos.Size = new System.Drawing.Size(120, 36);
            this.btnVerProductos.TabIndex = 13;
            this.btnVerProductos.Text = "Ver Productos";
            this.btnVerProductos.UseVisualStyleBackColor = true;
            this.btnVerProductos.Click += new System.EventHandler(this.btnVerProductos_Click_1);
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.AutoSize = true;
            this.btnCrearUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCrearUsuario.Depth = 0;
            this.btnCrearUsuario.Location = new System.Drawing.Point(47, 283);
            this.btnCrearUsuario.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCrearUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Primary = false;
            this.btnCrearUsuario.Size = new System.Drawing.Size(116, 36);
            this.btnCrearUsuario.TabIndex = 14;
            this.btnCrearUsuario.Text = "Crear Usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(47, 322);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = false;
            this.btnSalir.Size = new System.Drawing.Size(49, 36);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Depth = 0;
            this.txtNombreUsuario.Hint = "";
            this.txtNombreUsuario.Location = new System.Drawing.Point(20, 103);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.PasswordChar = '\0';
            this.txtNombreUsuario.SelectedText = "";
            this.txtNombreUsuario.SelectionLength = 0;
            this.txtNombreUsuario.SelectionStart = 0;
            this.txtNombreUsuario.Size = new System.Drawing.Size(169, 23);
            this.txtNombreUsuario.TabIndex = 16;
            this.txtNombreUsuario.Text = "Nombre Usuario";
            this.txtNombreUsuario.UseSystemPasswordChar = false;
            this.txtNombreUsuario.Click += new System.EventHandler(this.txtNombreUsuario_Click);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Depth = 0;
            this.txtContrasena.Hint = "";
            this.txtContrasena.Location = new System.Drawing.Point(20, 152);
            this.txtContrasena.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContrasena.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '\0';
            this.txtContrasena.SelectedText = "";
            this.txtContrasena.SelectionLength = 0;
            this.txtContrasena.SelectionStart = 0;
            this.txtContrasena.Size = new System.Drawing.Size(169, 23);
            this.txtContrasena.TabIndex = 17;
            this.txtContrasena.Text = "Contraseña";
            this.txtContrasena.UseSystemPasswordChar = true;
            this.txtContrasena.Click += new System.EventHandler(this.txtContrasena_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 381);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCrearUsuario);
            this.Controls.Add(this.btnVerProductos);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblLogin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private MaterialSkin.Controls.MaterialFlatButton btnLogin;
        private MaterialSkin.Controls.MaterialFlatButton btnVerProductos;
        private MaterialSkin.Controls.MaterialFlatButton btnCrearUsuario;
        private MaterialSkin.Controls.MaterialFlatButton btnSalir;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContrasena;
    }
}