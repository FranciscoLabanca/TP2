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
    public partial class Planes : Form
    {
        public Planes()
        {
            InitializeComponent();
            dataGridViewPlanes.AutoGenerateColumns = false;
        }

        private void Listar()
        {
            PlanLogic pl = new PlanLogic();
            dataGridViewPlanes.DataSource = pl.GetAll();
        }

        private void Planes_Load(object sender, EventArgs e)
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
            PlanesDesktop pldesk = new PlanesDesktop(ApplicationForm.ModoForm.Alta);
            pldesk.ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            PlanesDesktop pldesk = new PlanesDesktop(((Plan)dataGridViewPlanes.SelectedRows[0].DataBoundItem).ID,ApplicationForm.ModoForm.Modificacion);
            pldesk.ShowDialog();
            Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            PlanesDesktop pldesk = new PlanesDesktop(((Plan)dataGridViewPlanes.SelectedRows[0].DataBoundItem).ID,ApplicationForm.ModoForm.Baja);
            pldesk.ShowDialog();
            Listar();
        }
    }
}
