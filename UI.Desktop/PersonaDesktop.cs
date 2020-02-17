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
    public partial class PersonaDesktop : ApplicationForm
    {
        public PersonaDesktop()
        {
            InitializeComponent();
        }

        private Business.Entities.Persona PersonaActual { get; set; }

        public PersonaDesktop(int id, ModoForm modo)
        {
            InitializeComponent();
            Modo = modo;
            PersonaLogic pl = new PersonaLogic();
            PersonaActual = pl.GetOne(id);
            MapearDeDatos();
        }

        public PersonaDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }

        public override void MapearADatos()
        {
            switch (Modo)
            {
                case ModoForm.Alta:
                    PersonaActual = new Business.Entities.Persona();
                    PersonaActual.Nombre = textBoxNombre.Text;
                    PersonaActual.Apellido = textBoxApellido.Text;
                    PersonaActual.Direccion = textBoxDireccion.Text;
                    PersonaActual.Telefono = textBoxTelefono.Text;
                    PersonaActual.FechaNacimiento = dateTimePersona.Value;
                    PersonaActual.IDPlan = (int)((DataRowView)comboBoxIdPlan.SelectedItem).Row.ItemArray[0];
                    PersonaActual.Legajo = int.Parse(textBoxLegajo.Text);
                    PersonaActual.Email = textBoxEmail.Text;
                    switch(comboBoxTipo.Text)
                    {
                        case "Alumno":
                            PersonaActual.TipoPersona = Business.Entities.Persona.TiposPersona.Alumno;
                            break;
                        case "Profesor":
                            PersonaActual.TipoPersona = Business.Entities.Persona.TiposPersona.Profesor;
                            break;
                        case "Admin":
                            PersonaActual.TipoPersona = Business.Entities.Persona.TiposPersona.Admin;
                            break;
                    }                     
                    PersonaActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Modificacion:
                    PersonaActual.Nombre = textBoxNombre.Text;
                    PersonaActual.Apellido = textBoxApellido.Text;
                    PersonaActual.Direccion = textBoxDireccion.Text;
                    PersonaActual.Telefono = textBoxTelefono.Text;
                    PersonaActual.FechaNacimiento = dateTimePersona.Value;
                    PersonaActual.IDPlan = (int)((DataRowView)comboBoxIdPlan.SelectedItem).Row.ItemArray[0];
                    PersonaActual.Legajo = int.Parse(textBoxLegajo.Text);
                    PersonaActual.Email = textBoxEmail.Text;
                    switch (comboBoxTipo.Text)
                    {
                        case "Alumno":
                            PersonaActual.TipoPersona = Business.Entities.Persona.TiposPersona.Alumno;
                            break;
                        case "Profesor":
                            PersonaActual.TipoPersona = Business.Entities.Persona.TiposPersona.Profesor;
                            break;
                        case "Admin":
                            PersonaActual.TipoPersona = Business.Entities.Persona.TiposPersona.Admin;
                            break;
                    }
                    PersonaActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Baja:
                    PersonaActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Consulta:
                    PersonaActual.State = BusinessEntity.States.Modified;
                    break;
            }
        }

        public override void MapearDeDatos()
        {
            textBoxNombre.Text=PersonaActual.Nombre;
            textBoxApellido.Text = PersonaActual.Apellido;
            textBoxLegajo.Text = PersonaActual.Legajo.ToString(); ;
            textBoxDireccion.Text = PersonaActual.Direccion;
            textBoxTelefono.Text = PersonaActual.Telefono;
            textBoxEmail.Text = PersonaActual.Email;
            comboBoxIdPlan.SelectedItem = PersonaActual;
            comboBoxTipo.SelectedItem = PersonaActual.TipoPersona.ToString();
            dateTimePersona.Value = PersonaActual.FechaNacimiento;
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
            PersonaLogic pl = new PersonaLogic();
            pl.Save(PersonaActual);
        }
        public override bool Validar()
        {
            if (textBoxNombre.Text == "" || textBoxApellido.Text == "" || textBoxLegajo.Text == "" || textBoxDireccion.Text == "" || textBoxTelefono.Text == "" || textBoxEmail.Text == "")
                return false;
            else
                return true;
        }
        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();

                Close();
            }
            else
                Notificar("Verifique que todos los campos esten completos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PersonaDesktop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tp2_netDataSet.planes' table. You can move, or remove it, as needed.
            this.planesTableAdapter.Fill(this.tp2_netDataSet.planes);

        }
    }
}
