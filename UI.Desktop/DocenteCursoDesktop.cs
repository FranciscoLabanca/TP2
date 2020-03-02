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
    public partial class DocenteCursoDesktop : ApplicationForm
    {
        public DocenteCursoDesktop()
        {
            InitializeComponent();
        }

        public DocenteCurso DocCursoActual { get; set; }

        public DocenteCursoDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }


        public DocenteCursoDesktop (int id, ModoForm modo) : this()
        {
            Modo = modo;
            DocenteCursoLogic dcl = new DocenteCursoLogic();
            DocCursoActual = dcl.GetOne(id);
            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            tbIdDictado.Text = DocCursoActual.ID.ToString();
            //tbIdCurso.Text = DocCursoActual.IDCurso.ToString();
            //tbIdDocente.Text = DocCursoActual.IDDocente.ToString();
            cbCargo.SelectedItem = DocCursoActual.Cargo;

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
                    DocenteCurso dc = new DocenteCurso();
                    DocCursoActual = dc;
                    DocCursoActual.IDCurso = id_curso;
                    DocCursoActual.IDDocente = ((Persona)cbDocente.SelectedItem).ID;
                    DocCursoActual.Cargo = (DocenteCurso.TiposCargo)cbCargo.SelectedItem;
                    DocCursoActual.State = BusinessEntity.States.New;
                    break;

                case ModoForm.Modificacion:
                    DocCursoActual.IDCurso = id_curso;
                    DocCursoActual.IDDocente = ((Persona)cbDocente.SelectedItem).ID;
                    DocCursoActual.Cargo = (DocenteCurso.TiposCargo)cbCargo.SelectedItem;
                    DocCursoActual.State = BusinessEntity.States.Modified;
                    break;

                case ModoForm.Baja:
                    DocCursoActual.State = BusinessEntity.States.Deleted;
                    break;

                case ModoForm.Consulta:
                    DocCursoActual.State = BusinessEntity.States.Modified;
                    break;
            }
        }

        public void GuardarCambios(int id_curso)
        {
            MapearADatos(id_curso);
            DocenteCursoLogic dcl = new DocenteCursoLogic();
            dcl.Save(DocCursoActual);
        }

        public override bool Validar()
        {

            if (cbCargo.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void DocenteCursoDesktop_Load(object sender, EventArgs e)
        {
            cbCargo.DataSource = Enum.GetValues(typeof(DocenteCurso.TiposCargo));
            PersonaLogic pl = new PersonaLogic();
            List<Persona> profesores = pl.GetDocentes();
            cbDocente.DataSource = profesores;
            cbDocente.DisplayMember = "Legajo";
            cbDocente.ValueMember = "ID";
        }

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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbDocente_SelectedIndexChanged(object sender, EventArgs e)
        {
            MateriaLogic ml = new MateriaLogic();
            List<Materia> materias = ml.GetMateriasByPlan(((Persona)cbDocente.SelectedItem).IDPlan);
            cbMateria.DataSource = materias;
            cbMateria.DisplayMember = "Descripcion";
            cbMateria.ValueMember = "ID";

            ComisionLogic cl = new ComisionLogic();
            List<Comision> comisiones = cl.GetComisionByPlan(((Persona)cbDocente.SelectedItem).IDPlan);
            cbComision.DataSource = comisiones;
            cbComision.DisplayMember = "Descripcion";
            cbComision.ValueMember = "ID";
        }

        private int BuscarCurso(int id_materia, int id_comision)
        {
            CursoLogic cl = new CursoLogic();
            List<Curso> cursos = cl.GetAll();
            int id_curso = 0;
            foreach (Curso c in cursos)
            {
                if (c.IDComision == id_comision && c.IDMateria == id_materia)
                {
                    id_curso = c.ID;
                    break;
                }
            }
            return id_curso;
        }
    }
}
