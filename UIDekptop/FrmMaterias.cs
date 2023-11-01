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

    public partial class FrmMaterias : Form
    {
        private Entities.ModuloUsuario? mod;
        Entities.Usuario usuario;
        public FrmMaterias(Entities.Usuario usuario)
        {
            this.usuario = usuario;
            this.mod = Business.Validaciones.permisos(usuario, "Materias");
            InitializeComponent();
            //if (mod != null)
            //{
            //    if (!this.mod.Baja) { btnEliminarMateria.Enabled = false; };
            //    if (!this.mod.Modificacion) { btnEditarMateria.Enabled = false; };
            //    if (!this.mod.Alta) { btnAgregarMateria.Enabled = false; };
            //}
        }

        private void CargarMaterias()
        {
            List<Entities.Materia> materias = Business.Materia.getAll();
            if (materias != null)
            {
                DgvMaterias.Rows.Clear();
                foreach (Entities.Materia materia in materias)
                {
                    string descripcionPlan = Business.Plan.getById(materia.IdPlan).Descripcion;
                    DgvMaterias.Rows.Add(materia.IdMateria, materia.Descripcion, materia.HsSemanales, materia.HsTotales, descripcionPlan);
                }
            }
        }

        private void FrmMaterias_Load(object sender, EventArgs e)
        {
            CargarMaterias();
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            using (var modalform = new FrmMateria())
            {
                modalform.ShowDialog();
                CargarMaterias();
            }
        }

        private void btnEditarMateria_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DgvMaterias.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells["ID"].Value);
                Entities.Materia materia = Business.Materia.getById(id);
                using (var modalForm = new FrmMateria(materia))
                {
                    // Mostrar el formulario modal como un diálogo
                    modalForm.ShowDialog();
                }
            }
            CargarMaterias();
        }

        private void btnEliminarMateria_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in DgvMaterias.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells["ID"].Value);
                    Business.Materia.deleteMateria(id);
                }
            }
            CargarMaterias();
        }


    }
}
