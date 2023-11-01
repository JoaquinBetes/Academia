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
            txtId = new TextBox();
            btnArbol = new Button();
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
            DgvEspecialidades.Location = new Point(47, 59);
            DgvEspecialidades.Margin = new Padding(3, 4, 3, 4);
            DgvEspecialidades.Name = "DgvEspecialidades";
            DgvEspecialidades.ReadOnly = true;
            DgvEspecialidades.RowHeadersWidth = 51;
            DgvEspecialidades.RowTemplate.Height = 25;
            DgvEspecialidades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvEspecialidades.Size = new Size(983, 483);
            DgvEspecialidades.TabIndex = 0;
            // 
            // ID
            // 
            ID.FillWeight = 20F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
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
            btnAgregarEspecialidad.Location = new Point(746, 549);
            btnAgregarEspecialidad.Margin = new Padding(3, 4, 3, 4);
            btnAgregarEspecialidad.Name = "btnAgregarEspecialidad";
            btnAgregarEspecialidad.Size = new Size(151, 31);
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
            btnEditarEspecialidad.Location = new Point(227, 549);
            btnEditarEspecialidad.Margin = new Padding(3, 4, 3, 4);
            btnEditarEspecialidad.Name = "btnEditarEspecialidad";
            btnEditarEspecialidad.Size = new Size(86, 31);
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
            btnEliminarEspecialidad.Location = new Point(338, 549);
            btnEliminarEspecialidad.Margin = new Padding(3, 4, 3, 4);
            btnEliminarEspecialidad.Name = "btnEliminarEspecialidad";
            btnEliminarEspecialidad.Size = new Size(86, 31);
            btnEliminarEspecialidad.TabIndex = 6;
            btnEliminarEspecialidad.Text = "Eliminar";
            btnEliminarEspecialidad.UseVisualStyleBackColor = false;
            btnEliminarEspecialidad.Click += btnEliminarEspecialidad_Click;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtId.Location = new Point(568, 610);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(309, 32);
            txtId.TabIndex = 7;
            // 
            // btnArbol
            // 
            btnArbol.BackColor = SystemColors.Desktop;
            btnArbol.FlatAppearance.BorderSize = 0;
            btnArbol.FlatStyle = FlatStyle.Flat;
            btnArbol.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnArbol.ForeColor = SystemColors.ButtonHighlight;
            btnArbol.Location = new Point(899, 610);
            btnArbol.Margin = new Padding(3, 4, 3, 4);
            btnArbol.Name = "btnArbol";
            btnArbol.Size = new Size(151, 31);
            btnArbol.TabIndex = 8;
            btnArbol.Text = "Arbol";
            btnArbol.UseVisualStyleBackColor = false;
            btnArbol.Click += btnArbol_Click;
            // 
            // FrmEspecialidades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1126, 803);
            Controls.Add(btnArbol);
            Controls.Add(txtId);
            Controls.Add(btnEliminarEspecialidad);
            Controls.Add(btnEditarEspecialidad);
            Controls.Add(btnAgregarEspecialidad);
            Controls.Add(DgvEspecialidades);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmEspecialidades";
            Text = "FrmEspecialidades";
            Load += FrmEspecialidades_Load;
            ((System.ComponentModel.ISupportInitialize)DgvEspecialidades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvEspecialidades;
        private Button btnAgregarEspecialidad;
        private Button btnEditarEspecialidad;
        private Button btnEliminarEspecialidad;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Descripcion;
        private TextBox txtId;
        private Button btnArbol;
    }
}