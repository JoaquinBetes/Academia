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
            menuStrip1 = new MenuStrip();
            verToolStripMenuItem = new ToolStripMenuItem();
            personasToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            especialidadesToolStripMenuItem = new ToolStripMenuItem();
            pnlContainer = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { verToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1041, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // verToolStripMenuItem
            // 
            verToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { personasToolStripMenuItem, usuariosToolStripMenuItem, especialidadesToolStripMenuItem });
            verToolStripMenuItem.Name = "verToolStripMenuItem";
            verToolStripMenuItem.Size = new Size(35, 20);
            verToolStripMenuItem.Text = "Ver";
            // 
            // personasToolStripMenuItem
            // 
            personasToolStripMenuItem.Name = "personasToolStripMenuItem";
            personasToolStripMenuItem.Size = new Size(180, 22);
            personasToolStripMenuItem.Text = "Personas";
            personasToolStripMenuItem.Click += personasToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(180, 22);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // especialidadesToolStripMenuItem
            // 
            especialidadesToolStripMenuItem.Name = "especialidadesToolStripMenuItem";
            especialidadesToolStripMenuItem.Size = new Size(180, 22);
            especialidadesToolStripMenuItem.Text = "Especialidades";
            especialidadesToolStripMenuItem.Click += especialidadesToolStripMenuItem_Click;
            // 
            // pnlContainer
            // 
            pnlContainer.AutoSize = true;
            pnlContainer.Location = new Point(0, 27);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1041, 579);
            pnlContainer.TabIndex = 2;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1041, 605);
            Controls.Add(pnlContainer);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            Text = "Academia";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem verToolStripMenuItem;
        private ToolStripMenuItem personasToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem especialidadesToolStripMenuItem;
        private Panel pnlContainer;
    }
}