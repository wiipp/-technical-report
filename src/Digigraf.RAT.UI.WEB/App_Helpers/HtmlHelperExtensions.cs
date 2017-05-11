using Digigraf.Rat.Aplicacao.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Digigraf.RAT.UI.WEB.App_Helpers
{
    public static class HtmlHelperExtensions
    {
        public static HtmlString ExibirMessagemRetorno(this HtmlHelper htmlHelper, object mensagemRetorno)
        {
            if (mensagemRetorno == null) return null;

            var sb = new StringBuilder();

            if (mensagemRetorno is RespostaVm)
            {
                var respostaVm = (RespostaVm)mensagemRetorno;
                switch (respostaVm.Mensagem)
                {
                    case RespostaVm.MensagemEnum.Sucesso:
                        sb.Append("<div class=\"alert alert-success fade in\"><button class=\"close\" data-dismiss=\"alert\">");
                        sb.Append("<button class=\"close\" data-dismiss=\"alert\">   ×   </button><i class=\"fa-fw fa fa-check\"></i>");
                        sb.AppendFormat("<strong>Sucesso! </strong> {0}</div>", respostaVm.Descricao);
                        break;
                    case RespostaVm.MensagemEnum.NaoExiste:
                        sb.Append("<div class=\"alert alert-warning fade in\"><button class=\"close\" data-dismiss=\"alert\">");
                        sb.Append("<button class=\"close\" data-dismiss=\"alert\">   ×   </button><i class=\"fa-fw fa fa-warning\"></i>");
                        sb.AppendFormat("<strong>Alerta! </strong> {0}</div>", respostaVm.Descricao);
                        break;
                    case RespostaVm.MensagemEnum.ErroNegocio:
                    case RespostaVm.MensagemEnum.ErroSistema:
                    case RespostaVm.MensagemEnum.ErroSharePoint:
                    case RespostaVm.MensagemEnum.ErroGeral:
                        sb.Append("<div class=\"alert alert-danger fade in\"><button class=\"close\" data-dismiss=\"alert\">");
                        sb.Append("<button class=\"close\" data-dismiss=\"alert\">   ×   </button><i class=\"fa-fw fa fa-times\"></i>");
                        sb.AppendFormat("<strong>Erro! </strong> {0}</div>", respostaVm.Descricao);
                        break;
                    case RespostaVm.MensagemEnum.ErroBenner:
                        sb.Append("<div class=\"alert alert-danger fade in\"><button class=\"close\" data-dismiss=\"alert\">");
                        sb.Append("<button class=\"close\" data-dismiss=\"alert\">   ×   </button><i class=\"fa-fw fa fa-times\"></i>");
                        sb.AppendFormat("<strong>Erro Benner! </strong> {0}</div>", respostaVm.Descricao);
                        break;
                    case RespostaVm.MensagemEnum.Informacao:
                        sb.Append("<div class=\"alert alert-info fade in\"><button class=\"close\" data-dismiss=\"alert\">");
                        sb.Append("<button class=\"close\" data-dismiss=\"alert\">   ×   </button><i class=\"fa-fw fa fa-info \"></i>");
                        sb.AppendFormat("<strong>Informação! </strong> {0}</div>", respostaVm.Descricao);
                        break;
                    default:
                        sb.Append("<div class=\"alert alert-danger fade in\"><button class=\"close\" data-dismiss=\"alert\">");
                        sb.Append("<button class=\"close\" data-dismiss=\"alert\">   ×   </button><i class=\"fa-fw fa fa-times\"></i>");
                        sb.AppendFormat("<strong>Erro! </strong> {0}</div>", respostaVm.Descricao);
                        break;
                }

            }
            else if (mensagemRetorno is List<RespostaVm>)
            {
                var respostas = (List<RespostaVm>)mensagemRetorno;

                sb.Append("<div class=\"alert alert-danger fade in\"><button class=\"close\" data-dismiss=\"alert\">");
                sb.Append("<button class=\"close\" data-dismiss=\"alert\">   ×   </button><i class=\"fa-fw fa fa-times\"></i>");
                sb.Append("<strong>Erro: </strong>");

                foreach (var resposta in respostas)
                {
                    sb.AppendFormat("{0} ", resposta.Descricao);
                }
                sb.Append("</div>");
            }
            else
            {
                sb.Append("<div class=\"alert alert-danger fade in\"><button class=\"close\" data-dismiss=\"alert\">");
                sb.Append("<button class=\"close\" data-dismiss=\"alert\">   ×   </button><i class=\"fa-fw fa fa-times\"></i>");
                sb.Append("<strong>Erro! </strong>");
                sb.AppendFormat("{0} ", mensagemRetorno);
                sb.Append("</div>");
            }

            return new HtmlString(sb.ToString());
        }

    }
}