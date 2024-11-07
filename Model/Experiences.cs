namespace VM_Server.Model
{
    public class Experiences
    {
        public Guid Id { get; set; }
        public string? Company {  get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
        public string? RoleName { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}
