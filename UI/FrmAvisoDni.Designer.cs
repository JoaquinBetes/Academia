namespace UI
{
    partial class FrmAvisoDni
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
            LblAviso = new Label();
            BtnVolver = new Button();
            SuspendLayout();
            // 
            // LblAviso
            // 
            LblAviso.AutoSize = true;
            LblAviso.BackColor = Color.Black;
            LblAviso.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            LblAviso.ForeColor = SystemColors.ControlLight;
            LblAviso.Location = new Point(60, 58);
            LblAviso.Name = "LblAviso";
            LblAviso.Size = new Size(702, 25);
            LblAviso.TabIndex = 7;
            LblAviso.Text = "El DNI ingresado no corresponde a ninguna persona registrada en el sistema. ";
            // 
            // BtnVolver
            // 
            BtnVolver.BackColor = Color.Black;
            BtnVolver.Cursor = Cursors.Hand;
            BtnVolver.FlatAppearance.BorderSize = 2;
            BtnVolver.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 44, 44);
            BtnVolver.FlatStyle = FlatStyle.Flat;
            BtnVolver.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnVolver.ForeColor = Color.WhiteSmoke;
            BtnVolver.Location = new Point(599, 121);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(163, 50);
            BtnVolver.TabIndex = 11;
            BtnVolver.Text = "Aceptar";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // FrmAvisoDni
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 199);
            Controls.Add(BtnVolver);
            Controls.Add(LblAviso);
            Name = "FrmAvisoDni";
            Text = "FrmAvisoDni";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAviso;
        private Button BtnVolver;
    }
}