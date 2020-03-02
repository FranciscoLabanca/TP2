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
    public partial class MenuAlumno : Form
    {
        public MenuAlumno()
        {
            InitializeComponent();
        }

        public Business.Entities.Persona PersonaActual{ get; set; }

        public MenuAlumno(Business.Entities.Persona persona)
        {
            InitializeComponent();
            PersonaActual = persona;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            AlumnoInscripcionDesktop aid = new AlumnoInscripcionDesktop(ApplicationForm.ModoForm.Alta, PersonaActual);
            aid.ShowDialog();
        }
    }
}
