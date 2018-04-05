using AutoMapper;
using Hospital.Common;
using Hospital.Data;
using Hospital.Data.Model;
using Hospital.Dto;
using Hospital.Dto.Input;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace Hospital.Services.Department
{
    public class DepartmentService : IDepartmentService
    {
        private readonly HospitalDbContext _dc;

        public DepartmentService()
        {
            _dc = new HospitalDbContext();
        }

        public async Task<DepartmentDto> CreateNewAsync(CreateDepartmentInputDto input)
        {
            var entity = _dc.Departments.Add(new Departments
            {
                Address = input.Address,
                Name = input.Name,
                Profile = input.Profile,
                TherapeuticInstitutionsId = input.TherapeuticInstitutionsId
            });

            await _dc.SaveChangesAsync();

            var mappedEntity = Mapper.Map<DepartmentDto>(entity);
            return mappedEntity;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _dc.Departments
                .FirstOrDefaultAsync(u => u.Id == id && !u.IsDeleted);

            if (entity == null)
                throw new HospitalException($"Сущность с id = {id} не найдена!");

            entity.IsDeleted = true;

            await _dc.SaveChangesAsync();
        }

        public async Task<DepartmentDto> EditAsync(EditDepartmentInputDto input)
        {
            var entity = await _dc.Departments
                .FirstOrDefaultAsync(u => u.Id == input.Id && !u.IsDeleted);

            if (entity == null)
                throw new HospitalException($"Сущность с id = {input.Id} не найдена!");

            if (entity.TherapeuticInstitutionsId != input.TherapeuticInstitutionsId)
            {
                var insitiution = await _dc.TherapeuticInstitutions
                    .FirstOrDefaultAsync(u => u.Id == input.TherapeuticInstitutionsId && !u.IsDeleted);

                if (insitiution == null)
                    throw new HospitalException($"Учреждение с id = {input.TherapeuticInstitutionsId} не найдено!");
            }

            entity.Address = input.Address;
            entity.Name = input.Name;
            entity.Profile = input.Profile;
            entity.TherapeuticInstitutionsId = input.TherapeuticInstitutionsId;

            await _dc.SaveChangesAsync();

            var mapped = Mapper.Map<DepartmentDto>(entity);
            return mapped;
        }

        public async Task<IEnumerable<DepartmentDto>> GetListAsync(int institutionId)
        {
            var list = await _dc.Departments
                .Where(u => u.TherapeuticInstitutionsId == institutionId && !u.IsDeleted)
                .ToListAsync();

            var mappedList = list.Select(Mapper.Map<DepartmentDto>);
            return mappedList;
        }
    }
}
