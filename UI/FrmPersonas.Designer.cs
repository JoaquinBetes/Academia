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
            BtnAgregarPersona.Click += BtnAgregarUsuarios_Click;
            // 
            // DgvPersonas
            // 
            DgvPersonas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvPersonas.BackgroundColor = Color.Black;
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
            // FrmPersonas
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1017, 450);
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
    }
}