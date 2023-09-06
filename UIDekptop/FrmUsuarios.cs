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
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void CargarUsuarios()
        {
            List<Entities.Usuario> usuarios = Business.Usuario.getDatos();
            if (usuarios != null)
            {
                DgvUsuarios.Rows.Clear();
                foreach (Entities.Usuario usuario in usuarios)
                {
                    DgvUsuarios.Rows.Add(usuario.Legajo, usuario.NombreUsuario, usuario.Clave, usuario.TipoUsuario);
                }
            }
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void btnBuscarPorLegajo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(btnBuscarPorLegajo.Text) || !int.TryParse(btnBuscarPorLegajo.Text, out _) || btnBuscarPorLegajo.Text.Length != 5)
            {
                MessageBox.Show("El Legajo debe ser un número válido de 5 digitos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Entities.Usuario usuario = Business.Usuario.getUsuario(int.Parse(btnBuscarPorLegajo.Text));

            if (usuario != null)
            {
                // Limpia el DataGridView antes de mostrar la nueva persona
                DgvUsuarios.Rows.Clear();

                // Agrega una nueva fila con la información de la persona
                DgvUsuarios.Rows.Add(usuario.Legajo, usuario.NombreUsuario, usuario.Clave, usuario.TipoUsuario);
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
                    Business.Usuario.deleteUsuario(legajo);
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
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            using (var modalForm = new FrmUsuario())
            {
                // Mostrar el formulario modal como un diálogo
                modalForm.ShowDialog();
            }
        }
    }
}
