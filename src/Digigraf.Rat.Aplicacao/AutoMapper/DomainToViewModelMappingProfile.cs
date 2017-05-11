using AutoMapper;
using Digigraf.Rat.Aplicacao.ViewModel;
using Digigraf.Rat.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigraf.Rat.Aplicacao.AutoMapper
{
  public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<rat, RatVm>();
            CreateMap<tecnico, TecnicoVm>();
            CreateMap<atendente, AtendenteVm>();
            CreateMap<grupo, GrupoVm>();
            CreateMap<sx5, Sx5Vm>();
        }
    }
}
