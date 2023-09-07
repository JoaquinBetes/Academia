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
    public partial class FrmEspecialidad : Form
    {
        private int? id;
        public FrmEspecialidad(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if (this.id != null)
            {
                Get();
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == null) Business.Especialidad.Add(txtDescripcion.Text);
                else Business.Especialidad.Update((int)id, txtDescripcion.Text);
                this.Close();

            }
            catch
            {
                MessageBox.Show("Error al guardar");
            }
        }

        private void Get()
        {
            Entities.Especialidad esp = Business.Especialidad.Get((int)id);
            txtDescripcion.Text = esp.Descripcion;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
