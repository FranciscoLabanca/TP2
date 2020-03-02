using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class AlumnoInscripcionLogic : BusinessLogic
    {
        private AlumnoInscripcionAdapter _DataInscripcion;
        public AlumnoInscripcionAdapter DataInscripcion
        {
            get
            {
                return _DataInscripcion;
            }
            set
            {
                _DataInscripcion = value;
            }
        }

        public AlumnoInscripcionLogic()
        {
            _DataInscripcion = new AlumnoInscripcionAdapter();
        }

        public AlumnoInscripcionLogic(AlumnoInscripcionAdapter ia)
        {
            _DataInscripcion = ia;
        }

        public List<AlumnoInscripcion> GetAll()
        {
            return DataInscripcion.GetAll();
        }

        public AlumnoInscripcion GetOne(int id)
        {
            return DataInscripcion.GetOne(id);
        }

        public void Delete (int id)
        {
            DataInscripcion.Delete(id);
        }

        public void Save(AlumnoInscripcion inscripcion)
        {
            DataInscripcion.Save(inscripcion);
        }

        public List<AlumnoInscripcion> GetInscripciones(int id)
        {
            return DataInscripcion.GetInscripciones(id);
        }
    }
}
