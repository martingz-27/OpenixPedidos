using Core.Models.Dominio;
using System.Collections.Generic;


namespace Modelo.Core.DTO
{
    public class MenuDTO
    {
        public int idPlatoDTO { get; set; }
        public string nombrePlatoDTO { get; set; }
        public decimal precioPlatoDTO { get; set; }

        public IEnumerable<Guarnicion> _ListaNombreGuarniciones { get; set; }
        
       public IEnumerable<MenuDTO> menus { get; set; }

        public MenuDTO()
        {
        }

    }
}