namespace TaskTrackingSystem.Models
{
    public class TaskCard
    {
        public int Id { get; set; }

        public required string Title { get; set; }

        public string? Description { get; set; }

        public required string Status { get; set; } // ToDo, InProgress, Done

        public DateTime Deadline { get; set; }

        public int UserId { get; set; }

        public required User User { get; set; }
    }
}
