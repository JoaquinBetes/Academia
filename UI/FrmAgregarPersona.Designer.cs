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
            Direccion = new Label();
            Nombre = new Label();
            Apellido = new Label();
            Email = new Label();
            FechaNacimiento = new Label();
            BtnAgregar = new Button();
            BtnCancelar = new Button();
            DtpFechaNacimiento = new DateTimePicker();
            DNI = new Label();
            Telefono = new Label();
            TxtDNI = new TextBox();
            TxtTelefono = new TextBox();
            SuspendLayout();
            // 
            // TxtNombre
            // 
            TxtNombre.BackColor = SystemColors.ActiveCaptionText;
            TxtNombre.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNombre.ForeColor = Color.Black;
            TxtNombre.Location = new Point(145, 29);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(575, 32);
            TxtNombre.TabIndex = 0;
            // 
            // TxtApellido
            // 
            TxtApellido.BackColor = SystemColors.ActiveCaptionText;
            TxtApellido.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxtApellido.ForeColor = Color.Black;
            TxtApellido.Location = new Point(145, 84);
            TxtApellido.Name = "TxtApellido";
            TxtApellido.Size = new Size(575, 32);
            TxtApellido.TabIndex = 1;
            // 
            // TxtDireccion
            // 
            TxtDireccion.BackColor = SystemColors.ActiveCaptionText;
            TxtDireccion.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDireccion.ForeColor = Color.Black;
            TxtDireccion.Location = new Point(145, 139);
            TxtDireccion.Name = "TxtDireccion";
            TxtDireccion.Size = new Size(575, 32);
            TxtDireccion.TabIndex = 2;
            // 
            // TxtEmail
            // 
            TxtEmail.BackColor = SystemColors.ActiveCaptionText;
            TxtEmail.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxtEmail.ForeColor = Color.Black;
            TxtEmail.Location = new Point(145, 197);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(575, 32);
            TxtEmail.TabIndex = 3;
            // 
            // Direccion
            // 
            Direccion.AutoSize = true;
            Direccion.BackColor = Color.Black;
            Direccion.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            Direccion.ForeColor = SystemColors.ControlLight;
            Direccion.Location = new Point(32, 142);
            Direccion.Name = "Direccion";
            Direccion.Size = new Size(96, 25);
            Direccion.TabIndex = 5;
            Direccion.Text = "Dirección";
            Direccion.Click += label1_Click;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.BackColor = Color.Black;
            Nombre.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            Nombre.ForeColor = SystemColors.ControlLight;
            Nombre.Location = new Point(32, 32);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(86, 25);
            Nombre.TabIndex = 6;
            Nombre.Text = "Nombre";
            // 
            // Apellido
            // 
            Apellido.AutoSize = true;
            Apellido.BackColor = Color.Black;
            Apellido.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            Apellido.ForeColor = SystemColors.ControlLight;
            Apellido.Location = new Point(32, 84);
            Apellido.Name = "Apellido";
            Apellido.Size = new Size(86, 25);
            Apellido.TabIndex = 7;
            Apellido.Text = "Apellido";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.BackColor = Color.Black;
            Email.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            Email.ForeColor = SystemColors.ControlLight;
            Email.Location = new Point(32, 200);
            Email.Name = "Email";
            Email.Size = new Size(59, 25);
            Email.TabIndex = 8;
            Email.Text = "Email";
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.AutoSize = true;
            FechaNacimiento.BackColor = Color.Black;
            FechaNacimiento.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            FechaNacimiento.ForeColor = SystemColors.ControlLight;
            FechaNacimiento.Location = new Point(32, 263);
            FechaNacimiento.Name = "FechaNacimiento";
            FechaNacimiento.Size = new Size(196, 25);
            FechaNacimiento.TabIndex = 9;
            FechaNacimiento.Text = "Fecha de Nacimiento";
            FechaNacimiento.Click += Clave_Click;
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.Black;
            BtnAgregar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAgregar.ForeColor = Color.WhiteSmoke;
            BtnAgregar.Location = new Point(145, 464);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(184, 57);
            BtnAgregar.TabIndex = 10;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = false;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.Black;
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
            // DNI
            // 
            DNI.AutoSize = true;
            DNI.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            DNI.ForeColor = SystemColors.ControlLight;
            DNI.Location = new Point(37, 319);
            DNI.Name = "DNI";
            DNI.Size = new Size(47, 25);
            DNI.TabIndex = 13;
            DNI.Text = "DNI";
            DNI.Click += label1_Click_1;
            // 
            // Telefono
            // 
            Telefono.AutoSize = true;
            Telefono.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            Telefono.ForeColor = SystemColors.ControlLight;
            Telefono.Location = new Point(32, 378);
            Telefono.Name = "Telefono";
            Telefono.Size = new Size(89, 25);
            Telefono.TabIndex = 14;
            Telefono.Text = "Teléfono";
            // 
            // TxtDNI
            // 
            TxtDNI.BackColor = Color.Black;
            TxtDNI.ForeColor = SystemColors.ControlLight;
            TxtDNI.Location = new Point(145, 319);
            TxtDNI.MaxLength = 15;
            TxtDNI.Name = "TxtDNI";
            TxtDNI.Size = new Size(575, 29);
            TxtDNI.TabIndex = 15;
            // 
            // TxtTelefono
            // 
            TxtTelefono.BackColor = Color.Black;
            TxtTelefono.ForeColor = SystemColors.ControlLight;
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
            Controls.Add(Telefono);
            Controls.Add(DNI);
            Controls.Add(DtpFechaNacimiento);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAgregar);
            Controls.Add(FechaNacimiento);
            Controls.Add(Email);
            Controls.Add(Apellido);
            Controls.Add(Nombre);
            Controls.Add(Direccion);
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
        private Label Direccion;
        private Label Nombre;
        private Label Apellido;
        private Label Email;
        private Label FechaNacimiento;
        private Button BtnAgregar;
        private Button BtnCancelar;
        private DateTimePicker DtpFechaNacimiento;
        private Label DNI;
        private Label Telefono;
        private TextBox TxtDNI;
        private TextBox TxtTelefono;
    }

}