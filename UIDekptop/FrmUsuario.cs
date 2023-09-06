using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIDekptop
{
    public partial class FrmUsuario : Form
    {
        private Entities.Persona persona = new Entities.Persona();
        private Entities.Usuario usuario = new Entities.Usuario();
        private int dni = 0;
        private string? nombre;
        private string? apellido;
        private string? telefono;
        private string? direccion;
        private string? email;
        private DateTime fechaNacimiento = DateTime.MinValue;
        private int personaId;
        private bool existePersona = false;

        //Constructor para crear el primer usuario de la persona
        public FrmUsuario(int dni, string nombre, string apellido, string telefono, string direccion, string email, DateTime fechaNacimiento)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.direccion = direccion;
            this.email = email;
            this.fechaNacimiento = fechaNacimiento;
            InitializeComponent();
            txtDni.Text = dni.ToString();
        }

        //Constructor para ...
        public FrmUsuario()
        {
            InitializeComponent();
            txtDni.ReadOnly = false;
        }

        //Constructor para ...
        public FrmUsuario(int personaID)
        {
            this.personaId = personaID;
            this.existePersona = true;
            InitializeComponent();
        }

        //Constructor para editar usuario
        public FrmUsuario(Entities.Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Validaciones solo para agregar usuario a persona ya existente
            if (txtDni.ReadOnly == false)
            {
                if (string.IsNullOrEmpty(txtDni.Text) || !int.TryParse(txtDni.Text, out _) || txtDni.Text.Length != 8)
                {
                    MessageBox.Show("El DNI debe ser un número válido de 8 digitos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!Business.Persona.DniExists(int.Parse(txtDni.Text)))
                {
                    MessageBox.Show("No se encontro una persona con el DNI ingresado.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else 
                { 
                    existePersona = true;
                    this.dni = int.Parse(txtDni.Text);
                    this.personaId = Business.Persona.getPersona(this.dni).PersonaId;
                }
            }

            if (Business.Usuario.NombreUsuarioExists(TxtNombreUsuario.Text))
            {
                MessageBox.Show("Nombre de usuario en uso.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CmbTipoUsuario.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un tipo de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(TxtLegajo.Text) || !int.TryParse(TxtLegajo.Text, out _) || TxtLegajo.Text.Length != 5)
            {
                MessageBox.Show("El Legajo debe ser un número válido de 5 digitos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(TxtClave.Text))
            {
                MessageBox.Show("Se requiere una clave.", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Business.Usuario.LegajoUsuarioExists(int.Parse(TxtLegajo.Text)))
            {
                if (existePersona == false)
                {
                    Business.Persona.CreatePersona(this.dni, this.nombre, this.apellido, this.telefono, this.direccion, this.email, this.fechaNacimiento);
                    persona = Business.Persona.getPersona(this.dni);
                    Business.Usuario.CreateUsuario(TxtNombreUsuario.Text, TxtClave.Text, CmbTipoUsuario.Text, true, this.dni, persona.PersonaId, int.Parse(TxtLegajo.Text));
                }
                else
                {
                    Business.Usuario.CreateUsuario(TxtNombreUsuario.Text, TxtClave.Text, CmbTipoUsuario.Text, true, this.dni, this.personaId, int.Parse(TxtLegajo.Text));
                }
            }
            else
            {
                MessageBox.Show("El legajo ya existe", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
