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
                List<Entities.Plan> planes = Business.Plan.getByEspecialidad(idEspecialidad);

                cmbPlan.DataSource = planes;
                cmbPlan.DisplayMember = "descripcion";
                cmbPlan.ValueMember = "IdPlan";
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string descripcion = txtDescripcion.Text;
            int anioEsp = Convert.ToInt32(txtAnioEspecialidad.Text);
            int idPlan = Convert.ToInt32(cmbPlan.SelectedValue);

            if (!edicion)
            {
                Business.Comision.CreateComision(descripcion, anioEsp, idPlan);
                this.Close();
            }
            else
            {
                comision.IDPlan = idPlan;
                comision.Descripcion = descripcion;
                comision.AnioEspecialidad = anioEsp;
                Business.Comision.UpdateComision(comision);
                this.Close();
            }

        }

        private void txtAnioEspecialidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es un número o una tecla de control (por ejemplo, retroceso)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada del carácter no válido
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
