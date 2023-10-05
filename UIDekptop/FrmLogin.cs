using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UIDesktop
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Entities.Usuario? usuario = Business.Usuario.getUsuario(TxtNombreUsuario.Text);
            if (usuario == null || usuario.Legajo == 0)
            {
                MessageBox.Show("No existe el nombre de usuario ingresado", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (usuario.Clave != TxtContraseña.Text)
            {
                MessageBox.Show("La contraseña no es válida", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                var modalForm = new FrmMain(usuario);
                // Mostrar el formulario modal como un diálogo
                modalForm.ShowDialog();
            }
            this.Close();
        }
    }
}
