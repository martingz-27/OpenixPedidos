using System;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Core.Models.Dominio
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