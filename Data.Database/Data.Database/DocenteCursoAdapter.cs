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
    public class DocenteCursoAdapter : Adapter
    {
        public List<DocenteCurso> GetAll()
        {
            List<DocenteCurso> docenteCursos = new List<DocenteCurso>();
            try
            {
                OpenConnection();
                SqlCommand cmdDC = new SqlCommand("select * from docentes_cursos", sqlConn);
                SqlDataReader drDC = cmdDC.ExecuteReader();
                while (drDC.Read())
                {
                    DocenteCurso dc = new DocenteCurso();
                    dc.ID = (int)drDC["id_dictado"];
                    dc.IDCurso = (int)drDC["id_curso"];
                    dc.IDDocente = (int)drDC["id_docente"];
                    dc.Cargo = (DocenteCurso.TiposCargo)drDC["cargo"];
                    docenteCursos.Add(dc);
                }
                drDC.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Docentes", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return docenteCursos;
        }

        public DocenteCurso GetOne(int ID)
        {
            DocenteCurso dc = new DocenteCurso();
            try
            {
                OpenConnection();
                SqlCommand cmdDC = new SqlCommand("select * from docentes_cursos where id_dictado = @id", sqlConn);
                cmdDC.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drDC = cmdDC.ExecuteReader();
                while (drDC.Read())
                {
                    dc.ID = (int)drDC["id_dictado"];
                    dc.IDCurso = (int)drDC["id_curso"];
                    dc.IDDocente = (int)drDC["id_docente"];
                    dc.Cargo = (DocenteCurso.TiposCargo)drDC["cargo"]; //Esto no se si funciona
                }
                drDC.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar Docente del curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return dc;
        }

        public void Delete (int ID)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete docentes_cursos where id_dictado = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar Docente del curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update (DocenteCurso docenteCurso)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE docentes_cursos set id_curso = @id_curso, id_docente = @id_docente, cargo = @cargo " +
                    "where id_dictado = @id", sqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = docenteCurso.ID;
                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = docenteCurso.IDCurso;
                cmdSave.Parameters.Add("@id_docente", SqlDbType.Int).Value = docenteCurso.IDDocente;
                cmdSave.Parameters.Add("@cargo", SqlDbType.Int).Value = docenteCurso.Cargo;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar Docente del curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert (DocenteCurso docenteCurso)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "insert into docentes_cursos(id_curso, id_docente, cargo) " +
                    "values(@id_curso, @id_docente, @cargo) select @@identity", sqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = docenteCurso.ID;
                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = docenteCurso.IDCurso;
                cmdSave.Parameters.Add("@id_docente", SqlDbType.Int).Value = docenteCurso.IDDocente;
                cmdSave.Parameters.Add("@cargo", SqlDbType.Int).Value = docenteCurso.Cargo;
                docenteCurso.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al agregar Docente al curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(DocenteCurso docenteCurso)
        {
            if(docenteCurso.State == BusinessEntity.States.Deleted)
            {
                Delete(docenteCurso.ID);
            }
            else if (docenteCurso.State == BusinessEntity.States.Modified)
            {
                Update(docenteCurso);
            }
            else if(docenteCurso.State == BusinessEntity.States.New)
            {
                Insert(docenteCurso);
            }
            docenteCurso.State = BusinessEntity.States.Unmodified;
        }
    }
}
 