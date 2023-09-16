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

        private void CargarPlanes()
        {
            List<Entities.Plan> planes = Business.Plan.getAll();
            if (planes != null)
            {
                DgvPlanes.Rows.Clear();
                foreach (Entities.Plan plan in planes)
                {
                    string descripcionEsp = Business.Especialidad.Get(plan.IdEspecialidad).Descripcion;
                    DgvPlanes.Rows.Add(plan.IdPlan, plan.Descripcion, descripcionEsp);
                }
            }
        }
        private void FrmPlanes_Load(object sender, EventArgs e)
        {
            CargarPlanes();
        }

        private void btnAgregarPlan_Click(object sender, EventArgs e)
        {
            using (var modalform = new FrmPlan())
            {
                modalform.ShowDialog();
                CargarPlanes();
            }
        }

        private void btnEditarPlan_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DgvPlanes.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells["ID"].Value);
                Entities.Plan plan = Business.Plan.getById(id);
                using (var modalForm = new FrmPlan(plan))
                {
                    // Mostrar el formulario modal como un diálogo
                    modalForm.ShowDialog();
                }
            }
            CargarPlanes();
        }

        private void btnEliminarPlan_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in DgvPlanes.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells["ID"].Value);
                    Business.Plan.deletePlan(id);
                }
            }
            CargarPlanes();
        }
    }
}
