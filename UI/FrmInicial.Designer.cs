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
            btnCRUDUsuario = new Button();
            btnCRUDEspec = new Button();
            SuspendLayout();
            // 
            // btnCRUDPersona
            // 
            btnCRUDPersona.Location = new Point(45, 168);
            btnCRUDPersona.Name = "btnCRUDPersona";
            btnCRUDPersona.Size = new Size(134, 29);
            btnCRUDPersona.TabIndex = 0;
            btnCRUDPersona.Text = "CRUD Persona";
            btnCRUDPersona.UseVisualStyleBackColor = true;
            btnCRUDPersona.Click += btnCRUDPersona_Click;
            // 
            // btnCRUDUsuario
            // 
            btnCRUDUsuario.Location = new Point(296, 169);
            btnCRUDUsuario.Name = "btnCRUDUsuario";
            btnCRUDUsuario.Size = new Size(128, 29);
            btnCRUDUsuario.TabIndex = 1;
            btnCRUDUsuario.Text = "CRUD Usuario";
            btnCRUDUsuario.UseVisualStyleBackColor = true;
            btnCRUDUsuario.Click += btnCRUDUsuario_Click;
            // 
            // btnCRUDEspec
            // 
            btnCRUDEspec.Location = new Point(516, 168);
            btnCRUDEspec.Name = "btnCRUDEspec";
            btnCRUDEspec.Size = new Size(181, 30);
            btnCRUDEspec.TabIndex = 2;
            btnCRUDEspec.Text = "CRUD Especialidad";
            btnCRUDEspec.UseVisualStyleBackColor = true;
            btnCRUDEspec.Click += btnCRUDEspec_Click;
            // 
            // FrmInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCRUDEspec);
            Controls.Add(btnCRUDUsuario);
            Controls.Add(btnCRUDPersona);
            Name = "FrmInicial";
            Text = "FrmInicial";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCRUDPersona;
        private Button btnCRUDUsuario;
        private Button btnCRUDEspec;
    }
}