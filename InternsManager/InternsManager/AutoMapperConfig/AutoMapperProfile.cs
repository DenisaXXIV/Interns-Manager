using AutoMapper;
using InternsManager.DAL.Entities;
using InternsManager.TL.DTO;

namespace InternsManager.AutoMapperConfig
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Intern, InternDTO>().ReverseMap();
        }
    }
}
