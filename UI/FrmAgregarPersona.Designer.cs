namespace UI
{
    partial class FrmAgregarPersona
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
            TxtNombre = new TextBox();
            TxtApellido = new TextBox();
            TxtDireccion = new TextBox();
            TxtEmail = new TextBox();
            LblDireccion = new Label();
            LblNombre = new Label();
            LblApellido = new Label();
            LblEmail = new Label();
            LblFechaNacimiento = new Label();
            BtnAgregar = new Button();
            BtnCancelar = new Button();
            DtpFechaNacimiento = new DateTimePicker();
            LblDNI = new Label();
            LblTelefono = new Label();
            TxtDNI = new TextBox();
            TxtTelefono = new TextBox();
            SuspendLayout();
            // 
            // TxtNombre
            // 
            TxtNombre.BackColor = SystemColors.ActiveCaptionText;
            TxtNombre.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNombre.ForeColor = Color.WhiteSmoke;
            TxtNombre.Location = new Point(145, 29);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(575, 32);
            TxtNombre.TabIndex = 0;
            // 
            // TxtApellido
            // 
            TxtApellido.BackColor = SystemColors.ActiveCaptionText;
            TxtApellido.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxtApellido.ForeColor = Color.WhiteSmoke;
            TxtApellido.Location = new Point(145, 84);
            TxtApellido.Name = "TxtApellido";
            TxtApellido.Size = new Size(575, 32);
            TxtApellido.TabIndex = 1;
            // 
            // TxtDireccion
            // 
            TxtDireccion.BackColor = SystemColors.ActiveCaptionText;
            TxtDireccion.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDireccion.ForeColor = Color.WhiteSmoke;
            TxtDireccion.Location = new Point(145, 139);
            TxtDireccion.Name = "TxtDireccion";
            TxtDireccion.Size = new Size(575, 32);
            TxtDireccion.TabIndex = 2;
            // 
            // TxtEmail
            // 
            TxtEmail.BackColor = SystemColors.ActiveCaptionText;
            TxtEmail.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxtEmail.ForeColor = Color.WhiteSmoke;
            TxtEmail.Location = new Point(145, 197);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(575, 32);
            TxtEmail.TabIndex = 3;
            // 
            // LblDireccion
            // 
            LblDireccion.AutoSize = true;
            LblDireccion.BackColor = Color.Black;
            LblDireccion.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            LblDireccion.ForeColor = SystemColors.ControlLight;
            LblDireccion.Location = new Point(32, 142);
            LblDireccion.Name = "LblDireccion";
            LblDireccion.Size = new Size(96, 25);
            LblDireccion.TabIndex = 5;
            LblDireccion.Text = "Dirección";
            LblDireccion.Click += label1_Click;
            // 
            // LblNombre
            // 
            LblNombre.AutoSize = true;
            LblNombre.BackColor = Color.Black;
            LblNombre.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            LblNombre.ForeColor = SystemColors.ControlLight;
            LblNombre.Location = new Point(32, 32);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(86, 25);
            LblNombre.TabIndex = 6;
            LblNombre.Text = "Nombre";
            // 
            // LblApellido
            // 
            LblApellido.AutoSize = true;
            LblApellido.BackColor = Color.Black;
            LblApellido.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            LblApellido.ForeColor = SystemColors.ControlLight;
            LblApellido.Location = new Point(32, 84);
            LblApellido.Name = "LblApellido";
            LblApellido.Size = new Size(86, 25);
            LblApellido.TabIndex = 7;
            LblApellido.Text = "Apellido";
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.BackColor = Color.Black;
            LblEmail.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            LblEmail.ForeColor = SystemColors.ControlLight;
            LblEmail.Location = new Point(32, 200);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(59, 25);
            LblEmail.TabIndex = 8;
            LblEmail.Text = "Email";
            // 
            // LblFechaNacimiento
            // 
            LblFechaNacimiento.AutoSize = true;
            LblFechaNacimiento.BackColor = Color.Black;
            LblFechaNacimiento.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            LblFechaNacimiento.ForeColor = SystemColors.ControlLight;
            LblFechaNacimiento.Location = new Point(32, 263);
            LblFechaNacimiento.Name = "LblFechaNacimiento";
            LblFechaNacimiento.Size = new Size(196, 25);
            LblFechaNacimiento.TabIndex = 9;
            LblFechaNacimiento.Text = "Fecha de Nacimiento";
            LblFechaNacimiento.Click += Clave_Click;
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.Black;
            BtnAgregar.Cursor = Cursors.Hand;
            BtnAgregar.FlatAppearance.BorderColor = Color.WhiteSmoke;
            BtnAgregar.FlatAppearance.BorderSize = 2;
            BtnAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 44, 44);
            BtnAgregar.FlatStyle = FlatStyle.Flat;
            BtnAgregar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAgregar.ForeColor = Color.WhiteSmoke;
            BtnAgregar.Location = new Point(145, 464);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(184, 57);
            BtnAgregar.TabIndex = 10;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.Black;
            BtnCancelar.Cursor = Cursors.Hand;
            BtnCancelar.FlatAppearance.BorderColor = Color.WhiteSmoke;
            BtnCancelar.FlatAppearance.BorderSize = 2;
            BtnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 44, 44);
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCancelar.ForeColor = Color.WhiteSmoke;
            BtnCancelar.Location = new Point(536, 464);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(184, 57);
            BtnCancelar.TabIndex = 11;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // DtpFechaNacimiento
            // 
            DtpFechaNacimiento.CalendarFont = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            DtpFechaNacimiento.CalendarForeColor = Color.Transparent;
            DtpFechaNacimiento.CalendarMonthBackground = Color.Black;
            DtpFechaNacimiento.CalendarTitleForeColor = Color.Gainsboro;
            DtpFechaNacimiento.CalendarTrailingForeColor = SystemColors.ControlLightLight;
            DtpFechaNacimiento.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            DtpFechaNacimiento.Location = new Point(239, 257);
            DtpFechaNacimiento.Name = "DtpFechaNacimiento";
            DtpFechaNacimiento.Size = new Size(481, 32);
            DtpFechaNacimiento.TabIndex = 12;
            // 
            // LblDNI
            // 
            LblDNI.AutoSize = true;
            LblDNI.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            LblDNI.ForeColor = SystemColors.ControlLight;
            LblDNI.Location = new Point(37, 319);
            LblDNI.Name = "LblDNI";
            LblDNI.Size = new Size(47, 25);
            LblDNI.TabIndex = 13;
            LblDNI.Text = "DNI";
            LblDNI.Click += label1_Click_1;
            // 
            // LblTelefono
            // 
            LblTelefono.AutoSize = true;
            LblTelefono.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            LblTelefono.ForeColor = SystemColors.ControlLight;
            LblTelefono.Location = new Point(32, 378);
            LblTelefono.Name = "LblTelefono";
            LblTelefono.Size = new Size(89, 25);
            LblTelefono.TabIndex = 14;
            LblTelefono.Text = "Teléfono";
            // 
            // TxtDNI
            // 
            TxtDNI.BackColor = Color.Black;
            TxtDNI.ForeColor = Color.WhiteSmoke;
            TxtDNI.Location = new Point(145, 319);
            TxtDNI.MaxLength = 15;
            TxtDNI.Name = "TxtDNI";
            TxtDNI.Size = new Size(575, 29);
            TxtDNI.TabIndex = 15;
            // 
            // TxtTelefono
            // 
            TxtTelefono.BackColor = Color.Black;
            TxtTelefono.ForeColor = Color.WhiteSmoke;
            TxtTelefono.Location = new Point(145, 378);
            TxtTelefono.Name = "TxtTelefono";
            TxtTelefono.Size = new Size(575, 29);
            TxtTelefono.TabIndex = 16;
            // 
            // FrmAgregarPersona
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 551);
            Controls.Add(TxtTelefono);
            Controls.Add(TxtDNI);
            Controls.Add(LblTelefono);
            Controls.Add(LblDNI);
            Controls.Add(DtpFechaNacimiento);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAgregar);
            Controls.Add(LblFechaNacimiento);
            Controls.Add(LblEmail);
            Controls.Add(LblApellido);
            Controls.Add(LblNombre);
            Controls.Add(LblDireccion);
            Controls.Add(TxtEmail);
            Controls.Add(TxtDireccion);
            Controls.Add(TxtApellido);
            Controls.Add(TxtNombre);
            Name = "FrmAgregarPersona";
            Text = "Agregar Persona";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtNombre;
        private TextBox TxtApellido;
        private TextBox TxtDireccion;
        private TextBox TxtEmail;
        private Label LblDireccion;
        private Label LblNombre;
        private Label LblApellido;
        private Label LblEmail;
        private Label LblFechaNacimiento;
        private Button BtnAgregar;
        private Button BtnCancelar;
        private DateTimePicker DtpFechaNacimiento;
        private Label LblDNI;
        private Label LblTelefono;
        private TextBox TxtDNI;
        private TextBox TxtTelefono;
    }

}