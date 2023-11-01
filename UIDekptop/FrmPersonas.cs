using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using UIDekptop;

namespace UIDesktop
{

    public partial class FrmPersonas : Form
    {
        private Button btnBuscarPorDni;
        private Button btnAgregarPersona;
        private Button btnEditarPersona;
        private Button btnEliminarPersona;
        private Entities.ModuloUsuario? mod;
        private TextBox txtBuscarPorDni;
        private Label label1;
        Entities.Usuario usuario;
        public FrmPersonas(Entities.Usuario usuario)
        {
            this.usuario = usuario;
            this.mod = Business.Validaciones.permisos(usuario, "Personas");
            InitializeComponent();
            #region Opciones propias de cada usuario
            btnBuscarPorDni = new Button();
            btnAgregarPersona = new Button();
            btnEditarPersona = new Button();
            btnEliminarPersona = new Button();
            txtBuscarPorDni = new TextBox();
            label1 = new Label();
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
            #endregion
            #region Controles
            if (mod != null)
            {
                if (this.mod.Baja) { Controls.Add(btnEliminarPersona); };
                if (this.mod.Modificacion) { Controls.Add(btnEditarPersona); };
                if (this.mod.Alta) { Controls.Add(btnAgregarPersona); };
                if (this.mod.Alta)
                {
                    Controls.Add(btnBuscarPorDni);
                    Controls.Add(label1);
                    Controls.Add(txtBuscarPorDni);
                }
            }
            #endregion

        }

        private void CargarPersonas()
        {
            List<Entities.Persona> personas = Business.Persona.getDatos(usuario);
            DgvPersonas.DataSource = personas;
        }
        private void FrmPersonas_Load(object sender, EventArgs e)
        {
            CargarPersonas();
        }

        private void btnEliminarPersona_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in DgvPersonas.SelectedRows)
                {
                    int dni = Convert.ToInt32(row.Cells["DNI"].Value);
                    Business.Persona.deletePersona(Business.Persona.getPersona(dni).PersonaId);
                }
            }
            CargarPersonas();
        }

        private void btnAgregarPersona_Click(object sender, EventArgs e)
        {
            using (var modalForm = new FrmAgregarPersona())
            {
                // Mostrar el formulario modal como un diálogo
                modalForm.ShowDialog();
            }
            CargarPersonas();
        }

        private void btnEditarPersona_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DgvPersonas.SelectedRows)
            {
                int dni = Convert.ToInt32(row.Cells["DNI"].Value);
                Entities.Persona persona = Business.Persona.getPersona(dni);
                using (var modalForm = new FrmEditarPersona(usuario, persona))
                {
                    // Mostrar el formulario modal como un diálogo
                    modalForm.ShowDialog();
                }
            }
            CargarPersonas();
        }

        private void btnBuscarPorDni_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscarPorDni.Text) || !int.TryParse(txtBuscarPorDni.Text, out _) || txtBuscarPorDni.Text.Length != 8)
            {
                MessageBox.Show("El DNI debe ser un número válido de 8 digitos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Entities.Persona persona = Business.Persona.getPersona(int.Parse(txtBuscarPorDni.Text));

            if (persona != null)
            {
                // Limpia el DataGridView antes de mostrar la nueva persona
                DgvPersonas.Rows.Clear();

                // Agrega una nueva fila con la información de la persona
                DgvPersonas.Rows.Add(persona.DNI, persona.Nombre, persona.Apellido, persona.Telefono, persona.Direccion, persona.Email, persona.FechaNacimiento);
            }
            else
            {
                MessageBox.Show("Persona no encontrada.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
