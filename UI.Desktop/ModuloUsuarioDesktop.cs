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
    public partial class ModuloUsuarioDesktop : ApplicationForm
    {
        public ModuloUsuarioDesktop()
        {
            InitializeComponent();
        }

        public ModuloUsuarioDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }

        public ModuloUsuarioDesktop(int id, ModoForm modo) : this()
        {
            Modo = modo;
            ModuloUsuarioLogic mul = new ModuloUsuarioLogic();
            MUActual = mul.GetOne(id);
            MapearDeDatos();
        }

        private void ModuloUsuarioDesktop_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2_netDataSet.modulos' Puede moverla o quitarla según sea necesario.
            this.modulosTableAdapter.Fill(this.tp2_netDataSet.modulos);
            // TODO: esta línea de código carga datos en la tabla 'tp2_netDataSet.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.tp2_netDataSet.usuarios);
        }

        public ModuloUsuario MUActual { set; get; }

        public override void MapearDeDatos()
        {
            tbId.Text = MUActual.ID.ToString();
            cbAlta.Checked = MUActual.PermiteAlta;
            cbBaja.Checked = MUActual.PermiteBaja;
            cbModificacion.Checked = MUActual.PermiteModificacion;
            cbConsulta.Checked = MUActual.PermiteConsulta;

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
                    ModuloUsuario mu = new ModuloUsuario();
                    MUActual = mu;
                    MUActual.IdModulo = (int)((DataRowView)cbModulo.SelectedItem).Row.ItemArray[0];
                    MUActual.IdUsuario = (int)((DataRowView)cbUsuario.SelectedItem).Row.ItemArray[0];
                    MUActual.PermiteAlta = cbAlta.Checked;
                    MUActual.PermiteBaja = cbBaja.Checked;
                    MUActual.PermiteModificacion= cbModificacion.Checked;
                    MUActual.PermiteConsulta = cbConsulta.Checked;
                    MUActual.State = Usuario.States.New;
                    break;

                case ModoForm.Modificacion:
                    MUActual.IdModulo = (int)((DataRowView)cbModulo.SelectedItem).Row.ItemArray[0];
                    MUActual.IdUsuario = (int)((DataRowView)cbUsuario.SelectedItem).Row.ItemArray[0];
                    MUActual.PermiteAlta = cbAlta.Checked;
                    MUActual.PermiteBaja = cbBaja.Checked;
                    MUActual.PermiteModificacion = cbModificacion.Checked;
                    MUActual.PermiteConsulta = cbConsulta.Checked;
                    MUActual.State = BusinessEntity.States.Modified;
                    break;

                case ModoForm.Baja:
                    MUActual.State = Usuario.States.Deleted;
                    break;

                case ModoForm.Consulta:
                    MUActual.State = Usuario.States.Modified;
                    break;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            ModuloUsuarioLogic mul = new ModuloUsuarioLogic();
            mul.Save(MUActual);
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
