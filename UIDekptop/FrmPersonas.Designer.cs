namespace UIDesktop
{
    partial class FrmPersonas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DgvPersonas = new DataGridView();
            btnBuscarPorDni = new Button();
            btnAgregarPersona = new Button();
            btnEditarPersona = new Button();
            btnEliminarPersona = new Button();
            txtBuscarPorDni = new TextBox();
            label1 = new Label();

            ((System.ComponentModel.ISupportInitialize)DgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // btnBuscarPorDni
            // 
            btnBuscarPorDni.BackColor = SystemColors.MenuHighlight;
            btnBuscarPorDni.FlatAppearance.BorderSize = 0;
            btnBuscarPorDni.FlatStyle = FlatStyle.Flat;
            btnBuscarPorDni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarPorDni.ForeColor = SystemColors.ButtonHighlight;
            btnBuscarPorDni.Location = new Point(194, 59);
            btnBuscarPorDni.Name = "btnBuscarPorDni";
            btnBuscarPorDni.Size = new Size(75, 23);
            btnBuscarPorDni.TabIndex = 3;
            btnBuscarPorDni.Text = "Buscar";
            btnBuscarPorDni.UseVisualStyleBackColor = false;
            btnBuscarPorDni.Click += btnBuscarPorDni_Click;
            // 
            // btnAgregarPersona
            // 
            btnAgregarPersona.BackColor = SystemColors.Desktop;
            btnAgregarPersona.FlatAppearance.BorderSize = 0;
            btnAgregarPersona.FlatStyle = FlatStyle.Flat;
            btnAgregarPersona.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarPersona.ForeColor = SystemColors.ButtonHighlight;
            btnAgregarPersona.Location = new Point(648, 472);
            btnAgregarPersona.Name = "btnAgregarPersona";
            btnAgregarPersona.Size = new Size(132, 23);
            btnAgregarPersona.TabIndex = 4;
            btnAgregarPersona.Text = "Agregar persona";
            btnAgregarPersona.UseVisualStyleBackColor = false;
            btnAgregarPersona.Click += btnAgregarPersona_Click;
            // 
            // btnEditarPersona
            // 
            btnEditarPersona.BackColor = Color.Green;
            btnEditarPersona.FlatAppearance.BorderSize = 0;
            btnEditarPersona.FlatStyle = FlatStyle.Flat;
            btnEditarPersona.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditarPersona.ForeColor = SystemColors.ButtonHighlight;
            btnEditarPersona.Location = new Point(194, 472);
            btnEditarPersona.Name = "btnEditarPersona";
            btnEditarPersona.Size = new Size(75, 23);
            btnEditarPersona.TabIndex = 5;
            btnEditarPersona.Text = "Editar";
            btnEditarPersona.UseVisualStyleBackColor = false;
            btnEditarPersona.Click += btnEditarPersona_Click;
            // 
            // btnEliminarPersona
            // 
            btnEliminarPersona.BackColor = Color.FromArgb(192, 0, 0);
            btnEliminarPersona.FlatAppearance.BorderSize = 0;
            btnEliminarPersona.FlatStyle = FlatStyle.Flat;
            btnEliminarPersona.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarPersona.ForeColor = SystemColors.ButtonHighlight;
            btnEliminarPersona.Location = new Point(291, 472);
            btnEliminarPersona.Name = "btnEliminarPersona";
            btnEliminarPersona.Size = new Size(75, 23);
            btnEliminarPersona.TabIndex = 6;
            btnEliminarPersona.Text = "Eliminar";
            btnEliminarPersona.UseVisualStyleBackColor = false;
            btnEliminarPersona.Click += btnEliminarPersona_Click;
            // 
            // txtBuscarPorDni
            // 
            txtBuscarPorDni.BackColor = Color.White;
            txtBuscarPorDni.Location = new Point(37, 59);
            txtBuscarPorDni.Name = "txtBuscarPorDni";
            txtBuscarPorDni.Size = new Size(126, 23);
            txtBuscarPorDni.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 41);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 2;
            label1.Text = "Buscar por DNI";
            // 
            // DgvPersonas
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvPersonas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvPersonas.DefaultCellStyle = dataGridViewCellStyle2;
            DgvPersonas.Location = new Point(79, 129);
            DgvPersonas.Name = "DgvPersonas";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DgvPersonas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DgvPersonas.RowTemplate.Height = 25;
            DgvPersonas.Size = new Size(765, 309);
            DgvPersonas.TabIndex = 0;
            // 
            // FrmPersonas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(985, 602);
            Controls.Add(btnBuscarPorDni);
            Controls.Add(label1);
            Controls.Add(txtBuscarPorDni);
            Controls.Add(btnAgregarPersona);
            Controls.Add(btnEditarPersona);
            Controls.Add(btnEliminarPersona);
            Controls.Add(DgvPersonas);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPersonas";
            Text = "FrmPersonas";
            Load += FrmPersonas_Load;
            ((System.ComponentModel.ISupportInitialize)DgvPersonas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvPersonas;
    }
}