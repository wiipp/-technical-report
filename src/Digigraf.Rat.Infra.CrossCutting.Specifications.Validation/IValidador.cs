namespace Digigraf.Rat.Infra.CrossCutting.Specifications.Validation
{
    public interface IValidador<in TEntity>
    {
        ResultadoValidacao Validar(TEntity entity);
    }
}