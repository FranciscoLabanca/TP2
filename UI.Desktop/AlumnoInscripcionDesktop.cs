using System;
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
    public partial class AlumnoInscripcionDesktop : ApplicationForm
    {
        public AlumnoInscripcionDesktop()
        {
            InitializeComponent();
        }

        public AlumnoInscripcion InsActual { get; set; }

        public AlumnoInscripcionDesktop (ModoForm modo) : this()
        {
            Modo = modo;
        }

        public AlumnoInscripcionDesktop (int id, ModoForm modo) : this()
        {
            Modo = modo;
            AlumnoInscripcionLogic ail = new AlumnoInscripcionLogic();
            InsActual = ail.GetOne(id);
            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            tbIdAlumno.Text = InsActual.IDAlumno.ToString();
            tbIdCurso.Text = InsActual.IDCurso.ToString();
            tbIdIns.Text = InsActual.ID.ToString();
            tbNota.Text = InsActual.Nota.ToString();
            tbCondicion.Text = InsActual.Condicion;

            switch (Modo)
            {
                case ModoForm.Alta:
                    btnAceptar.Text = "Guardar";
                    break;

                case ModoForm.Modificacion:
                    btnAceptar.Text = "Guardar";
                    break;

                case ModoForm.Baja:
                    btnAceptar.Text = "Eliminar";
                    break;

                case ModoForm.Consulta:
                    btnAceptar.Text = "Aceptar";
                    break;
            }
        }

        public override void MapearADatos()
        {
            switch (Modo)
            {
                case ModoForm.Alta:
                    AlumnoInscripcion inscripcion = new AlumnoInscripcion();
                    InsActual = inscripcion;
                    InsActual.IDAlumno = Convert.ToInt32(tbIdAlumno.Text);
                    InsActual.IDCurso = Convert.ToInt32(tbIdCurso.Text);
                    InsActual.Nota = Convert.ToInt32(tbNota.Text);
                    InsActual.Condicion = tbCondicion.Text;
                    InsActual.State = BusinessEntity.States.New;
                    break;

                case ModoForm.Modificacion:
                    InsActual.IDAlumno = Convert.ToInt32(tbIdAlumno.Text);
                    InsActual.IDCurso = Convert.ToInt32(tbIdCurso.Text);
                    InsActual.Nota = Convert.ToInt32(tbNota.Text);
                    InsActual.Condicion = tbCondicion.Text;
                    InsActual.State = BusinessEntity.States.Modified;
                    break;

                case ModoForm.Baja:
                    InsActual.State = BusinessEntity.States.Deleted;
                    break;
                    
                case ModoForm.Consulta:
                    InsActual.State = BusinessEntity.States.Modified;
                    break;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            AlumnoInscripcionLogic ail = new AlumnoInscripcionLogic();
            ail.Save(InsActual);
        }

        public override bool Validar()
        {
            if(tbCondicion.Text == "" || tbIdAlumno.Text == "" || tbIdCurso.Text == "" || tbCondicion.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                Close();
            }
            else
            {
                Notificar("Faltan completar campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
