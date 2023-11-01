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
    public partial class FrmPlan : Form
    {
        Entities.Plan plan;
        private bool edicion;
        public FrmPlan(bool edicion)
        {
            this.edicion = edicion;
            InitializeComponent();
            //llenar combobox
            List<Entities.Especialidad> especialidades = Business.Especialidad.Get();
            cmbEspecialidades.DataSource = especialidades;
            cmbEspecialidades.DisplayMember = "Descripcion";
            cmbEspecialidades.ValueMember = "idEspecialidad";
        }

        public FrmPlan(Entities.Plan plan)
        {
            this.plan = plan;
            this.edicion = true;
            InitializeComponent();
            //llenar combobox
            List<Entities.Especialidad> especialidades = Business.Especialidad.Get();
            cmbEspecialidades.DataSource = especialidades;
            cmbEspecialidades.DisplayMember = "Descripcion";
            cmbEspecialidades.ValueMember = "idEspecialidad";
            txtDescripcion.Text = plan.Descripcion.ToString();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Se requiere una descripcion.", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbEspecialidades.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una especialidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!edicion)
            {
                if (Business.Plan.PlanExists(txtDescripcion.Text.ToString(), (int)cmbEspecialidades.SelectedValue))
                {
                    MessageBox.Show("Ya existe un Plan con esa descripcion y especialidad.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Business.Plan.createPlan(txtDescripcion.Text.ToString(), (int)cmbEspecialidades.SelectedValue);
                this.Close();
            }
            else {

                if (Business.Plan.PlanExists(txtDescripcion.Text.ToString(), (int)cmbEspecialidades.SelectedValue))
                {
                    if (plan.Descripcion.Equals(txtDescripcion.Text.ToString()) && plan.IdPlan == (int)cmbEspecialidades.SelectedValue)
                    {
                        plan.Descripcion = txtDescripcion.Text;
                        plan.IdEspecialidad = (int)cmbEspecialidades.SelectedValue;
                        Business.Plan.updatePlan(plan);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ya existe una plan con esa descripción y especialidad.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    plan.Descripcion = txtDescripcion.Text;
                    plan.IdEspecialidad = (int) cmbEspecialidades.SelectedValue;

                    Business.Plan.updatePlan(plan);
                    this.Close();
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
