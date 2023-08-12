using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DB;
using System.Windows.Forms;
namespace UI
{
    public partial class frmEspecialidadCRUD : Form
    {
        public frmEspecialidadCRUD()
        {
            InitializeComponent();
        }

        private void frmEspecialidadCRUD_Load(object sender, EventArgs e)
        {

            load();

        }
        private void load()
        {
            List<Entities.Especialidad> personas = Especialidad.Get();
            dataGridView1.DataSource = personas;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmEspecialidadCU frm = new FrmEspecialidadCU();
            frm.ShowDialog();
            load();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                FrmEspecialidadCU frmNew = new FrmEspecialidadCU(id);
                frmNew.ShowDialog();
                load();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                Especialidad.Delete((int)id);
                load();
            }
        }
        #region Helper
        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;//si no hay ninguna seleccionada da null
            }
        }
        #endregion



    }
}
