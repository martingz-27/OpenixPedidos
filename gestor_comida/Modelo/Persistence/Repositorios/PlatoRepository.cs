using Modelo.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelo.Models.PatronRepositorio
{
    public class PlatoRepository
    {
        protected readonly GestorComidaContext _gestorComidaContext;

        //Constructor
        public PlatoRepository(GestorComidaContext gestorComidaContext)
        {
            _gestorComidaContext = gestorComidaContext;
        }

        public void AddPlato(Plato entity)
        {
            _gestorComidaContext.Platos.Add(entity);
        }

        public Plato get(int id)
        {
            return _gestorComidaContext.Platos.Find(id);
        }

        public IEnumerable<Plato> GetAll()
        {
            return _gestorComidaContext.Platos.ToList();
        }
        

        public void RemovePlato(Plato entity)
        {
            _gestorComidaContext.Platos.Remove(entity);
        }

        public void SaveChange()
        {
            _gestorComidaContext.SaveChanges();
        }
    }
}