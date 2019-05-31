using Modelo.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Models
{
    public interface IUnitOfWork : IDisposable
    {
        
        int Complete();
    }
}
