using System.Collections.Generic;
using System.Threading.Tasks;
using Hospital.Dto;
using Hospital.Data;
using System.Data.Entity;
using Hospital.Common;
using System.Linq;
using AutoMapper;
using Hospital.Dto.Input;
using Hospital.Data.Model;

namespace Hospital.Services.Employee
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HospitalDbContext _dc;

        public EmployeeService()
        {
            _dc = new HospitalDbContext();
        }

        public async Task<EmployeeDto> CreateNewAsync(CreateEmployeeInputDto input)
        {
            var entity = _dc.Employees.Add(new Employees
            {
                Cabinet = input.Cabinet,
                DepartmentId = input.DepartmentId,
                FirstName = input.FirstName,
                LastName = input.LastName,
                Patronymic = input.Patronymic,
                Schedule = input.Schedule
            });

            await _dc.SaveChangesAsync();

            var mappedEntity = Mapper.Map<EmployeeDto>(entity);
            return mappedEntity;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _dc.Employees.FirstOrDefaultAsync(u => u.Id == id && !u.IsDeleted);
            if (entity == null)
                throw new HospitalException($"Сущность с id = {id} не найдена!");

            entity.IsDeleted = true;
            await _dc.SaveChangesAsync();
        }

        public async Task<IEnumerable<EmployeeDto>> GetListAsync()
        {
            var entityList = await _dc.Employees
                .AsNoTracking()
                .Where(u => !u.IsDeleted)
                .ToArrayAsync();

            var mappedList = entityList.Select(Mapper.Map<EmployeeDto>).ToArray();
            return mappedList;
        }
    }
}
