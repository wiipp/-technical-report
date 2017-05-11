using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigraf.Rat.Aplicacao.ViewModel
{
   public class RespostaVm
    {
        public string Descricao { get; set; }
        public MensagemEnum Mensagem { get; set; }

        public RespostaVm()
        {
            Descricao = string.Empty;
        }

        public enum MensagemEnum : int
        {
            Sucesso = 0,
            NaoExiste = 1,
            ErroNegocio = 2,
            ErroSistema = 4,
            ErroBenner = 8,
            ErroSharePoint = 16,
            ErroGeral = 32,
            Informacao = 64,
        }
    }
}
