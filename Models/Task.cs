namespace TaskManagement.Models
{
    public class Tasks
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; } // e.g., Pending, In Progress, Completed
        public int AssignedUserId { get; set; }
        public User AssignedUser { get; set; }
        public ICollection<TaskNote> TaskNotes { get; set; }
        public ICollection<Documents> Documents { get; set; }
    }
}
