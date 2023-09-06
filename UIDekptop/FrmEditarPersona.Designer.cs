namespace UIDekptop
{
    partial class FrmEditarPersona
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
            BtnCancelar = new Button();
            BtnGuardarEdicion = new Button();
            TxtEmail = new TextBox();
            lblEmail = new Label();
            DtpFechaNacimiento = new DateTimePicker();
            TxtTelefono = new TextBox();
            TxtDireccion = new TextBox();
            TxtApellido = new TextBox();
            TxtNombre = new TextBox();
            TxtDni = new TextBox();
            lblTelefono = new Label();
            label5 = new Label();
            lblDireccion = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            lblDni = new Label();
            SuspendLayout();
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.FromArgb(192, 0, 0);
            BtnCancelar.FlatAppearance.BorderSize = 0;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCancelar.ForeColor = SystemColors.Control;
            BtnCancelar.Location = new Point(266, 496);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(127, 41);
            BtnCancelar.TabIndex = 31;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnGuardarEdicion
            // 
            BtnGuardarEdicion.BackColor = SystemColors.Desktop;
            BtnGuardarEdicion.FlatAppearance.BorderSize = 0;
            BtnGuardarEdicion.FlatStyle = FlatStyle.Flat;
            BtnGuardarEdicion.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGuardarEdicion.ForeColor = SystemColors.Control;
            BtnGuardarEdicion.Location = new Point(121, 496);
            BtnGuardarEdicion.Name = "BtnGuardarEdicion";
            BtnGuardarEdicion.Size = new Size(127, 41);
            BtnGuardarEdicion.TabIndex = 30;
            BtnGuardarEdicion.Text = "Guardar";
            BtnGuardarEdicion.UseVisualStyleBackColor = false;
            BtnGuardarEdicion.Click += BtnGuardarEdicion_Click;
            // 
            // TxtEmail
            // 
            TxtEmail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TxtEmail.Location = new Point(54, 368);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(403, 27);
            TxtEmail.TabIndex = 29;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(54, 345);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 28;
            lblEmail.Text = "Email";
            // 
            // DtpFechaNacimiento
            // 
            DtpFechaNacimiento.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
            DtpFechaNacimiento.Location = new Point(54, 433);
            DtpFechaNacimiento.Name = "DtpFechaNacimiento";
            DtpFechaNacimiento.ShowUpDown = true;
            DtpFechaNacimiento.Size = new Size(215, 27);
            DtpFechaNacimiento.TabIndex = 27;
            // 
            // TxtTelefono
            // 
            TxtTelefono.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTelefono.Location = new Point(54, 302);
            TxtTelefono.Name = "TxtTelefono";
            TxtTelefono.Size = new Size(403, 27);
            TxtTelefono.TabIndex = 26;
            // 
            // TxtDireccion
            // 
            TxtDireccion.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDireccion.Location = new Point(54, 240);
            TxtDireccion.Name = "TxtDireccion";
            TxtDireccion.Size = new Size(403, 27);
            TxtDireccion.TabIndex = 25;
            // 
            // TxtApellido
            // 
            TxtApellido.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TxtApellido.Location = new Point(54, 176);
            TxtApellido.Name = "TxtApellido";
            TxtApellido.Size = new Size(403, 27);
            TxtApellido.TabIndex = 24;
            // 
            // TxtNombre
            // 
            TxtNombre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNombre.Location = new Point(54, 117);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(403, 27);
            TxtNombre.TabIndex = 23;
            // 
            // TxtDni
            // 
            TxtDni.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDni.Location = new Point(54, 56);
            TxtDni.Name = "TxtDni";
            TxtDni.Size = new Size(403, 27);
            TxtDni.TabIndex = 22;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefono.Location = new Point(54, 279);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 21;
            lblTelefono.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(54, 410);
            label5.Name = "label5";
            label5.Size = new Size(146, 20);
            label5.TabIndex = 20;
            label5.Text = "Fecha de nacimiento";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblDireccion.Location = new Point(54, 217);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(72, 20);
            lblDireccion.TabIndex = 19;
            lblDireccion.Text = "Direccion";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(54, 153);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 18;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(54, 94);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 17;
            lblNombre.Text = "Nombre";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.Location = new Point(54, 33);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(35, 20);
            lblDni.TabIndex = 16;
            lblDni.Text = "DNI";
            // 
            // FrmEditarPersona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 570);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnGuardarEdicion);
            Controls.Add(TxtEmail);
            Controls.Add(lblEmail);
            Controls.Add(DtpFechaNacimiento);
            Controls.Add(TxtTelefono);
            Controls.Add(TxtDireccion);
            Controls.Add(TxtApellido);
            Controls.Add(TxtNombre);
            Controls.Add(TxtDni);
            Controls.Add(lblTelefono);
            Controls.Add(label5);
            Controls.Add(lblDireccion);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblDni);
            Name = "FrmEditarPersona";
            Text = "Editar Persona";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCancelar;
        private Button BtnGuardarEdicion;
        private TextBox TxtEmail;
        private Label lblEmail;
        private DateTimePicker DtpFechaNacimiento;
        private TextBox TxtTelefono;
        private TextBox TxtDireccion;
        private TextBox TxtApellido;
        private TextBox TxtNombre;
        private TextBox TxtDni;
        private Label lblTelefono;
        private Label label5;
        private Label lblDireccion;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblDni;
    }
}