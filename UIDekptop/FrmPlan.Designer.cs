namespace UIDesktop
{
    partial class FrmPlan
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
            BtnGuardar = new Button();
            txtDescripcion = new TextBox();
            label2 = new Label();
            txtIdPlan = new TextBox();
            label1 = new Label();
            label3 = new Label();
            cmbEspecialidades = new ComboBox();
            SuspendLayout();
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.FromArgb(192, 0, 0);
            BtnCancelar.FlatAppearance.BorderSize = 0;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCancelar.ForeColor = SystemColors.Control;
            BtnCancelar.Location = new Point(196, 304);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(127, 41);
            BtnCancelar.TabIndex = 37;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = SystemColors.Desktop;
            BtnGuardar.FlatAppearance.BorderSize = 0;
            BtnGuardar.FlatStyle = FlatStyle.Flat;
            BtnGuardar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGuardar.ForeColor = SystemColors.Control;
            BtnGuardar.Location = new Point(51, 304);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(127, 41);
            BtnGuardar.TabIndex = 36;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.Location = new Point(52, 145);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(271, 27);
            txtDescripcion.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(53, 118);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 34;
            label2.Text = "Descripcion";
            // 
            // txtIdPlan
            // 
            txtIdPlan.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdPlan.Location = new Point(52, 71);
            txtIdPlan.Name = "txtIdPlan";
            txtIdPlan.Size = new Size(271, 27);
            txtIdPlan.TabIndex = 39;
            txtIdPlan.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(53, 44);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 38;
            label1.Text = "ID";
            label1.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(53, 198);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 40;
            label3.Text = "Especialidad";
            // 
            // cmbEspecialidades
            // 
            cmbEspecialidades.FormattingEnabled = true;
            cmbEspecialidades.Location = new Point(53, 235);
            cmbEspecialidades.Name = "cmbEspecialidades";
            cmbEspecialidades.Size = new Size(270, 28);
            cmbEspecialidades.TabIndex = 41;
            // 
            // FrmPlan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 413);
            Controls.Add(cmbEspecialidades);
            Controls.Add(label3);
            Controls.Add(txtIdPlan);
            Controls.Add(label1);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnGuardar);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPlan";
            Text = "Plan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCancelar;
        private Button BtnGuardar;
        private TextBox txtDescripcion;
        private Label label2;
        private TextBox txtIdPlan;
        private Label label1;
        private Label label3;
        private ComboBox cmbEspecialidades;
    }
}