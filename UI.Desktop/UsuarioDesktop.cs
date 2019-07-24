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
    public partial class UsuarioDesktop : ApplicationForm
    {
        public Usuario UsuarioActual { set; get; }

        public override void MapearDeDatos()
        {
            tbID.Text = UsuarioActual.ID.ToString();
            tbNombre.Text = UsuarioActual.Nombre;
            tbEmail.Text = UsuarioActual.EMail;
            tbClave.Text = UsuarioActual.Clave;
            checkBoxHabilitado.Checked = UsuarioActual.Habilitado;
            tbApellido.Text = UsuarioActual.Apellido;
            tbUsuario.Text = UsuarioActual.NombreUsuario;

            switch(Modo)
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
                    Usuario newUsuario = new Usuario();
                    UsuarioActual = newUsuario;
                    UsuarioActual.Nombre = tbNombre.Text;
                    UsuarioActual.EMail = tbEmail.Text;
                    UsuarioActual.Clave = tbClave.Text;
                    UsuarioActual.Habilitado = checkBoxHabilitado.Checked;
                    UsuarioActual.Apellido = tbApellido.Text;
                    UsuarioActual.NombreUsuario = tbUsuario.Text;
                    UsuarioActual.State = Usuario.States.New;
                    break;

                case ModoForm.Modificacion:
                    UsuarioActual.Nombre = tbNombre.Text;
                    UsuarioActual.EMail = tbEmail.Text;
                    UsuarioActual.Clave = tbClave.Text;
                    UsuarioActual.Habilitado = checkBoxHabilitado.Checked;
                    UsuarioActual.Apellido = tbApellido.Text;
                    UsuarioActual.NombreUsuario = tbUsuario.Text;
                    UsuarioActual.State = Usuario.States.Modified;
                    break;

                case ModoForm.Baja:
                    
                    break;

                case ModoForm.Consulta:
                    
                    break;
            }
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            UsuarioLogic ul = new UsuarioLogic();
            ul.Save(UsuarioActual);
        }
        public bool Validar()
        {
            if (tbNombre.Text != null && tbApellido.Text != null && tbEmail.Text != null && tbUsuario != null && tbClave != null)
            {
                if (tbClave.Text.Length >= 8)
                {
                    if (tbClave.Text == tbConfClave.Text)
                    {
                        if (ValidarMail(tbEmail.Text))
                        {
                            return true;
                        }
                        else
                        {
                            this.Notificar("Mail Invalido", "El Email ingresado es invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }

                    }
                    else
                    {
                        this.Notificar("Confimar Clave y clave no coinciden", "Los campos de clave no coinciden, verifiquelos e intente nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }
                else
                {
                    this.Notificar("Contraseña Invalida", "La contraseña debe tener al menos 8 caracteres", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            else
            {
                this.Notificar("Campos Obligatorios Vacios", "Existen uno o mas campos vacios, rellenelos antes de continuar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }
/*
        public void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }

        public void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }
        */
        public UsuarioDesktop()
        {
            InitializeComponent();
        }

        public UsuarioDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }

        public UsuarioDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            UsuarioLogic ul = new UsuarioLogic();
            UsuarioActual = ul.GetOne(ID);
            MapearDeDatos();
        }

        private bool ValidarMail(string Email)
        {
            bool arrobaFlag = false, dominioFlag = false;
            for (int i = 0; i < Email.Length; i++)
            {
                if (Email[i] == '@')
                {
                    arrobaFlag = true;
                    if (Email.Contains(".com") || Email.Contains(".net") || Email.Contains(".edu") || Email.Contains(".tur"))
                    {
                        dominioFlag = true;
                        break;
                    }
                    else
                        dominioFlag = false;
                }
                else
                    arrobaFlag = false;
            }
            if (arrobaFlag && dominioFlag)
                return true;
            else
                return false;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                Close();
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
