using Modelo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelo.Persistence.Repositorios
{
    public class PersonaRepository
    {
        protected readonly GestorComidaContext _gestorComidaContext;

        //Constructor
        public PersonaRepository(GestorComidaContext gestorComidaContext)
        {
            _gestorComidaContext = gestorComidaContext;
        }

        public void AddPersona(Persona entity)
        {
            _gestorComidaContext.Personas.Add(entity);
        }

        public Persona get(int id)
        {
            return _gestorComidaContext.Personas.Find(id);
        }

        public void RemovePersona(Persona entity)
        {
            _gestorComidaContext.Personas.Remove(entity);
        }

        public void SaveChange()
        {
            _gestorComidaContext.SaveChanges();
        }
    }
}