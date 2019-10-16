using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class CursoLogic : BusinessLogic
    {
        private CursoAdapter _DataCurso;
        public CursoAdapter DataCurso
        {
            get
            {
                return _DataCurso;
            }
            set
            {
                _DataCurso = value;
            }
        }

        public CursoLogic()
        {
            _DataCurso = new CursoAdapter();
        }

        public CursoLogic(CursoAdapter ca)
        {
            _DataCurso = ca;
        }

        public List<Curso> GetAll()
        {
            return DataCurso.GetAll();
        }

        public Curso GetOne(int id)
        {
            return DataCurso.GetOne(id);
        }

        public void Delete(int id)
        {
            DataCurso.Delete(id);
        }

        public void Save(Curso curso)
        {
            DataCurso.Save(curso);
        }
    }
}
