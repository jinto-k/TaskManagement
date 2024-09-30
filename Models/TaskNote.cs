namespace TaskManagement.Models
{
    public class TaskNote
    {
        public int Id { get; set; }
        public string Note { get; set; }
        public DateTime CreatedAt { get; set; }
        public int TaskId { get; set; }
        public Tasks Task { get; set; }
    }

}
