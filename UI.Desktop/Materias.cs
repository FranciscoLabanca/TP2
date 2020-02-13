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
    public partial class Materias : Form
    {
        public Materias()
        {
            InitializeComponent();
        }

        public void Listar()
        {
            MateriaLogic ml = new MateriaLogic();
            dgvMaterias.DataSource = ml.GetAll();
        }

        private void Materias_Load(object sender, EventArgs e)
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
            MateriaDesktop md = new MateriaDesktop(ApplicationForm.ModoForm.Alta);
            md.ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            MateriaDesktop md = new MateriaDesktop(((Materia)dgvMaterias.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Modificacion);
            md.ShowDialog();
            Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            MateriaDesktop md = new MateriaDesktop(((Materia)dgvMaterias.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Baja);
            md.ShowDialog();
            Listar();
        }
    }
}
