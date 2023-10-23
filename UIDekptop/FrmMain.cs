﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIDekptop;

namespace UIDesktop
{
    public partial class FrmMain : Form
    {
        Entities.Usuario usuario;
        public FrmMain(Entities.Usuario usuario)
        {
            this.usuario = usuario;
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

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild(new FrmPersonas(usuario));
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild(new FrmUsuarios());
        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild(new FrmEspecialidades());
        }

        private void planesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild(new FrmPlanes());
        }

        private void maToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild(new FrmMaterias());

        }

        private void comisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild(new FrmComisiones());
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild(new FrmCursos());
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInscripcionAlumnos frm = new FrmInscripcionAlumnos();
            frm.ShowDialog();
        }
    }
}
