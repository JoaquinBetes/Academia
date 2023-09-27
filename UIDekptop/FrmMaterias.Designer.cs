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
            DgvPlanes = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Especialidad = new DataGridViewTextBoxColumn();
            btnAgregarPlan = new Button();
            btnEditarPlan = new Button();
            btnEliminarPlan = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvPlanes).BeginInit();
            SuspendLayout();
            // 
            // DgvPlanes
            // 
            DgvPlanes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPlanes.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvPlanes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvPlanes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPlanes.Columns.AddRange(new DataGridViewColumn[] { ID, Descripcion, Especialidad });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvPlanes.DefaultCellStyle = dataGridViewCellStyle2;
            DgvPlanes.GridColor = SystemColors.Control;
            DgvPlanes.Location = new Point(37, 104);
            DgvPlanes.Name = "DgvPlanes";
            DgvPlanes.ReadOnly = true;
            DgvPlanes.RowTemplate.Height = 25;
            DgvPlanes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvPlanes.Size = new Size(860, 362);
            DgvPlanes.TabIndex = 0;
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
            // Especialidad
            // 
            Especialidad.HeaderText = "Especialidad";
            Especialidad.Name = "Especialidad";
            Especialidad.ReadOnly = true;
            // 
            // btnAgregarPlan
            // 
            btnAgregarPlan.BackColor = SystemColors.Desktop;
            btnAgregarPlan.FlatAppearance.BorderSize = 0;
            btnAgregarPlan.FlatStyle = FlatStyle.Flat;
            btnAgregarPlan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarPlan.ForeColor = SystemColors.ButtonHighlight;
            btnAgregarPlan.Location = new Point(648, 472);
            btnAgregarPlan.Name = "btnAgregarPlan";
            btnAgregarPlan.Size = new Size(132, 23);
            btnAgregarPlan.TabIndex = 4;
            btnAgregarPlan.Text = "Agregar Plan";
            btnAgregarPlan.UseVisualStyleBackColor = false;
            btnAgregarPlan.Click += btnAgregarPlan_Click;
            // 
            // btnEditarPlan
            // 
            btnEditarPlan.BackColor = Color.Green;
            btnEditarPlan.FlatAppearance.BorderSize = 0;
            btnEditarPlan.FlatStyle = FlatStyle.Flat;
            btnEditarPlan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditarPlan.ForeColor = SystemColors.ButtonHighlight;
            btnEditarPlan.Location = new Point(194, 472);
            btnEditarPlan.Name = "btnEditarPlan";
            btnEditarPlan.Size = new Size(75, 23);
            btnEditarPlan.TabIndex = 5;
            btnEditarPlan.Text = "Editar";
            btnEditarPlan.UseVisualStyleBackColor = false;
            btnEditarPlan.Click += btnEditarPlan_Click;
            // 
            // btnEliminarPlan
            // 
            btnEliminarPlan.BackColor = Color.FromArgb(192, 0, 0);
            btnEliminarPlan.FlatAppearance.BorderSize = 0;
            btnEliminarPlan.FlatStyle = FlatStyle.Flat;
            btnEliminarPlan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarPlan.ForeColor = SystemColors.ButtonHighlight;
            btnEliminarPlan.Location = new Point(291, 472);
            btnEliminarPlan.Name = "btnEliminarPlan";
            btnEliminarPlan.Size = new Size(75, 23);
            btnEliminarPlan.TabIndex = 6;
            btnEliminarPlan.Text = "Eliminar";
            btnEliminarPlan.UseVisualStyleBackColor = false;
            btnEliminarPlan.Click += btnEliminarPlan_Click;
            // 
            // FrmPlanes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(985, 602);
            Controls.Add(btnEliminarPlan);
            Controls.Add(btnEditarPlan);
            Controls.Add(btnAgregarPlan);
            Controls.Add(DgvPlanes);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMaterias";
            Text = "MAterias";
            Load += FrmPlanes_Load;
            ((System.ComponentModel.ISupportInitialize)DgvPlanes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvPlanes;
        private Button btnAgregarPlan;
        private Button btnEditarPlan;
        private Button btnEliminarPlan;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Especialidad;
    }
}