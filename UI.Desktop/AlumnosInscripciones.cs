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
    public partial class AlumnosInscripciones : Form
    {
        public AlumnosInscripciones()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            AlumnoInscripcionLogic ail = new AlumnoInscripcionLogic();
            dgvAlIns.DataSource = ail.GetAll();
        }

        private void AlumnosInscripciones_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            AlumnoInscripcionDesktop aid = new AlumnoInscripcionDesktop(ApplicationForm.ModoForm.Alta);
            aid.ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            AlumnoInscripcionDesktop aid = new AlumnoInscripcionDesktop(((AlumnoInscripcion)dgvAlIns.SelectedRows[0].DataBoundItem).ID,ApplicationForm.ModoForm.Modificacion);
            aid.ShowDialog();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            AlumnoInscripcionDesktop aid = new AlumnoInscripcionDesktop(((AlumnoInscripcion)dgvAlIns.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Baja);
            aid.ShowDialog();
            Listar();
        }
    }
}
