using AutoMapper;
using DestinoComum2.Dto;
using DestinoComum2.Models;

namespace DestinoComum2.Profiles
{
    public class ProfileAutoMapper:Profile
    {
        public ProfileAutoMapper() 
        {
            CreateMap<CidadeCriacaoDto, CidadeModel>();
            CreateMap<CidadeModel, CidadeEdicaoDto>();
            CreateMap<CidadeEdicaoDto, CidadeModel>();
        }
    }
}
