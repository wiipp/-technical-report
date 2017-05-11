using Digigraf.Rat.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigraf.Rat.Dominio.Interfaces.Repository
{
   public interface IRatRepository : IRepository<rat>
    {
       void RemoverRat(int id);
        IEnumerable<rat> ObterPorData();
        sx5 ObterServicos(rat rats);
        List<rat> ObterRats(int id);
    }
}
