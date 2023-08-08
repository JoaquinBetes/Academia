using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB;

namespace UI
{
    public partial class FrmEspecialidadCU : Form
    {
        private int? id;
        public FrmEspecialidadCU(int? id=null)
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
                if(id==null)
                    Especialidad.Add(txtDescripcion.Text);
                else
                    Especialidad.Update((int)id,txtDescripcion.Text);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error al guardar");
            }
           
        }
        private void Get() 
        {
            Entities.Especialidad esp =Especialidad.Get((int)id);
            txtDescripcion.Text = esp.Descripcion;
        }

    }
}
