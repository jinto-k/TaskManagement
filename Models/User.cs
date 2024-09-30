namespace TaskManagement.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; } // Employee, Manager, Admin
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public ICollection<Tasks> Tasks { get; set; }
    }
}
