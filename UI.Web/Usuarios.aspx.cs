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
            /*if(e.CommandName == "Insertar")
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
            }*/
        }

        
        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Server.Transfer("Menu.aspx");
        }


        protected void GridViewUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow gvr in GridViewUsuarios.Rows)
            {
                gvr.BackColor = System.Drawing.Color.White;
            }
            int index = GridViewUsuarios.SelectedIndex;
            GridViewUsuarios.Rows[index].BackColor = System.Drawing.Color.FromArgb(0, 255, 0);
        }
        protected void GridViewUsuarios_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
        }

        protected void BtnNuevo_Click(object sender, EventArgs e)
        {
            Server.Transfer("UsuariosDesktop.aspx");            
        }

        protected void BtnEditar_Click(object sender, EventArgs e)
        {
            if (GridViewUsuarios.SelectedRow != null)
            {
                Session["IdUsuarioEditar"] = GridViewUsuarios.SelectedRow.Cells[1].Text;
                Server.Transfer("UsuariosDesktop.aspx");
            }
            else
                Response.Write($"<script>alert('No se ha seleccionado ningun usuario');</script>");
        }
    }
}