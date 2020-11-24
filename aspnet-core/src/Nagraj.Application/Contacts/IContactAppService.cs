using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Nagraj.Contacts.Dto;

namespace Nagraj.Contacts
{
    public interface IContactAppService : IApplicationService
    {
        Task<Contact> GetContact(int id);
        Task<ListResultDto<ContactListDto>> GetAllContact();
        Task<Contact> CreateContact(Contact input);
        Task<Contact> UpdateContact(Contact input);
        Task DeleteContact(int id);
    }
}
