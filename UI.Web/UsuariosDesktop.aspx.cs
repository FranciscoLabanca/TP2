using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace UI.Web
{
    public partial class UsuariosDesktop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["IdUsuarioEditar"] != null)
                {
                    UsuarioLogic ul = new UsuarioLogic();
                    UsuarioActual = ul.GetOne(Int32.Parse(Session["IdUsuarioEditar"].ToString()));
                    MapearDeDatos();
                }
            }
        }

        public Usuario UsuarioActual 
        { 
            get { return _UsuarioActual; }
            set { _UsuarioActual = value; } 
        }
        private Usuario _UsuarioActual;

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            GuardarCambios();
        }

        public bool Validar()
        {
            if ((TxtBxNombre.Text != "" && TxtBxApellido.Text != "" && TxtBxEmail.Text != "" && TxtBxNombreUsu.Text != "" && TxtBxClave.Text != ""))
            {
                if (TxtBxClave.Text.Length >= 8)
                {
                    if (TxtBxClave.Text == TxtBxRepClave.Text)
                    {
                    if (ValidarMail(TxtBxEmail.Text))
                    {
                        return true;
                    }
                    else
                    {
                        this.Notificar("Mail Invalido");
                        return false;
                    }

                    }
                    else
                    {
                        this.Notificar("Confimar Clave y clave no coinciden. Los campos de clave no coinciden, verifiquelos e intente nuevamente");
                        return false;
                    }
                }
                else
                {
                    this.Notificar("Contraseña Invalida. La contraseña debe tener al menos 8 caracteres");
                    return false;
                }
            }
            else
            {
                this.Notificar("Campos Obligatorios Vacios. Existen uno o mas campos vacios, rellenelos antes de continuar");
                return false;
            }
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

        public void Notificar(string msj)
        {
            Response.Write($"<script>alert('{msj}');</script>");
        }

        private void MapearDeDatos()
        {
            TxtBxNombre.Text = UsuarioActual.Nombre;
            TxtBxApellido.Text = UsuarioActual.Apellido;
            TxtBxNombreUsu.Text = UsuarioActual.NombreUsuario;
            TxtBxEmail.Text = UsuarioActual.EMail;
            TxtBxClave.Text = UsuarioActual.Clave;
            TxtBxRepClave.Text = UsuarioActual.Clave;
            ChkBxHabilitado.Checked = UsuarioActual.Habilitado;
        }

        private void MapearADAtos()
        {
            if (Session["IdUsuarioEditar"] == null)
            {
                UsuarioActual = new Usuario();
                UsuarioActual.Nombre = TxtBxNombre.Text;
                UsuarioActual.EMail = TxtBxEmail.Text;
                UsuarioActual.Clave = TxtBxClave.Text;
                UsuarioActual.Habilitado = ChkBxHabilitado.Checked;
                UsuarioActual.Apellido = TxtBxApellido.Text;
                UsuarioActual.NombreUsuario = TxtBxNombreUsu.Text;
                UsuarioActual.State = Usuario.States.New;
            }
            else
            {
                UsuarioLogic usl = new UsuarioLogic();
                UsuarioActual = usl.GetOne(Int32.Parse(Session["IdUsuarioEditar"].ToString()));
                UsuarioActual.Nombre = TxtBxNombre.Text;
                UsuarioActual.EMail = TxtBxEmail.Text;
                UsuarioActual.Clave = TxtBxClave.Text;
                UsuarioActual.Habilitado = ChkBxHabilitado.Checked;
                UsuarioActual.Apellido = TxtBxApellido.Text;
                UsuarioActual.NombreUsuario = TxtBxNombreUsu.Text;
                UsuarioActual.State = Usuario.States.Modified;
            }
        }
        private void GuardarCambios()
        {
            if (Validar())
            {
                UsuarioLogic usl = new UsuarioLogic();
                //UsuarioActual = usl.GetOne(Int32.Parse(Session["IdUsuarioEditar"].ToString()));
                MapearADAtos();
                usl.Save(UsuarioActual);
               
                Session["IdUsuarioEditar"] = null;
                Server.Transfer("Usuarios.aspx");
            }
        }

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Server.Transfer("Usuarios.aspx");
        }

        protected void ChkBxHabilitado_Init(object sender, EventArgs e)
        {

        }
    }
}