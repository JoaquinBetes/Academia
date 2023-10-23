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
        public class MateriaComboBoxItem
        {
            public int IdMateria { get; set; }
            public string DescripcionMateria { get; set; }

            public override string ToString()
            {
                return DescripcionMateria;
            }
        }
        public class ComisionComboBoxItem
        {
            public int IdComision { get; set; }
            public string DescripcionComision { get; set; }

            public override string ToString()
            {
                return DescripcionComision;
            }
        }
        public FrmCurso()
        {
            InitializeComponent();

            // Llenar ComboBox
            List<Entities.Materia> materias = Business.Materia.getAll();
            List<MateriaComboBoxItem> materiaItems = new List<MateriaComboBoxItem>();

            foreach (var materia in materias)
            {
                materiaItems.Add(new MateriaComboBoxItem
                {
                    IdMateria = materia.IdMateria,
                    DescripcionMateria = materia.Descripcion
                });
            }

            cmbMaterias.DataSource = materiaItems;
            cmbMaterias.DisplayMember = "DescripcionMateria";
            cmbMaterias.ValueMember = "IdMateria";
            // Llenar ComboBox
            List<Entities.Comision> comisiones = Business.Comision.GetAll();
            List<ComisionComboBoxItem> comisionItems = new List<ComisionComboBoxItem>();

            foreach (var comision in comisiones)
            {
                comisionItems.Add(new ComisionComboBoxItem
                {
                    IdComision = comision.IdComision,
                    DescripcionComision = comision.Descripcion
                });
            }

            cmbComisiones.DataSource = comisionItems;
            cmbComisiones.DisplayMember = "DescripcionComision";
            cmbComisiones.ValueMember = "IdComision";
        }

        public FrmCurso(Entities.Curso curso)
        {
            InitializeComponent();

            // Llenar ComboBox
            List<Entities.Materia> materias = Business.Materia.getAll();
            List<MateriaComboBoxItem> materiaItems = new List<MateriaComboBoxItem>();

            foreach (var materia in materias)
            {
                materiaItems.Add(new MateriaComboBoxItem
                {
                    IdMateria = materia.IdMateria,
                    DescripcionMateria = materia.Descripcion
                });
            }

            cmbMaterias.DataSource = materiaItems;
            cmbMaterias.DisplayMember = "DescripcionMateria";
            cmbMaterias.ValueMember = "IdMateria";
            // Llenar ComboBox
            List<Entities.Comision> comisiones = Business.Comision.GetAll();
            List<ComisionComboBoxItem> comisionItems = new List<ComisionComboBoxItem>();

            foreach (var comision in comisiones)
            {
                comisionItems.Add(new ComisionComboBoxItem
                {
                    IdComision = comision.IdComision,
                    DescripcionComision = comision.Descripcion
                });
            }

            cmbComisiones.DataSource = comisionItems;
            cmbComisiones.DisplayMember = "DescripcionComision";
            cmbComisiones.ValueMember = "IdComision";
            this.edicion = true;
            this.curso = curso;
            // Asignar los valores del curso a los controles del formulario
            txtAnioCalendario.Text = curso.AnioCalendario.ToString();
            txtCupo.Text = curso.Cupo.ToString();
            // Aquí también debes asignar la materia seleccionada en el ComboBox.
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