namespace UIDesktop
{
    partial class Comision
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
            txtAnioEspecialidad = new TextBox();
            label1 = new Label();
            cmbPlan = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.FromArgb(192, 0, 0);
            BtnCancelar.FlatAppearance.BorderSize = 0;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCancelar.ForeColor = SystemColors.Control;
            BtnCancelar.Location = new Point(218, 308);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(127, 41);
            BtnCancelar.TabIndex = 37;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = SystemColors.Desktop;
            BtnGuardar.FlatAppearance.BorderSize = 0;
            BtnGuardar.FlatStyle = FlatStyle.Flat;
            BtnGuardar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGuardar.ForeColor = SystemColors.Control;
            BtnGuardar.Location = new Point(73, 308);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(127, 41);
            BtnGuardar.TabIndex = 36;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.Location = new Point(74, 83);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(271, 27);
            txtDescripcion.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(75, 56);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 34;
            label2.Text = "Descripcion";
            // 
            // txtAnioEspecialidad
            // 
            txtAnioEspecialidad.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtAnioEspecialidad.Location = new Point(74, 166);
            txtAnioEspecialidad.Name = "txtAnioEspecialidad";
            txtAnioEspecialidad.Size = new Size(271, 27);
            txtAnioEspecialidad.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(75, 139);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 38;
            label1.Text = "Año Especialidad";
            // 
            // cmbPlan
            // 
            cmbPlan.FormattingEnabled = true;
            cmbPlan.Location = new Point(75, 250);
            cmbPlan.Name = "cmbPlan";
            cmbPlan.Size = new Size(270, 28);
            cmbPlan.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(76, 227);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 41;
            label3.Text = "Plan";
            // 
            // Comision
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 396);
            Controls.Add(label3);
            Controls.Add(cmbPlan);
            Controls.Add(txtAnioEspecialidad);
            Controls.Add(label1);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnGuardar);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Comision";
            Text = "Comision";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCancelar;
        private Button BtnGuardar;
        private TextBox txtDescripcion;
        private Label label2;
        private TextBox txtAnioEspecialidad;
        private Label label1;
        private ComboBox cmbPlan;
        private Label label3;
    }
}