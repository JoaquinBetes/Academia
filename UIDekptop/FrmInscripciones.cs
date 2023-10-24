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
    public partial class FrmInscripciones : Form
    {
        public FrmInscripciones()
        {
            InitializeComponent();
        }

        private void FrmInscripciones_Load(object sender, EventArgs e)
        {
            List<Entities.Alumnos_Inscripciones> data = Business.Alumnos_Inscripciones.GetAll();
            dgvInscripciones.DataSource = data;
        }
    }
}
