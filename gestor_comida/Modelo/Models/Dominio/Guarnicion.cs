using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Modelo.Models
{
    public class Guarnicion
    {
        public int id { get; set; }
        [Required]
        [Display(Name = "Nombre de Guarnicion")]
        public String _NombreGuarnicion { get; set; }
        [Display(Name = "Cantidad de Guarniciones")]
        public int _Cantidad { get; set; }

        public Guarnicion()
        {

        }

        public Guarnicion(String nombre, int cantidad)
        {
            this._NombreGuarnicion = nombre;
            this._Cantidad = cantidad;
        }
    }
}