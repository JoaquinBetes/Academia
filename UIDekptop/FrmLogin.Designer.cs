namespace UIDesktop
{
    partial class FrmLogin
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
            LblNombreUsuario = new Label();
            TxtNombreUsuario = new TextBox();
            TxtContraseña = new TextBox();
            LblContraseña = new Label();
            LblTitulo = new Label();
            BtnLogin = new Button();
            SuspendLayout();
            // 
            // LblNombreUsuario
            // 
            LblNombreUsuario.AutoSize = true;
            LblNombreUsuario.Font = new Font("Segoe UI", 15F, FontStyle.Underline, GraphicsUnit.Point);
            LblNombreUsuario.Location = new Point(29, 116);
            LblNombreUsuario.Name = "LblNombreUsuario";
            LblNombreUsuario.Size = new Size(181, 28);
            LblNombreUsuario.TabIndex = 0;
            LblNombreUsuario.Text = "Nombre de usuario";
            // 
            // TxtNombreUsuario
            // 
            TxtNombreUsuario.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNombreUsuario.Location = new Point(248, 119);
            TxtNombreUsuario.MaxLength = 30;
            TxtNombreUsuario.Name = "TxtNombreUsuario";
            TxtNombreUsuario.Size = new Size(339, 34);
            TxtNombreUsuario.TabIndex = 1;
            // 
            // TxtContraseña
            // 
            TxtContraseña.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            TxtContraseña.Location = new Point(248, 225);
            TxtContraseña.MaxLength = 30;
            TxtContraseña.Name = "TxtContraseña";
            TxtContraseña.PasswordChar = '*';
            TxtContraseña.Size = new Size(339, 34);
            TxtContraseña.TabIndex = 3;
            // 
            // LblContraseña
            // 
            LblContraseña.AutoSize = true;
            LblContraseña.Font = new Font("Segoe UI", 15F, FontStyle.Underline, GraphicsUnit.Point);
            LblContraseña.Location = new Point(57, 222);
            LblContraseña.Name = "LblContraseña";
            LblContraseña.Size = new Size(110, 28);
            LblContraseña.TabIndex = 2;
            LblContraseña.Text = "Contraseña";
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LblTitulo.Location = new Point(205, 30);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(208, 41);
            LblTitulo.TabIndex = 4;
            LblTitulo.Text = "Iniciar Sesión";
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.LightSteelBlue;
            BtnLogin.Cursor = Cursors.Hand;
            BtnLogin.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnLogin.Location = new Point(175, 336);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(286, 60);
            BtnLogin.TabIndex = 5;
            BtnLogin.Text = "Aceptar";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += btnLogin_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 452);
            Controls.Add(BtnLogin);
            Controls.Add(LblTitulo);
            Controls.Add(TxtContraseña);
            Controls.Add(LblContraseña);
            Controls.Add(TxtNombreUsuario);
            Controls.Add(LblNombreUsuario);
            Name = "FrmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblNombreUsuario;
        private TextBox TxtNombreUsuario;
        private TextBox TxtContraseña;
        private Label LblContraseña;
        private Label LblTitulo;
        private Button BtnLogin;
    }
}