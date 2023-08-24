namespace UIDekptop
{
    partial class FrmUsuarios
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
            btnEliminarUsuario = new Button();
            btnEditarUsuario = new Button();
            btnAgregarUsuario = new Button();
            DgvUsuarios = new DataGridView();
            Legajo = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            Clave = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            TxtBuscarUsuarioDni = new TextBox();
            label1 = new Label();
            btnBuscarPorDni = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.BackColor = Color.FromArgb(192, 0, 0);
            btnEliminarUsuario.FlatAppearance.BorderSize = 0;
            btnEliminarUsuario.FlatStyle = FlatStyle.Flat;
            btnEliminarUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarUsuario.ForeColor = SystemColors.ButtonHighlight;
            btnEliminarUsuario.Location = new Point(326, 482);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(75, 23);
            btnEliminarUsuario.TabIndex = 10;
            btnEliminarUsuario.Text = "Eliminar";
            btnEliminarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.BackColor = Color.Green;
            btnEditarUsuario.FlatAppearance.BorderSize = 0;
            btnEditarUsuario.FlatStyle = FlatStyle.Flat;
            btnEditarUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditarUsuario.ForeColor = SystemColors.ButtonHighlight;
            btnEditarUsuario.Location = new Point(229, 482);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Size = new Size(75, 23);
            btnEditarUsuario.TabIndex = 9;
            btnEditarUsuario.Text = "Editar";
            btnEditarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.BackColor = SystemColors.Desktop;
            btnAgregarUsuario.FlatAppearance.BorderSize = 0;
            btnAgregarUsuario.FlatStyle = FlatStyle.Flat;
            btnAgregarUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarUsuario.ForeColor = SystemColors.ButtonHighlight;
            btnAgregarUsuario.Location = new Point(683, 482);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(132, 23);
            btnAgregarUsuario.TabIndex = 8;
            btnAgregarUsuario.Text = "Agregar usuario";
            btnAgregarUsuario.UseVisualStyleBackColor = false;
            // 
            // DgvUsuarios
            // 
            DgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvUsuarios.BackgroundColor = SystemColors.ButtonHighlight;
            DgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { Legajo, Usuario, Clave, Tipo });
            DgvUsuarios.GridColor = SystemColors.Control;
            DgvUsuarios.Location = new Point(72, 114);
            DgvUsuarios.Name = "DgvUsuarios";
            DgvUsuarios.ReadOnly = true;
            DgvUsuarios.RowTemplate.Height = 25;
            DgvUsuarios.Size = new Size(860, 362);
            DgvUsuarios.TabIndex = 7;
            // 
            // Legajo
            // 
            Legajo.HeaderText = "Legajo";
            Legajo.Name = "Legajo";
            Legajo.ReadOnly = true;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.Name = "Usuario";
            Usuario.ReadOnly = true;
            // 
            // Clave
            // 
            Clave.HeaderText = "Clave";
            Clave.Name = "Clave";
            Clave.ReadOnly = true;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            // 
            // TxtBuscarUsuarioDni
            // 
            TxtBuscarUsuarioDni.Location = new Point(72, 64);
            TxtBuscarUsuarioDni.Name = "TxtBuscarUsuarioDni";
            TxtBuscarUsuarioDni.Size = new Size(156, 23);
            TxtBuscarUsuarioDni.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 46);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 12;
            label1.Text = "Buscar por DNI";
            // 
            // btnBuscarPorDni
            // 
            btnBuscarPorDni.BackColor = SystemColors.MenuHighlight;
            btnBuscarPorDni.FlatAppearance.BorderSize = 0;
            btnBuscarPorDni.FlatStyle = FlatStyle.Flat;
            btnBuscarPorDni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarPorDni.ForeColor = SystemColors.ButtonHighlight;
            btnBuscarPorDni.Location = new Point(257, 64);
            btnBuscarPorDni.Name = "btnBuscarPorDni";
            btnBuscarPorDni.Size = new Size(75, 23);
            btnBuscarPorDni.TabIndex = 13;
            btnBuscarPorDni.Text = "Buscar";
            btnBuscarPorDni.UseVisualStyleBackColor = false;
            btnBuscarPorDni.Click += btnBuscarPorDni_Click;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 618);
            Controls.Add(btnBuscarPorDni);
            Controls.Add(label1);
            Controls.Add(TxtBuscarUsuarioDni);
            Controls.Add(btnEliminarUsuario);
            Controls.Add(btnEditarUsuario);
            Controls.Add(btnAgregarUsuario);
            Controls.Add(DgvUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuarios";
            Text = "FrmUsuarios";
            ((System.ComponentModel.ISupportInitialize)DgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminarUsuario;
        private Button btnEditarUsuario;
        private Button btnAgregarUsuario;
        private DataGridView DgvUsuarios;
        private DataGridViewTextBoxColumn Legajo;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Clave;
        private DataGridViewTextBoxColumn Tipo;
        private TextBox TxtBuscarUsuarioDni;
        private Label label1;
        private Button btnBuscarPorDni;
    }
}