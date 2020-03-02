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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(tbUsuario.Text != "" && tbContrasenia.Text != "")
            {
                if(tbContrasenia.Text.Length < 8)
                {
                    MessageBox.Show("La contraseña debe tener al menos 8 caracteres","Contraseña incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    UsuarioLogic ul = new UsuarioLogic();
                    Usuario usuario = ul.GetUser(tbUsuario.Text, tbContrasenia.Text);
                    if(usuario.NombreUsuario == null)
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        PersonaLogic pl = new PersonaLogic();
                        Business.Entities.Persona persona = pl.GetOne(usuario.IDPersona);
                        switch (persona.TipoPersona)
                        {
                            case Business.Entities.Persona.TiposPersona.Admin:
                                Menu menu = new Menu();
                                menu.ShowDialog();
                                break;

                            case Business.Entities.Persona.TiposPersona.Alumno:
                                MenuAlumno menuAlumno = new MenuAlumno(persona);
                                menuAlumno.ShowDialog();
                                break;

                            case Business.Entities.Persona.TiposPersona.Profesor:
                                MenuProfesor menuProfesor = new MenuProfesor(persona);
                                menuProfesor.ShowDialog();
                                break;
                        }
                    }
                }
            }
        }
    }
}
