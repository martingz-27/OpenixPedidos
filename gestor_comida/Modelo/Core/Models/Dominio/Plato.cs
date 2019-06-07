using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Modelo.Core.Models.Dominio
{
    public class Plato
    {
        public int id { get; set; }
        [Required]
        [Display(Name ="Nombre de Plato")]
        public String _Nombre { get; set; }

        [Display(Name = "Precio del Plato")]
        public decimal _Precio { get; set; }

        public Plato(String nombre, decimal precio)
        {
            _Nombre = nombre;
            _Precio = precio;
        }

        public Plato()
        {
        }
    }
}