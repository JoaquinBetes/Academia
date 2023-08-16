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
using Entities;

namespace UI
{
    public partial class FrmAgregarUsuarios : Form
    {
        private Entities.Persona persona = new Entities.Persona();
        // Variables para almacenar los datos del usuario
        private int dni = 0;
        private string? nombre;
        private string? apellido;
        private string? telefono;
        private string? direccion;
        private string? email;
        private DateTime fechaNacimiento = DateTime.MinValue;
        private int personaId;
        private bool existePersona = false;

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
        public FrmAgregarUsuarios(int personaID)
        {
            this.personaId = personaID;
            this.existePersona = true;
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
            if (Business.Usuario.NombreUsuarioExists(TxtNombreUsuario.Text))
            {
                MessageBox.Show("Nombre de usuario en uso.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (existePersona == false)
            {
                DB.Persona.CreatePersona(this.dni, this.nombre, this.apellido, this.telefono, this.direccion, this.email, this.fechaNacimiento);
                persona = DB.Persona.getPersona(this.dni);
                DB.Usuario.CreateUsuario(TxtNombreUsuario.Text, TxtClave.Text, TxtTipoUsuario.Text, true, this.dni, persona.PersonaId);
            }
            else
            {
                DB.Usuario.CreateUsuario(TxtNombreUsuario.Text, TxtClave.Text, TxtTipoUsuario.Text, true, this.dni, this.personaId);
            }

            this.Close();
        }
    }
}
