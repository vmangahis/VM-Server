using Microsoft.EntityFrameworkCore;
using VM_Server.Interfaces;
using VM_Server.Model;

namespace VM_Server.Repositories
{
    public class SkillRepository : RepositoryBase<Skills>, ISkillRepository
    {
        public SkillRepository(RepositoryContext context) : base(context) { }

        public async Task<IEnumerable<Skills>> GetAllSkillsAsync(bool TrackChanges) => await GetAll(TrackChanges).ToListAsync();
    }
}
