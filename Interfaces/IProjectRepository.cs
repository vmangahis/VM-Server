using VM_Server.Model;

namespace VM_Server.Interfaces
{
    public interface IProjectRepository
    {
        Task<IEnumerable<Projects>> GetAllProjectsAsync(bool TrackChanges);
    }
}
