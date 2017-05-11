using Digigraf.Rat.Aplicacao.ViewModel;
using Digigraf.Rat.Infra.CrossCutting.Specifications.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Digigraf.RAT.UI.WEB.Controllers
{
    public class PadraoController : Controller
    {
        // GET: Padrao
        public void GerarMensagemResposta(string descricao, RespostaVm.MensagemEnum mensagem)
        {
            TempData["MensagemRetorno"] = new RespostaVm
            {
                Mensagem = mensagem,
                Descricao = descricao
            };
        }

        public void CarregarMensagemDeErro(ResultadoValidacao validationResult)
        {
            var respostas = validationResult.Erros.Select(erro => new RespostaVm
            {
                Descricao = erro.Mensagem,
                Mensagem = RespostaVm.MensagemEnum.ErroGeral
            }).ToList();

            TempData["MensagemRetorno"] = respostas;
        }
    }
}