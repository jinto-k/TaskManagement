namespace TaskManagementSystem.Dtos
{
    public class UserRegistrationDto
    {
        public string UserName { get; set; }
        public int TeamId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
