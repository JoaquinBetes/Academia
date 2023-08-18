using static System.Net.Mime.MediaTypeNames;

namespace UI
{
    partial class FrmUsuario
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
            TipoUsuario = new Label();
            Legajo = new Label();
            SuspendLayout();
            // 
            // NombreUsuario
            // 
            NombreUsuario.AutoSize = true;
            NombreUsuario.BackColor = Color.Black;
            NombreUsuario.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            NombreUsuario.ForeColor = SystemColors.ControlLight;
            NombreUsuario.Location = new Point(37, 29);
            NombreUsuario.Name = "NombreUsuario";
            NombreUsuario.Size = new Size(77, 25);
            NombreUsuario.TabIndex = 5;
            NombreUsuario.Text = "Usuario";
            // 
            // Clave
            // 
            Clave.AutoSize = true;
            Clave.BackColor = Color.Black;
            Clave.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            Clave.ForeColor = SystemColors.ControlLight;
            Clave.Location = new Point(37, 145);
            Clave.Name = "Clave";
            Clave.Size = new Size(58, 25);
            Clave.TabIndex = 9;
            Clave.Text = "Clave";
            // 
            // TipoUsuario
            // 
            TipoUsuario.AutoSize = true;
            TipoUsuario.BackColor = Color.Black;
            TipoUsuario.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            TipoUsuario.ForeColor = SystemColors.ControlLight;
            TipoUsuario.Location = new Point(37, 82);
            TipoUsuario.Name = "TipoUsuario";
            TipoUsuario.Size = new Size(50, 25);
            TipoUsuario.TabIndex = 6;
            TipoUsuario.Text = "Tipo";
            // 
            // Legajo
            // 
            Legajo.AutoSize = true;
            Legajo.BackColor = Color.Black;
            Legajo.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            Legajo.ForeColor = SystemColors.ControlLight;
            Legajo.Location = new Point(31, 197);
            Legajo.Name = "Legajo";
            Legajo.Size = new Size(68, 25);
            Legajo.TabIndex = 10;
            Legajo.Text = "Legajo";
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 358);
            Controls.Add(Legajo);
            Controls.Add(Clave);
            Controls.Add(TipoUsuario);
            Controls.Add(NombreUsuario);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAgregarUsuario);
            Controls.Add(TxtClave);
            Controls.Add(TxtLegajo);
            Controls.Add(TxtNombreUsuario);
            Controls.Add(CmbTipoUsuario);
            Name = "FrmUsuario";
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
        private ComboBox CmbTipoUsuario;
        private Label Legajo;
        private TextBox TxtLegajo;
    }
}