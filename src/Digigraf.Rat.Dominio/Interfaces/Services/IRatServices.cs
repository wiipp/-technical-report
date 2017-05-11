using Digigraf.Rat.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigraf.Rat.Dominio.Interfaces.Services
{
  public interface IRatServices : IDisposable
    {
        rat Adicionar(rat rat);
        rat Atualizar(rat rat);
      //  TB_Rat ObterPorId(int id);
       // IEnumerable<TB_Rat> ObterTodos();
        void Remover(int id);
        void RemoverRat(int id);


    }
}
