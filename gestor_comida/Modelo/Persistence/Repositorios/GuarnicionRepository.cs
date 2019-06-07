using Core.Models.Dominio;
using Core.Repositorios;
using Modelo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Persistence.Repositorios
{
    public class GuarnicionRepository : IGuarnicionRepository
    {
        protected readonly GestorComidaContext _gestorComidaContext;

        //Constructor
        public GuarnicionRepository(GestorComidaContext gestorComidaContext)
        {
            _gestorComidaContext = gestorComidaContext;
        }

        public void AddGuarnicion(Guarnicion entity)
        {
            _gestorComidaContext.Guarniciones.Add(entity);
        }

        public Guarnicion get(int id)
        {
            return _gestorComidaContext.Guarniciones.Find(id);
        }

        public IEnumerable<Guarnicion> GetAll()
        {
            return _gestorComidaContext.Guarniciones.ToList();
        }

        public void RemoveGuarnicion(Guarnicion entity)
        {
            _gestorComidaContext.Guarniciones.Remove(entity);
        }

        public void SaveChange()
        {
            _gestorComidaContext.SaveChanges();
        }
    }
}