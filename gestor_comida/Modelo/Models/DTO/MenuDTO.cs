using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Modelo.Models.DTO
{
    public class MenuDTO
    {
        [Display(Name = "Nombre de Plato")]
        public String _Nombre { get; set; }

        [Display(Name = "Precio del Plato")]
        public decimal _Precio { get; set; }

        public List<String> _ListaNombreGuarniciones { get; set; }
        
        public IEnumerable<MenuDTO> _menuDTOs { get; set; }

        public MenuDTO()
        {

        }

    }
}