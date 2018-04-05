using Hospital.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;
using Hospital.Dto.Input;

namespace Hospital.Services.Employee
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDto>> GetListAsync();

        Task DeleteAsync(int id);

        Task<EmployeeDto> CreateNewAsync(CreateEmployeeInputDto createEmployeeInputDto);
    }
}
