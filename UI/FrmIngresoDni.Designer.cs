namespace UI
{
    partial class FrmIngresoDni
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
            BtnBuscarDni = new Button();
            DniPersona = new Label();
            TxtPersonaDni = new TextBox();
            SuspendLayout();
            // 
            // BtnBuscarDni
            // 
            BtnBuscarDni.BackColor = Color.FromArgb(34, 34, 34);
            BtnBuscarDni.Enabled = false;
            BtnBuscarDni.FlatAppearance.BorderColor = Color.WhiteSmoke;
            BtnBuscarDni.FlatAppearance.BorderSize = 2;
            BtnBuscarDni.FlatStyle = FlatStyle.Popup;
            BtnBuscarDni.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnBuscarDni.ForeColor = Color.WhiteSmoke;
            BtnBuscarDni.Location = new Point(195, 125);
            BtnBuscarDni.Name = "BtnBuscarDni";
            BtnBuscarDni.Size = new Size(234, 45);
            BtnBuscarDni.TabIndex = 1;
            BtnBuscarDni.Text = "Ingresar";
            BtnBuscarDni.UseVisualStyleBackColor = false;
            BtnBuscarDni.Click += BtnBuscarDni_Click;
            // 
            // DniPersona
            // 
            DniPersona.AutoSize = true;
            DniPersona.BackColor = Color.Black;
            DniPersona.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            DniPersona.ForeColor = SystemColors.ControlLight;
            DniPersona.Location = new Point(40, 44);
            DniPersona.Name = "DniPersona";
            DniPersona.Size = new Size(123, 25);
            DniPersona.TabIndex = 7;
            DniPersona.Text = "Ingrese DNI:";
            DniPersona.Click += NombreUsuario_Click;
            // 
            // TxtPersonaDni
            // 
            TxtPersonaDni.BackColor = SystemColors.ActiveCaptionText;
            TxtPersonaDni.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPersonaDni.ForeColor = Color.WhiteSmoke;
            TxtPersonaDni.Location = new Point(195, 44);
            TxtPersonaDni.MaxLength = 8;
            TxtPersonaDni.Name = "TxtPersonaDni";
            TxtPersonaDni.Size = new Size(375, 32);
            TxtPersonaDni.TabIndex = 6;
            TxtPersonaDni.TextChanged += TxtPersonaDni_TextChanged;
            TxtPersonaDni.KeyPress += TxtPersonaDni_KeyPress;
            // 
            // FrmIngresoDni
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(624, 201);
            Controls.Add(DniPersona);
            Controls.Add(TxtPersonaDni);
            Controls.Add(BtnBuscarDni);
            ForeColor = SystemColors.ButtonFace;
            Name = "FrmIngresoDni";
            Text = "Solicitud de DNI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnBuscarDni;
        private Label DniPersona;
        private TextBox TxtPersonaDni;
    }
}