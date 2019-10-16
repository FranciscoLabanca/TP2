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
    public partial class Especialidades : Form
    {
        public Especialidades()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            EspecialidadLogic el = new EspecialidadLogic();
            dgvEspecialidad.DataSource = el.GetAll();
        }

        private void Especialidad_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            EspecialidadDesktop ed = new EspecialidadDesktop(ApplicationForm.ModoForm.Alta);
            ed.ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            EspecialidadDesktop ed = new EspecialidadDesktop(((Especialidad)dgvEspecialidad.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Modificacion);
            ed.ShowDialog();
            Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            EspecialidadDesktop ed = new EspecialidadDesktop(((Especialidad)dgvEspecialidad.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Baja);
            ed.ShowDialog();
            Listar();
        }
    }
}
