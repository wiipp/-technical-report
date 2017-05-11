using Digigraf.Rat.Infra.CrossCutting.Specifications.Validation;

namespace Digigraf.Rat.Aplicacao.ViewModel
{
    public class DadosPadroesVm
    {
        public DadosPadroesVm()
        {
            ResultadoValidacao = new ResultadoValidacao();
        }
     
        public ResultadoValidacao ResultadoValidacao { get; set; }

    }
}