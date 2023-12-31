﻿namespace UIDesktop
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
            lblDni = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDireccion = new Label();
            label5 = new Label();
            lblTelefono = new Label();
            TxtDni = new TextBox();
            TxtNombre = new TextBox();
            TxtDireccion = new TextBox();
            TxtApellido = new TextBox();
            TxtTelefono = new TextBox();
            DtpFechaNacimiento = new DateTimePicker();
            TxtEmail = new TextBox();
            lblEmail = new Label();
            btnAgregar = new Button();
            btnCancelar = new Button();
            cmbPlanes = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.Location = new Point(55, 55);
            lblDni.Margin = new Padding(4, 0, 4, 0);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(35, 20);
            lblDni.TabIndex = 0;
            lblDni.Text = "DNI";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(55, 140);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(55, 223);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblDireccion.Location = new Point(55, 312);
            lblDireccion.Margin = new Padding(4, 0, 4, 0);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(72, 20);
            lblDireccion.TabIndex = 3;
            lblDireccion.Text = "Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(55, 582);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(146, 20);
            label5.TabIndex = 4;
            label5.Text = "Fecha de nacimiento";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefono.Location = new Point(55, 399);
            lblTelefono.Margin = new Padding(4, 0, 4, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 5;
            lblTelefono.Text = "Telefono";
            // 
            // TxtDni
            // 
            TxtDni.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDni.Location = new Point(55, 87);
            TxtDni.Margin = new Padding(4);
            TxtDni.Name = "TxtDni";
            TxtDni.Size = new Size(517, 27);
            TxtDni.TabIndex = 6;
            TxtDni.KeyPress += TxtDni_KeyPress;
            // 
            // TxtNombre
            // 
            TxtNombre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNombre.Location = new Point(55, 172);
            TxtNombre.Margin = new Padding(4);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(517, 27);
            TxtNombre.TabIndex = 7;
            // 
            // TxtDireccion
            // 
            TxtDireccion.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDireccion.Location = new Point(55, 344);
            TxtDireccion.Margin = new Padding(4);
            TxtDireccion.Name = "TxtDireccion";
            TxtDireccion.Size = new Size(517, 27);
            TxtDireccion.TabIndex = 9;
            // 
            // TxtApellido
            // 
            TxtApellido.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TxtApellido.Location = new Point(55, 255);
            TxtApellido.Margin = new Padding(4);
            TxtApellido.Name = "TxtApellido";
            TxtApellido.Size = new Size(517, 27);
            TxtApellido.TabIndex = 8;
            // 
            // TxtTelefono
            // 
            TxtTelefono.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTelefono.Location = new Point(55, 431);
            TxtTelefono.Margin = new Padding(4);
            TxtTelefono.Name = "TxtTelefono";
            TxtTelefono.Size = new Size(517, 27);
            TxtTelefono.TabIndex = 10;
            TxtTelefono.KeyPress += TxtTelefono_KeyPress;
            // 
            // DtpFechaNacimiento
            // 
            DtpFechaNacimiento.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            DtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
            DtpFechaNacimiento.Location = new Point(55, 615);
            DtpFechaNacimiento.Margin = new Padding(4);
            DtpFechaNacimiento.Name = "DtpFechaNacimiento";
            DtpFechaNacimiento.ShowUpDown = true;
            DtpFechaNacimiento.Size = new Size(275, 27);
            DtpFechaNacimiento.TabIndex = 11;
            // 
            // TxtEmail
            // 
            TxtEmail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TxtEmail.Location = new Point(55, 524);
            TxtEmail.Margin = new Padding(4);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(517, 27);
            TxtEmail.TabIndex = 13;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(55, 491);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.Desktop;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = SystemColors.Control;
            btnAgregar.Location = new Point(141, 703);
            btnAgregar.Margin = new Padding(4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(163, 57);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(192, 0, 0);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = SystemColors.Control;
            btnCancelar.Location = new Point(328, 703);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(163, 57);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cmbPlanes
            // 
            cmbPlanes.FormattingEnabled = true;
            cmbPlanes.Location = new Point(88, 495);
            cmbPlanes.Name = "cmbPlanes";
            cmbPlanes.Size = new Size(121, 23);
            cmbPlanes.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(45, 495);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 34;
            label1.Text = "Plan";
            // 
            // FrmAgregarPersona
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 798);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
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
            Margin = new Padding(4);
            Name = "FrmAgregarPersona";
            Text = "Agregar Persona";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDni;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDireccion;
        private Label label5;
        private Label lblTelefono;
        private TextBox TxtDni;
        private TextBox TxtNombre;
        private TextBox TxtDireccion;
        private TextBox TxtApellido;
        private TextBox TxtTelefono;
        private DateTimePicker DtpFechaNacimiento;
        private TextBox TxtEmail;
        private Label lblEmail;
        private Button btnAgregar;
        private Button btnCancelar;
        private ComboBox cmbPlanes;
        private Label label1;
    }
}