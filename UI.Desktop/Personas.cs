﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;


namespace UI.Desktop
{
    public partial class Personas : Form
    {
        public Personas()
        {
            InitializeComponent();
            dataGridViewPersona.AutoGenerateColumns = false;
        }

        private void Persona_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            //this.personasTableAdapter.Fill(this.tp2_netDataSet.personas);
            PersonaLogic pl = new PersonaLogic();
            dataGridViewPersona.DataSource = pl.GetAll();
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
            PersonaDesktop perDesk = new PersonaDesktop();
            perDesk.ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            PersonaDesktop perDesk = new PersonaDesktop(((Business.Entities.Persona)dataGridViewPersona.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Modificacion);
            perDesk.ShowDialog();
            Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            PersonaDesktop perDesk = new PersonaDesktop(((Business.Entities.Persona)dataGridViewPersona.SelectedRows[0].DataBoundItem).ID, ApplicationForm.ModoForm.Baja);
            perDesk.ShowDialog();
            Listar();
        }
    }
}
