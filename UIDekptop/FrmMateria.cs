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
            // Llenar combobox especialidad
            List<Entities.Especialidad> especialidades = Business.Especialidad.Get();
            cmbEspecialidad.DataSource = especialidades;
            cmbEspecialidad.ValueMember = "IdEspecialidad";
            cmbEspecialidad.DisplayMember = "descripcion";
        }

        public FrmMateria(Entities.Materia materia)
        {
            this.materia = materia;
            InitializeComponent();
            // Llenar combobox especialidad
            List<Entities.Especialidad> especialidades = Business.Especialidad.Get();
            cmbEspecialidad.DataSource = especialidades;
            cmbEspecialidad.ValueMember = "IdEspecialidad";
            cmbEspecialidad.DisplayMember = "descripcion";

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


            if (!edicion)
            {
                if (Business.Materia.MateriaExists(txtDescripcion.Text.ToString(), (int)cmbPlanes.SelectedValue))
                {
                    MessageBox.Show("Ya existe una Materia con esa descripción y plan.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Business.Materia.createMateria(txtDescripcion.Text.ToString(), int.Parse(txtHS.Text), int.Parse(txtHT.Text), (int)cmbPlanes.SelectedValue);
            }
            else
            {
                if (Business.Materia.MateriaExists(txtDescripcion.Text.ToString(), (int)cmbPlanes.SelectedValue))
                {
                    if (materia.Descripcion.Equals(txtDescripcion.Text.ToString()) && materia.IdPlan == (int)cmbPlanes.SelectedValue)
                    {
                        materia.IdMateria = materia.IdMateria; // Debes implementar un método para obtener el ID de la materia que deseas actualizar.
                        materia.Descripcion = txtDescripcion.Text;
                        materia.HsSemanales = Convert.ToInt32(txtHS.Text);
                        materia.HsTotales = Convert.ToInt32(txtHT.Text);
                        materia.IdPlan = (int)cmbPlanes.SelectedValue; // Debes implementar un método para obtener el ID del plan asociado.

                        Business.Materia.updateMateria(materia);
                    }
                    else 
                    {
                        MessageBox.Show("Ya existe una Materia con esa descripción y plan.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    materia.IdMateria = materia.IdMateria;
                    materia.Descripcion = txtDescripcion.Text;
                    materia.HsSemanales = Convert.ToInt32(txtHS.Text);
                    materia.HsTotales = Convert.ToInt32(txtHT.Text);
                    materia.IdPlan = (int)cmbPlanes.SelectedValue; 

                    Business.Materia.updateMateria(materia);
                }
            }
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEspecialidad.SelectedIndex != -1) // Asegurarse de que se haya seleccionado una especialidad
            {
                Entities.Especialidad especialidadSeleccionada = (Entities.Especialidad)cmbEspecialidad.SelectedItem;

                int idEspecialidad = especialidadSeleccionada.IdEspecialidad;

                // Filtrar los planes basados en la especialidad seleccionada
                List<Entities.Plan> planes = DB.Plan.getByEspecialidad(idEspecialidad);

                cmbPlanes.DataSource = planes;
                cmbPlanes.DisplayMember = "descripcion";
                cmbPlanes.ValueMember = "IdPlan";
            }
        }
    }
}