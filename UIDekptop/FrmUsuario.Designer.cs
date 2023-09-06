namespace UIDekptop
{
    partial class FrmUsuario
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
            lblUsuario = new Label();
            lblClave = new Label();
            lblLegajo = new Label();
            lblTipo = new Label();
            TxtNombreUsuario = new TextBox();
            TxtClave = new TextBox();
            TxtLegajo = new TextBox();
            CmbTipoUsuario = new ComboBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtDni = new TextBox();
            lblDni = new Label();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(59, 124);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(137, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Nombre de usuario";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblClave.Location = new Point(59, 196);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(45, 20);
            lblClave.TabIndex = 1;
            lblClave.Text = "Clave";
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblLegajo.Location = new Point(59, 333);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(54, 20);
            lblLegajo.TabIndex = 3;
            lblLegajo.Text = "Legajo";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipo.Location = new Point(59, 265);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(112, 20);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo de usuario";
            // 
            // TxtNombreUsuario
            // 
            TxtNombreUsuario.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNombreUsuario.Location = new Point(59, 147);
            TxtNombreUsuario.Name = "TxtNombreUsuario";
            TxtNombreUsuario.Size = new Size(333, 27);
            TxtNombreUsuario.TabIndex = 4;
            // 
            // TxtClave
            // 
            TxtClave.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TxtClave.Location = new Point(59, 219);
            TxtClave.Name = "TxtClave";
            TxtClave.Size = new Size(333, 27);
            TxtClave.TabIndex = 5;
            // 
            // TxtLegajo
            // 
            TxtLegajo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            TxtLegajo.Location = new Point(59, 356);
            TxtLegajo.Name = "TxtLegajo";
            TxtLegajo.Size = new Size(333, 27);
            TxtLegajo.TabIndex = 6;
            // 
            // CmbTipoUsuario
            // 
            CmbTipoUsuario.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            CmbTipoUsuario.FormattingEnabled = true;
            CmbTipoUsuario.Items.AddRange(new object[] { "Alumno", "Docente", "Administrador" });
            CmbTipoUsuario.Location = new Point(59, 288);
            CmbTipoUsuario.Name = "CmbTipoUsuario";
            CmbTipoUsuario.Size = new Size(333, 28);
            CmbTipoUsuario.TabIndex = 7;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(192, 0, 0);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = SystemColors.Control;
            btnCancelar.Location = new Point(236, 433);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(127, 41);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.Desktop;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = SystemColors.Control;
            btnGuardar.Location = new Point(91, 433);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(127, 41);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.Location = new Point(59, 78);
            txtDni.Name = "txtDni";
            txtDni.ReadOnly = true;
            txtDni.Size = new Size(333, 27);
            txtDni.TabIndex = 19;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.Location = new Point(59, 55);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(35, 20);
            lblDni.TabIndex = 18;
            lblDni.Text = "DNI";
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 516);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(CmbTipoUsuario);
            Controls.Add(TxtLegajo);
            Controls.Add(TxtClave);
            Controls.Add(TxtNombreUsuario);
            Controls.Add(lblLegajo);
            Controls.Add(lblTipo);
            Controls.Add(lblClave);
            Controls.Add(lblUsuario);
            Name = "FrmUsuario";
            Text = "Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblClave;
        private Label lblLegajo;
        private Label lblTipo;
        private TextBox TxtNombreUsuario;
        private TextBox TxtClave;
        private TextBox TxtLegajo;
        private ComboBox CmbTipoUsuario;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtDni;
        private Label lblDni;
    }
}