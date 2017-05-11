using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigraf.Rat.Infra.Dados.Interfaces
{
   public interface IUnitOfWork 
    {
        void BeginTransaction();
        void Commit();
    }
}
