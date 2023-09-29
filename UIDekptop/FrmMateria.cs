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

        public FrmMateria()
        {
            InitializeComponent();
            // Llenar combobox
            List<Entities.Plan> planes = Business.Plan.getAll();
            cmbPlanes.DataSource = planes;
            cmbPlanes.DisplayMember = "Descripcion";
            cmbPlanes.ValueMember = "IdPlan";
        }

        public FrmMateria(Entities.Materia materia)
        {
            InitializeComponent();
            // Llenar combobox
            List<Entities.Plan> planes = Business.Plan.getAll();
            cmbPlanes.DataSource = planes;
            cmbPlanes.DisplayMember = "Descripcion";
            cmbPlanes.ValueMember = "IdPlan";

            this.edicion = true;
            txtDescripcion.Text = materia.Descripcion.ToString();
            txtHS.Text = materia.HsSemanales.ToString();
            txtHT.Text = materia.HsTotales.ToString();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtDescripcion.Text))
            //{
            //    MessageBox.Show("Se requiere una descripción.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //if (cmbPlanes.SelectedItem == null)
            //{
            //    MessageBox.Show("Debe seleccionar un plan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //if (!edicion)
            //{
            //    if (Business.Materia.MateriaExists(txtDescripcion.Text.ToString(), (int)cmbPlanes.SelectedValue))
            //    {
            //        MessageBox.Show("Ya existe una Materia con esa descripción y plan.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //}
            Console.WriteLine("id plan: " + cmbPlanes.SelectedValue);
            Console.WriteLine("descripcion: " + txtDescripcion.Text);
            Console.WriteLine("hs semanales: " + txtHS.Text);
            Console.WriteLine("hs totales: " + txtHT.Text);

            Business.Materia.createMateria(txtDescripcion.Text.ToString(), int.Parse(txtHS.Text), int.Parse(txtHT.Text), (int)cmbPlanes.SelectedValue);
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