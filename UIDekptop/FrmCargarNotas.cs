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
    public partial class FrmCargarNotas : Form
    {
        public FrmCargarNotas()
        {
            InitializeComponent();
            // Llenar el combobox con las materias del profesor actualmente logueado
        }

        private void FrmCargarNotas_Load(object sender, EventArgs e)
        {

        }
    }
}
