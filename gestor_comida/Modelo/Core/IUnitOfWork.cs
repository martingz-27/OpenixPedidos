using Core.Repositorios;

namespace Core.Models
{ 
    public interface IUnitOfWork
    {
        IGuarnicionRepository _GuarnicionRepo { get; }
        IMenuRepository _MenuRepo { get; }
        IPedidoRepository _PedidoRepo { get; }
        IPersonaRepository _PersonaRepo { get; }
        IPlatoRepository _PlatoRepo { get; }

        int Complete();
        void Dispose();
    }
}