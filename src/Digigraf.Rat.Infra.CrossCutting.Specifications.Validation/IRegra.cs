namespace Digigraf.Rat.Infra.CrossCutting.Specifications.Validation
{
    public interface IRegra<in TEntity>
    {
        string MensagemErro { get; }

        TipoMensagem TipoMensagem { get; }

        bool Validar(TEntity entity);
    }
}