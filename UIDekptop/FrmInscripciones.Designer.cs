namespace UIDesktop
{
    partial class FrmInscripciones
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
            dgvInscripciones = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).BeginInit();
            SuspendLayout();
            // 
            // dgvInscripciones
            // 
            dgvInscripciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInscripciones.Location = new Point(102, 101);
            dgvInscripciones.Name = "dgvInscripciones";
            dgvInscripciones.RowTemplate.Height = 25;
            dgvInscripciones.Size = new Size(717, 324);
            dgvInscripciones.TabIndex = 0;
            // 
            // FrmInscripciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 527);
            Controls.Add(dgvInscripciones);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmInscripciones";
            Text = "FrmInscripciones";
            Load += FrmInscripciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvInscripciones;
    }
}