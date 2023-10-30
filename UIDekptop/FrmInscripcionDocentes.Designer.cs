namespace UIDesktop
{
    partial class FrmInscripcionDocentes
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
            txtIdDocente = new TextBox();
            label2 = new Label();
            cmbCursos = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblMateria = new Label();
            lblComision = new Label();
            lblAnio = new Label();
            label6 = new Label();
            cmbCargos = new ComboBox();
            btnAceptar = new Button();
            dgvDocentesCursos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDocentesCursos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "ID Docente";
            // 
            // txtIdDocente
            // 
            txtIdDocente.Location = new Point(12, 27);
            txtIdDocente.Name = "txtIdDocente";
            txtIdDocente.Size = new Size(100, 23);
            txtIdDocente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Cursos";
            // 
            // cmbCursos
            // 
            cmbCursos.FormattingEnabled = true;
            cmbCursos.Location = new Point(12, 79);
            cmbCursos.Name = "cmbCursos";
            cmbCursos.Size = new Size(121, 23);
            cmbCursos.TabIndex = 3;
            cmbCursos.SelectedIndexChanged += cmbCursos_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 61);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 4;
            label3.Text = "Materia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(292, 61);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 5;
            label4.Text = "Comision";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(437, 61);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 6;
            label5.Text = "Año";
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new Point(169, 82);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(52, 15);
            lblMateria.TabIndex = 7;
            lblMateria.Text = "_materia";
            lblMateria.Visible = false;
            // 
            // lblComision
            // 
            lblComision.AutoSize = true;
            lblComision.Location = new Point(295, 82);
            lblComision.Name = "lblComision";
            lblComision.Size = new Size(61, 15);
            lblComision.TabIndex = 8;
            lblComision.Text = "_comision";
            lblComision.Visible = false;
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Location = new Point(437, 82);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(35, 15);
            lblAnio.TabIndex = 9;
            lblAnio.Text = "_anio";
            lblAnio.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 116);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 10;
            label6.Text = "Cargo";
            // 
            // cmbCargos
            // 
            cmbCargos.FormattingEnabled = true;
            cmbCargos.Items.AddRange(new object[] { "1", "2", "3" });
            cmbCargos.Location = new Point(12, 134);
            cmbCargos.Name = "cmbCargos";
            cmbCargos.Size = new Size(121, 23);
            cmbCargos.TabIndex = 11;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(37, 176);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // dgvDocentesCursos
            // 
            dgvDocentesCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocentesCursos.Location = new Point(192, 134);
            dgvDocentesCursos.Name = "dgvDocentesCursos";
            dgvDocentesCursos.RowTemplate.Height = 25;
            dgvDocentesCursos.Size = new Size(461, 232);
            dgvDocentesCursos.TabIndex = 13;
            // 
            // FrmInscripcionDocentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDocentesCursos);
            Controls.Add(btnAceptar);
            Controls.Add(cmbCargos);
            Controls.Add(label6);
            Controls.Add(lblAnio);
            Controls.Add(lblComision);
            Controls.Add(lblMateria);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbCursos);
            Controls.Add(label2);
            Controls.Add(txtIdDocente);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmInscripcionDocentes";
            Text = "Inscripciones Docentes";
            Load += FrmInscripcionDocentes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDocentesCursos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIdDocente;
        private Label label2;
        private ComboBox cmbCursos;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblMateria;
        private Label lblComision;
        private Label lblAnio;
        private Label label6;
        private ComboBox cmbCargos;
        private Button btnAceptar;
        private DataGridView dgvDocentesCursos;
    }
}