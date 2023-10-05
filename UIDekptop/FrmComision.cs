using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static UIDesktop.FrmMateria;

namespace UIDesktop
{
    public partial class FrmComision : Form
    {
        private bool edicion = false;
        private Entities.Comision comision = new Entities.Comision();
        public class PlanComboBoxItem
        {
            public int IdPlan { get; set; }
            public string DescripcionPlan { get; set; }

            public override string ToString()
            {
                return DescripcionPlan;
            }
        }

        public FrmComision()
        {
            InitializeComponent();

            // Llenar combobox especialidad
            List<Entities.Especialidad> especialidades = Business.Especialidad.Get();


            // Llenar combobox Plan
            List<Entities.Plan> planes = Business.Plan.getAll();
        }

        public FrmComision(Entities.Comision comision)
        {
            InitializeComponent();
            // Llenar combobox
            List<Entities.Plan> planes = Business.Plan.getAll();
            List<PlanComboBoxItem> planItems = new List<PlanComboBoxItem>();

            foreach (var plan in planes)
            {
                planItems.Add(new PlanComboBoxItem
                {
                    IdPlan = plan.IdPlan,
                    DescripcionPlan = plan.Descripcion + " " + Business.Especialidad.Get(plan.IdEspecialidad).Descripcion
                });
            }

            cmbPlan.DataSource = planItems;
            cmbPlan.DisplayMember = "DescripcionPlan"; // Muestra la descripción del plan
            cmbPlan.ValueMember = "IdPlan"; // El valor seleccionado será el índice

            this.edicion = true;
            this.comision = comision;
            txtDescripcion.Text = comision.Descripcion.ToString();
            txtAnioEspecialidad.Text = comision.AnioEspecialidad.ToString();
        }

    }
}
