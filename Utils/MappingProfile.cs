using SBIChallenge.Models;

using AutoMapper;

namespace SBIChallenge.Utils
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<ServerPost, Salida>()
                .ForMember(x => x.Titulo, o => o.MapFrom(y => y.Title));
        }
    }
}