namespace UIDesktop
{
    partial class FrmCursos
    {
        private Button btnAgregarCurso;
        private Button btnEditarCurso;
        private Button btnEliminarCurso;
        private DataGridView DgvCursos;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn DescripcionMateria;
        private DataGridViewTextBoxColumn DescripcionComision;
        private DataGridViewTextBoxColumn AnioCalendario;
        private DataGridViewTextBoxColumn Cupo;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAgregarCurso = new System.Windows.Forms.Button();
            this.btnEditarCurso = new System.Windows.Forms.Button();
            this.btnEliminarCurso = new System.Windows.Forms.Button();
            this.DgvCursos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnioCalendario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarCurso
            // 
            this.btnAgregarCurso.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnAgregarCurso.FlatAppearance.BorderSize = 0;
            this.btnAgregarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCurso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarCurso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarCurso.Location = new System.Drawing.Point(741, 629);
            this.btnAgregarCurso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarCurso.Name = "btnAgregarCurso";
            this.btnAgregarCurso.Size = new System.Drawing.Size(151, 31);
            this.btnAgregarCurso.TabIndex = 4;
            this.btnAgregarCurso.Text = "Agregar Curso";
            this.btnAgregarCurso.UseVisualStyleBackColor = false;
            this.btnAgregarCurso.Click += new System.EventHandler(this.btnAgregarCurso_Click);
            // 
            // btnEditarCurso
            // 
            this.btnEditarCurso.BackColor = System.Drawing.Color.Green;
            this.btnEditarCurso.FlatAppearance.BorderSize = 0;
            this.btnEditarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCurso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditarCurso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarCurso.Location = new System.Drawing.Point(222, 629);
            this.btnEditarCurso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditarCurso.Name = "btnEditarCurso";
            this.btnEditarCurso.Size = new System.Drawing.Size(86, 31);
            this.btnEditarCurso.TabIndex = 5;
            this.btnEditarCurso.Text = "Editar";
            this.btnEditarCurso.UseVisualStyleBackColor = false;
            this.btnEditarCurso.Click += new System.EventHandler(this.btnEditarCurso_Click);
            // 
            // btnEliminarCurso
            // 
            this.btnEliminarCurso.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            this.btnEliminarCurso.FlatAppearance.BorderSize = 0;
            this.btnEliminarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCurso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarCurso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarCurso.Location = new System.Drawing.Point(333, 629);
            this.btnEliminarCurso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminarCurso.Name = "btnEliminarCurso";
            this.btnEliminarCurso.Size = new System.Drawing.Size(86, 31);
            this.btnEliminarCurso.TabIndex = 6;
            this.btnEliminarCurso.Text = "Eliminar";
            this.btnEliminarCurso.UseVisualStyleBackColor = false;
            this.btnEliminarCurso.Click += new System.EventHandler(this.btnEliminarCurso_Click);
            // 
            // DgvCursos
            // 
            this.DgvCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCursos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
        this.ID,
        this.DescripcionMateria,
        this.DescripcionComision,
        this.AnioCalendario,
        this.Cupo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCursos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvCursos.GridColor = System.Drawing.SystemColors.Control;
            this.DgvCursos.Location = new System.Drawing.Point(74, 81);
            this.DgvCursos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DgvCursos.Name = "DgvCursos";
            this.DgvCursos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCursos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvCursos.RowHeadersWidth = 51;
            this.DgvCursos.RowTemplate.Height = 25;
            this.DgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCursos.Size = new System.Drawing.Size(983, 483);
            this.DgvCursos.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.FillWeight = 20F;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 44;
            // 
            // DescripcionMateria
            // 
            this.DescripcionMateria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DescripcionMateria.HeaderText = "Materia";
            this.DescripcionMateria.MinimumWidth = 6;
            this.DescripcionMateria.Name = "DescripcionMateria";
            this.DescripcionMateria.ReadOnly = true;
            this.DescripcionMateria.Width = 222;
            // 
            // DescripcionComision
            // 
            this.DescripcionComision.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DescripcionComision.HeaderText = "Comision";
            this.DescripcionComision.MinimumWidth = 6;
            this.DescripcionComision.Name = "DescripcionComision";
            this.DescripcionComision.ReadOnly = true;
            this.DescripcionComision.Width = 222;
            // 
            // AnioCalendario
            // 
            this.AnioCalendario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AnioCalendario.HeaderText = "Año Calendario";
            this.AnioCalendario.MinimumWidth = 6;
            this.AnioCalendario.Name = "AnioCalendario";
            this.AnioCalendario.ReadOnly = true;
            this.AnioCalendario.Width = 120;
            // 
            // Cupo
            // 
            this.Cupo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cupo.HeaderText = "Cupo";
            this.Cupo.MinimumWidth = 6;
            this.Cupo.Name = "Cupo";
            this.Cupo.ReadOnly = true;
            this.Cupo.Width = 120;
            // 
            // FrmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1126, 803);
            this.Controls.Add(this.btnEliminarCurso);
            this.Controls.Add(this.btnEditarCurso);
            this.Controls.Add(this.btnAgregarCurso);
            this.Controls.Add(this.DgvCursos);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCursos";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.FrmCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCursos)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion
    }
}