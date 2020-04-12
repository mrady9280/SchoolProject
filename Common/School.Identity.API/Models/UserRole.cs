using System;

namespace School.Identity.API.Models
{
    public class UserRole
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public int StatusId { get; set; }
        public User User { get; set; }
        public Role Role { get; set; }
        public int ApplicationId { get; set; }
        public Application Application { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}