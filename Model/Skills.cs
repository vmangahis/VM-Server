namespace VM_Server.Model
{
    public class Skills
    {
        public Guid Id { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string? SkillName { get; set; }
        public string? SkillDescription { get; set; }
        public string? SkillIdentifier { get; set; }
    }
}
