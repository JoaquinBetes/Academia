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
            if (mod != null)
            {
                if (!this.mod.Baja) { btnEliminarPersona.Enabled = false; };
                if (!this.mod.Modificacion) { btnEditarPersona.Enabled = false; };
                if (!this.mod.Alta) { btnAgregarPersona.Enabled = false; };
            }
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
