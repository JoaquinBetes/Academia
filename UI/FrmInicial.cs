using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmInicial : Form
    {
        public FrmInicial()
        {
            InitializeComponent();
        }

        private void btnCRUDPersona_Click(object sender, EventArgs e)
        {
            using (FrmPersonas frmNew = new FrmPersonas())
            { frmNew.ShowDialog(); }
        }

        private void btnCRUDUsuario_Click(object sender, EventArgs e)
        {
           // using (frmEspecialidadCRUD frmNew = new frmEspecialidadCRUD()) 
           // { frmNew.ShowDialog(); }
        }

        private void btnCRUDEspec_Click(object sender, EventArgs e)
        {
            using (frmEspecialidadCRUD frmNew = new frmEspecialidadCRUD())
            { frmNew.ShowDialog(); }
        }
    }
}
