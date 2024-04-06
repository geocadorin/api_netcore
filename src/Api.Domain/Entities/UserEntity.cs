
using System;

namespace Api.Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateBirth { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Status Status { get; set; }
        public Role TypeUser { get; set; }

    }

    public enum Status
    {
        Active = 1,
        Inactive = 2,
        Blocked = 3
    }

    public enum Role
    {
        Regular = 1,
        Admin = 2,
        Guest = 3
    }
}
