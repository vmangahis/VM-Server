using Microsoft.EntityFrameworkCore;
using VM_Server.Interfaces;
using VM_Server.Model;

namespace VM_Server.Repositories
{
    public class ProjectRepository : RepositoryBase<Projects>, IProjectRepository
    {
        public ProjectRepository(RepositoryContext context) : base(context) { }

        public async Task<IEnumerable<Projects>> GetAllProjectsAsync(bool TrackChanges) => await GetAll(TrackChanges).ToListAsync();
     
    }
}
