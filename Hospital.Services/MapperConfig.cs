using AutoMapper;
using Hospital.Data.Model;
using Hospital.Dto;

namespace Hospital.Services
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<TherapeuticInstitutions, TherapeuticInstitutionDto>()
                .ForMember(dest => dest.Address, opt => opt.MapFrom(s => s.Address))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(s => s.Name))
                .ForMember(dest => dest.OKPO, opt => opt.MapFrom(s => s.OKPO))
                .ForAllOtherMembers(opt => opt.Ignore());
        }
    }
}
