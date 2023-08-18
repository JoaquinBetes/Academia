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
                using (var modalForm = new FrmAvisoEditar(int.Parse(TxtDNIData.Text), TxtNombreData.Text, TxtApellidoData.Text, TxtTelefonoData.Text, TxtDireccionData.Text, TxtEmailData.Text, DtpFechaNacimiento.Value, "Editar", "Persona"))
                {
                    modalForm.ShowDialog();
                    this.Close();
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            using (var modalForm = new FrmAvisoEditar(int.Parse(TxtDNIData.Text), TxtNombreData.Text, TxtApellidoData.Text, TxtTelefonoData.Text, TxtDireccionData.Text, TxtEmailData.Text, DtpFechaNacimiento.Value, "Eliminar", "Persona"))
            {
                modalForm.ShowDialog();
                this.Close();
            }
        }
    }
}
