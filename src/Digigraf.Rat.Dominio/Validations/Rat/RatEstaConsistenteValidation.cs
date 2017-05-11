using Digigraf.Rat.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Digigraf.Rat.Infra.CrossCutting.Specifications.Validation;

namespace Digigraf.Rat.Dominio.Validations.Rat
{
  public  class RatEstaConsistenteValidation : Validador<rat>
    {
        public RatEstaConsistenteValidation()
        {
            // depois tem escrever os alertas
        }
    }
}
