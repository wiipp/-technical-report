using System.Collections.Generic;

namespace Digigraf.Rat.Infra.CrossCutting.Specifications.Validation
{
    public abstract class Validador<TEntity> : IValidador<TEntity> where TEntity : class
    {
        private readonly Dictionary<string, IRegra<TEntity>> _validations = new Dictionary<string, IRegra<TEntity>>();

        public virtual ResultadoValidacao Validar(TEntity entity)
        {
            ResultadoValidacao resultadoValidacao = new ResultadoValidacao();
            foreach (string index in this._validations.Keys)
            {
                IRegra<TEntity> regra = this._validations[index];
                if (!regra.Validar(entity))
                    resultadoValidacao.AdicionarErro(new ErroValidacao(regra.MensagemErro, regra.TipoMensagem));
            }
            return resultadoValidacao;
        }

        protected virtual void AdicionarRegra(string name, IRegra<TEntity> rule)
        {
            this._validations.Add(name, rule);
        }

        protected virtual void RemoverRegra(string name)
        {
            this._validations.Remove(name);
        }

        protected IRegra<TEntity> ObterRegra(string name)
        {
            IRegra<TEntity> regra;
            this._validations.TryGetValue(name, out regra);
            return regra;
        }
    }
}