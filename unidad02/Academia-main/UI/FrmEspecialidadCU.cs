

namespace UI
{
    public partial class FrmEspecialidadCU : Form
    {
        private int? id;
        public FrmEspecialidadCU(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if (this.id != null)
            {
                Get();
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == null) Business.Especialidad.Add(txtDescripcion.Text);
                else Business.Especialidad.Update((int)id, txtDescripcion.Text);
                this.Close();

            }
            catch
            {
                MessageBox.Show("Error al guardar");
            }
        }
        private void Get()
        {
            Entities.Especialidad esp = Business.Especialidad.Get((int)id);
            txtDescripcion.Text = esp.Descripcion;
        }

    }
}
