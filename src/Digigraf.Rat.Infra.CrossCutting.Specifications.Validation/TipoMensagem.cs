namespace Digigraf.Rat.Infra.CrossCutting.Specifications.Validation
{
    public enum TipoMensagem
    {
        Sucesso = 0,
        NaoExiste = 1,
        ErroNegocio = 2,
        ErroSistema = 4,
        ErroGeral = 32,
        Informacao = 64,
    }
}