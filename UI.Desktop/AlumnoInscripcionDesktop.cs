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

        public Persona PersonaActual { set; get; }

        public AlumnoInscripcionDesktop (ModoForm modo) : this()
        {
            Modo = modo;
        }

        public AlumnoInscripcionDesktop(ModoForm modo, Persona persona) : this()
        {
            Modo = modo;
            PersonaActual = persona;
            tbIdAlumno.Text = persona.ID.ToString();
            tbIdAlumno.ReadOnly = true;
            tbNota.ReadOnly = true;
            tbCondicion.ReadOnly = true;
            
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
            //tbIdCurso.Text = InsActual.IDCurso.ToString();
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

        public void MapearADatos(int id_curso)
        {
            switch (Modo)
            {
                case ModoForm.Alta:
                    AlumnoInscripcion inscripcion = new AlumnoInscripcion();
                    InsActual = inscripcion;
                    InsActual.IDAlumno = Convert.ToInt32(tbIdAlumno.Text);
                    InsActual.IDCurso = id_curso;
                    InsActual.Condicion = "Cursando";
                    InsActual.State = BusinessEntity.States.New;
                    break;

                case ModoForm.Modificacion:
                    InsActual.IDAlumno = Convert.ToInt32(tbIdAlumno.Text);
                    InsActual.IDCurso = id_curso;
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

        public void GuardarCambios(int id_curso)
        {
            MapearADatos(id_curso);
            AlumnoInscripcionLogic ail = new AlumnoInscripcionLogic();
            ail.Save(InsActual);
        }

        /*public override bool Validar()
        {
            if(tbCondicion.Text == "" || tbIdAlumno.Text == "" || tbCondicion.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }*/

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int id_curso = BuscarCurso(((Materia)cbMateria.SelectedItem).ID, ((Comision)cbComision.SelectedItem).ID);
            if(id_curso == 0)
            {
                Notificar("Esa materia no existe en esa comision", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                GuardarCambios(id_curso);
                Close();
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AlumnoInscripcionDesktop_Load(object sender, EventArgs e)
        {
            MateriaLogic ml = new MateriaLogic();
            List<Materia> materias = ml.GetMateriasByPlan(PersonaActual.IDPlan);
            cbMateria.DataSource = materias;
            cbMateria.DisplayMember = "Descripcion";
            cbMateria.ValueMember = "ID";

            ComisionLogic cl = new ComisionLogic();
            List<Comision> comisions = cl.GetComisionByPlan(PersonaActual.IDPlan);
            cbComision.DataSource = comisions;
            cbComision.DisplayMember = "Descripcion";
            cbComision.ValueMember = "ID";
        }

        private int BuscarCurso(int id_materia, int id_comision)
        {
            CursoLogic cl = new CursoLogic();
            List<Curso> cursos = cl.GetAll();
            int id_curso = 0;
            foreach(Curso c in cursos)
            {
                if(c.IDComision == id_comision && c.IDMateria == id_materia)
                {
                    id_curso = c.ID;
                    break;
                }
            }
            return id_curso;
        }

    }
}
