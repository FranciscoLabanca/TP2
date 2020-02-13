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
                    ComisionActual.IDPlan = (int)((DataRowView)cbIdPlan.SelectedItem).Row.ItemArray[0];
                    ComisionActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    ComisionActual.Descripcion = tbDesc.Text;
                    ComisionActual.AnioEspecialidad = Convert.ToInt32(tbAnioEsp.Text);
                    ComisionActual.IDPlan = (int)((DataRowView)cbIdPlan.SelectedItem).Row.ItemArray[0];
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
            cbIdPlan.SelectedItem = ComisionActual;
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
            // TODO: esta línea de código carga datos en la tabla 'tp2_netDataSet.especialidades' Puede moverla o quitarla según sea necesario.
            this.especialidadesTableAdapter.Fill(this.tp2_netDataSet.especialidades);
            // TODO: esta línea de código carga datos en la tabla 'tp2_netDataSet.planes' Puede moverla o quitarla según sea necesario.
            planesTableAdapter.Fill(tp2_netDataSet.planes);
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

        private List<Plan> BuscarPlanPorId(int id)
        {
            //tp2_netDataSet.planesDataTable planes = new tp2_netDataSet.planesDataTable();
            PlanLogic pl = new PlanLogic();
            List<Plan> lista = pl.GetAll();
            List<Plan> planes = new List<Plan>();
            foreach(Plan p in lista)
            {
                if(p.ID == id)
                {
                    planes.Add(p);
                }
            }
            return planes;
        }
    }
}
