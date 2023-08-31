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
using Entities;

namespace UI
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

        public FrmUsuario(int dni, string nombre, string apellido, string telefono, string direccion, string email, DateTime fechaNacimiento)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.direccion = direccion;
            this.email = email;
            this.fechaNacimiento = fechaNacimiento;
            #region Boton Agregar
            BtnAgregarUsuario = new Button();
            BtnAgregarUsuario.BackColor = Color.Black;
            BtnAgregarUsuario.Cursor = Cursors.Hand;
            BtnAgregarUsuario.FlatAppearance.BorderColor = Color.WhiteSmoke;
            BtnAgregarUsuario.FlatAppearance.BorderSize = 2;
            BtnAgregarUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 44, 44);
            BtnAgregarUsuario.FlatStyle = FlatStyle.Flat;
            BtnAgregarUsuario.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAgregarUsuario.ForeColor = Color.WhiteSmoke;
            BtnAgregarUsuario.Location = new Point(145, 258);
            BtnAgregarUsuario.Name = "BtnAgregarUsuario";
            BtnAgregarUsuario.Size = new Size(184, 57);
            BtnAgregarUsuario.TabIndex = 10;
            BtnAgregarUsuario.Text = "Agregar";
            BtnAgregarUsuario.UseVisualStyleBackColor = false;
            BtnAgregarUsuario.Click += BtnAgregarUsuario_Click;
            #endregion
            #region Boton Cancelar
            BtnCancelar = new Button();
            BtnCancelar.BackColor = Color.Black;
            BtnCancelar.Cursor = Cursors.Hand;
            BtnCancelar.FlatAppearance.BorderColor = Color.WhiteSmoke;
            BtnCancelar.FlatAppearance.BorderSize = 2;
            BtnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 44, 44);
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCancelar.ForeColor = Color.WhiteSmoke;
            BtnCancelar.Location = new Point(536, 258);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(184, 57);
            BtnCancelar.TabIndex = 11;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelarUsuario_Click;
            #endregion
            #region info
            TxtNombreUsuario = new TextBox();
            TxtClave = new TextBox();
            CmbTipoUsuario = new ComboBox();
            TxtLegajo = new TextBox();
            // TxtNombreUsuario
            TxtNombreUsuario.BackColor = SystemColors.ActiveCaptionText;
            TxtNombreUsuario.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            TxtNombreUsuario.ForeColor = Color.WhiteSmoke;
            TxtNombreUsuario.Location = new Point(145, 29);
            TxtNombreUsuario.Name = "TxtNombreUsuario";
            TxtNombreUsuario.Size = new Size(575, 32);
            TxtNombreUsuario.TabIndex = 0;
            // TxtClave
            TxtClave.BackColor = SystemColors.ActiveCaptionText;
            TxtClave.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            TxtClave.ForeColor = Color.WhiteSmoke;
            TxtClave.Location = new Point(145, 142);
            TxtClave.MaxLength = 20;
            TxtClave.Name = "TxtClave";
            TxtClave.PasswordChar = '•';
            TxtClave.Size = new Size(575, 36);
            TxtClave.TabIndex = 4;
            TxtClave.UseSystemPasswordChar = true;
            // CmbTipoUsuario
            CmbTipoUsuario.BackColor = SystemColors.ActiveCaptionText;
            CmbTipoUsuario.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            CmbTipoUsuario.ForeColor = Color.WhiteSmoke;
            CmbTipoUsuario.Location = new Point(145, 84);
            CmbTipoUsuario.Name = "CmbTipoUsuario";
            CmbTipoUsuario.Size = new Size(575, 32);
            CmbTipoUsuario.TabIndex = 1;
            CmbTipoUsuario.Items.Add("Alumno");
            CmbTipoUsuario.Items.Add("Docente");
            CmbTipoUsuario.Items.Add("Administrador");
            CmbTipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            // TxtLegajo
            TxtLegajo.BackColor = SystemColors.ActiveCaptionText;
            TxtLegajo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            TxtLegajo.ForeColor = Color.WhiteSmoke;
            TxtLegajo.Location = new Point(145, 197);
            TxtLegajo.Name = "TxtLegajo";
            TxtLegajo.Size = new Size(575, 32);
            TxtLegajo.TabIndex = 11;
            TxtLegajo.KeyPress += TxtUsuarioLegajo_KeyPress;
            #endregion
            InitializeComponent();
        }
        public FrmUsuario(int personaID)
        {
            this.personaId = personaID;
            this.existePersona = true;
            #region Boton Agregar
            BtnAgregarUsuario = new Button();
            BtnAgregarUsuario.BackColor = Color.Black;
            BtnAgregarUsuario.Cursor = Cursors.Hand;
            BtnAgregarUsuario.FlatAppearance.BorderColor = Color.WhiteSmoke;
            BtnAgregarUsuario.FlatAppearance.BorderSize = 2;
            BtnAgregarUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 44, 44);
            BtnAgregarUsuario.FlatStyle = FlatStyle.Flat;
            BtnAgregarUsuario.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAgregarUsuario.ForeColor = Color.WhiteSmoke;
            BtnAgregarUsuario.Location = new Point(145, 258);
            BtnAgregarUsuario.Name = "BtnAgregarUsuario";
            BtnAgregarUsuario.Size = new Size(184, 57);
            BtnAgregarUsuario.TabIndex = 10;
            BtnAgregarUsuario.Text = "Agregar";
            BtnAgregarUsuario.UseVisualStyleBackColor = false;
            BtnAgregarUsuario.Click += BtnAgregarUsuario_Click;
            #endregion
            #region Boton Cancelar
            BtnCancelar = new Button();
            BtnCancelar.BackColor = Color.Black;
            BtnCancelar.Cursor = Cursors.Hand;
            BtnCancelar.FlatAppearance.BorderColor = Color.WhiteSmoke;
            BtnCancelar.FlatAppearance.BorderSize = 2;
            BtnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 44, 44);
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCancelar.ForeColor = Color.WhiteSmoke;
            BtnCancelar.Location = new Point(536, 258);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(184, 57);
            BtnCancelar.TabIndex = 11;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelarUsuario_Click;
            #endregion
            #region info
            TxtNombreUsuario = new TextBox();
            TxtClave = new TextBox();
            CmbTipoUsuario = new ComboBox();
            TxtLegajo = new TextBox();
            // TxtNombreUsuario
            TxtNombreUsuario.BackColor = SystemColors.ActiveCaptionText;
            TxtNombreUsuario.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            TxtNombreUsuario.ForeColor = Color.WhiteSmoke;
            TxtNombreUsuario.Location = new Point(145, 29);
            TxtNombreUsuario.Name = "TxtNombreUsuario";
            TxtNombreUsuario.Size = new Size(575, 32);
            TxtNombreUsuario.TabIndex = 0;
            // TxtClave
            TxtClave.BackColor = SystemColors.ActiveCaptionText;
            TxtClave.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            TxtClave.ForeColor = Color.WhiteSmoke;
            TxtClave.Location = new Point(145, 142);
            TxtClave.MaxLength = 20;
            TxtClave.Name = "TxtClave";
            TxtClave.PasswordChar = '•';
            TxtClave.Size = new Size(575, 36);
            TxtClave.TabIndex = 4;
            TxtClave.UseSystemPasswordChar = true;
            // CmbTipoUsuario
            CmbTipoUsuario.BackColor = SystemColors.ActiveCaptionText;
            CmbTipoUsuario.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            CmbTipoUsuario.ForeColor = Color.WhiteSmoke;
            CmbTipoUsuario.Location = new Point(145, 84);
            CmbTipoUsuario.Name = "CmbTipoUsuario";
            CmbTipoUsuario.Size = new Size(575, 32);
            CmbTipoUsuario.TabIndex = 1;
            CmbTipoUsuario.Items.Add("Alumno");
            CmbTipoUsuario.Items.Add("Docente");
            CmbTipoUsuario.Items.Add("Administrador");
            CmbTipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            // TxtLegajo
            TxtLegajo.BackColor = SystemColors.ActiveCaptionText;
            TxtLegajo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            TxtLegajo.ForeColor = Color.WhiteSmoke;
            TxtLegajo.Location = new Point(145, 197);
            TxtLegajo.Name = "TxtLegajo";
            TxtLegajo.Size = new Size(575, 32);
            TxtLegajo.TabIndex = 11;
            TxtLegajo.KeyPress += TxtUsuarioLegajo_KeyPress;
            #endregion
            InitializeComponent();
        }
        public FrmUsuario(Entities.Usuario usuario)
        {
            this.usuario = usuario;
            #region Boton Editar
            BtnAgregarUsuario = new Button();
            BtnAgregarUsuario.BackColor = Color.Black;
            BtnAgregarUsuario.Cursor = Cursors.Hand;
            BtnAgregarUsuario.FlatAppearance.BorderColor = Color.WhiteSmoke;
            BtnAgregarUsuario.FlatAppearance.BorderSize = 2;
            BtnAgregarUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 44, 44);
            BtnAgregarUsuario.FlatStyle = FlatStyle.Flat;
            BtnAgregarUsuario.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAgregarUsuario.ForeColor = Color.WhiteSmoke;
            BtnAgregarUsuario.Location = new Point(145, 258);
            BtnAgregarUsuario.Name = "BtnAgregarUsuario";
            BtnAgregarUsuario.Size = new Size(184, 57);
            BtnAgregarUsuario.TabIndex = 10;
            BtnAgregarUsuario.Text = "Aceptar";
            BtnAgregarUsuario.UseVisualStyleBackColor = false;
            BtnAgregarUsuario.Click += BtnEditarUsuario_Click;
            #endregion
            #region boton Eliminar
            BtnCancelar = new Button();
            BtnCancelar.BackColor = Color.Black;
            BtnCancelar.Cursor = Cursors.Hand;
            BtnCancelar.FlatAppearance.BorderColor = Color.Crimson;
            BtnCancelar.FlatAppearance.BorderSize = 2;
            BtnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 44, 44);
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCancelar.ForeColor = Color.Crimson;
            BtnCancelar.Location = new Point(536, 258);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(184, 57);
            BtnCancelar.TabIndex = 11;
            BtnCancelar.Text = "Eliminar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnEliminarUsuario_Click;
            #endregion
            #region info
            TxtNombreUsuario = new TextBox();
            TxtClave = new TextBox();
            CmbTipoUsuario = new ComboBox();
            TxtLegajo = new TextBox();
            // TxtNombreUsuario
            TxtNombreUsuario.BackColor = SystemColors.ActiveCaptionText;
            TxtNombreUsuario.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            TxtNombreUsuario.ForeColor = Color.WhiteSmoke;
            TxtNombreUsuario.Location = new Point(145, 29);
            TxtNombreUsuario.Name = "TxtNombreUsuario";
            TxtNombreUsuario.Size = new Size(575, 32);
            TxtNombreUsuario.TabIndex = 0;
            TxtNombreUsuario.Text = usuario.NombreUsuario;
            // TxtClave
            TxtClave.BackColor = SystemColors.ActiveCaptionText;
            TxtClave.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            TxtClave.ForeColor = Color.WhiteSmoke;
            TxtClave.Location = new Point(145, 142);
            TxtClave.MaxLength = 20;
            TxtClave.Name = "TxtClave";
            TxtClave.PasswordChar = '•';
            TxtClave.Size = new Size(575, 36);
            TxtClave.TabIndex = 4;
            TxtClave.UseSystemPasswordChar = true;
            TxtClave.Text = usuario.Clave;
            // CmbTipoUsuario
            CmbTipoUsuario.BackColor = SystemColors.ActiveCaptionText;
            CmbTipoUsuario.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            CmbTipoUsuario.ForeColor = Color.WhiteSmoke;
            CmbTipoUsuario.Location = new Point(145, 84);
            CmbTipoUsuario.Name = "CmbTipoUsuario";
            CmbTipoUsuario.Size = new Size(575, 32);
            CmbTipoUsuario.TabIndex = 1;
            CmbTipoUsuario.Text = usuario.TipoUsuario;
            CmbTipoUsuario.Items.Add("Alumno");
            CmbTipoUsuario.Items.Add("Docente");
            CmbTipoUsuario.Items.Add("Administrador");
            CmbTipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            // TxtLegajo
            TxtLegajo.BackColor = SystemColors.InactiveCaption;
            TxtLegajo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            TxtLegajo.ForeColor = Color.WhiteSmoke;
            TxtLegajo.Location = new Point(145, 197);
            TxtLegajo.Name = "TxtLegajo";
            TxtLegajo.Size = new Size(575, 32);
            TxtLegajo.TabIndex = 11;
            TxtLegajo.Text = usuario.Legajo.ToString();
            TxtLegajo.ReadOnly = true;
            TxtLegajo.Enabled = false;
            #endregion
            InitializeComponent();
        }

        private void BtnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (
                usuario.NombreUsuario == TxtNombreUsuario.Text &&
                usuario.TipoUsuario == CmbTipoUsuario.Text &&
                usuario.Clave == TxtClave.Text 
                )
            {
                this.Close();
            }
            else
            {
                usuario.NombreUsuario = TxtNombreUsuario.Text;
                usuario.TipoUsuario = CmbTipoUsuario.Text;
                usuario.Clave = TxtClave.Text;

                using (var modalForm = new FrmAvisoEditar(usuario, "Editar", "Usuario"))
                {
                    modalForm.ShowDialog();
                    this.Close();
                }
            }
            
        }

        private void BtnEliminarUsuario_Click(object sender, EventArgs e)
        {
            int id = Business.Usuario.getPersonaId(usuario.Legajo);
            if (!Business.Usuario.MinimoUsuarios(id))
            {
                using (var modalForm = new FrmAvisoEditar(usuario, "Eliminar", "Usuario"))
                {
                    modalForm.ShowDialog();
                    this.Close();
                }
            }
            else 
            { 
                MessageBox.Show("No se puede borrar el único usuario de esta persona", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void TxtUsuarioLegajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter ingresado no es un número y no es la tecla de retroceso (backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Cancelar el evento para evitar que se ingrese el carácter no válido
                e.Handled = true;
            }
        }

        private void BtnCancelarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (Business.Usuario.NombreUsuarioExists(TxtNombreUsuario.Text))
            {
                MessageBox.Show("Nombre de usuario en uso.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Business.Usuario.CampoVacio(TxtLegajo.Text) || Business.Usuario.CampoVacio(CmbTipoUsuario.Text) || Business.Usuario.CampoVacio(TxtClave.Text))
            {
                MessageBox.Show("Ha dejado campos necesarios sin completar.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else 
            {
                if (Business.Usuario.ClaveInvalida(TxtClave.Text)) 
                {
                    MessageBox.Show("La clave ingresada debe contener al menos 8 digitos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }

            this.Close();
        }
    }
}
