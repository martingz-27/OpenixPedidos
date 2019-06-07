using Modelo.Core.Models.Dominio;
using System.Collections.Generic;

namespace Modelo.Core.Repositorios
{
    public interface IPlatoRepository
    {
        void AddPlato(Plato entity);
        Plato get(int id);
        IEnumerable<Plato> GetAll();
        void RemovePlato(Plato entity);
        void SaveChange();
    }
}