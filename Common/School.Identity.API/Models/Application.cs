using System;
using System.Collections.Generic;

namespace School.Identity.API.Models
{
    public class Application
    {
        public int Id { get; set; }
        public string ApplicationName { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public List<UserRole> UserRoles { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }

}