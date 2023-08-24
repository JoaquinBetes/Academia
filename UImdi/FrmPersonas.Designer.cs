namespace UImdi
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
            DgvPersonas = new DataGridView();
            id_persona = new DataGridViewTextBoxColumn();
            dni_persona = new DataGridViewTextBoxColumn();
            nombre_persona = new DataGridViewTextBoxColumn();
            apellido_persona = new DataGridViewTextBoxColumn();
            telefono_persona = new DataGridViewTextBoxColumn();
            direccion_persona = new DataGridViewTextBoxColumn();
            email_persona = new DataGridViewTextBoxColumn();
            fecha_nac_persona = new DataGridViewTextBoxColumn();
            txtBuscarPorDni = new TextBox();
            label1 = new Label();
            btnBuscarPorDni = new Button();
            btnAgregarPersona = new Button();
            btnEditarPersona = new Button();
            btnEliminarPersona = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // DgvPersonas
            // 
            DgvPersonas.AllowUserToOrderColumns = true;
            DgvPersonas.BackgroundColor = SystemColors.ButtonHighlight;
            DgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPersonas.Columns.AddRange(new DataGridViewColumn[] { id_persona, dni_persona, nombre_persona, apellido_persona, telefono_persona, direccion_persona, email_persona, fecha_nac_persona });
            DgvPersonas.GridColor = SystemColors.Control;
            DgvPersonas.Location = new Point(37, 104);
            DgvPersonas.Name = "DgvPersonas";
            DgvPersonas.RowTemplate.Height = 25;
            DgvPersonas.Size = new Size(844, 362);
            DgvPersonas.TabIndex = 0;
            // 
            // id_persona
            // 
            id_persona.HeaderText = "ID";
            id_persona.Name = "id_persona";
            // 
            // dni_persona
            // 
            dni_persona.HeaderText = "DNI";
            dni_persona.Name = "dni_persona";
            // 
            // nombre_persona
            // 
            nombre_persona.HeaderText = "Nombre";
            nombre_persona.Name = "nombre_persona";
            // 
            // apellido_persona
            // 
            apellido_persona.HeaderText = "Apellido";
            apellido_persona.Name = "apellido_persona";
            // 
            // telefono_persona
            // 
            telefono_persona.HeaderText = "Telefono";
            telefono_persona.Name = "telefono_persona";
            // 
            // direccion_persona
            // 
            direccion_persona.HeaderText = "Direccion";
            direccion_persona.Name = "direccion_persona";
            // 
            // email_persona
            // 
            email_persona.HeaderText = "Email";
            email_persona.Name = "email_persona";
            // 
            // fecha_nac_persona
            // 
            fecha_nac_persona.HeaderText = "Fecha de nacimiento";
            fecha_nac_persona.Name = "fecha_nac_persona";
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
            // 
            // btnAgregarPersona
            // 
            btnAgregarPersona.BackColor = SystemColors.Desktop;
            btnAgregarPersona.FlatAppearance.BorderSize = 0;
            btnAgregarPersona.FlatStyle = FlatStyle.Flat;
            btnAgregarPersona.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarPersona.ForeColor = SystemColors.ButtonHighlight;
            btnAgregarPersona.Location = new Point(749, 472);
            btnAgregarPersona.Name = "btnAgregarPersona";
            btnAgregarPersona.Size = new Size(132, 23);
            btnAgregarPersona.TabIndex = 4;
            btnAgregarPersona.Text = "Agregar persona";
            btnAgregarPersona.UseVisualStyleBackColor = false;
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
            // 
            // FrmPersonas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(985, 602);
            Controls.Add(btnEliminarPersona);
            Controls.Add(btnEditarPersona);
            Controls.Add(btnAgregarPersona);
            Controls.Add(btnBuscarPorDni);
            Controls.Add(label1);
            Controls.Add(txtBuscarPorDni);
            Controls.Add(DgvPersonas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPersonas";
            Text = "FrmPersonas";
            ((System.ComponentModel.ISupportInitialize)DgvPersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvPersonas;
        private DataGridViewTextBoxColumn id_persona;
        private DataGridViewTextBoxColumn dni_persona;
        private DataGridViewTextBoxColumn nombre_persona;
        private DataGridViewTextBoxColumn apellido_persona;
        private DataGridViewTextBoxColumn telefono_persona;
        private DataGridViewTextBoxColumn direccion_persona;
        private DataGridViewTextBoxColumn email_persona;
        private DataGridViewTextBoxColumn fecha_nac_persona;
        private TextBox txtBuscarPorDni;
        private Label label1;
        private Button btnBuscarPorDni;
        private Button btnAgregarPersona;
        private Button btnEditarPersona;
        private Button btnEliminarPersona;
    }
}