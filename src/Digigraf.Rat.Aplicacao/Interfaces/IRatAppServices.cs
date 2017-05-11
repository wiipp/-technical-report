using Digigraf.Rat.Aplicacao.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigraf.Rat.Aplicacao.Interfaces
{
   public interface IRatAppServices : IDisposable
    {
        RatVm Adicionar (RatVm ratVm);
        RatVm Atualizar(RatVm ratVm);
        void Remover(int id);
        void RemoverRat(int id);
        RatVm ObterPorId(int id);
        IEnumerable<RatVm> ObterTodos();
        IEnumerable<RatVm> ObterPorData();
        Sx5Vm ObterServicos(RatVm ratVm);
        RatVm ObterRat(int id);

    }
}
