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
    public partial class FrmComision : Form
    {
        private bool edicion = false;
        public FrmComision()
        {
            InitializeComponent();
            //llenar combobox
        }

        public FrmComision(Entities.Comision comision)
        {
            InitializeComponent();
            //llenar combobox

            txtDescripcion.Text = comision.Descripcion.ToString();
            txtAnioEspecialidad.Text = comision.AnioEspecialidad.ToString();
        }

    }
}
