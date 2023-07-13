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
            using (var modalForm = new FrmAgregarUsuarios())
            {
                // Mostrar el formulario modal como un diálogo
                modalForm.ShowDialog();
            }
        }


    }
}