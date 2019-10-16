using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Business.Entities;

namespace Data.Database
{
    public class AlumnoInscripcionAdapter : Adapter
    {
        public List<AlumnoInscripcion> GetAll()
        {
            List<AlumnoInscripcion> inscripciones = new List<AlumnoInscripcion>();
            try
            {
                OpenConnection();
                SqlCommand cmdInscripcion = new SqlCommand("select * from alumnos_inscripciones", sqlConn);
                SqlDataReader drInscripcion = cmdInscripcion.ExecuteReader();
                while (drInscripcion.Read())
                {
                    AlumnoInscripcion ai = new AlumnoInscripcion();
                    ai.ID = (int)drInscripcion["id_inscripcion"];
                    ai.IDAlumno = (int)drInscripcion["id_alumno"];
                    ai.IDCurso = (int)drInscripcion["id_curso"];
                    ai.Condicion = (string)drInscripcion["condicion"];
                    ai.Nota = (int)drInscripcion["nota"];
                    inscripciones.Add(ai);
                }
                drInscripcion.Close();
            }
            catch(Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de inscripciones", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            return inscripciones;
        }

        public AlumnoInscripcion GetOne(int id)
        {
            AlumnoInscripcion inscripcion = new AlumnoInscripcion();
            try
            {
                OpenConnection();
                SqlCommand cmdInscripcion = new SqlCommand("select * from alumnos_inscripciones where id_inscripcion = @id", sqlConn);
                cmdInscripcion.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader drInscripcion = cmdInscripcion.ExecuteReader();
                while (drInscripcion.Read())
                {
                    inscripcion.ID = (int)drInscripcion["id_inscripcion"];
                    inscripcion.IDAlumno = (int)drInscripcion["id_alumno"];
                    inscripcion.IDCurso = (int)drInscripcion["id_curso"];
                    inscripcion.Condicion = (string)drInscripcion["condicion"];
                    inscripcion.Nota = (int)drInscripcion["nota"];
                }
                drInscripcion.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de inscripciones", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
            return inscripcion;
        }

        public void Delete (int id)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete alumnos_inscripciones where id_inscripcion = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar inscripcion", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Insert (AlumnoInscripcion ins)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "insert into alumnos_inscripciones(id_alumno, id_curso, condicion, nota) " + 
                    "values(@id_alumno, @id_curso, @condiciom, @nota) select @@identity", sqlConn);
                cmdSave.Parameters.Add("@id_alumno", SqlDbType.Int).Value = ins.IDAlumno;
                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = ins.IDCurso;
                cmdSave.Parameters.Add("@condicion", SqlDbType.VarChar, 50).Value = ins.Condicion;
                cmdSave.Parameters.Add("@nota", SqlDbType.Int).Value = ins.Nota;
                ins.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear inscripcion", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Update (AlumnoInscripcion ins)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "update alumnos_inscripciones set id_alumno = @id_alumno, id_curso = @id_curso, condicion = @condicion, nota = @nota where id_inscripcion = @id", sqlConn);
                cmdSave.Parameters.Add("@id_alumno", SqlDbType.Int).Value = ins.IDAlumno;
                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = ins.IDCurso;
                cmdSave.Parameters.Add("@condicion", SqlDbType.VarChar, 50).Value = ins.Condicion;
                cmdSave.Parameters.Add("@nota", SqlDbType.Int).Value = ins.Nota;
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = ins.ID;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al actualizar inscripcion", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Save (AlumnoInscripcion ins)
        {
            if(ins.State == BusinessEntity.States.Deleted)
            {
                Delete(ins.ID);
            }
            else if(ins.State == BusinessEntity.States.Modified)
            {
                Update(ins);
            }
            else if (ins.State == BusinessEntity.States.New)
            {
                Insert(ins);
            }
            ins.State = BusinessEntity.States.Unmodified;
        }
    }
}
