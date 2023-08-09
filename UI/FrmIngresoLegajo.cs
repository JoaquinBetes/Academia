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
    public partial class FrmIngresoLegajo : Form
    {
        public FrmIngresoLegajo()
        {
            InitializeComponent();
        }

        //Para evitar que manden un valor nulo.
        private void TxtUsuarioLegajo_TextChanged(object sender, EventArgs e)
        {
            // Habilitar o inhabilitar el botón según el contenido del campo de entrada
            BtnBuscarLegajo.Enabled = !string.IsNullOrWhiteSpace(TxtUsuarioLegajo.Text);
        }

        //Para que solo puedan ingresar números
        private void TxtUsuarioLegajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter ingresado no es un número y no es la tecla de retroceso (backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Cancelar el evento para evitar que se ingrese el carácter no válido
                e.Handled = true;
            }
        }
    }
}
