namespace UIDesktop
{
    partial class FrmCursos
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
            DgvComisiones = new DataGridView();
            btnAgregarComision = new Button();
            btnEditarComision = new Button();
            btnEliminarComision = new Button();
            ID = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            AnioEspecialidad = new DataGridViewTextBoxColumn();
            IDPlan = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DgvComisiones).BeginInit();
            SuspendLayout();
            // 
            // DgvComisiones
            // 
            DgvComisiones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvComisiones.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvComisiones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvComisiones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvComisiones.Columns.AddRange(new DataGridViewColumn[] { ID, Descripcion, AnioEspecialidad, IDPlan });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvComisiones.DefaultCellStyle = dataGridViewCellStyle2;
            DgvComisiones.GridColor = SystemColors.Control;
            DgvComisiones.Location = new Point(37, 104);
            DgvComisiones.Name = "DgvComisiones";
            DgvComisiones.ReadOnly = true;
            DgvComisiones.RowTemplate.Height = 25;
            DgvComisiones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvComisiones.Size = new Size(860, 362);
            DgvComisiones.TabIndex = 0;
            // 
            // btnAgregarComision
            // 
            btnAgregarComision.BackColor = SystemColors.Desktop;
            btnAgregarComision.FlatAppearance.BorderSize = 0;
            btnAgregarComision.FlatStyle = FlatStyle.Flat;
            btnAgregarComision.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarComision.ForeColor = SystemColors.ButtonHighlight;
            btnAgregarComision.Location = new Point(648, 472);
            btnAgregarComision.Name = "btnAgregarComision";
            btnAgregarComision.Size = new Size(132, 23);
            btnAgregarComision.TabIndex = 4;
            btnAgregarComision.Text = "Agregar Comision";
            btnAgregarComision.UseVisualStyleBackColor = false;
            btnAgregarComision.Click += btnAgregarComision_Click;
            // 
            // btnEditarComision
            // 
            btnEditarComision.BackColor = Color.Green;
            btnEditarComision.FlatAppearance.BorderSize = 0;
            btnEditarComision.FlatStyle = FlatStyle.Flat;
            btnEditarComision.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditarComision.ForeColor = SystemColors.ButtonHighlight;
            btnEditarComision.Location = new Point(194, 472);
            btnEditarComision.Name = "btnEditarComision";
            btnEditarComision.Size = new Size(75, 23);
            btnEditarComision.TabIndex = 5;
            btnEditarComision.Text = "Editar";
            btnEditarComision.UseVisualStyleBackColor = false;
            btnEditarComision.Click += btnEditarComision_Click;
            // 
            // btnEliminarComision
            // 
            btnEliminarComision.BackColor = Color.FromArgb(192, 0, 0);
            btnEliminarComision.FlatAppearance.BorderSize = 0;
            btnEliminarComision.FlatStyle = FlatStyle.Flat;
            btnEliminarComision.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarComision.ForeColor = SystemColors.ButtonHighlight;
            btnEliminarComision.Location = new Point(291, 472);
            btnEliminarComision.Name = "btnEliminarComision";
            btnEliminarComision.Size = new Size(75, 23);
            btnEliminarComision.TabIndex = 6;
            btnEliminarComision.Text = "Eliminar";
            btnEliminarComision.UseVisualStyleBackColor = false;
            btnEliminarComision.Click += btnEliminarComision_Click;
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
            // AnioEspecialidad
            // 
            AnioEspecialidad.HeaderText = "AnioEspecialidad";
            AnioEspecialidad.Name = "AnioEspecialidad";
            AnioEspecialidad.ReadOnly = true;
            // 
            // IDPlan
            // 
            IDPlan.HeaderText = "IDPlan";
            IDPlan.Name = "IDPlan";
            IDPlan.ReadOnly = true;
            // 
            // FrmComisiones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(985, 602);
            Controls.Add(btnEliminarComision);
            Controls.Add(btnEditarComision);
            Controls.Add(btnAgregarComision);
            Controls.Add(DgvComisiones);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmComisiones";
            Text = "FrmPersonas";
            Load += FrmComisiones_Load;
            ((System.ComponentModel.ISupportInitialize)DgvComisiones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvComisiones;
        private Button btnAgregarComision;
        private Button btnEditarComision;
        private Button btnEliminarComision;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn AnioEspecialidad;
        private DataGridViewTextBoxColumn IDPlan;
    }
}