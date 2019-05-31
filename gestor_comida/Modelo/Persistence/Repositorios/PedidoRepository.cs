using Modelo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelo.Persistence.Repositorios
{
    public class PedidoRepository
    {
        protected readonly GestorComidaContext _gestorComidaContext;

        //Constructor
        public PedidoRepository(GestorComidaContext gestorComidaContext)
        {
            _gestorComidaContext = gestorComidaContext;
        }

        public void AddPedido(Pedido entity)
        {
            _gestorComidaContext.Pedidos.Add(entity);
        }

        public Pedido get(int id)
        {
            return _gestorComidaContext.Pedidos.Find(id);
        }

        public void RemovePedido(Pedido entity)
        {
            _gestorComidaContext.Pedidos.Remove(entity);
        }

        public void SaveChange()
        {
            _gestorComidaContext.SaveChanges();
        }
    }
}