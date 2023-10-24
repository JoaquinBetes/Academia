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
    public partial class FrmCurso : Form
    {
        private bool edicion = false;
        private Entities.Curso curso = new Entities.Curso();

        public FrmCurso()
        {
            InitializeComponent();

            // Llenar ComboBox Especialidades
            List<Entities.Especialidad> especialidades = Business.Especialidad.Get();
            cmbEspecialidades.DataSource = especialidades;
            cmbEspecialidades.ValueMember = "IdEspecialidad";
            cmbEspecialidades.DisplayMember = "Descripcion";
        }

        public FrmCurso(Entities.Curso curso)
        {
            InitializeComponent();

            // Llenar ComboBox Especialidades
            List<Entities.Especialidad> especialidades = Business.Especialidad.Get();
            cmbEspecialidades.DataSource = especialidades;
            cmbEspecialidades.ValueMember = "IdEspecialidad";
            cmbEspecialidades.DisplayMember = "Descripcion";

            this.edicion = true;
            this.curso = curso;
            // Asignar los valores del curso a los controles del formulario
            txtAnioCalendario.Text = curso.AnioCalendario.ToString();
            txtCupo.Text = curso.Cupo.ToString();
            // Aquí también debes asignar la materia seleccionada en el ComboBox.
        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEspecialidades.SelectedIndex != -1) // Asegurarse de que se haya seleccionado una especialidad
            {
                Entities.Especialidad especialidadSeleccionada = (Entities.Especialidad)cmbEspecialidades.SelectedItem;

                int idEspecialidad = especialidadSeleccionada.IdEspecialidad;

                // Filtrar los planes basados en la especialidad seleccionada
                List<Entities.Plan> planes = Business.Plan.getByEspecialidad(idEspecialidad);

                cmbPlanes.DataSource = planes;
                cmbPlanes.DisplayMember = "descripcion";
                cmbPlanes.ValueMember = "IdPlan";
            }
        }

        private void cmbPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPlanes.SelectedIndex != -1) // Asegurarse de que se haya seleccionado una especialidad
            {
                Entities.Plan planSeleccionado = (Entities.Plan)cmbPlanes.SelectedItem;

                int idPlan = planSeleccionado.IdPlan;

                // Filtrar las materias y comisiones basados en la especialidad y plan seleccionada
                //cmbMaterias
                List<Entities.Materia> materias = Business.Materia.getByPlan(idPlan);

                cmbMaterias.DataSource = materias;
                cmbMaterias.DisplayMember = "Descripcion";
                cmbMaterias.ValueMember = "IdMateria";

                //cmbComisiones
                List<Entities.Comision> comisiones = Business.Comision.getByPlan(idPlan);

                cmbComisiones.DataSource = comisiones;
                cmbComisiones.DisplayMember = "Descripcion";
                cmbComisiones.ValueMember = "IdComision";
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAnioCalendario.Text) || !int.TryParse(txtAnioCalendario.Text, out _) || txtAnioCalendario.Text.Length != 4)
            {
                MessageBox.Show("El año calendario debe ser un número válido de 4 digitos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtCupo.Text) || !int.TryParse(txtCupo.Text, out _))
            {
                MessageBox.Show("Cupo requerido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!edicion)
            {
                Business.Curso.createCurso((int)cmbMaterias.SelectedValue, (int)cmbComisiones.SelectedValue, Convert.ToInt32(txtAnioCalendario.Text), Convert.ToInt32(txtCupo.Text));
            }
            else
            {
                // Actualizar el curso existente con los nuevos valores ingresados.
                curso.IdMateria = (int)cmbMaterias.SelectedValue;
                curso.IdComision = (int)cmbComisiones.SelectedValue;
                curso.AnioCalendario = Convert.ToInt32(txtAnioCalendario.Text);
                curso.Cupo = Convert.ToInt32(txtCupo.Text);
                curso.IdCurso = curso.IdCurso;
                Business.Curso.updateCurso(curso);
            }

            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}