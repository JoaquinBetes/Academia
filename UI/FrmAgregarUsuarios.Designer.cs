﻿namespace UI
{
    partial class FrmAgregarUsuarios
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

            NombreUsuario = new Label();
            Clave = new Label();
            BtnAgregarUsuario = new Button();
            TipoUsuario = new Label();
            
            SuspendLayout();

            // 
            // NombreUsuario
            // 
            NombreUsuario.AutoSize = true;
            NombreUsuario.BackColor = Color.Black;
            NombreUsuario.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            NombreUsuario.ForeColor = SystemColors.ControlLight;
            NombreUsuario.Location = new Point(37, 29);
            NombreUsuario.Name = "NombreUsuario";
            NombreUsuario.Size = new Size(81, 25);
            NombreUsuario.TabIndex = 5;
            NombreUsuario.Text = "Usuario";
            // 
            // Clave
            // 
            Clave.AutoSize = true;
            Clave.BackColor = Color.Black;
            Clave.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            Clave.ForeColor = SystemColors.ControlLight;
            Clave.Location = new Point(37, 145);
            Clave.Name = "Clave";
            Clave.Size = new Size(59, 25);
            Clave.TabIndex = 9;
            Clave.Text = "Clave";
            // 
            // BtnAgregarUsuario
            // 
            BtnAgregarUsuario.BackColor = Color.Black;
            BtnAgregarUsuario.Cursor = Cursors.Hand;
            BtnAgregarUsuario.FlatAppearance.BorderColor = Color.WhiteSmoke;
            BtnAgregarUsuario.FlatAppearance.BorderSize = 2;
            BtnAgregarUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 44, 44);
            BtnAgregarUsuario.FlatStyle = FlatStyle.Flat;
            BtnAgregarUsuario.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAgregarUsuario.ForeColor = Color.WhiteSmoke;
            BtnAgregarUsuario.Location = new Point(145, 228);
            BtnAgregarUsuario.Name = "BtnAgregarUsuario";
            BtnAgregarUsuario.Size = new Size(184, 57);
            BtnAgregarUsuario.TabIndex = 10;
            BtnAgregarUsuario.Text = "Agregar";
            BtnAgregarUsuario.UseVisualStyleBackColor = false;
            BtnAgregarUsuario.Click += BtnAgregarUsuario_Click;
            // 
            // TipoUsuario
            // 
            TipoUsuario.AutoSize = true;
            TipoUsuario.BackColor = Color.Black;
            TipoUsuario.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            TipoUsuario.ForeColor = SystemColors.ControlLight;
            TipoUsuario.Location = new Point(37, 84);
            TipoUsuario.Name = "TipoUsuario";
            TipoUsuario.Size = new Size(52, 25);
            TipoUsuario.TabIndex = 6;
            TipoUsuario.Text = "Tipo";
            // 
            // FrmAgregarUsuarios
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 329);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAgregarUsuario);
            Controls.Add(Clave);
            Controls.Add(TipoUsuario);
            Controls.Add(NombreUsuario);
            Controls.Add(TxtClave);
            Controls.Add(TxtTipoUsuario);
            Controls.Add(TxtNombreUsuario);
            Name = "FrmAgregarUsuarios";
            Text = "Agregar usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtNombreUsuario;
        private TextBox TxtClave;
        private Label NombreUsuario;
        private Label Clave;
        private Button BtnAgregarUsuario;
        private Button BtnCancelar;
        private Label TipoUsuario;
        private TextBox TxtTipoUsuario;
    }
}