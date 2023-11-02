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
    public partial class FrmInscripcionAlumnos : Form
    {
        public FrmInscripcionAlumnos()
        {
            InitializeComponent();
            // Llenar combobox especialidad
            List<Entities.Especialidad> especialidades = Business.Especialidad.Get();
            cmbEspecialidades.DataSource = especialidades;
            cmbEspecialidades.ValueMember = "IdEspecialidad";
            cmbEspecialidades.DisplayMember = "descripcion";

            //txtLegajoAlumno = Usuario.legajo
        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEspecialidades.SelectedIndex != -1) // Asegurarse de que se haya seleccionado una especialidad
            {
                Entities.Especialidad especialidadSeleccionada = (Entities.Especialidad)cmbEspecialidades.SelectedItem;

                int idEspecialidad = especialidadSeleccionada.IdEspecialidad;

                // Filtrar los planes basados en la especialidad seleccionada
                List<Entities.Plan> planes = DB.Plan.getByEspecialidad(idEspecialidad);

                cmbPlanes.DataSource = planes;
                cmbPlanes.DisplayMember = "descripcion";
                cmbPlanes.ValueMember = "IdPlan";
            }
        }

        private void cmbPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPlanes.SelectedIndex != -1) // Asegurarse de que se haya seleccionado un plan
            {
                Entities.Plan planSeleccionado = (Entities.Plan)cmbPlanes.SelectedItem;
                int idPlan = planSeleccionado.IdPlan;
                // Filtrar las materias basados en el plan seleccionado
                List<Entities.Materia> materias = Business.Materia.getByPlan(idPlan);
                cmbMaterias.DataSource = materias;
                cmbMaterias.DisplayMember = "Descripcion";
                cmbMaterias.ValueMember = "IdMateria";

                // Filtrar las comisiones basados en el plan seleccionado
                List<Entities.Comision> comisiones = Business.Comision.getByPlan(idPlan);
                cmbComisiones.DataSource = comisiones;
                cmbComisiones.DisplayMember = "Descripcion";
                cmbComisiones.ValueMember = "IdComision";
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbEspecialidades.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar una Especialidad.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbPlanes.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar un plan.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbMaterias.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar una materia.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbComisiones.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar una comision.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idMateria = Convert.ToInt32(cmbMaterias.SelectedValue);
            int idComision = Convert.ToInt32(cmbComisiones.SelectedValue);
            int idCurso = Business.Curso.GetByMateriaAndComision(idMateria, idComision).IdCurso;

            if (Business.Alumnos_Inscripciones.SuperaCupo(idCurso))
            {
                MessageBox.Show("No hay mas cupo en este curso.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string condicion = "Libre";
            int nota = 0;
            int idAlumno = 7;  // reemplazar por usuario.personaId

            Business.Alumnos_Inscripciones.CreateInscripcion( idAlumno, idCurso, condicion, nota );
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
