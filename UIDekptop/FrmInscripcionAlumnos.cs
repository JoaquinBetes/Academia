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
    }
}
