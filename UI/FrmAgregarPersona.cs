using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace UI
{
    public partial class FrmAgregarPersona : Form
    {
        public FrmAgregarPersona()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Clave_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            using (var modalForm = new FrmAgregarUsuarios(int.Parse(TxtDNI.Text), TxtNombre.Text, TxtApellido.Text, TxtTelefono.Text, TxtDireccion.Text, TxtEmail.Text, DtpFechaNacimiento.Value))
            {
                // Mostrar el formulario modal como un diálogo
                modalForm.ShowDialog();
                this.Close();

            }
        }
    }
}
