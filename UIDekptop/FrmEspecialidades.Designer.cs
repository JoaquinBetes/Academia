namespace UIDesktop
{
    partial class FrmEspecialidades
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
            DgvEspecialidades = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            btnAgregarEspecialidad = new Button();
            btnEditarEspecialidad = new Button();
            btnEliminarEspecialidad = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvEspecialidades).BeginInit();
            SuspendLayout();
            // 
            // DgvEspecialidades
            // 
            DgvEspecialidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvEspecialidades.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvEspecialidades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvEspecialidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvEspecialidades.Columns.AddRange(new DataGridViewColumn[] { ID, Descripcion });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvEspecialidades.DefaultCellStyle = dataGridViewCellStyle2;
            DgvEspecialidades.GridColor = SystemColors.Control;
            DgvEspecialidades.Location = new Point(37, 104);
            DgvEspecialidades.Name = "DgvEspecialidades";
            DgvEspecialidades.ReadOnly = true;
            DgvEspecialidades.RowTemplate.Height = 25;
            DgvEspecialidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvEspecialidades.Size = new Size(860, 362);
            DgvEspecialidades.TabIndex = 0;
            // 
            // ID
            // 
            ID.FillWeight = 20F;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // btnAgregarEspecialidad
            // 
            btnAgregarEspecialidad.BackColor = SystemColors.Desktop;
            btnAgregarEspecialidad.FlatAppearance.BorderSize = 0;
            btnAgregarEspecialidad.FlatStyle = FlatStyle.Flat;
            btnAgregarEspecialidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarEspecialidad.ForeColor = SystemColors.ButtonHighlight;
            btnAgregarEspecialidad.Location = new Point(648, 472);
            btnAgregarEspecialidad.Name = "btnAgregarEspecialidad";
            btnAgregarEspecialidad.Size = new Size(132, 23);
            btnAgregarEspecialidad.TabIndex = 4;
            btnAgregarEspecialidad.Text = "Agregar especialidad";
            btnAgregarEspecialidad.UseVisualStyleBackColor = false;
            btnAgregarEspecialidad.Click += btnAgregarEspecialidad_Click;
            // 
            // btnEditarEspecialidad
            // 
            btnEditarEspecialidad.BackColor = Color.Green;
            btnEditarEspecialidad.FlatAppearance.BorderSize = 0;
            btnEditarEspecialidad.FlatStyle = FlatStyle.Flat;
            btnEditarEspecialidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditarEspecialidad.ForeColor = SystemColors.ButtonHighlight;
            btnEditarEspecialidad.Location = new Point(194, 472);
            btnEditarEspecialidad.Name = "btnEditarEspecialidad";
            btnEditarEspecialidad.Size = new Size(75, 23);
            btnEditarEspecialidad.TabIndex = 5;
            btnEditarEspecialidad.Text = "Editar";
            btnEditarEspecialidad.UseVisualStyleBackColor = false;
            btnEditarEspecialidad.Click += btnEditarEspecialidad_Click;
            // 
            // btnEliminarEspecialidad
            // 
            btnEliminarEspecialidad.BackColor = Color.FromArgb(192, 0, 0);
            btnEliminarEspecialidad.FlatAppearance.BorderSize = 0;
            btnEliminarEspecialidad.FlatStyle = FlatStyle.Flat;
            btnEliminarEspecialidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarEspecialidad.ForeColor = SystemColors.ButtonHighlight;
            btnEliminarEspecialidad.Location = new Point(291, 472);
            btnEliminarEspecialidad.Name = "btnEliminarEspecialidad";
            btnEliminarEspecialidad.Size = new Size(75, 23);
            btnEliminarEspecialidad.TabIndex = 6;
            btnEliminarEspecialidad.Text = "Eliminar";
            btnEliminarEspecialidad.UseVisualStyleBackColor = false;
            btnEliminarEspecialidad.Click += btnEliminarEspecialidad_Click;
            // 
            // FrmEspecialidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(985, 602);
            Controls.Add(btnEliminarEspecialidad);
            Controls.Add(btnEditarEspecialidad);
            Controls.Add(btnAgregarEspecialidad);
            Controls.Add(DgvEspecialidades);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEspecialidades";
            Text = "FrmEspecialidades";
            Load += FrmEspecialidades_Load;
            ((System.ComponentModel.ISupportInitialize)DgvEspecialidades).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvEspecialidades;
        private Button btnAgregarEspecialidad;
        private Button btnEditarEspecialidad;
        private Button btnEliminarEspecialidad;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Descripcion;
    }
}