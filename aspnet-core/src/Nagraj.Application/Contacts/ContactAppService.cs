using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Nagraj.Contacts.Dto;

namespace Nagraj.Contacts
{
    public class ContactAppService : NagrajAppServiceBase,IContactAppService
    {
        private readonly IRepository<Contact> _contactRepository;

        public ContactAppService(IRepository<Contact> contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task<ListResultDto<ContactListDto>> GetAllContact()
        {
            var tasks = await _contactRepository
               .GetAll()
               .OrderByDescending(t => t.LastName)
               .ToListAsync();

            return new ListResultDto<ContactListDto>(
                ObjectMapper.Map<List<ContactListDto>>(tasks)
            );
        }
        public async Task<Contact> GetContact(int id)
        {
            return await _contactRepository.GetAsync(id);
        }
        public async Task<Contact> CreateContact(Contact input)
        {
            await _contactRepository.InsertAsync(input);
            return input;
        }
        public async Task<Contact> UpdateContact(Contact input)
        {
            await _contactRepository.UpdateAsync(input);
            return input;
        }

        public async Task DeleteContact(int id)
        {
            await _contactRepository.DeleteAsync(id);
        }
    }
}

