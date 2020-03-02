using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;


namespace Business.Logic
{
    public class MateriaLogic : BusinessLogic
    {
        private MateriaAdapter _MateriaData;
        public MateriaAdapter MateriaData
        {
            get
            {
                return _MateriaData;
            }
            set
            {
                _MateriaData = value;
            }
        }

        public MateriaLogic()
        {
            _MateriaData = new MateriaAdapter();
        }

        public MateriaLogic(MateriaAdapter materiaData)
        {
            _MateriaData = materiaData;
        }

        public List<Materia> GetAll()
        {
            return MateriaData.GetAll();
        }

        public Materia GetOne(int id)
        {
            return MateriaData.GetOne(id);
        }

        public void Delete(int id)
        {
            MateriaData.Delete(id);
        }

        public void Save(Materia materia)
        {
            MateriaData.Save(materia);
        }

        public List<Materia> GetMateriasByPlan (int id)
        {
            return MateriaData.GerMateriaByPlan(id);
        }
    }
}
