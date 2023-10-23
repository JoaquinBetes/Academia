namespace UIDesktop
{
    partial class FrmMateria
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
            cmbPlanes = new ComboBox();
            label3 = new Label();
            txtHS = new TextBox();
            label1 = new Label();
            txtHT = new TextBox();
            label4 = new Label();
            cmbEspecialidad = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.FromArgb(192, 0, 0);
            BtnCancelar.FlatAppearance.BorderSize = 0;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCancelar.ForeColor = SystemColors.Control;
            BtnCancelar.Location = new Point(256, 422);
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
            BtnGuardar.Location = new Point(111, 422);
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
            txtDescripcion.Location = new Point(114, 211);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(271, 27);
            txtDescripcion.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(112, 188);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 34;
            label2.Text = "Descripcion";
            // 
            // cmbPlanes
            // 
            cmbPlanes.FormattingEnabled = true;
            cmbPlanes.Location = new Point(114, 144);
            cmbPlanes.Name = "cmbPlanes";
            cmbPlanes.Size = new Size(270, 28);
            cmbPlanes.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(114, 121);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 42;
            label3.Text = "Plan";
            // 
            // txtHS
            // 
            txtHS.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtHS.Location = new Point(112, 282);
            txtHS.Name = "txtHS";
            txtHS.Size = new Size(271, 27);
            txtHS.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(114, 259);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 44;
            label1.Text = "HsSemanales";
            // 
            // txtHT
            // 
            txtHT.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtHT.Location = new Point(113, 356);
            txtHT.Name = "txtHT";
            txtHT.Size = new Size(271, 27);
            txtHT.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(114, 329);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 46;
            label4.Text = "HsTotales";
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new Point(114, 74);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(270, 28);
            cmbEspecialidad.TabIndex = 49;
            cmbEspecialidad.SelectedIndexChanged += cmbEspecialidad_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(114, 51);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 48;
            label5.Text = "Especialidad";
            // 
            // FrmMateria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 571);
            Controls.Add(cmbEspecialidad);
            Controls.Add(label5);
            Controls.Add(txtHT);
            Controls.Add(label4);
            Controls.Add(txtHS);
            Controls.Add(label1);
            Controls.Add(cmbPlanes);
            Controls.Add(label3);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnGuardar);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmMateria";
            Text = "Materia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCancelar;
        private Button BtnGuardar;
        private TextBox txtDescripcion;
        private Label label2;
        private ComboBox cmbPlanes;
        private Label label3;
        private TextBox txtHS;
        private Label label1;
        private TextBox txtHT;
        private Label label4;
        private ComboBox cmbEspecialidad;
        private Label label5;
    }
}