using Digigraf.Rat.Dominio.Entidades.SIGA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigraf.Rat.Dominio.Interfaces.Repository.SIGA
{
   public interface IRatRepositorySIGA : IRepositorySIGA<SA1110>
    {
        void PesquisarClienteSIGA(int id);
        List<SA1110> ObterRatSIGA(string id);
    }
}
