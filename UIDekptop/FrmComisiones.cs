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
        public FrmComisiones()
        {
            InitializeComponent();
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
        private void FrmPlanes_Load(object sender, EventArgs e)
        {
            CargarComisiones();
        }

        private void btnAgregarComision_Click(object sender, EventArgs e)
        {
            using (var modalform = new FrmPlan())
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
                Entities.Plan plan = Business.Plan.getById(id);
                using (var modalForm = new FrmPlan(plan))
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
