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

        protected void load()
        {
            List<Entities.Persona> personas = Persona.getDatos();
            if (personas != null)
            {
                DgvPersonas.Rows.Clear();
                foreach (Entities.Persona persona in personas)
                {
                    DgvPersonas.Rows.Add(persona.DNI, persona.Nombre, persona.Apellido, persona.Telefono, persona.Direccion, persona.Email, persona.FechaNacimiento);
                }
            }
        }

        private void BtnAgregarPersona_Click(object sender, EventArgs e)
        {
            using (var modalForm = new FrmAgregarPersona())
            {
                // Mostrar el formulario modal como un diálogo
                modalForm.ShowDialog();
                load();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            load();
        }

        private void BtnAgregarUsuario_Click(object sender, EventArgs e)
        {
            using (var modalForm = new FrmIngresoDni("Agregar"))
            {
                modalForm.ShowDialog();
            }
        }

        private void BtnBuscarPersona_Click(object sender, EventArgs e)
        {
            using (var modalForm = new FrmIngresoDni("Buscar"))
            {
                modalForm.ShowDialog();
            }
        }
    }
}