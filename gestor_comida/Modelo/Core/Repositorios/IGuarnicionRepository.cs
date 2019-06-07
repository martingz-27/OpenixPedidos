using System.Collections.Generic;
using Core.Models.Dominio;
using Modelo.Models;

namespace Core.Repositorios
{
    public interface IGuarnicionRepository
    {
        void AddGuarnicion(Guarnicion entity);
        Guarnicion get(int id);
        IEnumerable<Guarnicion> GetAll();
        void RemoveGuarnicion(Guarnicion entity);
        void SaveChange();
    }
}