using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Core.Models.Dominio
{
    public class Guarnicion
    {
        public int id { get; set; }
        [Required]
        [Display(Name = "Nombre de Guarnicion")]
        public String _NombreGuarnicion { get; set; }
 
        public Guarnicion()
        {

        }

        public Guarnicion(String nombre)
        {
            this._NombreGuarnicion = nombre;
        }
    }
}