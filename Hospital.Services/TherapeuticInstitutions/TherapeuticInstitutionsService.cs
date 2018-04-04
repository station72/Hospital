using Hospital.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Hospital.Dto.Input;
using Hospital.Common;

namespace Hospital.Services.TherapeuticInstitutions
{
    public class TherapeuticInstitutionsService : ITherapeuticInstitutionsService
    {
        public async Task<TherapeuticInstitutionDto> CreateNewAsync(CreateInstitutionInputDto input)
        {
            await Task.Delay(TimeSpan.FromSeconds(3));

            if (input.Name == "a")
            {
                throw new HospitalException("Такой уже есть!!!");
            }

            return new TherapeuticInstitutionDto
            {
                Id = 11,
                Address = input.Address,
                Name = input.Name,
                OKPO = input.OKPO
            };
        }

        public async Task DeleteAsync(int id)
        {
            await Task.Delay(TimeSpan.FromSeconds(3));
            return;
        }

        public async Task<TherapeuticInstitutionDto> EditAsync(EditInsitutionInputDto input)
        {
            await Task.Delay(TimeSpan.FromSeconds(3));

            if (input.Name == "a")
            {
                throw new HospitalException("Такое имя уже есть");
            }

            return new TherapeuticInstitutionDto
            {
                Id = input.Id,
                Address = input.Address,
                Name = input.Name,
                OKPO = input.OKPO
            };
        }

        //TODO: add paging
        public async Task<IEnumerable<TherapeuticInstitutionDto>> GetInstitutionsAsync()
        {
            await Task.Delay(TimeSpan.FromSeconds(3));

            return new List<TherapeuticInstitutionDto>
            {
                new TherapeuticInstitutionDto
                {
                    Id = 1,
                    Name = "Name1",
                    Address = "Address1"
                },
                new TherapeuticInstitutionDto
                {
                    Id = 2,
                    Name = "Name2",
                    Address = "Address2"
                },
                new TherapeuticInstitutionDto
                {
                    Id = 3,
                    Name = "Name3",
                    Address = "Address3"
                },
                new TherapeuticInstitutionDto
                {
                    Id = 4,
                    Name = "Name4",
                    Address = "Address4"
                },
                new TherapeuticInstitutionDto
                {
                    Id = 5,
                    Name = "Name5",
                    Address = "Address5"
                },
                new TherapeuticInstitutionDto
                {
                    Id = 6,
                    Name = "Name6",
                    Address = "Address6"
                },
                new TherapeuticInstitutionDto
                {
                    Id = 7,
                    Name = "Name7",
                    Address = "Address7"
                },
            };
        }
    }
}
