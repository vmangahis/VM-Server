namespace VM_Server.Model
{
    public class Projects
    {
        public Guid Id { get; set; }
        public string? ProjectName { get; set; }
        public string? ImageLink { get; set; }
        public string? ProjectLink { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}
