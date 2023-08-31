namespace UIDesktop
{
    partial class FrmMain
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
            pnlNav = new Panel();
            btnUsuarios = new Button();
            btnPersonas = new Button();
            pnlContainer = new Panel();
            pnlNav.SuspendLayout();
            SuspendLayout();
            // 
            // pnlNav
            // 
            pnlNav.BackColor = SystemColors.Highlight;
            pnlNav.Controls.Add(btnUsuarios);
            pnlNav.Controls.Add(btnPersonas);
            pnlNav.Dock = DockStyle.Left;
            pnlNav.Location = new Point(0, 0);
            pnlNav.Name = "pnlNav";
            pnlNav.Size = new Size(200, 606);
            pnlNav.TabIndex = 0;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(0, 224);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(200, 49);
            btnUsuarios.TabIndex = 1;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnPersonas
            // 
            btnPersonas.Location = new Point(0, 169);
            btnPersonas.Name = "btnPersonas";
            btnPersonas.Size = new Size(200, 49);
            btnPersonas.TabIndex = 0;
            btnPersonas.Text = "Personas";
            btnPersonas.UseVisualStyleBackColor = true;
            btnPersonas.Click += btnPersonas_Click;
            // 
            // pnlContainer
            // 
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(200, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(993, 606);
            pnlContainer.TabIndex = 1;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1193, 606);
            Controls.Add(pnlContainer);
            Controls.Add(pnlNav);
            IsMdiContainer = true;
            Name = "FrmMain";
            Text = "Academia";
            pnlNav.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlNav;
        private Button btnPersonas;
        private Panel pnlContainer;
        private Button btnUsuarios;
    }
}