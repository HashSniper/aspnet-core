using System;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Microsoft.EntityFrameworkCore;
using MPACORE.PhoneBook.PhoneBooks.Dtos;
using MPACORE.PhoneBook.PhoneBooks.Persons;

namespace MPACORE.PhoneBook.PhoneBooks
{
    public class PersonAppService : PhoneBookAppServiceBase, IPersonAppService
    {

        private readonly IRepository<Person> _personRepository;


        public PersonAppService(IRepository<Person> repository)
        {
            _personRepository = repository;
        }

        public async Task CreateOrUpdatePersonAsync( CreateOrUpdatePersonInput input)
        {
            try
            {
                if (input.PersonEditDto.Id.HasValue)
                {
                    await UpdatePersonAsync(input.PersonEditDto);
                }
                else
                {
                    await CreatePersonAsync(input.PersonEditDto);
                }
            }
            catch(Exception ex)
            {
                var str = ex.ToString();
            }
        }

        public async Task DeletePersonAsync(EntityDto input)
        {
            var entity = await _personRepository.GetAsync(input.Id);
            if (entity == null)
            {
                throw new Exception("用户不存在");
            }
            await _personRepository.DeleteAsync(input.Id);
        }

        public async Task<PagedResultDto<PersonListDto>> GetPagedPeronAsync(GetPersionInput input)
        {
            var query = _personRepository.GetAll();
            var personCount = await query.CountAsync();

            var persons = await query.OrderBy(input.Sorting).PageBy(input).ToListAsync();

            var dtos = persons.MapTo<List<PersonListDto>>();
            return new PagedResultDto<PersonListDto>(personCount, dtos);
        }

        public async Task<PersonListDto> GetPersonByIdAsync(NullableIdDto input)
        {
            var person = await _personRepository.GetAsync(input.Id.Value);
            return person.MapTo<PersonListDto>();
           
        }

        protected async Task UpdatePersonAsync(PersonEditDto input)
        {
            var entity = await _personRepository.GetAsync(input.Id.Value);

            await _personRepository.UpdateAsync(input.MapTo(entity));
        }
        protected async Task CreatePersonAsync(PersonEditDto input)
        {
            await _personRepository.InsertAsync(input.MapTo<Person>());
        }
    }
}
