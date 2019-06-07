using Core.Repositorios;
using Modelo.Models;

namespace Core.Models.UnityOfWork
{

    public class UnitOfWork : IUnitOfWork
    {
        private readonly GestorComidaContext _gestorComidaContext;
        public IPlatoRepository _PlatoRepo { get; private set; }
        public IPersonaRepository _PersonaRepo { get; private set; }
        public IGuarnicionRepository _GuarnicionRepo { get; private set; }
        public IPedidoRepository _PedidoRepo { get; private set; }
        public IMenuRepository _MenuRepo { get; private set; }

        public UnitOfWork(GestorComidaContext gestorComidaContext)
        {
            _gestorComidaContext = gestorComidaContext;
        }
        public int Complete()
        {
            return _gestorComidaContext.SaveChanges();
        }

        public void Dispose()
        {
            _gestorComidaContext.Dispose();
        }
    }
}