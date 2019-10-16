using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;


namespace Business.Logic
{
    public class DocenteCursoLogic : BusinessLogic
    {
        private DocenteCursoAdapter _DocenteCursoData;
        public DocenteCursoAdapter DocenteCursoData
        {
            get
            {
                return _DocenteCursoData;
            }
            set
            {
                _DocenteCursoData = value;
            }
        }

        public DocenteCursoLogic()
        {
            _DocenteCursoData = new DocenteCursoAdapter();
        }

        public DocenteCursoLogic(DocenteCursoAdapter docenteCursoData)
        {
            _DocenteCursoData = docenteCursoData;
        }

        public List<DocenteCurso> GetAll()
        {
            return DocenteCursoData.GetAll();
        }

        public DocenteCurso GetOne (int id)
        {
            return DocenteCursoData.GetOne(id);
        }

        public void Delete (int id)
        {
            DocenteCursoData.Delete(id);
        }

        public void Save(DocenteCurso dc)
        {
            DocenteCursoData.Save(dc);
        }
    }
}
