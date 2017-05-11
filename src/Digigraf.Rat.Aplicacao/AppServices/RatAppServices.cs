using Digigraf.Rat.Aplicacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Digigraf.Rat.Aplicacao.ViewModel;
using Digigraf.Rat.Dominio.Interfaces.Services;
using Digigraf.Rat.Dominio.Interfaces.Repository;
using AutoMapper;
using Digigraf.Rat.Dominio.Entidades;
using Digigraf.Rat.Infra.Dados.Interfaces;
using Digigraf.Rat.Dominio.Interfaces.Repository.SIGA;
using Digigraf.Rat.Dominio.Entidades.SIGA;

namespace Digigraf.Rat.Aplicacao.AppServices
{
    public class RatAppServices : ApplicationService, IRatAppServices
    {
        private readonly IRatServices _ratServices;
        private readonly IRatRepository _ratRepository;
        private readonly IRatRepositorySIGA _ratRepositorySIGA;
        private readonly ITecnicoRepository _tecnicoRepository;
        private readonly IGrupoRepository _grupoRepository;
        private readonly IAtendenteRepository _atendenteRepository;


        public RatAppServices(IUnitOfWork uow,
                              IRatServices ratServices,
                              IRatRepository ratRepository,
                              IRatRepositorySIGA ratRepositorySIGA,
                              ITecnicoRepository tecnicoRepository,
                              IGrupoRepository grupoRepository,
                              IAtendenteRepository atendenteRepository) : base(uow)
        {
            _ratServices = ratServices;
            _ratRepository = ratRepository;
            _ratRepositorySIGA = ratRepositorySIGA;
            _tecnicoRepository = tecnicoRepository;
            _grupoRepository = grupoRepository;
            _atendenteRepository = atendenteRepository;
        }

        public RatVm Adicionar(RatVm ratVm)
        {
            var rat = Mapper.Map<RatVm, rat>(ratVm);

            BeginTransaction();

            var ratReturn = _ratServices.Adicionar(rat);
            ratVm = Mapper.Map<rat, RatVm>(ratReturn);

            if (!ratVm.ResultadoValidacao.IsValid)
            {
                return ratVm;

            }

            Commit();
            return ratVm;
        }

        public RatVm Atualizar(RatVm ratVm)
        {
            var rat = Mapper.Map<RatVm, rat>(ratVm);

            BeginTransaction();

            var ratReturn = _ratServices.Atualizar(rat);
            ratVm = Mapper.Map<rat, RatVm>(ratReturn);

            if (!ratVm.ResultadoValidacao.IsValid)
            {
                return ratVm;
            }

            Commit();
            return ratVm;
        }

        public void Dispose()
        {
            _ratServices.Dispose(); // destruir   
            _ratRepository.Dispose();
            _ratRepositorySIGA.Dispose();
            GC.SuppressFinalize(this);
        }

        public RatVm ObterPorId(int id)
        {
            return Mapper.Map<rat, RatVm>(_ratRepository.ObterPorId(id));

        }

        public IEnumerable<RatVm> ObterTodos()
        {
         
            throw new NotImplementedException();
            
        }

