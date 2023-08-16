namespace UI
{
    partial class FrmVerPersona
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
            LblTelefono = new Label();
            LblDNI = new Label();
            BtnEliminar = new Button();
            BtnEditarPersona = new Button();
            LblFechaNacimiento = new Label();
            LblEmail = new Label();
            LblApellido = new Label();
            LblNombre = new Label();
            LblDireccion = new Label();
            TxtDireccionData = new TextBox();
            TxtApellidoData = new TextBox();
            TxtNombreData = new TextBox();
            TxtEmailData = new TextBox();
            TxtTelefonoData = new TextBox();
            TxtDNIData = new TextBox();
            DtpFechaNacimiento = new DateTimePicker();
            SuspendLayout();
            // 
            // LblTelefono
            // 
            LblTelefono.AutoSize = true;
            LblTelefono.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            LblTelefono.ForeColor = SystemColors.ControlLight;
            LblTelefono.Location = new Point(68, 405);
            LblTelefono.Name = "LblTelefono";
            LblTelefono.Size = new Size(94, 25);
            LblTelefono.TabIndex = 30;
            LblTelefono.Text = "Teléfono:";
            // 
            // LblDNI
            // 
            LblDNI.AutoSize = true;
            LblDNI.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            LblDNI.ForeColor = SystemColors.ControlLight;
            LblDNI.Location = new Point(73, 346);
            LblDNI.Name = "LblDNI";
            LblDNI.Size = new Size(52, 25);
            LblDNI.TabIndex = 29;
            LblDNI.Text = "DNI:";
            // 
            // BtnEliminar
            // 
            BtnEliminar.BackColor = Color.Black;
            BtnEliminar.Cursor = Cursors.Hand;
            BtnEliminar.FlatAppearance.BorderColor = Color.Crimson;
            BtnEliminar.FlatAppearance.BorderSize = 2;
            BtnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 44, 44);
            BtnEliminar.FlatStyle = FlatStyle.Flat;
            BtnEliminar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnEliminar.ForeColor = Color.Crimson;
            BtnEliminar.Location = new Point(572, 491);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(184, 57);
            BtnEliminar.TabIndex = 27;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = false;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnEditarPersona
            // 
            BtnEditarPersona.BackColor = Color.Black;
            BtnEditarPersona.Cursor = Cursors.Hand;
            BtnEditarPersona.FlatAppearance.BorderColor = Color.WhiteSmoke;
            BtnEditarPersona.FlatAppearance.BorderSize = 2;
            BtnEditarPersona.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 44, 44);
            BtnEditarPersona.FlatStyle = FlatStyle.Flat;
            BtnEditarPersona.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnEditarPersona.ForeColor = Color.WhiteSmoke;
            BtnEditarPersona.Location = new Point(181, 491);
            BtnEditarPersona.Name = "BtnEditarPersona";
            BtnEditarPersona.Size = new Size(184, 57);
            BtnEditarPersona.TabIndex = 26;
            BtnEditarPersona.Text = "Aceptar";
            BtnEditarPersona.UseVisualStyleBackColor = false;
            BtnEditarPersona.Click += BtnEditarPersona_Click;
            // 
            // LblFechaNacimiento
            // 
            LblFechaNacimiento.AutoSize = true;
            LblFechaNacimiento.BackColor = Color.Black;
            LblFechaNacimiento.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            LblFechaNacimiento.ForeColor = SystemColors.ControlLight;
            LblFechaNacimiento.Location = new Point(68, 290);
            LblFechaNacimiento.Name = "LblFechaNacimiento";
            LblFechaNacimiento.Size = new Size(201, 25);
            LblFechaNacimiento.TabIndex = 25;
            LblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.BackColor = Color.Black;
            LblEmail.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            LblEmail.ForeColor = SystemColors.ControlLight;
            LblEmail.Location = new Point(68, 227);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(64, 25);
            LblEmail.TabIndex = 24;
            LblEmail.Text = "Email:";
            // 
            // LblApellido
            // 
            LblApellido.AutoSize = true;
            LblApellido.BackColor = Color.Black;
            LblApellido.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            LblApellido.ForeColor = SystemColors.ControlLight;
            LblApellido.Location = new Point(68, 111);
            LblApellido.Name = "LblApellido";
            LblApellido.Size = new Size(91, 25);
            LblApellido.TabIndex = 23;
            LblApellido.Text = "Apellido:";
            // 
            // LblNombre
            // 
            LblNombre.AutoSize = true;
            LblNombre.BackColor = Color.Black;
            LblNombre.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            LblNombre.ForeColor = SystemColors.ControlLight;
            LblNombre.Location = new Point(68, 59);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(91, 25);
            LblNombre.TabIndex = 22;
            LblNombre.Text = "Nombre:";
            // 
            // LblDireccion
            // 
            LblDireccion.AutoSize = true;
            LblDireccion.BackColor = Color.Black;
            LblDireccion.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            LblDireccion.ForeColor = SystemColors.ControlLight;
            LblDireccion.Location = new Point(68, 169);
            LblDireccion.Name = "LblDireccion";
            LblDireccion.Size = new Size(101, 25);
            LblDireccion.TabIndex = 21;
            LblDireccion.Text = "Dirección:";
            // 
            // TxtDireccionData
            // 
            TxtDireccionData.BackColor = SystemColors.ActiveCaptionText;
            TxtDireccionData.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDireccionData.ForeColor = Color.WhiteSmoke;
            TxtDireccionData.Location = new Point(181, 162);
            TxtDireccionData.Name = "TxtDireccionData";
            TxtDireccionData.Size = new Size(575, 32);
            TxtDireccionData.TabIndex = 33;
            TxtDireccionData.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtApellidoData
            // 
            TxtApellidoData.BackColor = SystemColors.ActiveCaptionText;
            TxtApellidoData.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxtApellidoData.ForeColor = Color.WhiteSmoke;
            TxtApellidoData.Location = new Point(181, 107);
            TxtApellidoData.Name = "TxtApellidoData";
            TxtApellidoData.Size = new Size(575, 32);
            TxtApellidoData.TabIndex = 32;
            TxtApellidoData.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtNombreData
            // 
            TxtNombreData.BackColor = SystemColors.ActiveCaptionText;
            TxtNombreData.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNombreData.ForeColor = Color.WhiteSmoke;
            TxtNombreData.Location = new Point(181, 52);
            TxtNombreData.Name = "TxtNombreData";
            TxtNombreData.Size = new Size(575, 32);
            TxtNombreData.TabIndex = 31;
            TxtNombreData.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtEmailData
            // 
            TxtEmailData.BackColor = SystemColors.ActiveCaptionText;
            TxtEmailData.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxtEmailData.ForeColor = Color.WhiteSmoke;
            TxtEmailData.Location = new Point(181, 220);
            TxtEmailData.Name = "TxtEmailData";
            TxtEmailData.Size = new Size(575, 32);
            TxtEmailData.TabIndex = 35;
            TxtEmailData.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtTelefonoData
            // 
            TxtTelefonoData.BackColor = SystemColors.ActiveCaptionText;
            TxtTelefonoData.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTelefonoData.ForeColor = Color.WhiteSmoke;
            TxtTelefonoData.Location = new Point(181, 405);
            TxtTelefonoData.Name = "TxtTelefonoData";
            TxtTelefonoData.Size = new Size(575, 32);
            TxtTelefonoData.TabIndex = 38;
            TxtTelefonoData.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtDNIData
            // 
            TxtDNIData.BackColor = SystemColors.ActiveCaptionText;
            TxtDNIData.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDNIData.ForeColor = Color.WhiteSmoke;
            TxtDNIData.Location = new Point(181, 346);
            TxtDNIData.Name = "TxtDNIData";
            TxtDNIData.Size = new Size(575, 32);
            TxtDNIData.TabIndex = 37;
            TxtDNIData.TextAlign = HorizontalAlignment.Center;
            // 
            // DtpFechaNacimiento
            // 
            DtpFechaNacimiento.CalendarFont = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            DtpFechaNacimiento.CalendarForeColor = Color.Transparent;
            DtpFechaNacimiento.CalendarMonthBackground = Color.Black;
            DtpFechaNacimiento.CalendarTitleForeColor = Color.Gainsboro;
            DtpFechaNacimiento.CalendarTrailingForeColor = SystemColors.ControlLightLight;
            DtpFechaNacimiento.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            DtpFechaNacimiento.Location = new Point(275, 284);
            DtpFechaNacimiento.Name = "DtpFechaNacimiento";
            DtpFechaNacimiento.Size = new Size(481, 32);
            DtpFechaNacimiento.TabIndex = 39;
            // 
            // FrmVerPersona
            // 
            //
            TxtDireccionData.Text = persona.Direccion.ToString();
            TxtApellidoData.Text = persona.Apellido.ToString();
            TxtNombreData.Text = persona.Nombre;
            TxtEmailData.Text = persona.Email;
            TxtTelefonoData.Text = persona.Telefono;
            TxtDNIData.Text = persona.DNI.ToString();
            DtpFechaNacimiento.Value = persona.FechaNacimiento;
            //
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(825, 576);
            Controls.Add(DtpFechaNacimiento);
            Controls.Add(TxtTelefonoData);
            Controls.Add(TxtDNIData);
            Controls.Add(TxtEmailData);
            Controls.Add(TxtDireccionData);
            Controls.Add(TxtApellidoData);
            Controls.Add(TxtNombreData);
            Controls.Add(LblTelefono);
            Controls.Add(LblDNI);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnEditarPersona);
            Controls.Add(LblFechaNacimiento);
            Controls.Add(LblEmail);
            Controls.Add(LblApellido);
            Controls.Add(LblNombre);
            Controls.Add(LblDireccion);
            Name = "FrmVerPersona";
            Text = "Persona";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblTelefono;
        private Label LblDNI;
        private Button BtnEliminar;
        private Button BtnEditarPersona;
        private Label LblFechaNacimiento;
        private Label LblEmail;
        private Label LblApellido;
        private Label LblNombre;
        private Label LblDireccion;
        private TextBox TxtDireccionData;
        private TextBox TxtApellidoData;
        private TextBox TxtNombreData;
        private TextBox TxtEmailData;
        private TextBox TxtTelefonoData;
        private TextBox TxtDNIData;
        private DateTimePicker DtpFechaNacimiento;
    }
}