using Core.Models.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Modelo.Models
{
    public class GestorComidaContext : DbContext
    {
        public GestorComidaContext():
            base("DefaultConnection")
        {
        }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Plato> Platos { get; set; }
        public DbSet<Guarnicion> Guarniciones { get; set; }
        public DbSet<Menu> Menus { get; set; }

    }
}