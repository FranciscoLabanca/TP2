using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;


namespace Business.Logic
{
    public class ModuloLogic : BusinessLogic
    {
        private ModuloAdapter _ModuloData;
        public ModuloAdapter ModuloData
        {
            get
            {
                return _ModuloData;
            }
            set
            {
                _ModuloData = value;
            }
        }

        public ModuloLogic()
        {
            _ModuloData = new ModuloAdapter();
        }

        public ModuloLogic(ModuloAdapter moduloData)
        {
            _ModuloData = moduloData;
        }

        public List<Modulo> GetAll()
        {
            return ModuloData.GetAll();
        }

        public Modulo GetOne (int id)
        {
            return ModuloData.GetOne(id);
        }

        public void Delete (int id)
        {
            ModuloData.Delete(id);
        }

        public void Save(Modulo modulo)
        {
            ModuloData.Save(modulo);
        }
    }
}
