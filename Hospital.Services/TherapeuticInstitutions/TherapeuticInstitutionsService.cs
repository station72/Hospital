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

namespace Hospital.Services.Institution
{
    public class TherapeuticInstitutionsService : ITherapeuticInstitutionsService
    {
        private readonly HospitalDbContext _dc;

        public TherapeuticInstitutionsService()
        {
            _dc = new HospitalDbContext();
        }

        public async Task<TherapeuticInstitutionDto> CreateNewAsync(CreateInstitutionInputDto input)
        {
            var addedEntity = _dc.TherapeuticInstitutions.Add(new TherapeuticInstitutions
            {
                Address = input.Address,
                Name = input.Name,
                OKPO = input.OKPO
            });

            await _dc.SaveChangesAsync();

            var result = Mapper.Map<TherapeuticInstitutionDto>(addedEntity);
            return result;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _dc.TherapeuticInstitutions
                .FirstOrDefaultAsync(u => u.Id == id && !u.IsDeleted);

            if (entity == null)
                throw new HospitalException($"Сущность с id = {id} не найдена!");

            entity.IsDeleted = true;

            await _dc.SaveChangesAsync();
        }

        public async Task<TherapeuticInstitutionDto> EditAsync(EditInsitutionInputDto input)
        {
            var entity = await _dc.TherapeuticInstitutions
                .FirstOrDefaultAsync(u => u.Id == input.Id && !u.IsDeleted);

            if (entity == null)
                throw new HospitalException($"Сущность с id = {input.Id} не найдена!");

            entity.Address = input.Address;
            entity.Name = input.Name;
            entity.OKPO = input.OKPO;

            await _dc.SaveChangesAsync();

            var mappedEntity = Mapper.Map<TherapeuticInstitutionDto>(entity);
            return mappedEntity;
        }

        public async Task<IEnumerable<TherapeuticInstitutionDto>> GetListAsync()
        {
            var list = await _dc.TherapeuticInstitutions
                .Where(u => !u.IsDeleted)
                .ToListAsync();

            var mappedList = list.Select(Mapper.Map<TherapeuticInstitutionDto>);
            return mappedList;
        }
    }
}
