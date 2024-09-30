namespace TaskManagement.Models
{
    public class Documents
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public byte[] Content { get; set; }
        public int TaskId { get; set; }
        public Tasks Task { get; set; }
    }

}
