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
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            List<Entities.Persona> personas = Persona.getDatos();
            Console.WriteLine(personas);
            if (personas != null)
            {
                foreach (Entities.Persona persona in personas)
                {
                    DgvPersonas.Rows.Add(persona.DNI, persona.Nombre, persona.Apellido, persona.Telefono, persona.Direccion, persona.Email, persona.FechaNacimiento);
                }
            }


        }
    }
}