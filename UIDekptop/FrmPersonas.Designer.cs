namespace UIDesktop
{
    partial class FrmPersonas
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
            DgvPersonas = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            FechaNacimiento = new DataGridViewTextBoxColumn();
            IdPlan = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // DgvPersonas
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvPersonas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPersonas.Columns.AddRange(new DataGridViewColumn[] { id, Nombre, Apellido, Telefono, Direccion, Email, FechaNacimiento, IdPlan });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvPersonas.DefaultCellStyle = dataGridViewCellStyle2;
            DgvPersonas.Location = new Point(42, 131);
            DgvPersonas.Name = "DgvPersonas";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DgvPersonas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DgvPersonas.RowTemplate.Height = 25;
            DgvPersonas.Size = new Size(843, 341);
            DgvPersonas.TabIndex = 0;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.HeaderText = "Fecha Nacimiento";
            FechaNacimiento.Name = "FechaNacimiento";
            // 
            // IdPlan
            // 
            IdPlan.HeaderText = "ID Plan";
            IdPlan.Name = "IdPlan";
            // 
            // FrmPersonas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(985, 602);
            Controls.Add(DgvPersonas);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPersonas";
            Text = "FrmPersonas";
            Load += FrmPersonas_Load;
            ((System.ComponentModel.ISupportInitialize)DgvPersonas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvPersonas;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn FechaNacimiento;
        private DataGridViewTextBoxColumn IdPlan;
    }
}