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
            DgvPersonas = new DataGridView();
            DNI = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            FechaNacimiento = new DataGridViewTextBoxColumn();
            btnBuscarPorDni = new Button();
            btnAgregarPersona = new Button();
            btnEditarPersona = new Button();
            btnEliminarPersona = new Button();
            txtBuscarPorDni = new TextBox();
            label1 = new Label();

            ((System.ComponentModel.ISupportInitialize)DgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // btnBuscarPorDni
            // 
            btnBuscarPorDni.BackColor = SystemColors.MenuHighlight;
            btnBuscarPorDni.FlatAppearance.BorderSize = 0;
            btnBuscarPorDni.FlatStyle = FlatStyle.Flat;
            btnBuscarPorDni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarPorDni.ForeColor = SystemColors.ButtonHighlight;
            btnBuscarPorDni.Location = new Point(194, 59);
            btnBuscarPorDni.Name = "btnBuscarPorDni";
            btnBuscarPorDni.Size = new Size(75, 23);
            btnBuscarPorDni.TabIndex = 3;
            btnBuscarPorDni.Text = "Buscar";
            btnBuscarPorDni.UseVisualStyleBackColor = false;
            btnBuscarPorDni.Click += btnBuscarPorDni_Click;
            // 
            // btnAgregarPersona
            // 
            btnAgregarPersona.BackColor = SystemColors.Desktop;
            btnAgregarPersona.FlatAppearance.BorderSize = 0;
            btnAgregarPersona.FlatStyle = FlatStyle.Flat;
            btnAgregarPersona.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarPersona.ForeColor = SystemColors.ButtonHighlight;
            btnAgregarPersona.Location = new Point(648, 472);
            btnAgregarPersona.Name = "btnAgregarPersona";
            btnAgregarPersona.Size = new Size(132, 23);
            btnAgregarPersona.TabIndex = 4;
            btnAgregarPersona.Text = "Agregar persona";
            btnAgregarPersona.UseVisualStyleBackColor = false;
            btnAgregarPersona.Click += btnAgregarPersona_Click;
            // 
            // btnEditarPersona
            // 
            btnEditarPersona.BackColor = Color.Green;
            btnEditarPersona.FlatAppearance.BorderSize = 0;
            btnEditarPersona.FlatStyle = FlatStyle.Flat;
            btnEditarPersona.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditarPersona.ForeColor = SystemColors.ButtonHighlight;
            btnEditarPersona.Location = new Point(194, 472);
            btnEditarPersona.Name = "btnEditarPersona";
            btnEditarPersona.Size = new Size(75, 23);
            btnEditarPersona.TabIndex = 5;
            btnEditarPersona.Text = "Editar";
            btnEditarPersona.UseVisualStyleBackColor = false;
            btnEditarPersona.Click += btnEditarPersona_Click;
            // 
            // btnEliminarPersona
            // 
            btnEliminarPersona.BackColor = Color.FromArgb(192, 0, 0);
            btnEliminarPersona.FlatAppearance.BorderSize = 0;
            btnEliminarPersona.FlatStyle = FlatStyle.Flat;
            btnEliminarPersona.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarPersona.ForeColor = SystemColors.ButtonHighlight;
            btnEliminarPersona.Location = new Point(291, 472);
            btnEliminarPersona.Name = "btnEliminarPersona";
            btnEliminarPersona.Size = new Size(75, 23);
            btnEliminarPersona.TabIndex = 6;
            btnEliminarPersona.Text = "Eliminar";
            btnEliminarPersona.UseVisualStyleBackColor = false;
            btnEliminarPersona.Click += btnEliminarPersona_Click;
            // 
            // txtBuscarPorDni
            // 
            txtBuscarPorDni.BackColor = Color.White;
            txtBuscarPorDni.Location = new Point(37, 59);
            txtBuscarPorDni.Name = "txtBuscarPorDni";
            txtBuscarPorDni.Size = new Size(126, 23);
            txtBuscarPorDni.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 41);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 2;
            label1.Text = "Buscar por DNI";
            // 
            // DgvPersonas
            // 
            DgvPersonas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPersonas.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvPersonas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPersonas.Columns.AddRange(new DataGridViewColumn[] { DNI, Nombre, Apellido, Telefono, Direccion, Email, FechaNacimiento });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvPersonas.DefaultCellStyle = dataGridViewCellStyle2;
            DgvPersonas.GridColor = SystemColors.Control;
            DgvPersonas.Location = new Point(37, 104);
            DgvPersonas.Name = "DgvPersonas";
            DgvPersonas.ReadOnly = true;
            DgvPersonas.RowTemplate.Height = 25;
            DgvPersonas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvPersonas.Size = new Size(860, 362);
            DgvPersonas.TabIndex = 0;
            // 
            // DNI
            // 
            DNI.HeaderText = "DNI";
            DNI.Name = "DNI";
            DNI.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.HeaderText = "Fecha de nacimiento";
            FechaNacimiento.Name = "FechaNacimiento";
            FechaNacimiento.ReadOnly = true;
            // 
            // FrmPersonas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(985, 602);
            Controls.Add(btnBuscarPorDni);
            Controls.Add(label1);
            Controls.Add(txtBuscarPorDni);
            Controls.Add(btnAgregarPersona);
            Controls.Add(btnEditarPersona);
            Controls.Add(btnEliminarPersona);
            Controls.Add(DgvPersonas);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPersonas";
            Text = "FrmPersonas";
            Load += FrmPersonas_Load;
            ((System.ComponentModel.ISupportInitialize)DgvPersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvPersonas;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn FechaNacimiento;
    }
}