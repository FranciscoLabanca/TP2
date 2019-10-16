using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class ComisionLogic : BusinessLogic
    {
        private ComisionAdapter _ComisionData;
        public ComisionAdapter ComisionData
        {
            get
            {
                return _ComisionData;
            }
            set
            {
                _ComisionData = value;
            }
        }

        public ComisionLogic()
        {
            _ComisionData = new ComisionAdapter();
        }

        public ComisionLogic(ComisionAdapter comData)
        {
            _ComisionData = comData;
        }

        public List<Comision> GetAll()
        {
            return ComisionData.GetAll();
        }

        public Comision GetiOne(int id)
        {
            return ComisionData.GetOne(id);
        }
        
        public void Delete(int id)
        {
            ComisionData.Delete(id);
        }

        public void Save(Comision comision)
        {
            ComisionData.Save(comision);
        }
    }
}
