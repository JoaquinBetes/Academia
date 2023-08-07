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
            BtnAgregarPersona.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAgregarPersona.Location = new Point(12, 21);
            BtnAgregarPersona.Name = "BtnAgregarPersona";
            BtnAgregarPersona.Size = new Size(234, 45);
            BtnAgregarPersona.TabIndex = 0;
            BtnAgregarPersona.Text = "Agregar Persona";
            BtnAgregarPersona.UseVisualStyleBackColor = false;
            BtnAgregarPersona.Click += BtnAgregarPersona_Click;
            // 
            // DgvPersonas
            // 
            DgvPersonas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPersonas.BackgroundColor = Color.Black;
            DgvPersonas.ForeColor = Color.Black;
            DgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPersonas.Columns.AddRange(new DataGridViewColumn[] { DNI, Nombre, Apellido, Telefono, Direccion, Email, FechaNacimiento });
            DgvPersonas.GridColor = Color.Black;
            DgvPersonas.Location = new Point(12, 89);
            DgvPersonas.Name = "DgvPersonas";
            DgvPersonas.RowTemplate.Height = 31;
            DgvPersonas.Size = new Size(993, 349);
            DgvPersonas.TabIndex = 1;
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
            BtnAgregarUsuario.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAgregarUsuario.Location = new Point(771, 21);
            BtnAgregarUsuario.Name = "BtnAgregarUsuario";
            BtnAgregarUsuario.Size = new Size(234, 45);
            BtnAgregarUsuario.TabIndex = 3;
            BtnAgregarUsuario.Text = "Agregar Usuario";
            BtnAgregarUsuario.UseVisualStyleBackColor = false;
            BtnAgregarUsuario.Click += BtnAgregarUsuario_Click;
            // 
            // BtnBuscarPersona
            // 
            BtnBuscarPersona.BackColor = Color.Black;
            BtnBuscarPersona.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnBuscarPersona.Location = new Point(252, 21);
            BtnBuscarPersona.Name = "BtnBuscarPersona";
            BtnBuscarPersona.Size = new Size(234, 45);
            BtnBuscarPersona.TabIndex = 4;
            BtnBuscarPersona.Text = "Buscar Persona";
            BtnBuscarPersona.UseVisualStyleBackColor = false;
            BtnBuscarPersona.Click += BtnBuscarPersona_Click;
            // 
            // BtnBuscarUsuario
            // 
            BtnBuscarUsuario.BackColor = Color.Black;
            BtnBuscarUsuario.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnBuscarUsuario.Location = new Point(531, 21);
            BtnBuscarUsuario.Name = "BtnBuscarUsuario";
            BtnBuscarUsuario.Size = new Size(234, 45);
            BtnBuscarUsuario.TabIndex = 5;
            BtnBuscarUsuario.Text = "Buscar Usuario";
            BtnBuscarUsuario.UseVisualStyleBackColor = false;
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
            ForeColor = SystemColors.ButtonFace;
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