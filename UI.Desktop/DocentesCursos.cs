﻿using System;
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
    public partial class DocentesCursos : Form
    {
        public DocentesCursos()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            DocenteCursoLogic dcl = new DocenteCursoLogic();
            dgvDocentes.DataSource = dcl.GetAll();
        }

        private void DocentesCursos_Load(object sender, EventArgs e)
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
            DocenteCursoDesktop dcd = new DocenteCursoDesktop(ApplicationForm.ModoForm.Alta);
            dcd.ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            DocenteCursoDesktop dcd = new DocenteCursoDesktop(((DocenteCurso)dgvDocentes.SelectedRows[0].DataBoundItem).ID,ApplicationForm.ModoForm.Modificacion);
            dcd.ShowDialog();
            Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            DocenteCursoDesktop dcd = new DocenteCursoDesktop(((DocenteCurso)dgvDocentes.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Baja);
            dcd.ShowDialog();
            Listar();
        }
    }
}
