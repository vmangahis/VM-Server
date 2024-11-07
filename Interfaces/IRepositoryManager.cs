namespace VM_Server.Interfaces
{
    public interface IRepositoryManager
    {
        IProjectRepository Projects { get; }
        IExperienceRepository Experiences { get; }
        ISkillRepository Skills { get; }
        Task SaveAsync();
    }
}
