using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIDekptop;

namespace UIDesktop
{
    public partial class FrmAgregarPersona : Form
    {
        public FrmAgregarPersona()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
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

            if (string.IsNullOrEmpty(TxtDni.Text) || !int.TryParse(TxtDni.Text, out _) || TxtDni.Text.Length != 8)
            {
                MessageBox.Show("El DNI debe ser un número válido de 8 digitos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(TxtApellido.Text) || TxtApellido.Text.Length > 50)
            {
                MessageBox.Show("Apellido no valido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Business.Persona.DniExists(int.Parse(TxtDni.Text)))
            {
                MessageBox.Show("Ya existe una persona con ese DNI.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var modalForm = new FrmUsuario(int.Parse(TxtDni.Text), TxtNombre.Text, TxtApellido.Text, TxtTelefono.Text, TxtDireccion.Text, TxtEmail.Text, DtpFechaNacimiento.Value))
            {
                // Mostrar el formulario modal como un diálogo
                modalForm.ShowDialog();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es un número o una tecla de control (por ejemplo, retroceso)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada del carácter no válido
            }
        }

        private void TxtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es un número o una tecla de control (por ejemplo, retroceso)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada del carácter no válido
            }
        }
    }
}
