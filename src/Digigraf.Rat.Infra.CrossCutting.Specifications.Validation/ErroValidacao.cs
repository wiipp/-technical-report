namespace Digigraf.Rat.Infra.CrossCutting.Specifications.Validation
{
    public class ErroValidacao
    {
        public TipoMensagem TipoMensagem { get; set; }

        public string Mensagem { get; set; }

        public ErroValidacao(string mensagem, TipoMensagem tipoMensagem = TipoMensagem.ErroGeral)
        {
            this.Mensagem = mensagem;
            this.TipoMensagem = tipoMensagem;
        }
    }
}