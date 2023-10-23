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
            cmbEspecialidad.DataSource = especialidades;
            cmbEspecialidad.ValueMember = "IdEspecialidad";
            cmbEspecialidad.DisplayMember = "descripcion";
        }

        public FrmComision(Entities.Comision comision)
        {
            InitializeComponent();
            // Llenar combobox especialidad
            List<Entities.Especialidad> especialidades = Business.Especialidad.Get();
            cmbEspecialidad.DataSource = especialidades;
            cmbEspecialidad.ValueMember = "IdEspecialidad";
            cmbEspecialidad.DisplayMember = "descripcion";

            this.edicion = true;
            this.comision = comision;
            txtDescripcion.Text = comision.Descripcion.ToString();
            txtAnioEspecialidad.Text = comision.AnioEspecialidad.ToString();
        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEspecialidad.SelectedIndex != -1) // Asegurarse de que se haya seleccionado una especialidad
            {
                Entities.Especialidad especialidadSeleccionada = (Entities.Especialidad)cmbEspecialidad.SelectedItem;

                int idEspecialidad = especialidadSeleccionada.IdEspecialidad;

                // Filtrar los planes basados en la especialidad seleccionada
                List<Entities.Plan> planes = DB.Plan.getByEspecialidad(idEspecialidad);

                cmbPlan.DataSource = planes;
                cmbPlan.DisplayMember = "descripcion";
                cmbPlan.ValueMember = "IdPlan";
            }
        }
    }
}
