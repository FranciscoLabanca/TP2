using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;
using Business.Entities;

namespace UI.Web
{
    public partial class Usuarios1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Listar();
        }

        
        protected void GridViewUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "Insertar")
            {
                Usuario newUsuario = new Usuario();
                newUsuario.Nombre = ((TextBox)GridViewUsuarios.FooterRow.FindControl("txtBoxNombre")).Text;
                newUsuario.EMail = ((TextBox)GridViewUsuarios.FooterRow.FindControl("txtBoxEmail")).Text;
                newUsuario.Clave = ((TextBox)GridViewUsuarios.FooterRow.FindControl("txtBoxClave")).Text;
                newUsuario.Habilitado = ((CheckBox)GridViewUsuarios.FooterRow.FindControl("ChkBxHabilitado")).Checked;
                newUsuario.Apellido = ((TextBox)GridViewUsuarios.FooterRow.FindControl("txtBoxApellido")).Text;
                newUsuario.NombreUsuario = ((TextBox)GridViewUsuarios.FooterRow.FindControl("txtBoxNombreUsu")).Text;
                newUsuario.State = Usuario.States.New;

                if (Validar())
                {
                    UsuarioLogic usl = new UsuarioLogic();
                    usl.Save(newUsuario);
                }

                Server.Transfer("Usuarios.aspx");
            }
        }

        public bool Validar()
        {
            if (((TextBox)GridViewUsuarios.FooterRow.FindControl("txtBoxNombre")).Text ==""  && ((TextBox)GridViewUsuarios.FooterRow.FindControl("txtBoxApellido")).Text =="" && ((TextBox)GridViewUsuarios.FooterRow.FindControl("txtBoxEmail")).Text == "" && ((TextBox)GridViewUsuarios.FooterRow.FindControl("txtBoxNombreUsu")).Text == "" && ((TextBox)GridViewUsuarios.FooterRow.FindControl("txtBoxClave")).Text == "")
            {
                if (((TextBox)GridViewUsuarios.FooterRow.FindControl("txtBoxClave")).Text.Length >= 8)
                {
                    //if (tbClave.Text == tbConfClave.Text)
                    //{
                        if (ValidarMail(((TextBox)GridViewUsuarios.FooterRow.FindControl("txtBoxEmail")).Text))
                        {
                            return true;
                        }
                        else
                        {
                            this.Notificar("Mail Invalido");
                            return false;
                        }

                    //}
                    /*else
                    //{
                        this.Notificar("Confimar Clave y clave no coinciden", "Los campos de clave no coinciden, verifiquelos e intente nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }*/
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

        protected void GridViewUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Server.Transfer("Menu.aspx");
        }
    }
}