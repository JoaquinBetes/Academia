﻿using DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmIngreso : Form
    {
        private Entities.Persona persona = new Entities.Persona();
        private Entities.Usuario usuario = new Entities.Usuario();
        private string accion;
        private string tipo;
        

        public FrmIngreso(string accion, string tipo)
        {
            this.accion = accion;
            this.tipo = tipo;
            #region Label
            label = new Label();
            label.AutoSize = true;
            label.BackColor = Color.Black;
            label.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label.ForeColor = SystemColors.ControlLight;
            label.Location = new Point(40, 44);
            label.Name = "label";
            label.Size = new Size(123, 25);
            label.TabIndex = 7;
            if (tipo == "Persona") { label.Text = "Ingrese DNI:"; }
            else if (tipo == "Usuario") { label.Text = "Ingrese legajo:"; }

            #endregion
            InitializeComponent();
        }

        private void NombreUsuario_Click(object sender, EventArgs e)
        {

        }
        //Para evitar que manden un valor nulo.
        private void TxtPersonaDni_TextChanged(object sender, EventArgs e)
        {
            // Habilitar o inhabilitar el botón según el contenido del campo de entrada
            BtnBuscarDni.Enabled = !string.IsNullOrWhiteSpace(TxtPersonaDni.Text);
        }
        //Para que solo puedan ingresar números
        private void TxtPersonaDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter ingresado no es un número y no es la tecla de retroceso (backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Cancelar el evento para evitar que se ingrese el carácter no válido
                e.Handled = true;
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (this.tipo == "Persona") {
                persona = DB.Persona.getPersona(int.Parse(TxtPersonaDni.Text));
                if (persona.DNI != 0)
                {
                    if (accion == "Agregar")
                    {
                        using (var modalForm = new FrmAgregarUsuarios(persona.PersonaId))
                        {
                            modalForm.ShowDialog();
                            this.Close();
                        }
                    }
                    else if (accion == "Buscar")
                    {
                        using (var modalForm = new FrmVerPersona(persona))
                        {
                            modalForm.ShowDialog();
                            this.Close();
                        }
                    }

                }
                else
                {
                    using (var modalForm = new FrmAvisoDni())
                    {
                        modalForm.ShowDialog();
                        this.Close();
                    }
                }
            }
            else if (tipo == "Usuario") 
            {
                usuario = DB.Usuario.getUsuario(int.Parse(TxtPersonaDni.Text));
                using (var modalForm = new FrmAgregarUsuarios(usuario))
                {
                    modalForm.ShowDialog();
                    this.Close();
                }
            }

            }

    }
}