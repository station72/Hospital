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

            CreateMap<Departments, DepartmentDto>()
                .ForMember(dest => dest.Address, opt => opt.MapFrom(s => s.Address))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(s => s.Name))
                .ForMember(dest => dest.Profile, opt => opt.MapFrom(s => s.Profile))
                .ForMember(dest => dest.TherapeuticInstitutionsId, opt => opt.MapFrom(s => s.TherapeuticInstitutionsId))
                .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<Employees, EmployeeDto>()
                .ForMember(dest => dest.Cabinet, opt => opt.MapFrom(s => s.Cabinet))
                .ForMember(dest => dest.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(s => s.DepartmentId))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(s => s.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(s => s.LastName))
                .ForMember(dest => dest.Patronymic, opt => opt.MapFrom(s => s.Patronymic))
                .ForMember(dest => dest.Schedule, opt => opt.MapFrom(s => s.Schedule))
                .ForAllOtherMembers(opt => opt.Ignore());

            CreateMap<Users, UserDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(dest => dest.Login, opt => opt.MapFrom(s => s.Login))
                .ForMember(dest => dest.Role, opt => opt.MapFrom(s => s.Role))
                .ForAllOtherMembers(opt => opt.Ignore());
        }
    }
}