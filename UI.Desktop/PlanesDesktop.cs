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
    public partial class PlanesDesktop : ApplicationForm
    {
        public PlanesDesktop()
        {
            InitializeComponent();
        }

        public Plan PlanActual { get; set; }

        public PlanesDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }

        public PlanesDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            PlanLogic pl = new PlanLogic();
            PlanActual = pl.GetOne(ID);
            MapearDeDatos();
        }

        public override void MapearADatos()
        {
            switch (Modo)
            {
                case ModoForm.Alta:
                    PlanActual = new Plan();
                    PlanActual.Descripcion = textBoxDescripcion.Text;
                    PlanActual.IDEspecialidad = (int)((DataRowView)comboBoxIDEspecialidad.SelectedItem).Row.ItemArray[0];
                    PlanActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    PlanActual.Descripcion = textBoxDescripcion.Text;
                    PlanActual.IDEspecialidad = (int)((DataRowView)comboBoxIDEspecialidad.SelectedItem).Row.ItemArray[0];
                    PlanActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Baja:
                    PlanActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Consulta:
                    PlanActual.State = BusinessEntity.States.Modified;
                    break;
            }
        }

        public override void MapearDeDatos()
        {
            textBoxID.Text = PlanActual.ID.ToString();
            textBoxDescripcion.Text = PlanActual.Descripcion;
            comboBoxIDEspecialidad.SelectedItem = PlanActual;
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
            PlanLogic pl = new PlanLogic();
            pl.Save(PlanActual);
        }
        public override bool Validar()
        {
            if (textBoxDescripcion.Text == "" || comboBoxIDEspecialidad.Text == "")
                return false;
            else
                return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PlanesDesktop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tp2_netDataSet.especialidades' table. You can move, or remove it, as needed.
            this.especialidadesTableAdapter.Fill(this.tp2_netDataSet.especialidades);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                
                Close();
            }
            else
                Notificar("Verifique que todos los campos esten completos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
