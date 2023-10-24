namespace UIDesktop
{
    partial class FrmInscripcionDocentes
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
            dgvDocentesCursos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDocentesCursos).BeginInit();
            SuspendLayout();
            // 
            // dgvDocentesCursos
            // 
            dgvDocentesCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocentesCursos.Location = new Point(100, 80);
            dgvDocentesCursos.Name = "dgvDocentesCursos";
            dgvDocentesCursos.RowTemplate.Height = 25;
            dgvDocentesCursos.Size = new Size(582, 264);
            dgvDocentesCursos.TabIndex = 0;
            // 
            // FrmInscripcionDocentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDocentesCursos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmInscripcionDocentes";
            Text = "Inscripciones Docentes";
            Load += FrmInscripcionDocentes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDocentesCursos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDocentesCursos;
    }
}