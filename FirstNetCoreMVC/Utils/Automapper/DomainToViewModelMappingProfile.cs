using AutoMapper;
using BusinessEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstNetCoreMVC.ViewModels;

namespace FirstNetCoreMVC.Utils.Automapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        public DomainToViewModelMappingProfile()
        {
            CreateMap<Movie, MovieViewModel>();
        }
    }
}
