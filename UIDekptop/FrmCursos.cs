using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using UIDekptop;

namespace UIDesktop
{
    public partial class FrmCursos : Form
    {
        public FrmCursos()
        {
            InitializeComponent();
        }

        private void CargarCursos()
        {
            List<Entities.Curso> cursos = Business.Curso.getAll();
            if (cursos != null)
            {
                DgvCursos.Rows.Clear();
                foreach (Entities.Curso curso in cursos)
                {
                    string descripcionMateria = Business.Materia.getById(curso.IdMateria).Descripcion;
                    string descripcionComision = Business.Comision.GetById(curso.IdComision).Descripcion;
                    DgvCursos.Rows.Add(curso.IdCurso, descripcionMateria, descripcionComision, curso.AnioCalendario, curso.Cupo);
                }
            }
        }

        private void FrmCursos_Load(object sender, EventArgs e)
        {
            CargarCursos();
        }

        private void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            using (var modalForm = new FrmCurso())
            {
                modalForm.ShowDialog();
                CargarCursos();
            }
        }

        private void btnEditarCurso_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DgvCursos.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells["ID"].Value);
                Entities.Curso curso = Business.Curso.getOne(id);
                using (var modalForm = new FrmCurso(curso))
                {
                    modalForm.ShowDialog();
                }
            }
            CargarCursos();
        }

        private void btnEliminarCurso_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in DgvCursos.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells["ID"].Value);
                    Business.Curso.deleteCurso(id);
                }
            }
            CargarCursos();
        }
    }

}
