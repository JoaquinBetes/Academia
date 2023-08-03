using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB;

namespace UI
{
    public partial class FrmAgregarUsuarios : Form
    {
        // Variables para almacenar los datos del usuario
        private int dni;
        private string nombre;
        private string apellido;
        private string telefono;
        private string direccion;
        private string email;
        private DateTime fechaNacimiento;

        public FrmAgregarUsuarios(int dni, string nombre, string apellido, string telefono, string direccion, string email, DateTime fechaNacimiento)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.direccion = direccion;
            this.email = email;
            this.fechaNacimiento = fechaNacimiento;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Nombre_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregarUsuario_Click(object sender, EventArgs e)
        {
            //Persona.CreatePersona(int.Parse(TxtDNI.Text), TxtNombre.Text, TxtApellido.Text, TxtTelefono.Text, TxtDireccion.Text, TxtEmail.Text, DtpFechaNacimiento.Value, 999
            Persona.CreatePersona(this.dni, this.nombre, this.apellido, this.telefono, this.direccion, this.email, this.fechaNacimiento);
            Usuario.CreateUsuario(TxtNombreUsuario.Text, 666, TxtClave.Text, TxtTipoUsuario.Text, true);
            this.Close();
        }
    }
}
