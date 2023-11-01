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
            BtnCancelar = new Button();
            BtnGuardar = new Button();
            label3 = new Label();
            cmbMaterias = new ComboBox();
            label4 = new Label();
            cmbComisiones = new ComboBox();
            label5 = new Label();
            txtPlan = new TextBox();
            txtEspecialidad = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Legajo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 9);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Especialidad";
            // 
            // txtLegajoAlumno
            // 
            txtLegajoAlumno.Location = new Point(23, 27);
            txtLegajoAlumno.Name = "txtLegajoAlumno";
            txtLegajoAlumno.ReadOnly = true;
            txtLegajoAlumno.Size = new Size(120, 23);
            txtLegajoAlumno.TabIndex = 2;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.FromArgb(192, 0, 0);
            BtnCancelar.FlatAppearance.BorderSize = 0;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCancelar.ForeColor = SystemColors.Control;
            BtnCancelar.Location = new Point(278, 213);
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
            BtnGuardar.Location = new Point(156, 213);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(85, 29);
            BtnGuardar.TabIndex = 38;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(386, 9);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 40;
            label3.Text = "Plan";
            // 
            // cmbMaterias
            // 
            cmbMaterias.FormattingEnabled = true;
            cmbMaterias.Location = new Point(23, 98);
            cmbMaterias.Name = "cmbMaterias";
            cmbMaterias.Size = new Size(218, 23);
            cmbMaterias.TabIndex = 43;
            cmbMaterias.SelectedIndexChanged += cmbMaterias_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 80);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 42;
            label4.Text = "Materia";
            // 
            // cmbComisiones
            // 
            cmbComisiones.FormattingEnabled = true;
            cmbComisiones.Location = new Point(23, 161);
            cmbComisiones.Name = "cmbComisiones";
            cmbComisiones.Size = new Size(218, 23);
            cmbComisiones.TabIndex = 45;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 143);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 44;
            label5.Text = "Comision";
            // 
            // txtPlan
            // 
            txtPlan.Location = new Point(384, 27);
            txtPlan.Name = "txtPlan";
            txtPlan.ReadOnly = true;
            txtPlan.Size = new Size(100, 23);
            txtPlan.TabIndex = 46;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Location = new Point(179, 27);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.ReadOnly = true;
            txtEspecialidad.Size = new Size(184, 23);
            txtEspecialidad.TabIndex = 47;
            // 
            // FrmInscripcionAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 271);
            Controls.Add(txtEspecialidad);
            Controls.Add(txtPlan);
            Controls.Add(cmbComisiones);
            Controls.Add(label5);
            Controls.Add(cmbMaterias);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnGuardar);
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
        private Button BtnCancelar;
        private Button BtnGuardar;
        private Label label3;
        private ComboBox cmbMaterias;
        private Label label4;
        private ComboBox cmbComisiones;
        private Label label5;
        private TextBox txtPlan;
        private TextBox txtEspecialidad;
    }
}