        public void Remover(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoverRat(int id)
        {
            BeginTransaction();
            _ratServices.RemoverRat(id);
            Commit();

        }

        public IEnumerable<RatVm> ObterPorData()
        {
            var rats = new List<RatVm>();
            var resultado = _ratRepository.ObterPorData();
            return rats = Mapper.Map<IEnumerable<rat>, IEnumerable<RatVm>>(resultado).ToList();
        }

        public Sx5Vm ObterServicos(RatVm ratVm)
        {
            //var sx5Vm = new List<Sx5Vm>();
            //var rats = Mapper.Map<RatVm, rat>(ratVm);
            //var resultado = _ratRepository.ObterServicos(rats);
            //return Mapper.Map<sx5>,<Sx5Vm> (resultado);

            return null;
        }

        public RatVm ObterRat(int id)
        {
            var ratSIS  = _ratRepository.ObterRats(id);
            var rat     = _ratRepository.ObterPorId(id);          
            var ratSiGA = _ratRepositorySIGA.ObterRatSIGA(rat.a1_cod);
            var tecSIS  = _tecnicoRepository.ObterPorId(rat.cod_tec);
            var gruSIS  = _grupoRepository.ObterGrupos(rat.cod_gru);
            var ateSIS  = _atendenteRepository.ObterPorId(rat.cod_ate);

            var query = ratSIS.Join(ratSiGA, post => post.a1_cod,
                                    meta => meta.A1_COD,
                                    (post, meta) => new { ratSIS = post, ratSiGA = meta }).
                                
                                    Select(x => new RatVm
                                    {
                                        A1_CEP = x.ratSiGA.A1_CEP,
                                        a1_cod = x.ratSIS.a1_cod,
                                        A1_CONTATO = x.ratSiGA.A1_CONTATO,
                                        A1_END = x.ratSiGA.A1_END,
                                        A1_EST = x.ratSiGA.A1_EST,
                                        A1_FAX = x.ratSiGA.A1_FAX,
                                        A1_MUN = x.ratSiGA.A1_MUN,
                                        A1_NOME = x.ratSiGA.A1_NOME,
                                        b1_cod = x.ratSIS.b1_cod,
                                        cod_ate = x.ratSIS.cod_ate,
                                        chamado = x.ratSIS.chamado,
                                        cod_gru = x.ratSIS.cod_gru,
                                        c5_num = x.ratSIS.c5_num,
                                        cod_rat = x.ratSIS.cod_rat,
                                        cod_tec = x.ratSIS.cod_tec,
                                        defeito_rat = x.ratSIS.defeito_rat,
                                        def_diag_rat = x.ratSIS.def_diag_rat,
                                        descricao = x.ratSIS.descricao,
                                        dt_abre_cham_hp = x.ratSIS.dt_abre_cham_hp,
                                        dt_fecha_cham_hp = x.ratSIS.dt_fecha_cham_hp,
                                        dt_rat = x.ratSIS.dt_rat,
                                        dt_vis_rat = x.ratSIS.dt_vis_rat,
                                        email_cli_rat = x.ratSIS.email_cli_rat,
                                        empresa = x.ratSIS.empresa,
                                        hr_abre_cham_hp = (x.ratSIS.hr_abre_cham_hp),
                                        hr_fecha_cham_hp = (x.ratSIS.hr_fecha_cham_hp),
                                        hr_rat = x.ratSIS.hr_rat,
                                        hr_vis_fim_rat = x.ratSIS.hr_vis_fim_rat,
                                        hr_vis_rat = x.ratSIS.hr_vis_rat,
                                        inst_sw = x.ratSIS.inst_sw,
                                        km_cli_rat = x.ratSIS.km_cli_rat,
                                        local_rat = x.ratSIS.local_rat,
                                        m_obra_rat = x.ratSIS.m_obra_rat,
                                        n_serie_exp = x.ratSIS.n_serie_exp,
                                        obs_rat = x.ratSIS.obs_rat,
                                        pendencia_rat = x.ratSIS.pendencia_rat,
                                        severidade = x.ratSIS.severidade,
                                        solucao = x.ratSIS.solucao,
                                        tipo_o_rat = x.ratSIS.tipo_o_rat,
                                        tipo_rat = x.ratSIS.tipo_rat,
                                        valor_rat = x.ratSIS.valor_rat,
                                        A1_TEL = x.ratSiGA.A1_TEL,
                                        Tecnico = new TecnicoVm {
                                            cod_tec = tecSIS.cod_tec,
                                            nome_tec = tecSIS.nome_tec,
                                            Grupo = new GrupoVm {
                                                cod_gru = gruSIS.cod_gru,
                                                des_gru = gruSIS.des_gru,
                                                delete_gru = gruSIS.delete_gru,
                                                status_gru = gruSIS.status_gru
                                            }

                                        },
                                        Atendente = new AtendenteVm {
                                            cod_ate = ateSIS.cod_ate,
                                            nome_ate = ateSIS.nome_ate,                                            
                                            
                                        }                                    
                                        

                                    }).ToList();
                   

            var ratVm = query.FirstOrDefault();

            return ratVm;

            
        }
    }
}
