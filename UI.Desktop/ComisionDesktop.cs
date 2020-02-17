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
    public partial class ComisionDesktop : ApplicationForm
    {
        public ComisionDesktop()
        {
            InitializeComponent();
        }

        public Comision ComisionActual { get; set; }

        public ComisionDesktop (ModoForm modo) : this()
        {
            Modo = modo;
        }

        public ComisionDesktop (int ID, ModoForm modo) : this()
        {
            Modo = modo;
            ComisionLogic cl = new ComisionLogic();
            ComisionActual = cl.GetiOne(ID);
            MapearDeDatos();
        }

        public override void MapearADatos()
        {
            switch (Modo)
            {
                case ModoForm.Alta:
                    ComisionActual = new Comision();
                    ComisionActual.Descripcion = tbDesc.Text;
                    ComisionActual.AnioEspecialidad = Convert.ToInt32(tbAnioEsp.Text);
                    ComisionActual.IDPlan = (int)cbIdPlan.SelectedValue;
                    ComisionActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    ComisionActual.Descripcion = tbDesc.Text;
                    Notificar(ComisionActual.Descripcion, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ComisionActual.AnioEspecialidad = Convert.ToInt32(tbAnioEsp.Text);
                    ComisionActual.IDPlan = (int)cbIdPlan.SelectedValue;
                    ComisionActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Baja:
                    ComisionActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Consulta:
                    ComisionActual.State = BusinessEntity.States.Modified;
                    break;
            }
        }

        public override void MapearDeDatos()
        {
            tbId.Text = ComisionActual.ID.ToString();
            tbDesc.Text = ComisionActual.Descripcion;
            tbAnioEsp.Text = ComisionActual.AnioEspecialidad.ToString();
            cbEspecialidad.SelectedValue = buscarEspecialidad(ComisionActual.IDPlan).ID;
            cbIdPlan.SelectedValue = ComisionActual.ID;
            
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

        public override void GuardarCambios()
        {
            MapearADatos();
            ComisionLogic cl = new ComisionLogic();
            cl.Save(ComisionActual);
        }

        public override bool Validar()
        {
            if(tbAnioEsp.Text == "" || tbDesc.Text == "" || cbIdPlan.Text == "" )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ComisionDesktop_Load(object sender, EventArgs e)
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

            if(Modo == ModoForm.Modificacion || Modo == ModoForm.Baja)
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
                Notificar("Verifique que todos los campos esten completos y son correctos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private List<Plan> FiltrarPorId (int id)
        {
            List<Plan> listaPlanes = new List<Plan>();
            List<Plan> lista = new List<Plan>();
            PlanLogic pl = new PlanLogic();
            listaPlanes = pl.GetAll();

            foreach(Plan plan in listaPlanes)
            {
                if(plan.IDEspecialidad == id)
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

        private Especialidad buscarEspecialidad (int id_plan)
        {
            Plan plan = new Plan();
            PlanLogic pl = new PlanLogic();
            plan = pl.GetOne(id_plan);

            Especialidad esp = new Especialidad();
            EspecialidadLogic el = new EspecialidadLogic();
            esp = el.GetOne(plan.IDEspecialidad);


            return esp;            
        }

    }
}
