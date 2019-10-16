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
    public partial class ModuloDesktop : ApplicationForm
    {
        public ModuloDesktop()
        {
            InitializeComponent();
        }

        public Modulo ModuloActual { get; set;}

        public ModuloDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }

        public ModuloDesktop (int ID, ModoForm modo) : this()
        {
            Modo = modo;
            ModuloLogic ml = new ModuloLogic();
            ModuloActual = ml.GetOne(ID);
            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            tbId.Text = ModuloActual.ID.ToString();
            tbDesc.Text = ModuloActual.Descripcion;
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
                    ModuloActual = new Modulo();
                    ModuloActual.Descripcion = tbDesc.Text;
                    ModuloActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    ModuloActual.Descripcion = tbDesc.Text;
                    ModuloActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Baja:
                    ModuloActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Consulta:
                    ModuloActual.State = BusinessEntity.States.Modified;
                    break;
            }
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            ModuloLogic ml = new ModuloLogic();
            ml.Save(ModuloActual);
        }

        public override bool Validar()
        {
            if (tbDesc.Text == null)
            {
                Notificar("Campos Obligatorios Vacios", "Existen uno o mas campos vacios, rellenelos antes de continuar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
