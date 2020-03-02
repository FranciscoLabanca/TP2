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
    public partial class MenuProfesor : Form
    {
        public MenuProfesor()
        {
            InitializeComponent();
        }

        public Persona PersonaActual { get; set; }

        public MenuProfesor (Persona persona)
        {
            InitializeComponent();
            PersonaActual = persona;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuProfesor_Load(object sender, EventArgs e)
        {
            PersonaLogic pl = new PersonaLogic();
            //List<Curso> cursos = 
        }
    }
}
