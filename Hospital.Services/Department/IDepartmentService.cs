using Hospital.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hospital.Services.Department
{
    public interface IDepartmentService
    {
        Task<IEnumerable<DepartmentDto>> GetListAsync(int institutionId);
        Task DeleteAsync(int id);
    }
}