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
            BtnAgregarPersona = new Button();
            DgvPersonas = new DataGridView();
            DNI = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            FechaNacimiento = new DataGridViewTextBoxColumn();
            BtnAgregarUsuario = new Button();
            BtnBuscarPersona = new Button();
            BtnBuscarUsuario = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // BtnAgregarPersona
            // 
            BtnAgregarPersona.BackColor = Color.Black;
            BtnAgregarPersona.Cursor = Cursors.Hand;
            BtnAgregarPersona.FlatAppearance.BorderColor = Color.WhiteSmoke;
            BtnAgregarPersona.FlatAppearance.BorderSize = 2;
            BtnAgregarPersona.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 44, 44);
            BtnAgregarPersona.FlatStyle = FlatStyle.Flat;
            BtnAgregarPersona.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAgregarPersona.Location = new Point(13, 21);
            BtnAgregarPersona.Margin = new Padding(4, 2, 4, 2);
            BtnAgregarPersona.Name = "BtnAgregarPersona";
            BtnAgregarPersona.Size = new Size(234, 44);
            BtnAgregarPersona.TabIndex = 0;
            BtnAgregarPersona.Text = "Agregar Persona";
            BtnAgregarPersona.UseVisualStyleBackColor = false;
            BtnAgregarPersona.Click += BtnAgregarPersona_Click;
            // 
            // DgvPersonas
            // 
            DgvPersonas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPersonas.BackgroundColor = Color.Black;
            DgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPersonas.Columns.AddRange(new DataGridViewColumn[] { DNI, Nombre, Apellido, Telefono, Direccion, Email, FechaNacimiento });
            DgvPersonas.GridColor = Color.Black;
            DgvPersonas.Location = new Point(13, 89);
            DgvPersonas.Margin = new Padding(4, 2, 4, 2);
            DgvPersonas.Name = "DgvPersonas";
            DgvPersonas.RowTemplate.Height = 31;
            DgvPersonas.Size = new Size(994, 350);
            DgvPersonas.TabIndex = 1;
            DgvPersonas.ForeColor = Color.Black;
            // 
            // DNI
            // 
            DNI.Name = "DNI";
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
            Telefono.Name = "Telefono";
            // 
            // Direccion
            // 
            Direccion.Name = "Direccion";
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.Name = "FechaNacimiento";
            // 
            // BtnAgregarUsuario
            // 
            BtnAgregarUsuario.BackColor = Color.Black;
            BtnAgregarUsuario.Cursor = Cursors.Hand;
            BtnAgregarUsuario.FlatAppearance.BorderColor = Color.WhiteSmoke;
            BtnAgregarUsuario.FlatAppearance.BorderSize = 2;
            BtnAgregarUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 44, 44);
            BtnAgregarUsuario.FlatStyle = FlatStyle.Flat;
            BtnAgregarUsuario.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAgregarUsuario.Location = new Point(770, 21);
            BtnAgregarUsuario.Margin = new Padding(4, 2, 4, 2);
            BtnAgregarUsuario.Name = "BtnAgregarUsuario";
            BtnAgregarUsuario.Size = new Size(234, 44);
            BtnAgregarUsuario.TabIndex = 3;
            BtnAgregarUsuario.Text = "Agregar Usuario";
            BtnAgregarUsuario.UseVisualStyleBackColor = false;
            BtnAgregarUsuario.Click += BtnAgregarUsuario_Click;
            // 
            // BtnBuscarPersona
            // 
            BtnBuscarPersona.BackColor = Color.Black;
            BtnBuscarPersona.Cursor = Cursors.Hand;
            BtnBuscarPersona.FlatAppearance.BorderColor = Color.WhiteSmoke;
            BtnBuscarPersona.FlatAppearance.BorderSize = 2;
            BtnBuscarPersona.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 44, 44);
            BtnBuscarPersona.FlatStyle = FlatStyle.Flat;
            BtnBuscarPersona.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            BtnBuscarPersona.Location = new Point(252, 21);
            BtnBuscarPersona.Margin = new Padding(4, 2, 4, 2);
            BtnBuscarPersona.Name = "BtnBuscarPersona";
            BtnBuscarPersona.Size = new Size(234, 44);
            BtnBuscarPersona.TabIndex = 4;
            BtnBuscarPersona.Text = "Buscar Persona";
            BtnBuscarPersona.UseVisualStyleBackColor = false;
            BtnBuscarPersona.Click += BtnBuscarPersona_Click;
            // 
            // BtnBuscarUsuario
            // 
            BtnBuscarUsuario.BackColor = Color.Black;
            BtnBuscarUsuario.Cursor = Cursors.Hand;
            BtnBuscarUsuario.FlatAppearance.BorderColor = Color.WhiteSmoke;
            BtnBuscarUsuario.FlatAppearance.BorderSize = 2;
            BtnBuscarUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 44, 44);
            BtnBuscarUsuario.FlatStyle = FlatStyle.Flat;
            BtnBuscarUsuario.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            BtnBuscarUsuario.Location = new Point(531, 21);
            BtnBuscarUsuario.Margin = new Padding(4, 2, 4, 2);
            BtnBuscarUsuario.Name = "BtnBuscarUsuario";
            BtnBuscarUsuario.Size = new Size(234, 44);
            BtnBuscarUsuario.TabIndex = 5;
            BtnBuscarUsuario.Text = "Buscar Usuario";
            BtnBuscarUsuario.UseVisualStyleBackColor = false;
            BtnBuscarUsuario.Click += BtnBuscarUsuario_Click;
            // 
            // FrmPersonas
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1017, 450);
            Controls.Add(BtnBuscarUsuario);
            Controls.Add(BtnBuscarPersona);
            Controls.Add(BtnAgregarUsuario);
            Controls.Add(DgvPersonas);
            Controls.Add(BtnAgregarPersona);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonFace;
            Margin = new Padding(4, 2, 4, 2);
            Name = "FrmPersonas";
            Text = "Persona";
            ((System.ComponentModel.ISupportInitialize)DgvPersonas).EndInit();
            ResumeLayout(false);
        }

        #endregion


        private Button BtnAgregarPersona;
        private DataGridView DgvPersonas;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn FechaNacimiento;
        private Button BtnAgregarUsuario;
        private Button BtnBuscarPersona;
        private Button BtnBuscarUsuario;
    }
}