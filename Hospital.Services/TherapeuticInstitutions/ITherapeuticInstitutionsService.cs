using Hospital.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;
using Hospital.Dto.Input;

namespace Hospital.Services.Institution
{
    public interface ITherapeuticInstitutionsService
    {
        Task<IEnumerable<TherapeuticInstitutionDto>> GetListAsync();

        Task DeleteAsync(int id);

        Task<TherapeuticInstitutionDto> CreateNewAsync(CreateInstitutionInputDto createInstitutionInputDto);

        Task<TherapeuticInstitutionDto> EditAsync(EditInsitutionInputDto inputDto);
    }
}