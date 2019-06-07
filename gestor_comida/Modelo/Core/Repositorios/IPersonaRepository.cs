using Modelo.Core.Models.Dominio;

namespace Modelo.Core.Repositorios
{
    public interface IPersonaRepository
    {
        void AddPersona(Persona entity);
        Persona get(int id);
        void RemovePersona(Persona entity);
        void SaveChange();
    }
}