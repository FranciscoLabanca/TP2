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
    public partial class Cursos : Form
    {
        public Cursos()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            CursoLogic cl = new CursoLogic();
            dgvCursos.DataSource = cl.GetAll();
        }

        private void Cursos_Load(object sender, EventArgs e)
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
            CursoDesktop cursoDesktop = new CursoDesktop(ApplicationForm.ModoForm.Alta);
            cursoDesktop.ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            CursoDesktop cd = new CursoDesktop(((Curso)dgvCursos.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Modificacion);
            cd.ShowDialog();
            Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            CursoDesktop cd = new CursoDesktop(((Curso)dgvCursos.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Baja);
            cd.ShowDialog();
            Listar();
        }
    }
}
