using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Modelo.Core.Models.Dominio
{
    public class Persona
    {
        public int id { get; set; }
        [Required]
        [Display(Name = "Nombre del Usuario")]
        public String _Nombre { get; set; }
        [Required]
        [Display(Name = "Apellido del Usuario")]
        public String _Apellido { get; set; }
        [Required]
        [Display(Name = "Telefono del Usuario")]
        public String _Telefono { get; set; }

        [Required]
        [Display(Name = "Rol del Usuario")]
        public String _Rol { get; set; }

        public Persona(String nombre, String apellido, String telefono, String rol)
        {
            this._Nombre = nombre;
            this._Apellido = apellido;
            this._Telefono = telefono;
            this._Rol = rol;
        }

        public Persona()
        {

        }
    }
}