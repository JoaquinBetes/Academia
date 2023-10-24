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
        }

        private void FrmInscripcionDocentes_Load(object sender, EventArgs e)
        {
            List<Entities.Docentes_Cursos> data = Business.Docentes_Cursos.GetAll();
            dgvDocentesCursos.DataSource = data;
        }
    }
}
