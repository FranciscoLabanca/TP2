using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;


namespace Business.Logic
{
    public class ModuloUsuarioLogic : BusinessLogic
    {
        private ModuloUsuarioAdapter _MUData;
        public ModuloUsuarioAdapter MUData
        {
            get
            {
                return _MUData;
            }
            set
            {
                _MUData = value;
            }
        }

        public ModuloUsuarioLogic()
        {
            _MUData = new ModuloUsuarioAdapter();
        }

        public ModuloUsuarioLogic(ModuloUsuarioAdapter muData)
        {
            _MUData = muData;
        }

        public List<ModuloUsuario> GetAll()
        {
            return MUData.GetAll();
        }

        public ModuloUsuario GetOne(int id)
        {
            return MUData.GetOne(id);
        }

        public void Delete (int id)
        {
            MUData.Delete(id);
        }

        public void Save (ModuloUsuario mu)
        {
            MUData.Save(mu);
        }
    }
}
