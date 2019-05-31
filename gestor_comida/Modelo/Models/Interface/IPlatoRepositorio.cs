using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Models.Interface
{
    public interface IPlatoRepositorio 
    {
        Plato get(int id);
        void AddPlato(Plato plato);
        void RemovePlato(Plato plato);
        void SaveChange();
    }
}
