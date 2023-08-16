using DB;
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
    public partial class FrmAgregarPersona : Form
    {
        public FrmAgregarPersona()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            using (var modalForm = new FrmUsuario(int.Parse(TxtDNI.Text), TxtNombre.Text, TxtApellido.Text, TxtTelefono.Text, TxtDireccion.Text, TxtEmail.Text, DtpFechaNacimiento.Value))
            {
                // Mostrar el formulario modal como un diálogo
                modalForm.ShowDialog();
                this.Close();
            }
        }
    }
}
