using DB;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmPersonas : Form
    {
        public FrmPersonas()
        {
            InitializeComponent();
        }

        private void BtnAgregarUsuarios_Click(object sender, EventArgs e)
        {
            using (var modalForm = new FrmAgregarPersona())
            {
                // Mostrar el formulario modal como un diálogo
                modalForm.ShowDialog();
            }
        }
        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var personas = await Persona.getDatosAsync();
            foreach (Persona persona in personas)
            {
                DgvPersonas.Rows.Add(persona.DNI, persona.Nombre, persona.Apellido, persona.Telefono, persona.Direccion, persona.Email, persona.FechaNacimiento);
            }

        }
    }
}