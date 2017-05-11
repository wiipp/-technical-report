using Digigraf.Rat.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigraf.Rat.Dominio.Interfaces.Repository
{
   public interface IAtendenteRepository: IRepository<atendente>
    {
        List<atendente> ObterAtendentes(int id);
    }
}
