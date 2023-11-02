using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIDekptop
{
    public partial class FrmUsuarios : Form
    {
        private Entities.ModuloUsuario? mod;
        Entities.Usuario usuario;
        public FrmUsuarios(Entities.Usuario usuario)
        {
            this.usuario = usuario;
            this.mod = Business.Validaciones.permisos(usuario, "Personas");
            InitializeComponent();
            if (mod != null)
            {
                if (!this.mod.Baja) { btnEliminarUsuario.Enabled = false; };
                if (!this.mod.Modificacion) { btnEditarUsuario.Enabled = false; };
                if (!this.mod.Alta) { btnAgregarUsuario.Enabled = false; };
                if (!this.mod.Alta)
                {
                    LblBuscarLegajo.Text = string.Empty;
                    TxtBuscarLegajo.Enabled = false;
                    btnBuscarPorLegajo.Enabled = false;
                    btnEditarUsuario.Enabled = false;
                }
            }
        }

        private void CargarUsuarios()
        {
            List<Entities.Usuario> usuarios = Business.Usuario.getDatos(usuario);
            if (usuarios != null)
            {
                DgvUsuarios.Rows.Clear();
                foreach (Entities.Usuario usuario in usuarios)
                {
                    string nombrePlan = Business.Plan.getById(usuario.IdPlan).Descripcion;
                    DgvUsuarios.Rows.Add(usuario.Legajo, usuario.NombreUsuario, usuario.Clave, usuario.TipoUsuario, nombrePlan);
                }
            }
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void btnBuscarPorLegajo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBuscarLegajo.Text) || !int.TryParse(TxtBuscarLegajo.Text, out _) || TxtBuscarLegajo.Text.Length != 5)
            {
                MessageBox.Show("El Legajo debe ser un número válido de 5 digitos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Entities.Usuario usuario = Business.Usuario.getUsuario(int.Parse(TxtBuscarLegajo.Text));

            if (usuario != null)
            {
                // Limpia el DataGridView antes de mostrar la nueva persona
                DgvUsuarios.Rows.Clear();
                string nombrePlan = Business.Plan.getById(usuario.IdPlan).Descripcion;
                DgvUsuarios.Rows.Add(usuario.Legajo, usuario.NombreUsuario, usuario.Clave, usuario.TipoUsuario, nombrePlan);
                // Agrega una nueva fila con la información de la persona
            }
            else
            {
                MessageBox.Show("Usuario no encontrada.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in DgvUsuarios.SelectedRows)
                {
                    int legajo = Convert.ToInt32(row.Cells["Legajo"].Value);
                    int personaId = Business.Usuario.getPersonaId(legajo);
                    if (!Business.Usuario.MinimoUsuarios(personaId))
                    {
                        Business.Usuario.deleteUsuario(legajo);
                    }
                    else
                    {
                        MessageBox.Show("No puede borrar el único usuario de esta persona", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            CargarUsuarios();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DgvUsuarios.SelectedRows)
            {
                int legajo = Convert.ToInt32(row.Cells["Legajo"].Value);
                Entities.Usuario usuario = Business.Usuario.getUsuario(legajo);
                using (var modalForm = new FrmUsuario(usuario))
                {
                    // Mostrar el formulario modal como un diálogo
                    modalForm.ShowDialog();
                }
            }
            CargarUsuarios();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            using (var modalForm = new FrmUsuario())
            {
                // Mostrar el formulario modal como un diálogo
                modalForm.ShowDialog();
            }
            CargarUsuarios();
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            Informe.Program.InformeUsuarios();
        }
    }
}
