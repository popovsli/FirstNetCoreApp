using AutoMapper;
using BusinessEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModels.ViewModels;

namespace FirstNetCoreMVC.Utils.Automapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        public ViewModelToDomainMappingProfile()
        {
            CreateMap<MovieViewModel,Movie>().ForMember(g => g.ID, map => map.MapFrom(vm => vm.genres));
        }
    }
}