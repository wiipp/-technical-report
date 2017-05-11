using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigraf.Rat.Infra.CrossCutting.Specifications.Validation
{
    public class ResultadoValidacao
    {
        private readonly List<ErroValidacao> _erros = new List<ErroValidacao>();

        public string Mensagem { get; set; }

        public TipoMensagem TipoMensagem { get; set; }

        public bool IsValid
        {
            get
            {
                return this._erros.Count == 0;
            }
        }

        public IEnumerable<ErroValidacao> Erros
        {
            get
            {
                return (IEnumerable<ErroValidacao>)this._erros;
            }
        }

        public void AdicionarErro(ErroValidacao erro)
        {
            this._erros.Add(erro);
        }

        public void RemoverErro(ErroValidacao erro)
        {
            if (!this._erros.Contains(erro))
                return;
            this._erros.Remove(erro);
        }

        public void AdicionarErro(params ResultadoValidacao[] resultadoValidacao)
        {
            if (resultadoValidacao == null)
                return;
            foreach (ResultadoValidacao resultadoValidacao1 in Enumerable.Where<ResultadoValidacao>((IEnumerable<ResultadoValidacao>)resultadoValidacao, (Func<ResultadoValidacao, bool>)(result => result != null)))
                this._erros.AddRange(resultadoValidacao1.Erros);
        }
    }
}
