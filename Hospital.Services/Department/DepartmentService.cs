using Hospital.Dto;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Hospital.Services.Department
{
    public class DepartmentService : IDepartmentService
    {
        public async Task DeleteAsync(int id)
        {
            await Task.Delay(TimeSpan.FromSeconds(3));
        }

        public async Task<IEnumerable<DepartmentDto>> GetListAsync(int institutionId)
        {
            await Task.Delay(TimeSpan.FromSeconds(4));

            return new List<DepartmentDto>
            {
                new DepartmentDto
                {
                    Id = 1,
                    Name = "Name1",
                    Profile = "Profile",

                    TherapeuticInstitutionsId = institutionId
                },
                new DepartmentDto
                {
                    Id = 2,
                    Name = "Name2",
                    Profile = "Profile",
                    TherapeuticInstitutionsId = institutionId
                },
                new DepartmentDto
                {
                    Id = 3,
                    Name = "Name3",
                    Profile = "Profile",
                    TherapeuticInstitutionsId = institutionId
                }
            };
        }
    }
}
