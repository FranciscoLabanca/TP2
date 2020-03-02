using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class PersonaLogic : BusinessEntity
    {
        private PersonaAdapter _DataPersona;
        public PersonaAdapter DataPersona
        {
            get
            {
                return _DataPersona;
            }
            set
            {
                _DataPersona = value;
            }
        }

        public PersonaLogic()
        {
            _DataPersona = new PersonaAdapter();
        }

        public PersonaLogic(PersonaAdapter pa)
        {
            _DataPersona = pa;
        }

        public List<Persona> GetAll()
        {
            return DataPersona.GetAll();
        }

        public Persona GetOne(int id)
        {
            return DataPersona.GetOne(id);
        }

        public void Delete(int id)
        {
            DataPersona.Delete(id);
        }

        public void Save(Persona persona)
        {
            DataPersona.Save(persona);
        }

        public List<Persona> GetDocentes()
        {
            return DataPersona.GetDocentes();
        }
    }
}
