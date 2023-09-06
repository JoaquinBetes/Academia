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
using UIDesktop;

namespace UIDekptop
{
    public partial class FrmEditarPersona : Form
    {
        private Entities.Persona persona;
        public FrmEditarPersona(Entities.Persona persona)
        {
            this.persona = persona;
            InitializeComponent();

            TxtNombre.Text = persona.Nombre;
            TxtApellido.Text = persona.Apellido;
            TxtDni.Text = persona.DNI.ToString();
            TxtEmail.Text = persona.Email;
            TxtDireccion.Text = persona.Direccion;
            TxtTelefono.Text = persona.Telefono;
            DtpFechaNacimiento.Value = persona.FechaNacimiento;
        }

        private void BtnGuardarEdicion_Click(object sender, EventArgs e)
        {
            if (
                persona.Apellido == TxtApellido.Text &&
                persona.Nombre == TxtNombre.Text &&
                persona.DNI.ToString() == TxtDni.Text &&
                persona.Email == TxtEmail.Text &&
                persona.Direccion == TxtDireccion.Text &&
                persona.Telefono == TxtTelefono.Text &&
                persona.FechaNacimiento.Date == DtpFechaNacimiento.Value.Date
                )
            {
                this.Close();
            }
            else
            {
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

                if (Business.Persona.DniExists(int.Parse(TxtDni.Text)) && TxtDni.Text != persona.DNI.ToString())
                {
                    MessageBox.Show("Ya existe una persona con ese DNI.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show("¿Desea confirmar la edición?", "Confirmar Edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Business.Persona.UpdatePersona(int.Parse(TxtDni.Text), TxtNombre.Text, TxtApellido.Text, TxtTelefono.Text, TxtDireccion.Text, TxtEmail.Text, DtpFechaNacimiento.Value, Business.Persona.getPersona(int.Parse(TxtDni.Text)).PersonaId);
                    this.Close();
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
