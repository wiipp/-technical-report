using Digigraf.Rat.Infra.CrossCutting.Specifications.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigraf.Rat.Dominio.Entidades
{
   public class DadosPadroes
    {
        public DadosPadroes()
        {
            ResultadoValidacao = new ResultadoValidacao();
        }

        public ResultadoValidacao ResultadoValidacao { get; set; }
    }
}
