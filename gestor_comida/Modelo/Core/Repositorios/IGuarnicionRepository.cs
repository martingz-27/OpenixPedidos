using System.Collections.Generic;
using Modelo.Core.Models.Dominio;
using Modelo.Models;

namespace Modelo.Core.Repositorios
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