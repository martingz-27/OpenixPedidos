using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Modelo.Models
{
    public class Menu
    {
        public int id { get; set; }
        public int idPlato { get; set; }
        public int idGuarnicion { get; set; }
        public Menu()
        {

        }
    }
}