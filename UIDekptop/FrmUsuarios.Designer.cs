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
            TxtBuscarLegajo = new TextBox();
            LblBuscarLegajo = new Label();
            btnBuscarPorLegajo = new Button();
            btnInforme = new Button();
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
            btnEliminarUsuario.Location = new Point(372, 643);
            btnEliminarUsuario.Margin = new Padding(4);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(85, 30);
            btnEliminarUsuario.TabIndex = 10;
            btnEliminarUsuario.Text = "Eliminar";
            btnEliminarUsuario.UseVisualStyleBackColor = false;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.BackColor = Color.Green;
            btnEditarUsuario.FlatAppearance.BorderSize = 0;
            btnEditarUsuario.FlatStyle = FlatStyle.Flat;
            btnEditarUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditarUsuario.ForeColor = SystemColors.ButtonHighlight;
            btnEditarUsuario.Location = new Point(261, 643);
            btnEditarUsuario.Margin = new Padding(4);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Size = new Size(85, 30);
            btnEditarUsuario.TabIndex = 9;
            btnEditarUsuario.Text = "Editar";
            btnEditarUsuario.UseVisualStyleBackColor = false;
            btnEditarUsuario.Click += btnEditarUsuario_Click;
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.BackColor = SystemColors.Desktop;
            btnAgregarUsuario.FlatAppearance.BorderSize = 0;
            btnAgregarUsuario.FlatStyle = FlatStyle.Flat;
            btnAgregarUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarUsuario.ForeColor = SystemColors.ButtonHighlight;
            btnAgregarUsuario.Location = new Point(780, 643);
            btnAgregarUsuario.Margin = new Padding(4);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(151, 30);
            btnAgregarUsuario.TabIndex = 8;
            btnAgregarUsuario.Text = "Agregar usuario";
            btnAgregarUsuario.UseVisualStyleBackColor = false;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // DgvUsuarios
            // 
            DgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvUsuarios.BackgroundColor = SystemColors.ButtonHighlight;
            DgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { Legajo, Usuario, Clave, Tipo });
            DgvUsuarios.GridColor = SystemColors.Control;
            DgvUsuarios.Location = new Point(83, 152);
            DgvUsuarios.Margin = new Padding(4);
            DgvUsuarios.Name = "DgvUsuarios";
            DgvUsuarios.ReadOnly = true;
            DgvUsuarios.RowHeadersWidth = 51;
            DgvUsuarios.RowTemplate.Height = 25;
            DgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvUsuarios.Size = new Size(983, 483);
            DgvUsuarios.TabIndex = 7;
            // 
            // Legajo
            // 
            Legajo.HeaderText = "Legajo";
            Legajo.MinimumWidth = 6;
            Legajo.Name = "Legajo";
            Legajo.ReadOnly = true;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.MinimumWidth = 6;
            Usuario.Name = "Usuario";
            Usuario.ReadOnly = true;
            // 
            // Clave
            // 
            Clave.HeaderText = "Clave";
            Clave.MinimumWidth = 6;
            Clave.Name = "Clave";
            Clave.ReadOnly = true;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.MinimumWidth = 6;
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            // 
            // TxtBuscarLegajo
            // 
            TxtBuscarLegajo.Location = new Point(83, 86);
            TxtBuscarLegajo.Margin = new Padding(4);
            TxtBuscarLegajo.Name = "TxtBuscarLegajo";
            TxtBuscarLegajo.Size = new Size(177, 27);
            TxtBuscarLegajo.TabIndex = 11;
            // 
            // LblBuscarLegajo
            // 
            LblBuscarLegajo.AutoSize = true;
            LblBuscarLegajo.Location = new Point(83, 61);
            LblBuscarLegajo.Margin = new Padding(4, 0, 4, 0);
            LblBuscarLegajo.Name = "LblBuscarLegajo";
            LblBuscarLegajo.Size = new Size(128, 20);
            LblBuscarLegajo.TabIndex = 12;
            LblBuscarLegajo.Text = "Buscar por Legajo";
            // 
            // btnBuscarPorLegajo
            // 
            btnBuscarPorLegajo.BackColor = SystemColors.MenuHighlight;
            btnBuscarPorLegajo.FlatAppearance.BorderSize = 0;
            btnBuscarPorLegajo.FlatStyle = FlatStyle.Flat;
            btnBuscarPorLegajo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarPorLegajo.ForeColor = SystemColors.ButtonHighlight;
            btnBuscarPorLegajo.Location = new Point(293, 86);
            btnBuscarPorLegajo.Margin = new Padding(4);
            btnBuscarPorLegajo.Name = "btnBuscarPorLegajo";
            btnBuscarPorLegajo.Size = new Size(85, 30);
            btnBuscarPorLegajo.TabIndex = 13;
            btnBuscarPorLegajo.Text = "Buscar";
            btnBuscarPorLegajo.UseVisualStyleBackColor = false;
            btnBuscarPorLegajo.Click += btnBuscarPorLegajo_Click;
            // 
            // btnInforme
            // 
            btnInforme.BackColor = SystemColors.MenuHighlight;
            btnInforme.FlatAppearance.BorderSize = 0;
            btnInforme.FlatStyle = FlatStyle.Flat;
            btnInforme.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInforme.ForeColor = SystemColors.ButtonHighlight;
            btnInforme.Location = new Point(890, 86);
            btnInforme.Margin = new Padding(4);
            btnInforme.Name = "btnInforme";
            btnInforme.Size = new Size(190, 30);
            btnInforme.TabIndex = 14;
            btnInforme.Text = "Informe Usuarios";
            btnInforme.UseVisualStyleBackColor = false;
            btnInforme.Click += btnInforme_Click;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 824);
            Controls.Add(btnInforme);
            Controls.Add(btnBuscarPorLegajo);
            Controls.Add(LblBuscarLegajo);
            Controls.Add(TxtBuscarLegajo);
            Controls.Add(btnEliminarUsuario);
            Controls.Add(btnEditarUsuario);
            Controls.Add(btnAgregarUsuario);
            Controls.Add(DgvUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmUsuarios";
            Text = "FrmUsuarios";
            Load += FrmUsuarios_Load;
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
        private TextBox TxtBuscarLegajo;
        private Label LblBuscarLegajo;
        private Button btnBuscarPorLegajo;
        private Button btnInforme;
    }
}