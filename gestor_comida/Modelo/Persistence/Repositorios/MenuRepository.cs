using Modelo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelo.Persistence.Repositorios
{
    public class MenuRepository
    {
        protected readonly GestorComidaContext _gestorComidaContext;

        public MenuRepository(GestorComidaContext gestorComidaContext)
        {
            _gestorComidaContext = gestorComidaContext;
        }

        public void AddMenu(Menu entity)
        {
            _gestorComidaContext.Menus.Add(entity);
        }

        public Menu get(int id)
        {
            return _gestorComidaContext.Menus.Find(id);
        }

        public void RemoveMenu(Menu entity)
        {
            _gestorComidaContext.Menus.Remove(entity);
        }

        public IEnumerable<Menu> GetAll()
        {
            return _gestorComidaContext.Menus.ToList();
        }

        public void SaveChange()
        {
            _gestorComidaContext.SaveChanges();
        }
    }
}