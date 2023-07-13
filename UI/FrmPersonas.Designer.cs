namespace UI
{
    partial class FrmPersonas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnAgregarUsuarios = new Button();
            DgvUsuarios = new DataGridView();
            Usuario = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // BtnAgregarUsuarios
            // 
            BtnAgregarUsuarios.BackColor = Color.Black;
            BtnAgregarUsuarios.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAgregarUsuarios.Location = new Point(12, 21);
            BtnAgregarUsuarios.Name = "BtnAgregarUsuarios";
            BtnAgregarUsuarios.Size = new Size(234, 45);
            BtnAgregarUsuarios.TabIndex = 0;
            BtnAgregarUsuarios.Text = "Agregar Usuario";
            BtnAgregarUsuarios.UseVisualStyleBackColor = false;
            BtnAgregarUsuarios.Click += BtnAgregarUsuarios_Click;
            // 
            // DgvUsuarios
            // 
            DgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvUsuarios.BackgroundColor = Color.Black;
            DgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { Usuario, Nombre, Apellido, Email });
            DgvUsuarios.GridColor = Color.Black;
            DgvUsuarios.Location = new Point(12, 89);
            DgvUsuarios.Name = "DgvUsuarios";
            DgvUsuarios.RowTemplate.Height = 31;
            DgvUsuarios.Size = new Size(776, 349);
            DgvUsuarios.TabIndex = 1;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.Name = "Usuario";
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
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(DgvUsuarios);
            Controls.Add(BtnAgregarUsuarios);
            ForeColor = SystemColors.ButtonFace;
            Name = "FrmUsuarios";
            Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)DgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnAgregarUsuarios;
        private DataGridView DgvUsuarios;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Email;
    }
}