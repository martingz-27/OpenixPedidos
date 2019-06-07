using Modelo.Core.Models.Dominio;
using Modelo.Core.Repositorios;
using Modelo.Models;


namespace Persistence.Repositorios
{
    public class PedidoRepository : IPedidoRepository
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