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
    public partial class FrmComisiones : Form
    {
        private Entities.ModuloUsuario? mod;
        Entities.Usuario usuario;
        public FrmComisiones(Entities.Usuario usuario)
        {
            this.usuario = usuario;
            this.mod = Business.Validaciones.permisos(usuario, "Comisiones");
            InitializeComponent();
            if (mod != null)
            {
                if (!this.mod.Baja) { btnEliminarComision.Enabled = false; };
                if (!this.mod.Modificacion) { btnEditarComision.Enabled = false; };
                if (!this.mod.Alta) { btnAgregarComision.Enabled = false; };
            }
        }

        private void CargarComisiones()
        {
            List<Entities.Comision> comisiones = Business.Comision.GetAll();
            if (comisiones != null)
            {
                DgvComisiones.Rows.Clear();
                foreach (Entities.Comision comision in comisiones)
                {
                    DgvComisiones.Rows.Add(comision.IdComision, comision.Descripcion, comision.AnioEspecialidad, comision.IDPlan);
                }
            }
        }
        private void FrmComisiones_Load(object sender, EventArgs e)
        {
            CargarComisiones();
        }

        private void btnAgregarComision_Click(object sender, EventArgs e)
        {
            using (var modalform = new FrmComision())
            {
                modalform.ShowDialog();
                CargarComisiones();
            }
        }

        private void btnEditarComision_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DgvComisiones.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells["ID"].Value);
                Entities.Comision comision = Business.Comision.GetById(id);
                using (var modalForm = new FrmComision(comision))
                {
                    // Mostrar el formulario modal como un diálogo
                    modalForm.ShowDialog();
                }
            }
            CargarComisiones();
        }

        private void btnEliminarComision_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in DgvComisiones.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells["ID"].Value);
                    Business.Comision.DeleteComision(id);
                }
            }
            CargarComisiones();
        }
    }
}
