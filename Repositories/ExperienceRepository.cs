using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using VM_Server.Interfaces;
using VM_Server.Model;

namespace VM_Server.Repositories
{
    public class ExperienceRepository : RepositoryBase<Experiences>, IExperienceRepository
    {
        public ExperienceRepository(RepositoryContext repContext) : base(repContext) { }

        public async Task<IEnumerable<Experiences>> GetExperiencesAsync(bool TrackChanges) => await GetAll(TrackChanges).ToListAsync();

    }
}
