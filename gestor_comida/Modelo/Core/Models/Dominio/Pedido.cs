using Modelo.Core.Models.Dominio;
using System.Collections.Generic;

namespace Modelo.Core.Models.Dominio
{
    public class Pedido
    {
        public int id { get; set; }
        public List<Plato> _ListaPlato { get; set; }
        public List<Guarnicion> _ListaGuarnicion { get; set; }
        public List<Persona> _ListaPersonas { get; set; }
        public decimal _Total { get; set; }

        public Pedido()
        {

        }



      
    }
}