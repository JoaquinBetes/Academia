using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UImdi
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public void OpenChild(object child)
        {
            if (this.pnlContainer.Controls.Count > 0)
                this.pnlContainer.Controls.RemoveAt(0);
            Form fh = child as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlContainer.Controls.Add(fh);
            this.pnlContainer.Tag = fh;
            fh.Show();
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            OpenChild(new FrmPersonas());
        }
    }
}
