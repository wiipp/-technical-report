using AutoMapper;
using Digigraf.Rat.Aplicacao.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digigraf.Rat.Aplicacao.AutoMapper
{
   public  class ViewModelToViewMappingProfile : Profile
    {
        public ViewModelToViewMappingProfile()
        {
            CreateMap<RatVm, RatVm>();
            CreateMap<TecnicoVm, TecnicoVm>();
            CreateMap<AtendenteVm, AtendenteVm>();
            CreateMap<GrupoVm, GrupoVm>();
            CreateMap<Sx5Vm, Sx5Vm>();
        }
    }
}
