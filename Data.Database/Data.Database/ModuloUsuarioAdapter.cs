using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class ModuloUsuarioAdapter : Adapter
    {
        public List<ModuloUsuario> GetAll()
        {
            List<ModuloUsuario> moduloUsuarios = new List<ModuloUsuario>();
            try
            {
                OpenConnection();
                SqlCommand cmdMU = new SqlCommand("select * from modulos_usuarios", sqlConn);
                SqlDataReader drMU = cmdMU.ExecuteReader();
                while (drMU.Read())
                {
                    ModuloUsuario mu = new ModuloUsuario();
                    mu.ID = (int)drMU["id_modulo_usuario"];
                    mu.IdUsuario = (int)drMU["id_usuario"];
                    mu.IdModulo = (int)drMU["id_modulo"];
                    mu.PermiteAlta = (bool)drMU["alta"];
                    mu.PermiteBaja = (bool)drMU["baja"];
                    mu.PermiteModificacion = (bool)drMU["modificacion"];
                    mu.PermiteConsulta = (bool)drMU["consulta"];
                    moduloUsuarios.Add(mu);
                }
                drMU.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Modulo - Usuario", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            return moduloUsuarios;
        }

        public ModuloUsuario GetOne(int id)
        {
            ModuloUsuario mu = new ModuloUsuario();
            try
            {
                OpenConnection();
                SqlCommand cmdMU = new SqlCommand("select * from modulos_usuarios where id_modulo_usuario = @id", sqlConn);
                cmdMU.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader drMU = cmdMU.ExecuteReader();
                while (drMU.Read())
                {
                    mu.ID = (int)drMU["id_modulo_usuario"];
                    mu.IdUsuario = (int)drMU["id_usuario"];
                    mu.IdModulo = (int)drMU["id_modulo"];
                    mu.PermiteAlta = (bool)drMU["alta"];
                    mu.PermiteBaja = (bool)drMU["baja"];
                    mu.PermiteModificacion = (bool)drMU["modificacion"];
                    mu.PermiteConsulta = (bool)drMU["consulta"];
                }
                drMU.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar Modulo de Usuario", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            return mu;
        }

        public void Delete (int id)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete modulos_usuarios where id_modulo_usuario = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar eliminar Modulo de Usuario", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }

        protected void Update (ModuloUsuario mu)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "Update modulos_usuarios set id_usuario = @id_usuario, id_modulo = @id_modulo, alta = @alta, " +
                    "baja = @baja, modificacion = @modificacion, consulta = @consulta " + 
                    "where id_modulo_usuario = @id", sqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = mu.ID;
                cmdSave.Parameters.Add("@id_usuario", SqlDbType.Int).Value = mu.IdUsuario;
                cmdSave.Parameters.Add("@id_modulo", SqlDbType.Int).Value = mu.IdModulo;
                cmdSave.Parameters.Add("@alta", SqlDbType.Bit).Value = mu.PermiteAlta;
                cmdSave.Parameters.Add("@baja", SqlDbType.Bit).Value = mu.PermiteBaja;
                cmdSave.Parameters.Add("@consulta", SqlDbType.Bit).Value = mu.PermiteConsulta;
                cmdSave.Parameters.Add("@modificacion", SqlDbType.Int).Value = mu.PermiteModificacion;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al actualizar Modulo de Usuario", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }

        protected void Insert (ModuloUsuario mu)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "Insert into modulos_usuarios(id_usuario, id_modulo, alta, baja, modificacion, consulta) " +
                    "values (@id_usuario, @id_modulo, @alta, @baja, @modificacion, @consulta) " +
                    "select @@identity", sqlConn);
                cmdSave.Parameters.Add("@id_usuario", SqlDbType.Int).Value = mu.IdUsuario;
                cmdSave.Parameters.Add("@id_modulo", SqlDbType.Int).Value = mu.IdModulo;
                cmdSave.Parameters.Add("@alta", SqlDbType.Bit).Value = mu.PermiteAlta;
                cmdSave.Parameters.Add("@baja", SqlDbType.Bit).Value = mu.PermiteBaja;
                cmdSave.Parameters.Add("@consulta", SqlDbType.Bit).Value = mu.PermiteConsulta;
                cmdSave.Parameters.Add("@modificacion", SqlDbType.Int).Value = mu.PermiteModificacion;
                mu.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear Modulo de Usuario", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Save (ModuloUsuario mu)
        {
            if(mu.State == BusinessEntity.States.Deleted)
            {
                Delete(mu.ID);
            }
            else if (mu.State == BusinessEntity.States.New)
            {
                Insert(mu);
            }
            else if (mu.State == BusinessEntity.States.Modified)
            {
                Update(mu);
            }
            mu.State = BusinessEntity.States.Unmodified;
        }
    }
}
