namespace UIDesktop
{
    partial class FrmCargarNotas
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
            cmbCursos = new ComboBox();
            dgwInscrip = new DataGridView();
            label3 = new Label();
            lblNombreAlumno = new Label();
            label4 = new Label();
            label6 = new Label();
            cmbCondicion = new ComboBox();
            txtNota = new TextBox();
            btnGuardarCambios = new Button();
            IdInsc = new DataGridViewTextBoxColumn();
            IdAlumno = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Condicion = new DataGridViewTextBoxColumn();
            Nota = new DataGridViewTextBoxColumn();
            IdCurso = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgwInscrip).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 6;
            label1.Text = "Cargar Notas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 67);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 7;
            label2.Text = "Seleccione un curso";
            // 
            // cmbCursos
            // 
            cmbCursos.FormattingEnabled = true;
            cmbCursos.Location = new Point(192, 64);
            cmbCursos.Margin = new Padding(3, 4, 3, 4);
            cmbCursos.Name = "cmbCursos";
            cmbCursos.Size = new Size(349, 28);
            cmbCursos.TabIndex = 8;
            cmbCursos.SelectedIndexChanged += cmbCursos_SelectedIndexChanged;
            // 
            // dgwInscrip
            // 
            dgwInscrip.AllowUserToAddRows = false;
            dgwInscrip.AllowUserToDeleteRows = false;
            dgwInscrip.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwInscrip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwInscrip.Columns.AddRange(new DataGridViewColumn[] { IdInsc, IdAlumno, Apellido, Nombre, Condicion, Nota, IdCurso });
            dgwInscrip.Location = new Point(14, 143);
            dgwInscrip.Margin = new Padding(3, 4, 3, 4);
            dgwInscrip.MultiSelect = false;
            dgwInscrip.Name = "dgwInscrip";
            dgwInscrip.ReadOnly = true;
            dgwInscrip.RowHeadersWidth = 51;
            dgwInscrip.RowTemplate.Height = 25;
            dgwInscrip.Size = new Size(805, 476);
            dgwInscrip.TabIndex = 10;
            dgwInscrip.RowEnter += dgwInscrip_RowEnter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(831, 431);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 11;
            label3.Text = "Alumno:";
            // 
            // lblNombreAlumno
            // 
            lblNombreAlumno.AutoSize = true;
            lblNombreAlumno.Location = new Point(898, 431);
            lblNombreAlumno.Name = "lblNombreAlumno";
            lblNombreAlumno.Size = new Size(67, 20);
            lblNombreAlumno.TabIndex = 12;
            lblNombreAlumno.Text = "_nombre";
            lblNombreAlumno.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(831, 483);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 13;
            label4.Text = "Condicion:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(831, 536);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 15;
            label6.Text = "Nota:";
            // 
            // cmbCondicion
            // 
            cmbCondicion.FormattingEnabled = true;
            cmbCondicion.Items.AddRange(new object[] { "Libre", "Regular", "Aprobado" });
            cmbCondicion.Location = new Point(912, 479);
            cmbCondicion.Margin = new Padding(3, 4, 3, 4);
            cmbCondicion.Name = "cmbCondicion";
            cmbCondicion.Size = new Size(138, 28);
            cmbCondicion.TabIndex = 16;
            // 
            // txtNota
            // 
            txtNota.Location = new Point(879, 532);
            txtNota.Margin = new Padding(3, 4, 3, 4);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(26, 27);
            txtNota.TabIndex = 17;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Location = new Point(859, 588);
            btnGuardarCambios.Margin = new Padding(3, 4, 3, 4);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(191, 31);
            btnGuardarCambios.TabIndex = 18;
            btnGuardarCambios.Text = "Guardar cambios";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // IdInsc
            // 
            IdInsc.HeaderText = "IdInsc";
            IdInsc.MinimumWidth = 6;
            IdInsc.Name = "IdInsc";
            IdInsc.ReadOnly = true;
            // 
            // IdAlumno
            // 
            IdAlumno.HeaderText = "ID Alumno";
            IdAlumno.MinimumWidth = 6;
            IdAlumno.Name = "IdAlumno";
            IdAlumno.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Condicion
            // 
            Condicion.HeaderText = "Condicion";
            Condicion.MinimumWidth = 6;
            Condicion.Name = "Condicion";
            Condicion.ReadOnly = true;
            // 
            // Nota
            // 
            Nota.HeaderText = "Nota";
            Nota.MinimumWidth = 6;
            Nota.Name = "Nota";
            Nota.ReadOnly = true;
            // 
            // IdCurso
            // 
            IdCurso.HeaderText = "IdCurso";
            IdCurso.MinimumWidth = 6;
            IdCurso.Name = "IdCurso";
            IdCurso.ReadOnly = true;
            // 
            // FrmCargarNotas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 660);
            Controls.Add(btnGuardarCambios);
            Controls.Add(txtNota);
            Controls.Add(cmbCondicion);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(lblNombreAlumno);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(cmbCursos);
            Controls.Add(dgwInscrip);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmCargarNotas";
            Text = "FrmCargarNotas";
            Load += FrmCargarNotas_Load;
            ((System.ComponentModel.ISupportInitialize)dgwInscrip).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbCursos;
        private DataGridView dataGridView1;
        private Label label3;
        private Label lblNombreAlumno;
        private Label label4;
        private Label label6;
        private ComboBox cmbCondicion;
        private TextBox txtNota;
        private Button btnGuardarCambios;
        private DataGridView dgwInscrip;
        private DataGridViewTextBoxColumn IdInsc;
        private DataGridViewTextBoxColumn IdAlumno;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Condicion;
        private DataGridViewTextBoxColumn Nota;
        private DataGridViewTextBoxColumn IdCurso;
    }
}