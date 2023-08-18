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
            List<Entities.Especialidad> personas = Business.Especialidad.Get();
            dataGridView1.DataSource = personas;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmEspecialidadCU frm = new FrmEspecialidadCU();
            frm.ShowDialog();
            
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
                Business.Especialidad.Delete((int)id);
                load();
            }
        }
        #region Helper
        private int? GetId()
        {
            try
            {
                if (dataGridView1.CurrentRow == null) { return null; }
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
