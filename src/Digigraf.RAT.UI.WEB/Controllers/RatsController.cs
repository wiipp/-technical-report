using Digigraf.Rat.Aplicacao.Interfaces;
using Digigraf.Rat.Aplicacao.ViewModel;
using Rotativa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Digigraf.RAT.UI.WEB.Controllers
{
    public class RatsController : PadraoController
    {
        // GET: Rats
        private readonly IRatAppServices _ratAppServices;


        public RatsController(IRatAppServices ratAppServices)
        {
            _ratAppServices = ratAppServices;
        }


        // GET: Rats
        [HttpGet]
        [Route("listar-rat")]
        public ActionResult Index()
        {
            return View(_ratAppServices.ObterTodos());
        }

        [HttpGet]
        public ActionResult ListarRat()
        {
            return View(_ratAppServices.ObterPorData());
        }

        public ActionResult Teste()
        {
            return View();
        }


        public ActionResult GerarPDF(int? id)
        {
            var rat = _ratAppServices.ObterRat(id.Value);
            //var sx5 = _ratAppServices.ObterServicos(rat);            
            //rat.severidade = new Sx5Vm { valor = sx5}
            if (rat.tipo_rat == "Co")
                rat.tipo_rat = "Contrato";
            if (rat.tipo_rat == "Ga")
                rat.tipo_rat = "Garantia";
            if (rat.tipo_rat == "In")
                rat.tipo_rat = "Instalação";
            if (rat.tipo_rat == "Cv")
                rat.tipo_rat = "Conversao";
            if (rat.tipo_rat == "Su")
                rat.tipo_rat = "Suporte Tecnico";
            if (rat.tipo_rat == "Tr")
                rat.tipo_rat = "Treinamento";
            if (rat.tipo_rat == "Av")
                rat.tipo_rat = "Avaliação";
            if (rat.tipo_rat == "Ou")
                rat.tipo_rat = rat.tipo_o_rat;
            if (rat.local_rat == "C")
                rat.local_rat = "Cliente";
            if (rat.local_rat == "D")
                rat.local_rat = "Digigraf";
            var pdf = new ViewAsPdf
            {
                ViewName = "RelatorioRAT",
                Model = rat

            };
            return pdf;
        }


        [HttpGet]
        [Route("{id:int}/visualizar-rat")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest); // que dizer que esse objeto nao vai ser nulabo
            }
            var ratVm = _ratAppServices.ObterPorId(id.Value); // vai pegar o valor real de guid 
            if (ratVm == null)
            {
                return HttpNotFound();
            }
            return View(ratVm);
        }


        [HttpGet]
        [Route("novo-rat")]
        public ActionResult Create()
        {
            var ratVm = new RatVm();

            return View(ratVm);
        }

        [HttpPost]
        [Route("novo-rat")]
        public ActionResult Create(RatVm ratVm)
        {
            //ratVm.DescGrupo = ratVm.DropListGrupo.Where(p => p.Value == ratVm.cod_gru.ToString()).First().Text; // trazendo o text SelectListItem
            //ratVm.DescAtendente = ratVm.DropListAtendente.Where(p => p.Value == ratVm.cod_ate.ToString()).First().Text;
            //ratVm.DescTecnico = ratVm.DropListTecnico.Where(p => p.Value == ratVm.cod_tec.ToString()).First().Text;

            ///  ratVm.Ativo = true;
            ratVm.Ativo = true;
            ratVm.hr_rat = DateTime.Now.Date.ToShortTimeString();
            ratVm.dt_rat = DateTime.Now.Date.ToShortDateString();

            if (ModelState.IsValid)
            {
                ratVm = _ratAppServices.Adicionar(ratVm);
                if (ratVm.ResultadoValidacao.IsValid)
                {
                    GerarMensagemResposta(string.Format("{0} ", ratVm.ResultadoValidacao.Mensagem, ""), RespostaVm.MensagemEnum.Sucesso);
                    return RedirectToAction("Create");
                }

                CarregarMensagemDeErro(ratVm.ResultadoValidacao);

                return View(ratVm);
            }

            return View(ratVm);
        }
        [HttpGet]
        [Route("{id:int}/editar-rat")]
        public ActionResult Edit(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var ratVm = _ratAppServices.ObterPorId(id.Value);

            if (ratVm == null)
            {
                return HttpNotFound();
            }

            return View(ratVm);
        }

        [Route("{id:int}/editar-rat")]
        [HttpPost]
        public ActionResult Edit(RatVm ratVm)
        {
            //ratVm.DescGrupo = ratVm.DropListGrupo.Where(p => p.Value == ratVm.cod_gru.ToString()).First().Text; // trazendo o text SelectListItem
            //ratVm.DescAtendente = ratVm.DropListAtendente.Where(p => p.Value == ratVm.cod_ate.ToString()).First().Text;
            //ratVm.DescTecnico = ratVm.DropListTecnico.Where(p => p.Value == ratVm.cod_tec.ToString()).First().Text;

            ratVm.Ativo = true;
            ratVm.hr_rat = DateTime.Now.Date.ToShortTimeString();
            ratVm.dt_rat = DateTime.Now.Date.ToShortDateString();

            if (ModelState.IsValid)
            {
                ratVm = _ratAppServices.Atualizar(ratVm);

                if (ratVm.ResultadoValidacao.IsValid)
                {
                    GerarMensagemResposta(string.Format("{0} ", ratVm.ResultadoValidacao.Mensagem, ""), RespostaVm.MensagemEnum.Sucesso);
                    //Log.LogarInformacao("Sucesso " + " Registrado ");
                    return RedirectToAction("Edit");
                }

                CarregarMensagemDeErro(ratVm.ResultadoValidacao);
            }
            return View();
        }

        [Route("{id:int}/excluir-rat")]
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var ratVm = _ratAppServices.ObterPorId(id.Value);
            if (ratVm == null)
            {
                return HttpNotFound();
            }
            return View(ratVm);
        }

        [Route("{id:int}/excluir-rat")]
        [HttpPost]
        public ActionResult Delete(int id)
        {
            _ratAppServices.RemoverRat(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _ratAppServices.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}