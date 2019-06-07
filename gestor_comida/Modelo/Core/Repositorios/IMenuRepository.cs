using System.Collections.Generic;
using Modelo.Core.Models.Dominio;

namespace Modelo.Core.Repositorios
{
    public interface IMenuRepository
    {
        void AddMenu(Menu entity);
        Menu get(int id);
        IEnumerable<Menu> GetAll();
        void RemoveMenu(Menu entity);
        void SaveChange();
    }
}