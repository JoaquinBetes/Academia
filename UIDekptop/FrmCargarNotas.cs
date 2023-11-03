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
    public partial class FrmCargarNotas : Form
    {
        public FrmCargarNotas()
        {
            InitializeComponent();
            // Llenar el combo de cursos con el nombre de la materia, la comision y el año

            // Obtener la lista de cursos
            List<Entities.Curso> cursos = Business.Curso.getAll();

            // Modificar la lista de cursos para mostrar el nombre completo
            List<string> cursosDisplay = new List<string>();
            foreach (var curso in cursos)
            {
                // Obtener los datos necesarios para mostrar
                string materiaNombre = Business.Materia.getById(curso.IdMateria).Descripcion;
                string comisionDescripcion = Business.Comision.GetById(curso.IdComision).Descripcion;
                // Crear una cadena que combina los datos
                string cursoDisplay = $" {curso.IdCurso} Materia {materiaNombre}, Comisión: {comisionDescripcion}, Año: {curso.AnioCalendario}";

                cursosDisplay.Add(cursoDisplay);
            }

            // Asignar la lista modificada al ComboBox
            cmbCursos.DataSource = cursosDisplay;


        }
        private int ObtenerIdCursoDesdeDescripcionCompleta(string descripcionCompleta)
        {
            descripcionCompleta = descripcionCompleta.Trim(); // Eliminar espacios en blanco al principio y al final
            string numero = string.Empty;

            for (int i = 0; i < descripcionCompleta.Length; i++)
            {
                if (char.IsDigit(descripcionCompleta[i]))
                {
                    numero += descripcionCompleta[i];
                }
                else if (!string.IsNullOrEmpty(numero))
                {
                    break; // Romper cuando ya hemos encontrado el número
                }
            }

            if (!string.IsNullOrEmpty(numero) && int.TryParse(numero, out int idCurso))
            {
                return idCurso;
            }

            return -1;
        }

        private void FrmCargarNotas_Load(object sender, EventArgs e)
        {

        }
        private void CargarCursos(int idCurso)
        {
            List<Entities.Alumnos_Inscripciones> ins = Business.Alumnos_Inscripciones.GetAll();
            //filtrar por idCurso las inscripciones
            List<Entities.Alumnos_Inscripciones> inscripciones = ins.Where(x => x.IdCurso == idCurso).ToList();

            if (inscripciones != null)
            {
                dgwInscrip.Rows.Clear();
                //por cada incripcionn traer il idAlumno, nombre, apellido, condicion y nota
                foreach (Entities.Alumnos_Inscripciones inscripcion in inscripciones)
                {
                    Entities.Usuario usuari = Business.Usuario.getUsuarioById(inscripcion.IdAlumno);    
                    Entities.Persona persona = Business.Persona.getPersonaById(usuari.PersonaId);
                    dgwInscrip.Rows.Add(inscripcion.IdInscripcion, inscripcion.IdAlumno, persona.Nombre, persona.Apellido, inscripcion.Condicion, inscripcion.Nota, inscripcion.IdCurso);
                }
            }

        }

        private void cmbCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cursoDescripcionCompleta = cmbCursos.SelectedItem.ToString();

            int idCursoSeleccionado = ObtenerIdCursoDesdeDescripcionCompleta(cursoDescripcionCompleta);
            if (idCursoSeleccionado != -1)
            {
                CargarCursos(idCursoSeleccionado);
            }
        }

        private void dgwInscrip_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // dgwInscrip.Rows.Add(inscripcion.IdCurso, persona.PersonaId, persona.Nombre, persona.Apellido, inscripcion.Condicion, inscripcion.Nota);
            int idex = e.RowIndex;
            if (idex >= 0)
            {
                int IdIns = int.Parse(dgwInscrip.Rows[idex].Cells[0].Value.ToString());

                lblNombreAlumno.Text = dgwInscrip.Rows[idex].Cells[2].Value.ToString() + " " + dgwInscrip.Rows[idex].Cells[3].Value.ToString();
                string a = dgwInscrip.Rows[idex].Cells[2].Value.ToString() + " " + dgwInscrip.Rows[idex].Cells[3].Value.ToString();
                lblNombreAlumno.Visible = true;
                //poenr el valor de cmbCondicion al mismo que  dgwInscrip.Rows[idex].Cells[4].Value.ToString();
                cmbCondicion.Text = dgwInscrip.Rows[idex].Cells[4].Value.ToString();
                //poenr el valor de cmbNota al mismo que  dgwInscrip.Rows[idex].Cells[5].Value.ToString() pero en numero si no es vacio
                if (dgwInscrip.Rows[idex].Cells[5].Value.ToString() != "")
                {
                    txtNota.Text = dgwInscrip.Rows[idex].Cells[5].Value.ToString();
                }
                else
                {
                    txtNota.Text = "";
                }
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            //updatear la incripcion con los datos de los campos
            int idex = dgwInscrip.CurrentRow.Index;
            int IdIns = int.Parse(dgwInscrip.Rows[idex].Cells[0].Value.ToString());
            int IdAlu = int.Parse(dgwInscrip.Rows[idex].Cells[1].Value.ToString());
            string Condicion = cmbCondicion.Text;
            int Nota = int.Parse(txtNota.Text);
            int idCurso = int.Parse(dgwInscrip.Rows[idex].Cells[6].Value.ToString());
            Business.Alumnos_Inscripciones.UpdateInscripcion(IdIns,IdAlu, idCurso, Condicion, Nota);
            CargarCursos(idCurso);
        }
    }
}
