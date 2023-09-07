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

namespace UIDesktop
{
    public partial class FrmPlanes : Form
    {
        public FrmPlanes()
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
    }
}
