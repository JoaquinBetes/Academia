﻿using System;
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
        private int idPlan;
        private bool existePersona = false;
        private bool edicion = false;

        //Constructor para crear el primer usuario de la persona
        public FrmUsuario(int dni, string nombre, string apellido, string telefono, string direccion, string email, DateTime fechaNacimiento, int idPlan)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.direccion = direccion;
            this.email = email;
            this.fechaNacimiento = fechaNacimiento;
            this.idPlan = idPlan;
            InitializeComponent();
            txtDni.Text = dni.ToString();
            List<Entities.Plan> planes = Business.Plan.getAll();
            CmbPlan.DataSource = planes;
            CmbPlan.ValueMember = "IdPlan";
            CmbPlan.DisplayMember = "Descripcion";
        }

        //Constructor para ...
        public FrmUsuario()
        {
            InitializeComponent();
            txtDni.ReadOnly = false;
            List<Entities.Plan> planes = Business.Plan.getAll();
            CmbPlan.DataSource = planes;
            CmbPlan.ValueMember = "IdPlan";
            CmbPlan.DisplayMember = "Descripcion";
        }

        //Constructor para ...
        public FrmUsuario(int personaID)
        {
            this.personaId = personaID;
            this.existePersona = true;
            InitializeComponent();
            List<Entities.Plan> planes = Business.Plan.getAll();
            CmbPlan.DataSource = planes;
            CmbPlan.ValueMember = "IdPlan";
            CmbPlan.DisplayMember = "Descripcion";
        }

        //Constructor para editar usuario
        public FrmUsuario(Entities.Usuario usuario)
        {
            this.edicion = true;
            this.usuario = usuario;
            InitializeComponent();
            txtDni.Text = Business.Persona.getDni(Business.Usuario.getPersonaId(usuario.Legajo)).ToString();
            TxtNombreUsuario.Text = usuario.NombreUsuario;
            TxtLegajo.Text = usuario.Legajo.ToString();
            CmbTipoUsuario.Text = usuario.TipoUsuario;
            TxtClave.Text = usuario.Clave.ToString();
            List<Entities.Plan> planes = Business.Plan.getAll();
            CmbPlan.DataSource = planes;
            CmbPlan.ValueMember = "IdPlan";
            CmbPlan.DisplayMember = "Descripcion";
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
            if (!edicion)
            {
                if (Business.Usuario.NombreUsuarioExists(TxtNombreUsuario.Text))
                {
                    MessageBox.Show("Nombre de usuario en uso.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (CmbTipoUsuario.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un tipo de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CmbPlan.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un plan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (existePersona == false) // Se esta crando  persona y usuario por 1° vez.
                {
                    Business.Persona.CreatePersona(this.dni, this.nombre, this.apellido, this.telefono, this.direccion, this.email, this.fechaNacimiento, this.idPlan);
                    persona = Business.Persona.getPersona(this.dni);
                    Business.Usuario.CreateUsuario(TxtNombreUsuario.Text, TxtClave.Text, CmbTipoUsuario.Text, true, this.dni, persona.PersonaId, int.Parse(TxtLegajo.Text), (int)CmbPlan.SelectedValue);
                    Business.ModuloUsuario.CreateModulosUsuario(CmbTipoUsuario.Text, Business.Usuario.getUsuarioId(int.Parse(TxtLegajo.Text)));
                }
                else // Se esta creando usuario para persona ya creada.
                {
                    Business.Usuario.CreateUsuario(TxtNombreUsuario.Text, TxtClave.Text, CmbTipoUsuario.Text, true, this.dni, this.personaId, int.Parse(TxtLegajo.Text), (int)CmbPlan.SelectedValue);
                    Business.ModuloUsuario.CreateModulosUsuario(CmbTipoUsuario.Text, Business.Usuario.getUsuarioId(int.Parse(TxtLegajo.Text)));
                }
            }
            else
            {
                if (edicion)
                {
                    if (TxtLegajo.Text == usuario.Legajo.ToString())
                    {
                        usuario.NombreUsuario = TxtNombreUsuario.Text;
                        usuario.Clave = TxtClave.Text;
                        usuario.TipoUsuario = CmbTipoUsuario.Text;
                        usuario.IdPlan = (int)CmbPlan.SelectedValue;
                        Business.Usuario.UpdateUsuario(usuario);
                    }
                    else { MessageBox.Show("El legajo ya existe", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MessageBox.Show("El legajo ya existe", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
