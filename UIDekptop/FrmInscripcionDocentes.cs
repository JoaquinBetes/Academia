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
    public partial class FrmInscripcionDocentes : Form
    {
        public FrmInscripcionDocentes()
        {
            InitializeComponent();
            List<Entities.Docentes_Cursos> docentesCursos = Business.Docentes_Cursos.GetAll();
            dgvDocentesCursos.DataSource = docentesCursos;
        }

        private void FrmInscripcionDocentes_Load(object sender, EventArgs e)
        {
            List<Entities.Curso> cursos = Business.Curso.getAll();
            cmbCursos.DataSource = cursos;
            cmbCursos.DisplayMember = "IdCurso";
            cmbCursos.ValueMember = "IdCurso";
        }

        private void cmbCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCursos.SelectedIndex != -1) // Asegurarse de que se haya seleccionado un curso
            {
                Entities.Curso cursoSeleciconado = (Entities.Curso)cmbCursos.SelectedItem;

                // Cambiar las labels de materia, comision y anio
                lblMateria.Text = Business.Materia.getById(cursoSeleciconado.IdMateria).Descripcion;
                lblMateria.Visible = true;
                lblComision.Text = Business.Comision.GetById(cursoSeleciconado.IdComision).Descripcion;
                lblComision.Visible = true;
                lblAnio.Text = cursoSeleciconado.AnioCalendario.ToString();
                lblAnio.Visible = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdDocente.Text) || !int.TryParse(txtIdDocente.Text, out _))
            {
                MessageBox.Show("El Legajo del Docente debe ser un numero.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Business.Usuario.EsDocente(Convert.ToInt32(txtIdDocente.Text)))
            {
                MessageBox.Show("No existe un docente con ese legajo.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!(cmbCursos.SelectedIndex != -1))
            {
                MessageBox.Show("Debe elegir un Curso.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!(cmbCargos.SelectedIndex != -1))
            {
                MessageBox.Show("Debe elegir un Cargo.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int idCurso = (int)cmbCursos.SelectedValue;
            int legajo = Convert.ToInt32(txtIdDocente.Text);
            int cargo = (int)cmbCargos.SelectedIndex + 1;
            int idDocente = Business.Usuario.getUsuario(legajo).Id;
            Business.Docentes_Cursos.CreateInscripcion(idCurso, idDocente, cargo);
            List<Entities.Docentes_Cursos> docentesCursos = Business.Docentes_Cursos.GetAll();
            dgvDocentesCursos.DataSource = docentesCursos;

        }
    }
}
