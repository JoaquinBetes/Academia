namespace UI
{
    partial class FrmIngresoLegajo
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
            LblLegajoUsuario = new Label();
            TxtUsuarioLegajo = new TextBox();
            BtnBuscarLegajo = new Button();
            SuspendLayout();
            // 
            // LblLegajoUsuario
            // 
            LblLegajoUsuario.AutoSize = true;
            LblLegajoUsuario.BackColor = Color.Black;
            LblLegajoUsuario.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            LblLegajoUsuario.ForeColor = SystemColors.ControlLight;
            LblLegajoUsuario.Location = new Point(47, 37);
            LblLegajoUsuario.Name = "LblLegajoUsuario";
            LblLegajoUsuario.Size = new Size(147, 25);
            LblLegajoUsuario.TabIndex = 10;
            LblLegajoUsuario.Text = "Ingrese Legajo:";
            // 
            // TxtUsuarioLegajo
            // 
            TxtUsuarioLegajo.BackColor = SystemColors.ActiveCaptionText;
            TxtUsuarioLegajo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxtUsuarioLegajo.ForeColor = Color.WhiteSmoke;
            TxtUsuarioLegajo.Location = new Point(202, 37);
            TxtUsuarioLegajo.MaxLength = 8;
            TxtUsuarioLegajo.Name = "TxtUsuarioLegajo";
            TxtUsuarioLegajo.Size = new Size(375, 32);
            TxtUsuarioLegajo.TabIndex = 9;
            TxtUsuarioLegajo.KeyPress += TxtUsuarioLegajo_KeyPress;
            TxtUsuarioLegajo.TextChanged += TxtUsuarioLegajo_TextChanged;
            // 
            // BtnBuscarLegajo
            // 
            BtnBuscarLegajo.BackColor = Color.FromArgb(34, 34, 34);
            BtnBuscarLegajo.Enabled = false;
            BtnBuscarLegajo.FlatAppearance.BorderColor = Color.WhiteSmoke;
            BtnBuscarLegajo.FlatAppearance.BorderSize = 2;
            BtnBuscarLegajo.FlatStyle = FlatStyle.Popup;
            BtnBuscarLegajo.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnBuscarLegajo.ForeColor = Color.WhiteSmoke;
            BtnBuscarLegajo.Location = new Point(202, 118);
            BtnBuscarLegajo.Name = "BtnBuscarLegajo";
            BtnBuscarLegajo.Size = new Size(234, 45);
            BtnBuscarLegajo.TabIndex = 8;
            BtnBuscarLegajo.Text = "Ingresar";
            BtnBuscarLegajo.UseVisualStyleBackColor = false;
            
            // 
            // FrmIngresoLegajo
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(624, 201);
            Controls.Add(LblLegajoUsuario);
            Controls.Add(TxtUsuarioLegajo);
            Controls.Add(BtnBuscarLegajo);
            Name = "FrmIngresoLegajo";
            Text = "FrmIngresoLegajo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblLegajoUsuario;
        private TextBox TxtUsuarioLegajo;
        private Button BtnBuscarLegajo;
    }
}