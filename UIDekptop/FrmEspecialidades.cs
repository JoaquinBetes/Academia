﻿using Newtonsoft.Json;
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
    public partial class FrmEspecialidades : Form
    {
        private Entities.ModuloUsuario? mod;
        Entities.Usuario usuario;
        public FrmEspecialidades(Entities.Usuario usuario)
        {
            this.usuario = usuario;
            this.mod = Business.Validaciones.permisos(usuario, "Especialidades");
            InitializeComponent();
            if (mod != null)
            {
                if (!this.mod.Baja) { btnEliminarEspecialidad.Enabled = false; };
                if (!this.mod.Modificacion) { btnEditarEspecialidad.Enabled = false; };
                if (!this.mod.Alta) 
                { 
                    btnAgregarEspecialidad.Enabled = false;
                    btnArbol.Enabled = false;
                    txtId.Enabled = false;
                };
            }
        }

        private void CargarEspecialidades()
        {
            List<Entities.Especialidad> especialidades = Business.Especialidad.Get();
            if (especialidades != null)
            {
                DgvEspecialidades.Rows.Clear();
                foreach (Entities.Especialidad especialidad in especialidades)
                {
                    DgvEspecialidades.Rows.Add(especialidad.IdEspecialidad, especialidad.Descripcion);
                }
            }
        }
        private void FrmEspecialidades_Load(object sender, EventArgs e)
        {
            CargarEspecialidades();
        }

        private void btnAgregarEspecialidad_Click(object sender, EventArgs e)
        {
            using (var modalForm = new FrmEspecialidad())
            {
                // Mostrar el formulario modal como un diálogo
                modalForm.ShowDialog();
            }
            CargarEspecialidades();
        }

        private void btnEditarEspecialidad_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                FrmEspecialidad frmNew = new FrmEspecialidad(id);
                frmNew.ShowDialog();
                CargarEspecialidades();
            }
        }
        private void btnEliminarEspecialidad_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                DialogResult result = MessageBox.Show("¿Esta seguro?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in DgvEspecialidades.SelectedRows)
                    {
                        Business.Especialidad.Delete((int)id);
                        CargarEspecialidades();
                    }
                }
            }
        }
        #region Helper
        private int? GetId()
        {
            try
            {
                if (DgvEspecialidades.CurrentRow == null) { return null; }
                return int.Parse(DgvEspecialidades.Rows[DgvEspecialidades.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;//si no hay ninguna seleccionada da null
            }
        }
        #endregion

        private void btnArbol_Click(object sender, EventArgs e)
        {

            string idText = txtId.Text;

            if (string.IsNullOrEmpty(idText))
            {
                // El campo está vacío, muestra un mensaje de advertencia
                MessageBox.Show("Por favor, ingrese un ID de especialidad.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int idEspecialidad = int.Parse(idText);
                Informe.Program.InformeArbol(idEspecialidad);
            }
        }

    }
}
