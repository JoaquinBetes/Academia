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
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            IdAlumno = new DataGridViewTextBoxColumn();
            Legajo = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Condicion = new DataGridViewTextBoxColumn();
            Nota = new DataGridViewTextBoxColumn();
            label3 = new Label();
            lblNombreAlumno = new Label();
            label4 = new Label();
            label6 = new Label();
            cmbCondicion = new ComboBox();
            txtNota = new TextBox();
            btnGuardarCambios = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 6;
            label1.Text = "Cargar Notas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 7;
            label2.Text = "Seleccione una materia";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(147, 47);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(306, 23);
            comboBox1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdAlumno, Legajo, Apellido, Nombre, Condicion, Nota });
            dataGridView1.Location = new Point(12, 107);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(704, 357);
            dataGridView1.TabIndex = 10;
            // 
            // IdAlumno
            // 
            IdAlumno.HeaderText = "ID Alumno";
            IdAlumno.Name = "IdAlumno";
            IdAlumno.ReadOnly = true;
            // 
            // Legajo
            // 
            Legajo.HeaderText = "Legajo";
            Legajo.Name = "Legajo";
            Legajo.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Condicion
            // 
            Condicion.HeaderText = "Condicion";
            Condicion.Name = "Condicion";
            Condicion.ReadOnly = true;
            // 
            // Nota
            // 
            Nota.HeaderText = "Nota";
            Nota.Name = "Nota";
            Nota.ReadOnly = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(727, 323);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 11;
            label3.Text = "Alumno:";
            // 
            // lblNombreAlumno
            // 
            lblNombreAlumno.AutoSize = true;
            lblNombreAlumno.Location = new Point(786, 323);
            lblNombreAlumno.Name = "lblNombreAlumno";
            lblNombreAlumno.Size = new Size(54, 15);
            lblNombreAlumno.TabIndex = 12;
            lblNombreAlumno.Text = "_nombre";
            lblNombreAlumno.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(727, 362);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 13;
            label4.Text = "Condicion:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(727, 402);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 15;
            label6.Text = "Nota:";
            // 
            // cmbCondicion
            // 
            cmbCondicion.FormattingEnabled = true;
            cmbCondicion.Items.AddRange(new object[] { "Libre", "Regular", "Aprobado" });
            cmbCondicion.Location = new Point(798, 359);
            cmbCondicion.Name = "cmbCondicion";
            cmbCondicion.Size = new Size(121, 23);
            cmbCondicion.TabIndex = 16;
            // 
            // txtNota
            // 
            txtNota.Location = new Point(769, 399);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(23, 23);
            txtNota.TabIndex = 17;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Location = new Point(752, 441);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(167, 23);
            btnGuardarCambios.TabIndex = 18;
            btnGuardarCambios.Text = "Guardar cambios";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            // 
            // FrmCargarNotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 495);
            Controls.Add(btnGuardarCambios);
            Controls.Add(txtNota);
            Controls.Add(cmbCondicion);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(lblNombreAlumno);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCargarNotas";
            Text = "FrmCargarNotas";
            Load += FrmCargarNotas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IdAlumno;
        private DataGridViewTextBoxColumn Legajo;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Condicion;
        private DataGridViewTextBoxColumn Nota;
        private Label label3;
        private Label lblNombreAlumno;
        private Label label4;
        private Label label6;
        private ComboBox cmbCondicion;
        private TextBox txtNota;
        private Button btnGuardarCambios;
    }
}