using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class EspecialidadLogic : BusinessLogic
    {
        private EspecialidadAdapter _EspData;
        public EspecialidadAdapter   EspData
        {
            get
            {
                return _EspData;
            }
            set
            {
                _EspData = value;
            }
        }
        public EspecialidadLogic()
        {
            _EspData = new EspecialidadAdapter();
        }

        public EspecialidadLogic(EspecialidadAdapter EspData)
        {
            _EspData = EspData;
        }

        public List<Especialidad> GetAll()
        {
            return EspData.GetAll();
        }

        public Especialidad GetOne(int id)
        {
            return EspData.GetOne(id);
        }

        public void Delete(int id)
        {
            EspData.Delete(id);
        }

        public void Save (Especialidad esp)
        {
            EspData.Save(esp);
        }
    }
}
