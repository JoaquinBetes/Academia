using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIDesktop
{
    public partial class FrmMateria : Form
    {
        private bool edicion = false;
        private Entities.Materia materia = new Entities.Materia();
        public class PlanComboBoxItem
        {
            public int IdPlan { get; set; }
            public string DescripcionPlan { get; set; }

            public override string ToString()
            {
                return DescripcionPlan;
            }
        }

        public FrmMateria()
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
                    DescripcionPlan = Business.Especialidad.Get(plan.IdEspecialidad).Descripcion
                });
            }

            cmbPlanes.DataSource = planItems;
            cmbPlanes.DisplayMember = "Item2.Descripcion"; // Muestra la descripción del plan
            cmbPlanes.ValueMember = "Item1"; // El valor seleccionado será el índice
        }

        public FrmMateria(Entities.Materia materia)
        {
            InitializeComponent();
            // Llenar combobox
            List<Entities.Plan> planes = Business.Plan.getAll();
            List<Tuple<string, Entities.Plan>> values = new List<Tuple<string, Entities.Plan>>();

            // Llenar la lista "values" con planes y especialidades

            foreach (var plan in planes)
            {
                values.Add(new Tuple<string, Entities.Plan>(Business.Especialidad.Get(plan.IdEspecialidad).Descripcion, plan));

            }

            cmbPlanes.DataSource = values;
            cmbPlanes.DisplayMember = "Descripcion";
            cmbPlanes.ValueMember = "IdPlan";

            this.edicion = true;
            this.materia = materia;
            txtDescripcion.Text = materia.Descripcion.ToString();
            txtHS.Text = materia.HsSemanales.ToString();
            txtHT.Text = materia.HsTotales.ToString();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Se requiere una descripción.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbPlanes.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un plan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Business.Materia.MateriaExists(txtDescripcion.Text.ToString(), (int)cmbPlanes.SelectedValue))
            {
                MessageBox.Show("Ya existe una Materia con esa descripción y plan.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!edicion)
            {
                Business.Materia.createMateria(txtDescripcion.Text.ToString(), int.Parse(txtHS.Text), int.Parse(txtHT.Text), (int)cmbPlanes.SelectedValue);
            }
            else
            {
                materia.IdMateria =materia.IdMateria; // Debes implementar un método para obtener el ID de la materia que deseas actualizar.
                materia.Descripcion = txtDescripcion.Text;
                materia.HsSemanales = Convert.ToInt32(txtHS.Text);
                materia.HsTotales = Convert.ToInt32(txtHT.Text);
                materia.IdPlan = (int)cmbPlanes.SelectedValue; // Debes implementar un método para obtener el ID del plan asociado.

                Business.Materia.updateMateria(materia);
               
            }


           
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}