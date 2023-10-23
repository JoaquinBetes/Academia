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
            SuspendLayout();
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.FromArgb(192, 0, 0);
            BtnCancelar.FlatAppearance.BorderSize = 0;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCancelar.ForeColor = SystemColors.Control;
            BtnCancelar.Location = new Point(195, 372);
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
            BtnGuardar.Location = new Point(50, 372);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(127, 41);
            BtnGuardar.TabIndex = 36;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // txtAnioCalendario
            // 
            txtAnioCalendario.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtAnioCalendario.Location = new Point(53, 90);
            txtAnioCalendario.Name = "txtAnioCalendario";
            txtAnioCalendario.Size = new Size(271, 27);
            txtAnioCalendario.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(54, 63);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 34;
            label2.Text = "Año Calendario";
            // 
            // cmbMaterias
            // 
            cmbMaterias.FormattingEnabled = true;
            cmbMaterias.Location = new Point(54, 165);
            cmbMaterias.Name = "cmbMaterias";
            cmbMaterias.Size = new Size(270, 28);
            cmbMaterias.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(52, 136);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 42;
            label3.Text = "Materia";
            // 
            // txtCupo
            // 
            txtCupo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtCupo.Location = new Point(54, 307);
            txtCupo.Name = "txtCupo";
            txtCupo.Size = new Size(271, 27);
            txtCupo.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(53, 284);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 44;
            label1.Text = "Cupo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(48, 196);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 46;
            label4.Text = "Comisión";
            // 
            // cmbComisiones
            // 
            cmbComisiones.FormattingEnabled = true;
            cmbComisiones.Location = new Point(54, 235);
            cmbComisiones.Name = "cmbComisiones";
            cmbComisiones.Size = new Size(270, 28);
            cmbComisiones.TabIndex = 47;
            // 
            // FrmCurso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 496);
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
    }
}