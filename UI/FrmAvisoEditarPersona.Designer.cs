namespace UI
{
    partial class FrmAvisoEditarPersona
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
            BtnCancelar = new Button();
            BtnAceptarEditarPersona = new Button();
            
            SuspendLayout();
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.Black;
            BtnCancelar.Cursor = Cursors.Hand;
            BtnCancelar.FlatAppearance.BorderColor = Color.WhiteSmoke;
            BtnCancelar.FlatAppearance.BorderSize = 2;
            BtnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 44, 44);
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCancelar.ForeColor = Color.WhiteSmoke;
            BtnCancelar.Location = new Point(505, 120);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(163, 50);
            BtnCancelar.TabIndex = 15;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnAceptarEditarPersona
            // 
            BtnAceptarEditarPersona.BackColor = Color.Black;
            BtnAceptarEditarPersona.Cursor = Cursors.Hand;
            BtnAceptarEditarPersona.FlatAppearance.BorderColor = Color.WhiteSmoke;
            BtnAceptarEditarPersona.FlatAppearance.BorderSize = 2;
            BtnAceptarEditarPersona.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 44, 44);
            BtnAceptarEditarPersona.FlatStyle = FlatStyle.Flat;
            BtnAceptarEditarPersona.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAceptarEditarPersona.ForeColor = Color.WhiteSmoke;
            BtnAceptarEditarPersona.Location = new Point(134, 120);
            BtnAceptarEditarPersona.Name = "BtnAceptarEditarPersona";
            BtnAceptarEditarPersona.Size = new Size(163, 50);
            BtnAceptarEditarPersona.TabIndex = 14;
            BtnAceptarEditarPersona.Text = "Aceptar";
            BtnAceptarEditarPersona.UseVisualStyleBackColor = false;
            BtnAceptarEditarPersona.Click += BtnAceptarEditarPersona_Click;
            
            // 
            // FrmAvisoEditarPersona
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 205);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAceptarEditarPersona);
            Controls.Add(LblAviso);
            Name = "FrmAvisoEditarPersona";
            Text = "FrmAvisoEditarPersona";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCancelar;
        private Button BtnAceptarEditarPersona;
        private Label LblAviso;
    }
}