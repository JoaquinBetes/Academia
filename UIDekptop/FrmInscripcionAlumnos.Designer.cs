namespace UIDesktop
{
    partial class FrmInscripcionAlumnos
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
            label1 = new Label();
            label2 = new Label();
            txtLegajoAlumno = new TextBox();
            cmbEspecialidades = new ComboBox();
            BtnCancelar = new Button();
            BtnGuardar = new Button();
            cmbPlanes = new ComboBox();
            label3 = new Label();
            cmbMaterias = new ComboBox();
            label4 = new Label();
            cmbComisiones = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 13);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Legajo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 60);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Especialidad";
            // 
            // txtLegajoAlumno
            // 
            txtLegajoAlumno.Location = new Point(68, 10);
            txtLegajoAlumno.Name = "txtLegajoAlumno";
            txtLegajoAlumno.ReadOnly = true;
            txtLegajoAlumno.Size = new Size(120, 23);
            txtLegajoAlumno.TabIndex = 2;
            // 
            // cmbEspecialidades
            // 
            cmbEspecialidades.FormattingEnabled = true;
            cmbEspecialidades.Location = new Point(101, 57);
            cmbEspecialidades.Name = "cmbEspecialidades";
            cmbEspecialidades.Size = new Size(218, 23);
            cmbEspecialidades.TabIndex = 3;
            cmbEspecialidades.SelectedIndexChanged += cmbEspecialidad_SelectedIndexChanged;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.FromArgb(192, 0, 0);
            BtnCancelar.FlatAppearance.BorderSize = 0;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCancelar.ForeColor = SystemColors.Control;
            BtnCancelar.Location = new Point(200, 260);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(85, 29);
            BtnCancelar.TabIndex = 39;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = SystemColors.Desktop;
            BtnGuardar.FlatAppearance.BorderSize = 0;
            BtnGuardar.FlatStyle = FlatStyle.Flat;
            BtnGuardar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGuardar.ForeColor = SystemColors.Control;
            BtnGuardar.Location = new Point(67, 260);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(85, 29);
            BtnGuardar.TabIndex = 38;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // cmbPlanes
            // 
            cmbPlanes.FormattingEnabled = true;
            cmbPlanes.Location = new Point(101, 102);
            cmbPlanes.Name = "cmbPlanes";
            cmbPlanes.Size = new Size(218, 23);
            cmbPlanes.TabIndex = 41;
            cmbPlanes.SelectedIndexChanged += cmbPlanes_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 105);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 40;
            label3.Text = "Plan";
            // 
            // cmbMaterias
            // 
            cmbMaterias.FormattingEnabled = true;
            cmbMaterias.Location = new Point(101, 140);
            cmbMaterias.Name = "cmbMaterias";
            cmbMaterias.Size = new Size(218, 23);
            cmbMaterias.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 143);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 42;
            label4.Text = "Materia";
            // 
            // cmbComisiones
            // 
            cmbComisiones.FormattingEnabled = true;
            cmbComisiones.Location = new Point(101, 188);
            cmbComisiones.Name = "cmbComisiones";
            cmbComisiones.Size = new Size(218, 23);
            cmbComisiones.TabIndex = 45;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 191);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 44;
            label5.Text = "Comision";
            // 
            // FrmInscripcionAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 319);
            Controls.Add(cmbComisiones);
            Controls.Add(label5);
            Controls.Add(cmbMaterias);
            Controls.Add(label4);
            Controls.Add(cmbPlanes);
            Controls.Add(label3);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnGuardar);
            Controls.Add(cmbEspecialidades);
            Controls.Add(txtLegajoAlumno);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmInscripcionAlumnos";
            Text = "Inscripcion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtLegajoAlumno;
        private ComboBox cmbEspecialidades;
        private Button BtnCancelar;
        private Button BtnGuardar;
        private ComboBox cmbPlanes;
        private Label label3;
        private ComboBox cmbMaterias;
        private Label label4;
        private ComboBox cmbComisiones;
        private Label label5;
    }
}