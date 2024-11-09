namespace VM_Server.Model
{
    public class Experiences
    {
        public Guid Id { get; set; }
        public string? Company {  get; set; }
        public DateOnly? StartDate { get; set; }
        public DateOnly? EndDate { get; set; }
        public string? RoleName { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}
