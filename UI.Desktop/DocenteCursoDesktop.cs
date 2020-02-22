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
            tbIdCurso.Text = DocCursoActual.IDCurso.ToString();
            tbIdDocente.Text = DocCursoActual.IDDocente.ToString();
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

        public override void MapearADatos()
        {
            switch (Modo)
            {
                case ModoForm.Alta:
                    DocenteCurso dc = new DocenteCurso();
                    DocCursoActual = dc;
                    DocCursoActual.IDCurso = Convert.ToInt32(tbIdCurso.Text);
                    DocCursoActual.IDDocente = Convert.ToInt32(tbIdDocente.Text);
                    DocCursoActual.Cargo = (DocenteCurso.TiposCargo)cbCargo.SelectedItem;
                    DocCursoActual.State = BusinessEntity.States.New;
                    break;

                case ModoForm.Modificacion:
                    DocCursoActual.IDCurso = Convert.ToInt32(tbIdCurso.Text);
                    DocCursoActual.IDDocente = Convert.ToInt32(tbIdDocente);
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

        public override void GuardarCambios()
        {
            MapearADatos();
            DocenteCursoLogic dcl = new DocenteCursoLogic();
            dcl.Save(DocCursoActual);
        }

        public override bool Validar()
        {
            if (tbIdCurso.Text == "" || tbIdDocente.Text == "" || cbCargo.Text == "")
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
