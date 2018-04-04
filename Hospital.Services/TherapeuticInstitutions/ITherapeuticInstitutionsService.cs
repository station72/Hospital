using Hospital.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;
using Hospital.Dto.Input;

namespace Hospital.Services.TherapeuticInstitutions
{
    public interface ITherapeuticInstitutionsService
    {
        Task<IEnumerable<TherapeuticInstitutionDto>> GetInstitutionsAsync();

        Task DeleteAsync(int id);

        Task<TherapeuticInstitutionDto> CreateNewAsync(CreateInstitutionInputDto createInstitutionInputDto);

        Task<TherapeuticInstitutionDto> EditAsync(EditInsitutionInputDto inputDto);
    }
}