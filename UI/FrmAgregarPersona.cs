using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
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
            // Validaciones de los campos
            if (string.IsNullOrEmpty(TxtNombre.Text) || TxtNombre.Text.Length > 50)
            {
                MessageBox.Show("Nombre no valido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(TxtApellido.Text) || TxtApellido.Text.Length > 50)
            {
                MessageBox.Show("Apellido no valido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(TxtApellido.Text) || TxtApellido.Text.Length > 100)
            {
                MessageBox.Show("Direccion no valida.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            if (!Regex.IsMatch(TxtEmail.Text, emailPattern))
            {
                MessageBox.Show("El formato del correo electrónico no es válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(TxtDNI.Text) || !int.TryParse(TxtDNI.Text, out _) || TxtDNI.Text.Length != 8)
            {
                MessageBox.Show("El DNI debe ser un número válido de 8 digitos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(TxtApellido.Text) || TxtApellido.Text.Length > 50)
            {
                MessageBox.Show("Apellido no valido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Business.Persona.DniExists(int.Parse(TxtDNI.Text)))
            {
                MessageBox.Show("Ya existe una persona con ese DNI.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var modalForm = new FrmAgregarUsuarios(int.Parse(TxtDNI.Text), TxtNombre.Text, TxtApellido.Text, TxtTelefono.Text, TxtDireccion.Text, TxtEmail.Text, DtpFechaNacimiento.Value))
            {
                // Mostrar el formulario modal como un diálogo
                modalForm.ShowDialog();
                this.Close();

            }
        }
    }
}
