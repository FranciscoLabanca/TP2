using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;


namespace Business.Logic
{
    public class UsuarioLogic : BusinessLogic
    {
        private UsuarioAdapter _UsuarioData;
        public UsuarioAdapter UsuarioData 
        {
            get
            {
                return _UsuarioData;
            } 
            set
            {
                _UsuarioData = value;
            }
        }
        public UsuarioLogic(UsuarioAdapter usuarioData)
        {
            _UsuarioData = usuarioData;
        }
        public List<Usuario> GetAll()
        {
            return UsuarioData.GetAll();
        }
        public Usuario GetOne(int id)
        {
            return UsuarioData.GetOne(id);
        }
        public void Delete(int id)
        {
            UsuarioData.Delete(id);
        }
        public void Save(Usuario usuario)
        {
            UsuarioData.Save(usuario);
        }
    }
}
