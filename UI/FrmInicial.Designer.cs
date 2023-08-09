namespace UI
{
    partial class FrmInicial
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
            btnCRUDPersona = new Button();
            btnCRUDEspec = new Button();
            SuspendLayout();
            // 
            // btnCRUDPersona
            // 
            btnCRUDPersona.Cursor = Cursors.Hand;
            btnCRUDPersona.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnCRUDPersona.FlatAppearance.BorderSize = 2;
            btnCRUDPersona.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 44, 44);
            btnCRUDPersona.FlatStyle = FlatStyle.Flat;
            btnCRUDPersona.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnCRUDPersona.ForeColor = Color.WhiteSmoke;
            btnCRUDPersona.Location = new Point(61, 101);
            btnCRUDPersona.Name = "btnCRUDPersona";
            btnCRUDPersona.Size = new Size(461, 79);
            btnCRUDPersona.TabIndex = 0;
            btnCRUDPersona.Text = "Personas";
            btnCRUDPersona.UseVisualStyleBackColor = true;
            btnCRUDPersona.Click += btnCRUDPersona_Click;
            // 
            // btnCRUDEspec
            // 
            btnCRUDEspec.Cursor = Cursors.Hand;
            btnCRUDEspec.FlatAppearance.BorderColor = Color.WhiteSmoke;
            btnCRUDEspec.FlatAppearance.BorderSize = 2;
            btnCRUDEspec.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 44, 44);
            btnCRUDEspec.FlatStyle = FlatStyle.Flat;
            btnCRUDEspec.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnCRUDEspec.ForeColor = Color.WhiteSmoke;
            btnCRUDEspec.Location = new Point(61, 235);
            btnCRUDEspec.Name = "btnCRUDEspec";
            btnCRUDEspec.Size = new Size(461, 79);
            btnCRUDEspec.TabIndex = 2;
            btnCRUDEspec.Text = "Especialidades";
            btnCRUDEspec.UseVisualStyleBackColor = true;
            btnCRUDEspec.Click += btnCRUDEspec_Click;
            // 
            // FrmInicial
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(588, 472);
            Controls.Add(btnCRUDEspec);
            Controls.Add(btnCRUDPersona);
            Name = "FrmInicial";
            Text = "Inicio";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCRUDPersona;
        private Button btnCRUDEspec;
    }
}