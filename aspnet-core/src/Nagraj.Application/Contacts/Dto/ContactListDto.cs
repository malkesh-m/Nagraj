using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nagraj.Contacts.Dto
{
    [AutoMapFrom(typeof(Contact))]
    public class ContactListDto : EntityDto, IHasCreationTime
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreationTime { get; set; }
    }
    public class GetAllContactInput
    {
        
    }

}
