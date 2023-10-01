namespace UIDesktop
{
    partial class FrmMaterias
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnAgregarMateria = new Button();
            btnEditarMateria = new Button();
            btnEliminarMateria = new Button();
            DgvMaterias = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            HsSemanales = new DataGridViewTextBoxColumn();
            HsTotales = new DataGridViewTextBoxColumn();
            Plan = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DgvMaterias).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarMateria
            // 
            btnAgregarMateria.BackColor = SystemColors.Desktop;
            btnAgregarMateria.FlatAppearance.BorderSize = 0;
            btnAgregarMateria.FlatStyle = FlatStyle.Flat;
            btnAgregarMateria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarMateria.ForeColor = SystemColors.ButtonHighlight;
            btnAgregarMateria.Location = new Point(741, 629);
            btnAgregarMateria.Margin = new Padding(3, 4, 3, 4);
            btnAgregarMateria.Name = "btnAgregarMateria";
            btnAgregarMateria.Size = new Size(151, 31);
            btnAgregarMateria.TabIndex = 4;
            btnAgregarMateria.Text = "Agregar Materia";
            btnAgregarMateria.UseVisualStyleBackColor = false;
            btnAgregarMateria.Click += btnAgregarMateria_Click;
            // 
            // btnEditarMateria
            // 
            btnEditarMateria.BackColor = Color.Green;
            btnEditarMateria.FlatAppearance.BorderSize = 0;
            btnEditarMateria.FlatStyle = FlatStyle.Flat;
            btnEditarMateria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditarMateria.ForeColor = SystemColors.ButtonHighlight;
            btnEditarMateria.Location = new Point(222, 629);
            btnEditarMateria.Margin = new Padding(3, 4, 3, 4);
            btnEditarMateria.Name = "btnEditarMateria";
            btnEditarMateria.Size = new Size(86, 31);
            btnEditarMateria.TabIndex = 5;
            btnEditarMateria.Text = "Editar";
            btnEditarMateria.UseVisualStyleBackColor = false;
            btnEditarMateria.Click += btnEditarMateria_Click;
            // 
            // btnEliminarMateria
            // 
            btnEliminarMateria.BackColor = Color.FromArgb(192, 0, 0);
            btnEliminarMateria.FlatAppearance.BorderSize = 0;
            btnEliminarMateria.FlatStyle = FlatStyle.Flat;
            btnEliminarMateria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarMateria.ForeColor = SystemColors.ButtonHighlight;
            btnEliminarMateria.Location = new Point(333, 629);
            btnEliminarMateria.Margin = new Padding(3, 4, 3, 4);
            btnEliminarMateria.Name = "btnEliminarMateria";
            btnEliminarMateria.Size = new Size(86, 31);
            btnEliminarMateria.TabIndex = 6;
            btnEliminarMateria.Text = "Eliminar";
            btnEliminarMateria.UseVisualStyleBackColor = false;
            btnEliminarMateria.Click += btnEliminarMateria_Click;
            // 
            // DgvMaterias
            // 
            DgvMaterias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvMaterias.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvMaterias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvMaterias.Columns.AddRange(new DataGridViewColumn[] { ID, Descripcion, HsSemanales, HsTotales, Plan });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvMaterias.DefaultCellStyle = dataGridViewCellStyle2;
            DgvMaterias.GridColor = SystemColors.Control;
            DgvMaterias.Location = new Point(74, 81);
            DgvMaterias.Margin = new Padding(3, 4, 3, 4);
            DgvMaterias.Name = "DgvMaterias";
            DgvMaterias.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DgvMaterias.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DgvMaterias.RowHeadersWidth = 51;
            DgvMaterias.RowTemplate.Height = 25;
            DgvMaterias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvMaterias.Size = new Size(983, 483);
            DgvMaterias.TabIndex = 0;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ID.FillWeight = 20F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 44;
            // 
            // Descripcion
            // 
            Descripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Width = 222;
            // 
            // HsSemanales
            // 
            HsSemanales.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            HsSemanales.HeaderText = "HsSemanales";
            HsSemanales.MinimumWidth = 6;
            HsSemanales.Name = "HsSemanales";
            HsSemanales.ReadOnly = true;
            HsSemanales.Width = 221;
            // 
            // HsTotales
            // 
            HsTotales.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            HsTotales.HeaderText = "HsTotales";
            HsTotales.MinimumWidth = 6;
            HsTotales.Name = "HsTotales";
            HsTotales.ReadOnly = true;
            HsTotales.Width = 222;
            // 
            // Plan
            // 
            Plan.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Plan.HeaderText = "Plan";
            Plan.MinimumWidth = 6;
            Plan.Name = "Plan";
            Plan.ReadOnly = true;
            Plan.Width = 221;
            // 
            // FrmMaterias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1126, 803);
            Controls.Add(btnEliminarMateria);
            Controls.Add(btnEditarMateria);
            Controls.Add(btnAgregarMateria);
            Controls.Add(DgvMaterias);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmMaterias";
            Text = "Materias";
            Load += FrmMaterias_Load;
            ((System.ComponentModel.ISupportInitialize)DgvMaterias).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAgregarMateria;
        private Button btnEditarMateria;
        private Button btnEliminarMateria;
        private DataGridView DgvMaterias;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn HsSemanales;
        private DataGridViewTextBoxColumn HsTotales;
        private DataGridViewTextBoxColumn Plan;
    }
}