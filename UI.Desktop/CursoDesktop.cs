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
    public partial class CursoDesktop : ApplicationForm
    {
        public CursoDesktop()
        {
            InitializeComponent();
        }

        public Curso CursoActual { get; set; }

        public CursoDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }

        public CursoDesktop(int id, ModoForm modo) : this()
        {
            Modo = modo;
            CursoLogic cl = new CursoLogic();
            CursoActual = cl.GetOne(id);
            MapearDeDatos();
        }

        private void CursoDesktop_Load(object sender, EventArgs e)
        {
            EspecialidadLogic el = new EspecialidadLogic();
            List<Especialidad> especialidades = el.GetAll();
            cbEspecialidad.DataSource = especialidades;
            cbEspecialidad.DisplayMember = "Descripcion";
            cbEspecialidad.ValueMember = "ID";
            

            List<Plan> planes = new List<Plan>();
            planes = FiltrarPlanPorId(((Especialidad)cbEspecialidad.SelectedItem).ID);
            cbPlan.DataSource = planes;
            cbPlan.DisplayMember = "Descripcion";
            cbPlan.ValueMember = "ID";

            List<Comision> comisiones = new List<Comision>();
            comisiones = FiltarComisionPorId(((Plan)cbPlan.SelectedItem).ID);
            cbComision.DataSource = comisiones;
            cbComision.DisplayMember = "Descripcion";
            cbComision.ValueMember = "ID";

            List<Materia> materias = new List<Materia>();
            materias = FiltarMateriaPorId(((Plan)cbPlan.SelectedItem).ID);
            cbMateria.DataSource = materias;
            cbMateria.DisplayMember = "Descripcion";
            cbMateria.ValueMember = "ID";

            if(Modo == ModoForm.Modificacion || Modo == ModoForm.Baja)
            {
                MapearDeDatos();
            }
        }

        private List<Plan> FiltrarPlanPorId(int id)
        {
            List<Plan> listaPlanes = new List<Plan>();
            List<Plan> lista = new List<Plan>();
            PlanLogic pl = new PlanLogic();
            listaPlanes = pl.GetAll();

            foreach (Plan plan in listaPlanes)
            {
                if (plan.IDEspecialidad == id)
                {
                    lista.Add(plan);
                }
            }
            return lista;
        }

        private List<Comision> FiltarComisionPorId (int id)
        {
            List<Comision> listaComisiones = new List<Comision>();
            List<Comision> comisiones = new List<Comision>();
            ComisionLogic cl = new ComisionLogic();
            listaComisiones = cl.GetAll();

            foreach(Comision com in listaComisiones)
            {
                if(com.IDPlan == id)
                {
                    comisiones.Add(com);
                }
            }
            return comisiones;
        }

        private List<Materia> FiltarMateriaPorId (int id)
        {
            List<Materia> listaMaterias = new List<Materia>();
            List<Materia> materias = new List<Materia>();
            MateriaLogic ml = new MateriaLogic();
            listaMaterias = ml.GetAll();

            foreach(Materia mat in listaMaterias)
            {
                if(mat.IDPlan == id)
                {
                    materias.Add(mat);
                }
            }
            return materias;
        }

        public override void MapearDeDatos()
        {
            tbId.Text = CursoActual.ID.ToString();
            tbAnioCalendario.Text = CursoActual.AnioCalendario.ToString();
            tbCupo.Text = CursoActual.Cupo.ToString();
            Plan plan = BuscarPlan(CursoActual.IDMateria);
            cbEspecialidad.SelectedValue = BuscarEspecialidad(plan.ID).ID;
            cbMateria.SelectedValue = plan.ID;
            cbComision.SelectedValue = CursoActual.IDComision;
            cbMateria.SelectedValue = CursoActual.IDMateria;
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
                    CursoActual = new Curso();
                    CursoActual.AnioCalendario = Int32.Parse(tbAnioCalendario.Text);
                    CursoActual.Cupo = Int32.Parse(tbCupo.Text);
                    CursoActual.IDComision = ((Comision)cbComision.SelectedItem).ID;
                    CursoActual.IDMateria = ((Materia)cbMateria.SelectedItem).ID;
                    CursoActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    CursoActual.AnioCalendario = Int32.Parse(tbAnioCalendario.Text);
                    CursoActual.Cupo = Int32.Parse(tbCupo.Text);
                    CursoActual.IDComision = ((Comision)cbComision.SelectedItem).ID;
                    CursoActual.IDMateria = ((Materia)cbMateria.SelectedItem).ID;
                    CursoActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Baja:
                    CursoActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Consulta:
                    CursoActual.State = BusinessEntity.States.Modified;
                    break;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            CursoLogic cl = new CursoLogic();
            cl.Save(CursoActual);
        }

        public override bool Validar()
        {
            if(tbAnioCalendario.Text == "" || tbCupo.Text == "" || cbMateria.Text =="" || cbComision.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
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
                Notificar("Verifique que todos los campos esten completos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Plan> planes = new List<Plan>();
            planes = FiltrarPlanPorId(((Especialidad)cbEspecialidad.SelectedItem).ID);
            cbPlan.DataSource = planes;
            cbPlan.DisplayMember = "Descripcion";
            cbPlan.ValueMember = "ID";

            List<Comision> comisiones = new List<Comision>();
            comisiones = FiltarComisionPorId(((Plan)cbPlan.SelectedItem).ID);
            cbComision.DataSource = comisiones;
            cbComision.DisplayMember = "Descripcion";
            cbComision.ValueMember = "ID";

            List<Materia> materias = new List<Materia>();
            materias = FiltarMateriaPorId(((Plan)cbPlan.SelectedItem).ID);
            cbMateria.DataSource = materias;
            cbMateria.DisplayMember = "Descripcion";
            cbMateria.ValueMember = "ID";
        }

        private void cbPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Comision> comisiones = new List<Comision>();
            comisiones = FiltarComisionPorId(((Plan)cbPlan.SelectedItem).ID);
            cbComision.DataSource = comisiones;
            cbComision.DisplayMember = "Descripcion";
            cbComision.ValueMember = "ID";

            List<Materia> materias = new List<Materia>();
            materias = FiltarMateriaPorId(((Plan)cbPlan.SelectedItem).ID);
            cbMateria.DataSource = materias;
            cbMateria.DisplayMember = "Descripcion";
            cbMateria.ValueMember = "ID";
        }

        private Especialidad BuscarEspecialidad(int id_plan)
        {
            Plan plan = new Plan();
            PlanLogic pl = new PlanLogic();
            plan = pl.GetOne(id_plan);

            Especialidad esp = new Especialidad();
            EspecialidadLogic el = new EspecialidadLogic();
            esp = el.GetOne(plan.IDEspecialidad);


            return esp;
        }

        private Plan BuscarPlan (int id_materia)
        {
            MateriaLogic ml = new MateriaLogic();
            Materia materia = ml.GetOne(id_materia);

            PlanLogic pl = new PlanLogic();
            Plan plan = pl.GetOne(materia.IDPlan);

            return plan;
        }
    }
}
