using Hospital.Dto;
using Hospital.Dto.Input;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hospital.Services.Department
{
    public interface IDepartmentService
    {
        Task<IEnumerable<DepartmentDto>> GetListAsync(int institutionId);

        Task DeleteAsync(int id);

        Task<DepartmentDto> CreateNewAsync(CreateDepartmentInputDto input);

        Task<DepartmentDto> EditAsync(EditDepartmentInputDto inputDto);
    }
}