using System.ComponentModel;
using Digigraf.Rat.Aplicacao.AppServices;
using Digigraf.Rat.Aplicacao.Interfaces;
using Digigraf.Rat.Dominio.Interfaces.Repository;
using Digigraf.Rat.Dominio.Interfaces.Services;
using Digigraf.Rat.Dominio.Services;
using Digigraf.Rat.Infra.Dados.Context;
using Digigraf.Rat.Infra.Dados.Interfaces;
using Digigraf.Rat.Infra.Dados.Repository;
using Digigraf.Rat.Infra.Dados.UoW;
using SimpleInjector;
using Digigraf.Rat.Dominio.Interfaces.Repository.SIGA;
using Digigraf.Rat.Infra.Dados.Repository.SIGA;

namespace Digigraf.Rat.Infra.CrossCutting.Ioc
{
    public class InjecaoDependencia
    {
       

        public static void RegisterServices(Container container)
        {

            //Aplicacao
            container.RegisterPerWebRequest<IRatAppServices, RatAppServices>();

            //Domanio
            container.RegisterPerWebRequest<IRatServices, RatServices>();

            //Infra
            container.RegisterPerWebRequest<IRatRepository, RatRepository>();
            container.RegisterPerWebRequest<IGrupoRepository, GrupoRepository>();
            container.RegisterPerWebRequest<IAtendenteRepository, AtendenteRepository>();
            container.RegisterPerWebRequest<ITecnicoRepository, TecnicoRepository>();
            container.RegisterPerWebRequest<IRatRepositorySIGA, RatRepositorySIGA>();
            container.RegisterPerWebRequest<IUnitOfWork, UnitOfWork>();
            container.RegisterPerWebRequest<RatContext>();
            container.RegisterPerWebRequest<SIGAContext>();
        }


        public static void RegisterServicesTotal(Container container)
        {

            //Aplicacao
            container.Register<IRatAppServices, RatAppServices>(Lifestyle.Scoped);

            //Domanio
            container.Register<IRatServices, RatServices>(Lifestyle.Scoped);

            //Infra
            container.Register<IRatRepository, RatRepository>(Lifestyle.Scoped);
            container.Register<IGrupoRepository, GrupoRepository>(Lifestyle.Scoped);
            container.Register<IAtendenteRepository, AtendenteRepository>(Lifestyle.Scoped);
            container.Register<ITecnicoRepository, TecnicoRepository>(Lifestyle.Scoped);
            container.Register<IRatRepositorySIGA, RatRepositorySIGA>(Lifestyle.Scoped);
            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
            container.Register<RatContext>(Lifestyle.Scoped);
            container.Register<SIGAContext>(Lifestyle.Scoped);
        }


    }
}
