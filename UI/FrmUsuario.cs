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
            BtnAgregarUsuario.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAgregarUsuario.ForeColor = Color.WhiteSmoke;
            BtnAgregarUsuario.Location = new Point(145, 228);
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
            BtnCancelar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCancelar.ForeColor = Color.WhiteSmoke;
            BtnCancelar.Location = new Point(536, 228);
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
            TxtTipoUsuario = new TextBox();
            // TxtNombreUsuario
            TxtNombreUsuario.BackColor = SystemColors.ActiveCaptionText;
            TxtNombreUsuario.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
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
            // TxtTipoUsuario
            TxtTipoUsuario.BackColor = SystemColors.ActiveCaptionText;
            TxtTipoUsuario.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTipoUsuario.ForeColor = Color.WhiteSmoke;
            TxtTipoUsuario.Location = new Point(145, 84);
            TxtTipoUsuario.Name = "TxtTipoUsuario";
            TxtTipoUsuario.Size = new Size(575, 32);
            TxtTipoUsuario.TabIndex = 1;
            #endregion
            InitializeComponent();
        }
        public FrmUsuario( int personaID )
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
            BtnAgregarUsuario.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAgregarUsuario.ForeColor = Color.WhiteSmoke;
            BtnAgregarUsuario.Location = new Point(145, 228);
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
            BtnCancelar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCancelar.ForeColor = Color.WhiteSmoke;
            BtnCancelar.Location = new Point(536, 228);
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
            TxtTipoUsuario = new TextBox();
            // TxtNombreUsuario
            TxtNombreUsuario.BackColor = SystemColors.ActiveCaptionText;
            TxtNombreUsuario.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
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
            // TxtTipoUsuario
            TxtTipoUsuario.BackColor = SystemColors.ActiveCaptionText;
            TxtTipoUsuario.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTipoUsuario.ForeColor = Color.WhiteSmoke;
            TxtTipoUsuario.Location = new Point(145, 84);
            TxtTipoUsuario.Name = "TxtTipoUsuario";
            TxtTipoUsuario.Size = new Size(575, 32);
            TxtTipoUsuario.TabIndex = 1;
            #endregion
            InitializeComponent();
        }
        public FrmUsuario( Entities.Usuario usuario )
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
            BtnAgregarUsuario.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAgregarUsuario.ForeColor = Color.WhiteSmoke;
            BtnAgregarUsuario.Location = new Point(145, 228);
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
            BtnCancelar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCancelar.ForeColor = Color.Crimson;
            BtnCancelar.Location = new Point(536, 228);
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
            TxtTipoUsuario = new TextBox();
            // TxtNombreUsuario
            TxtNombreUsuario.BackColor = SystemColors.ActiveCaptionText;
            TxtNombreUsuario.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
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
            // TxtTipoUsuario
            TxtTipoUsuario.BackColor = SystemColors.ActiveCaptionText;
            TxtTipoUsuario.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTipoUsuario.ForeColor = Color.WhiteSmoke;
            TxtTipoUsuario.Location = new Point(145, 84);
            TxtTipoUsuario.Name = "TxtTipoUsuario";
            TxtTipoUsuario.Size = new Size(575, 32);
            TxtTipoUsuario.TabIndex = 1;
            TxtTipoUsuario.Text = usuario.TipoUsuario;
            #endregion
            InitializeComponent();
        }

        private void BtnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (
                usuario.NombreUsuario == TxtNombreUsuario.Text &&
                usuario.TipoUsuario == TxtTipoUsuario.Text &&
                usuario.Clave == TxtClave.Text 
                )
            {
                this.Close();
            }
            else
            {
                usuario.NombreUsuario = TxtNombreUsuario.Text;
                usuario.TipoUsuario = TxtTipoUsuario.Text;
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
            using (var modalForm = new FrmAvisoEditar( usuario ,"Eliminar", "Usuario"))
            {
                modalForm.ShowDialog();
                this.Close();
            }
        }

        private void BtnCancelarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnAgregarUsuario_Click(object sender, EventArgs e)
        {
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
