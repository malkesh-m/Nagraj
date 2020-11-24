using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;

namespace Nagraj.Contacts
{
    [Table("Contacts")]
    public class Contact : Entity, IHasCreationTime
    {
        public const int MaxTitleLength = 25;
        [Required]
        [StringLength(MaxTitleLength)]
        public string FirstName { get; set; }
        [StringLength(MaxTitleLength)]
        public string LastName { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }

        public DateTime CreationTime { get; set; }


        public Contact()
        {
            CreationTime = Clock.Now;
        }

        public Contact(string firstName, string lastName = null, string city = null, string phoneNumber = null)
            : this()
        {
            FirstName = firstName;
            LastName = lastName;
            City = city;
            PhoneNumber = phoneNumber;
        }
    }
}
