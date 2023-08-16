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
    public partial class FrmAvisoEditarPersona : Form
    {
        // Variables para almacenar los datos del usuario
        private int dni = 0;
        private int id;
        private string? nombre;
        private string? apellido;
        private string? telefono;
        private string? direccion;
        private string? email;
        private DateTime fechaNacimiento = DateTime.MinValue;
        private string? accion;

        public FrmAvisoEditarPersona(int dni, string nombre, string apellido, string telefono, string direccion, string email, DateTime fechaNacimiento, string accion)
        {
            this.accion = accion;
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.direccion = direccion;
            this.email = email;
            this.fechaNacimiento = fechaNacimiento;
            this.id = DB.Persona.getPersona(this.dni).PersonaId;
            #region Label Aviso
            LblAviso = new Label();
            LblAviso.AutoSize = true;
            LblAviso.BackColor = Color.Black;
            LblAviso.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LblAviso.ForeColor = SystemColors.ControlLight;
            LblAviso.Location = new Point(148, 43);
            LblAviso.Name = "LblAviso";
            LblAviso.Size = new Size(505, 30);
            LblAviso.TabIndex = 13;
            if (this.accion == "Editar")
            {
                LblAviso.Text = "Esta a punto de modificar sus datos personales.";
            }
            else if (this.accion == "Eliminar")
            {
                LblAviso.Text = "Esta a punto de ELIMINAR una persona del sistema";
            }
            #endregion
            InitializeComponent();
        }

        private void BtnAceptarEditarPersona_Click(object sender, EventArgs e)
        {
            if (this.accion == "Editar")
            {
                DB.Persona.UpdatePersona(dni, nombre, apellido, telefono, direccion, email, fechaNacimiento, id);
            }
            else if (this.accion == "Eliminar") 
            {
                DB.Persona.deletePersona(id);
            }
            
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
