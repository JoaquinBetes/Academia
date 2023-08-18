namespace UI
{
    partial class FrmIngreso
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
            this.BtnBuscarDni = new Button();
            this.TxtPersonaDni = new TextBox();
            SuspendLayout();
            // 
            // BtnBuscarDni
            // 
            this.BtnBuscarDni.BackColor = Color.FromArgb(34, 34, 34);
            this.BtnBuscarDni.Enabled = false;
            this.BtnBuscarDni.FlatAppearance.BorderColor = Color.WhiteSmoke;
            this.BtnBuscarDni.FlatAppearance.BorderSize = 2;
            this.BtnBuscarDni.FlatStyle = FlatStyle.Popup;
            this.BtnBuscarDni.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            this.BtnBuscarDni.ForeColor = Color.WhiteSmoke;
            this.BtnBuscarDni.Location = new Point(195, 125);
            this.BtnBuscarDni.Name = "BtnBuscarDni";
            this.BtnBuscarDni.Size = new Size(234, 45);
            this.BtnBuscarDni.TabIndex = 1;
            this.BtnBuscarDni.Text = "Ingresar";
            this.BtnBuscarDni.UseVisualStyleBackColor = false;
            this.BtnBuscarDni.Click += this.BtnBuscar_Click;
            
            // 
            // TxtPersonaDni
            // 
            this.TxtPersonaDni.BackColor = SystemColors.ActiveCaptionText;
            this.TxtPersonaDni.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            this.TxtPersonaDni.ForeColor = Color.WhiteSmoke;
            this.TxtPersonaDni.Location = new Point(195, 44);
            this.TxtPersonaDni.MaxLength = 8;
            this.TxtPersonaDni.Name = "TxtPersonaDni";
            this.TxtPersonaDni.Size = new Size(375, 32);
            this.TxtPersonaDni.TabIndex = 6;
            this.TxtPersonaDni.TextChanged += this.TxtPersonaDni_TextChanged;
            this.TxtPersonaDni.KeyPress += this.TxtPersonaDni_KeyPress;
            // 
            // FrmIngresoDni
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(624, 201);
            Controls.Add(this.label);
            Controls.Add(this.TxtPersonaDni);
            Controls.Add(this.BtnBuscarDni);
            ForeColor = SystemColors.ButtonFace;
            Name = "FrmIngresoDni";
            Text = "Solicitud de DNI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnBuscarDni;
        private Label label;
        private TextBox TxtPersonaDni;
    }
}