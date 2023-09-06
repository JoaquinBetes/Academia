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
    public partial class FrmPersona : Form
    {
        private Entities.Persona persona;
        public FrmPersona(Entities.Persona persona)
        {
            this.persona = persona;
            InitializeComponent();
        }

        private void BtnEditarPersona_Click(object sender, EventArgs e)
        {
            if (
                persona.Apellido == TxtApellidoData.Text &&
                persona.Nombre == TxtNombreData.Text &&
                persona.DNI.ToString() == TxtDNIData.Text &&
                persona.Email == TxtEmailData.Text &&
                persona.Direccion == TxtDireccionData.Text &&
                persona.Telefono == TxtTelefonoData.Text &&
                persona.FechaNacimiento.Date == DtpFechaNacimiento.Value.Date
                )
            {
                this.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Desea confirmar la edición?", "Confirmar Edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Business.Persona.UpdatePersona(int.Parse(TxtDNIData.Text), TxtNombreData.Text, TxtApellidoData.Text, TxtTelefonoData.Text, TxtDireccionData.Text, TxtEmailData.Text, DtpFechaNacimiento.Value, Business.Persona.getPersona(int.Parse(TxtDNIData.Text)).PersonaId);
                    this.Close();
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Business.Persona.deletePersona(Business.Persona.getPersona(int.Parse(TxtDNIData.Text)).PersonaId);
                this.Close();
            }
        }
    }
}
