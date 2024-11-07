using VM_Server.Model;

namespace VM_Server.Interfaces
{
    public interface ISkillRepository
    {
        Task<IEnumerable<Skills>> GetAllSkillsAsync(bool TrackChanges);
    }
}
