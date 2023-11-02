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
        public int idAlumno = 7;  // ----------------------------------------------- cambiar por el id del alumno logueado
        public FrmInscripcionAlumnos()
        {
            InitializeComponent();
            Entities.Persona persona = Business.Persona.getPersonaById(idAlumno);
            int idPlan = persona.IdPlan;
            int idEsp = Business.Plan.getById(idPlan).IdEspecialidad;
            txtEspecialidad.Text = Business.Especialidad.Get(idEsp).Descripcion;
            txtPlan.Text = Business.Plan.getById(idPlan).Descripcion;

            List<Entities.Materia> materias = Business.Materia.getByPlan(idPlan);
            cmbMaterias.DataSource = materias;
            cmbMaterias.ValueMember = "IdMateria";
            cmbMaterias.DisplayMember = "Descripcion";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
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

            Business.Alumnos_Inscripciones.CreateInscripcion(idAlumno, idCurso, condicion, nota);
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaterias.SelectedIndex != -1) // Asegurarse de que se haya seleccionado una materia
            {
                Entities.Materia materiaSeleccionada = (Entities.Materia)cmbMaterias.SelectedItem;

                int idMateria = materiaSeleccionada.IdMateria;

                // Filtrar las comisiones basado en la materia seleccionada
                List<Entities.Comision> comisiones = Business.Materia.getComisionesPorMateria(idMateria);
                cmbComisiones.DataSource = comisiones;
                cmbComisiones.ValueMember = "IdComision";
                cmbComisiones.DisplayMember = "Descripcion";
            }
        }
    }
}
