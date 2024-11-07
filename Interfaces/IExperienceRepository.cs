using VM_Server.Model;

namespace VM_Server.Interfaces
{
    public interface IExperienceRepository
    {
        Task<IEnumerable<Experiences>> GetExperiencesAsync(bool TrackChanges);
    }
}
