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
    public partial class EspecialidadDesktop : ApplicationForm
    {
        public Especialidad EspActual { set; get; }

        public EspecialidadDesktop()
        {
            InitializeComponent();
        }

        public override void MapearDeDatos()
        {
            tbId.Text = EspActual.ID.ToString();
            tbDesc.Text = EspActual.Descripcion;

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
                    Especialidad newEsp = new Especialidad();
                    EspActual = newEsp;
                    EspActual.Descripcion = tbDesc.Text;
                    EspActual.State = Especialidad.States.New;
                    break;

                case ModoForm.Modificacion:
                    EspActual.Descripcion = tbDesc.Text;
                    EspActual.State = Especialidad.States.Modified;
                    break;

                case ModoForm.Baja:
                    EspActual.State = Especialidad.States.Deleted;
                    break;

                case ModoForm.Consulta:
                    EspActual.State = Especialidad.States.Modified;
                    break;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            EspecialidadLogic el = new EspecialidadLogic();
            el.Save(EspActual);
        }

        public EspecialidadDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }

        public EspecialidadDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            EspecialidadLogic el = new EspecialidadLogic();
            EspActual = el.GetOne(ID);
            MapearDeDatos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            GuardarCambios();
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
