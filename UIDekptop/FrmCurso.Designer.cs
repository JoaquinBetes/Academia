using System.Drawing.Printing;
using System.Windows.Forms;

namespace UIDesktop
{
    partial class FrmCurso
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
            txtAnioCalendario = new TextBox();
            label2 = new Label();
            cmbMaterias = new ComboBox();
            label3 = new Label();
            txtCupo = new TextBox();
            label1 = new Label();
            label4 = new Label();
            cmbComisiones = new ComboBox();
            label5 = new Label();
            cmbEspecialidades = new ComboBox();
            label6 = new Label();
            cmbPlanes = new ComboBox();
            SuspendLayout();
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.FromArgb(192, 0, 0);
            BtnCancelar.FlatAppearance.BorderSize = 0;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCancelar.ForeColor = SystemColors.Control;
            BtnCancelar.Location = new Point(169, 411);
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
            BtnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGuardar.ForeColor = SystemColors.Control;
            BtnGuardar.Location = new Point(24, 411);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(127, 41);
            BtnGuardar.TabIndex = 36;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // txtAnioCalendario
            // 
            txtAnioCalendario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAnioCalendario.Location = new Point(24, 284);
            txtAnioCalendario.Name = "txtAnioCalendario";
            txtAnioCalendario.Size = new Size(271, 23);
            txtAnioCalendario.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 266);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 34;
            label2.Text = "Año Calendario";
            // 
            // cmbMaterias
            // 
            cmbMaterias.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbMaterias.FormattingEnabled = true;
            cmbMaterias.Location = new Point(24, 158);
            cmbMaterias.Name = "cmbMaterias";
            cmbMaterias.Size = new Size(270, 23);
            cmbMaterias.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 140);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 42;
            label3.Text = "Materia";
            // 
            // txtCupo
            // 
            txtCupo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCupo.Location = new Point(24, 352);
            txtCupo.Name = "txtCupo";
            txtCupo.Size = new Size(271, 23);
            txtCupo.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 334);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 44;
            label1.Text = "Cupo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(24, 203);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 46;
            label4.Text = "Comisión";
            // 
            // cmbComisiones
            // 
            cmbComisiones.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbComisiones.FormattingEnabled = true;
            cmbComisiones.Location = new Point(24, 221);
            cmbComisiones.Name = "cmbComisiones";
            cmbComisiones.Size = new Size(270, 23);
            cmbComisiones.TabIndex = 47;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(24, 26);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 48;
            label5.Text = "Especialidad";
            // 
            // cmbEspecialidades
            // 
            cmbEspecialidades.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbEspecialidades.FormattingEnabled = true;
            cmbEspecialidades.Location = new Point(24, 44);
            cmbEspecialidades.Name = "cmbEspecialidades";
            cmbEspecialidades.Size = new Size(270, 23);
            cmbEspecialidades.TabIndex = 49;
            cmbEspecialidades.SelectedIndexChanged += cmbEspecialidad_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(24, 82);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 50;
            label6.Text = "Plan";
            // 
            // cmbPlanes
            // 
            cmbPlanes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbPlanes.FormattingEnabled = true;
            cmbPlanes.Location = new Point(24, 100);
            cmbPlanes.Name = "cmbPlanes";
            cmbPlanes.Size = new Size(270, 23);
            cmbPlanes.TabIndex = 51;
            cmbPlanes.SelectedIndexChanged += cmbPlanes_SelectedIndexChanged;
            // 
            // FrmCurso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 468);
            Controls.Add(cmbPlanes);
            Controls.Add(label6);
            Controls.Add(cmbEspecialidades);
            Controls.Add(label5);
            Controls.Add(cmbComisiones);
            Controls.Add(label4);
            Controls.Add(txtCupo);
            Controls.Add(label1);
            Controls.Add(cmbMaterias);
            Controls.Add(label3);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnGuardar);
            Controls.Add(txtAnioCalendario);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmCurso";
            Text = "Curso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCancelar;
        private Button BtnGuardar;
        private TextBox txtAnioCalendario;
        private Label label2;
        private ComboBox cmbMaterias;
        private Label label3;
        private TextBox txtCupo;
        private Label label1;
        private Label label4;
        private ComboBox cmbComisiones;
        private Label label5;
        private ComboBox cmbEspecialidades;
        private Label label6;
        private ComboBox cmbPlanes;
    }
}