using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;
using Data.Database;

namespace UI.Consola
{
    public class Usuarios
    {
        private UsuarioLogic _UsuarioNegocio;
        public UsuarioLogic UsuarioNegocio 
        {
        	get
        	{
        		return _UsuarioNegocio;
        	} 
        	set
        	{
        		_UsuarioNegocio = value;
        	}
        }
        public Usuarios(UsuarioLogic usuarioNegocio)
        {
            _UsuarioNegocio = usuarioNegocio;
        }
        public void ListadoGeneral()
        {
            Console.Clear();
            foreach(Usuario usuario in UsuarioNegocio.GetAll())
            {
                MostrarDatos(usuario);
            }
        }
        public void Consultar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID del usuario a consultar: ");
                int id = int.Parse(Console.ReadLine());
                MostrarDatos(UsuarioNegocio.GetOne(id));
            }
            catch (FormatException fe)
            {
                Console.WriteLine("La id ingresada debe ser un entero");
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar: ");
                Console.ReadKey();
            }
        }
        public void Agregar()
        {

        }
        public void Modificar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID del usuario a consultar: ");
                int id = int.Parse(Console.ReadLine());
                Usuario usuario = UsuarioNegocio.GetOne(id);
                Console.Write("Ingrese nombre: ");
                usuario.Nombre = Console.ReadLine();
                Console.Write("Ingrese apellido: ");
                usuario.Apellido = Console.ReadLine();
                Console.Write("Ingrese nombre de usuario: ");
                usuario.NombreUsuario = Console.ReadLine();
                Console.Write("Ingrese clave: ");
                usuario.Clave = Console.ReadLine();
                Console.Write("Ingrese email: ");
                usuario.EMail = Console.ReadLine();
                Console.Write("Ingrese habilitacion de usuario (1 - Si/Otro - No): ");
                usuario.Habilitado = (Console.ReadLine()=="1");
                usuario.State = BusinessEntity.States.Modified;
                UsuarioNegocio.Save(usuario);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("La id ingresada debe ser un entero");
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar: ");
                Console.ReadKey();
            }
        }
        public void Eliminar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID del usuario a consultar: ");
                int id = int.Parse(Console.ReadLine());
                UsuarioNegocio.Delete(id);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("La id ingresada debe ser un entero");
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar: ");
                Console.ReadKey();
            }
        }
        public void MostrarDatos(Usuario usuario)
        {
            Console.WriteLine("Usuario: {0}", usuario.ID);
            Console.WriteLine("\t\tNombre: {0}", usuario.Nombre);
            Console.WriteLine("\t\tApellido: {0}", usuario.Apellido);
            Console.WriteLine("\t\tNombre de Usuario: {0}", usuario.NombreUsuario);
            Console.WriteLine("\t\tClave: {0}", usuario.Clave);
            Console.WriteLine("\t\tEmail: {0}", usuario.EMail);
            Console.WriteLine("\t\tHabilitado: {0}", usuario.Habilitado);
            Console.WriteLine("");
        }
        public void Menu()
        {
            string op = "0";
            while (op != "6")
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1 - Listado General");
                Console.WriteLine("2 - Consulta");
                Console.WriteLine("3 - Agregar");
                Console.WriteLine("4 - Modificar");
                Console.WriteLine("5 - Eliminar");
                Console.WriteLine("6 - Salir");
                Console.WriteLine("Elija una opcion: ");
                op = Console.ReadLine();
                switch (op)
                {
                    case "1":
                        this.ListadoGeneral();
                        Console.ReadKey();
                        break;
                    case "2":
                        this.Consultar();
                        Console.ReadKey();
                        break;
                    case "3":
                        break;
                    case "4":
                        this.Modificar();
                        break;
                    case "5":
                        this.Eliminar();
                        break;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            UsuarioAdapter usuarioData = new UsuarioAdapter();
            UsuarioLogic usuarioLogic = new UsuarioLogic(usuarioData);
            new Usuarios(usuarioLogic).Menu();
        }
    }
}