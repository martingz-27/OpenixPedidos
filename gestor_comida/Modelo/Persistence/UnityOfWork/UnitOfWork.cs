using Modelo.Models.Interface;
using Modelo.Models.PatronRepositorio;
using Modelo.Persistence.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelo.Models.UnityOfWork
{

    public class UnitOfWork
    {
        private readonly GestorComidaContext _gestorComidaContext;
        private PlatoRepository _PlatoRepository;
        private PersonaRepository _PersonaRepository;
        private GuarnicionRepository _GuarnicionRepository;
        private PedidoRepository _PedidoRepository;
        private MenuRepository _MenuRepository;

        public UnitOfWork(GestorComidaContext gestorComidaContext)
        {
            _gestorComidaContext = gestorComidaContext;
            
        }

        public MenuRepository MenuRepository
        {
            get
            {
                if (_MenuRepository == null)
                    _MenuRepository = new MenuRepository(_gestorComidaContext);
                return _MenuRepository;
            }
        }

        public PedidoRepository PedidoRepository
        {
            get
            {
                if (_PedidoRepository == null)
                    _PedidoRepository = new PedidoRepository(_gestorComidaContext);
                return _PedidoRepository;
            }
        }
        public PlatoRepository PlatoRepository
        {
            get
            {
                if (_PlatoRepository == null)
                    _PlatoRepository = new PlatoRepository(_gestorComidaContext);
                return _PlatoRepository;
            }
        }

        public PersonaRepository PersonaRepository
        {
            get
            {
                if (_PersonaRepository == null)
                    _PersonaRepository = new PersonaRepository(_gestorComidaContext);
                return _PersonaRepository;
            }
        }

        public GuarnicionRepository GuarnicionRepository
        {
            get
            {
                if (_GuarnicionRepository == null)
                    _GuarnicionRepository = new GuarnicionRepository(_gestorComidaContext);
                return _GuarnicionRepository;
            }
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