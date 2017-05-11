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
   public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<RatVm, rat>();
            CreateMap<TecnicoVm, tecnico>();
            CreateMap<AtendenteVm, atendente>();
            CreateMap<GrupoVm, grupo>();
            CreateMap<Sx5Vm, sx5>();
        }
    }
}
