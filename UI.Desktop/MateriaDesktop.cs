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
    public partial class MateriaDesktop : ApplicationForm
    {
        public MateriaDesktop()
        {
            InitializeComponent();
        }

        public Materia MateriaActual { get; set; }

        public MateriaDesktop(ModoForm modo):this()
        {
            Modo = modo;
        }

        public MateriaDesktop(int Id, ModoForm modo) : this()
        {
            Modo = modo;
            MateriaLogic ml = new MateriaLogic();
            MateriaActual = ml.GetOne(Id);
            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            tbId.Text = MateriaActual.ID.ToString();
            tbDesc.Text = MateriaActual.Descripcion;
            tbHsSem.Text = MateriaActual.HSSemanales.ToString();
            tbHsTot.Text = MateriaActual.HSTotales.ToString();
            cbEspecialidad.SelectedValue = BuscarEspecialidad(MateriaActual.IDPlan);
            cbIdPlan.SelectedValue = MateriaActual.IDPlan;
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
                    MateriaActual = new Materia();
                    MateriaActual.Descripcion = tbDesc.Text;
                    MateriaActual.HSSemanales = Int32.Parse(tbHsSem.Text);
                    MateriaActual.HSTotales = Int32.Parse(tbHsTot.Text);
                    MateriaActual.IDPlan = ((Plan)cbIdPlan.SelectedItem).ID;
                    MateriaActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    MateriaActual.Descripcion = tbDesc.Text;
                    MateriaActual.HSSemanales = Int32.Parse(tbHsSem.Text);
                    MateriaActual.HSTotales = Int32.Parse(tbHsTot.Text);
                    MateriaActual.IDPlan = ((Plan)cbIdPlan.SelectedItem).ID;
                    MateriaActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Baja:
                    MateriaActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Consulta:
                    MateriaActual.State = BusinessEntity.States.Modified;
                    break;
            }
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            MateriaLogic ml = new MateriaLogic();
            ml.Save(MateriaActual);
        }
        public override bool Validar()
        {
            if(tbDesc.Text == "" || tbHsSem.Text == "" || tbHsTot.Text == "" || cbIdPlan.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        private void MateriaDesktop_Load(object sender, EventArgs e)
        {
            EspecialidadLogic el = new EspecialidadLogic();
            List<Especialidad> especialidades = el.GetAll();
            cbEspecialidad.DataSource = especialidades;
            cbEspecialidad.DisplayMember = "Descripcion";
            cbEspecialidad.ValueMember = "ID";

            List<Plan> planes = new List<Plan>();
            planes = FiltrarPorId(((Especialidad)cbEspecialidad.SelectedItem).ID);

            cbIdPlan.DataSource = planes;
            cbIdPlan.DisplayMember = "Descripcion";
            cbIdPlan.ValueMember = "ID";
            if (Modo == ModoForm.Modificacion || Modo == ModoForm.Baja)
            {
                MapearDeDatos();
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

        private List<Plan> FiltrarPorId(int id)
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

        private void cbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Plan> planes = new List<Plan>();
            planes = FiltrarPorId(((Especialidad)cbEspecialidad.SelectedItem).ID);

            cbIdPlan.DataSource = planes;
            cbIdPlan.DisplayMember = "Descripcion";
            cbIdPlan.ValueMember = "ID";
        }

        private Especialidad BuscarEspecialidad(int id_plan)
        {
            PlanLogic pl = new PlanLogic();
            Plan plan = pl.GetOne(id_plan);
            EspecialidadLogic el = new EspecialidadLogic();
            List<Especialidad> lista = el.GetAll();
            Especialidad especialidad = new Especialidad();
            foreach(Especialidad esp in lista)
            {
                if(plan.IDEspecialidad == esp.ID)
                {
                    especialidad = esp;
                }
            }
            return especialidad;

        }
    }
}
