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
        //Persona.CreatePersona(333333, "Max", "Demian", "384726666", "lavalle 666", "maxdem@gmail.com", specificDate, 22);

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
            using (var modalForm = new FrmAgregarUsuarios())
            {
                // Mostrar el formulario modal como un diálogo
                modalForm.ShowDialog();
            }// PROBLEMA, no se puede crear el usuario antes que la persona pero tampoco un usuario sin persona
            Persona.CreatePersona(int.Parse(TxtDNI.Text), TxtNombre.Text, TxtApellido.Text, TxtTelefono.Text, TxtDireccion.Text, TxtEmail.Text, DtpFechaNacimiento.Value, 999);
        }
    }
}
