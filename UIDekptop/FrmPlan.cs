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
        private bool edicion = false;
        public FrmPlan()
        {
            InitializeComponent();
            //llenar combobox
            List<Entities.Especialidad> especialidades = Business.Especialidad.Get();
            cmbEspecialidades.DataSource = especialidades;
            cmbEspecialidades.DisplayMember = "Descripcion";
            cmbEspecialidades.ValueMember = "idEspecialidad";
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
            }

            Business.Plan.createPlan(txtDescripcion.Text.ToString(), (int)cmbEspecialidades.SelectedValue);
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
