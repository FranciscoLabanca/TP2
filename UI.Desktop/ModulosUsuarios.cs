using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class ModulosUsuarios : Form
    {
        public ModulosUsuarios()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            ModuloUsuarioLogic mul = new ModuloUsuarioLogic();
            dgvModUsuarios.DataSource = mul.GetAll();
        }

        private void ModulosUsuarios_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            ModuloUsuarioDesktop mud = new ModuloUsuarioDesktop(ApplicationForm.ModoForm.Alta);
            mud.ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            ModuloUsuarioDesktop mud = new ModuloUsuarioDesktop(((ModuloUsuario)dgvModUsuarios.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Modificacion);
            mud.ShowDialog();
            Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            ModuloUsuarioDesktop mud = new ModuloUsuarioDesktop(((ModuloUsuario)dgvModUsuarios.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Baja);
            mud.ShowDialog();
            Listar();
        }
    }
}
