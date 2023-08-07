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
            button2.Text

        }

        private void dgvEspecialidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
