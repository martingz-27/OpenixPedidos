using Core.Models.Dominio;

namespace Core.Repositorios
{
    public interface IPedidoRepository
    {
        void AddPedido(Pedido entity);
        Pedido get(int id);
        void RemovePedido(Pedido entity);
        void SaveChange();
    }
}