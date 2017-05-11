using Digigraf.Rat.Dominio.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Digigraf.Rat.Dominio.Entidades;
using Digigraf.Rat.Dominio.Interfaces.Repository;

namespace Digigraf.Rat.Dominio.Services
{
    public class RatServices : IRatServices
    {
        private readonly IRatRepository _ratRepository;

        public RatServices(IRatRepository ratRepository)
        {
            _ratRepository = ratRepository;
        }

        public rat Adicionar(rat rat)
        {
            if (rat.ResultadoValidacao.IsValid)
            {
                rat.ResultadoValidacao.Mensagem = "Rat Inserido com Sucesso";
                return _ratRepository.Adicionar(rat);
            }
            
            return rat;
        }

        public rat Atualizar(rat rat)
        {
            if (rat.ResultadoValidacao.IsValid)
            {
                rat.ResultadoValidacao.Mensagem = "Rat Atualizado com Sucesso"; 
                return _ratRepository.Atualizar(rat);
            }
            
            return rat;
        }

        public void Dispose()
        {
            _ratRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public void Remover(int id)
        {


            _ratRepository.Remover(id);
        }

        public void RemoverRat(int id)
        {
            _ratRepository.RemoverRat(id);
        }
    }
}
