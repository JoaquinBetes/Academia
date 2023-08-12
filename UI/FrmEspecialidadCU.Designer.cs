namespace UI
{
    partial class FrmEspecialidadCU
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
            label1 = new Label();
            label2 = new Label();
            txtDescripcion = new TextBox();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(43, 108);
            label1.Name = "label1";
            label1.Size = new Size(118, 28);
            label1.TabIndex = 0;
            label1.Text = "Descripción:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(43, 54);
            label2.Name = "label2";
            label2.Size = new Size(354, 30);
            label2.TabIndex = 1;
            label2.Text = "Ingrese los datos de la Especialidad";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = SystemColors.ActiveCaptionText;
            txtDescripcion.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.ForeColor = Color.WhiteSmoke;
            txtDescripcion.Location = new Point(180, 111);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(217, 32);
            txtDescripcion.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Black;
            btnGuardar.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnGuardar.FlatAppearance.BorderSize = 2;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 44, 44);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.WhiteSmoke;
            btnGuardar.Location = new Point(257, 213);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(140, 40);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmEspecialidadCU
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(443, 301);
            Controls.Add(btnGuardar);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmEspecialidadCU";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmEspecialidadCU";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtDescripcion;
        private Button btnGuardar;
    }
}