using VM_Server.Interfaces;

namespace VM_Server.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly Lazy<IExperienceRepository> _experienceRepository;
        private readonly Lazy<ISkillRepository> _skillRepository;
        private readonly Lazy<IProjectRepository> _projectRepository;
        public RepositoryManager(RepositoryContext cont)
        {
            _context = cont;
            _experienceRepository = new Lazy<IExperienceRepository>(() => new ExperienceRepository(cont));
            _skillRepository = new Lazy<ISkillRepository>(() => new SkillRepository(cont));
            _projectRepository = new Lazy<IProjectRepository>(() => new ProjectRepository(cont));
        }
        public IProjectRepository Projects => _projectRepository.Value;
        public IExperienceRepository Experiences => _experienceRepository.Value;

        public ISkillRepository Skills => _skillRepository.Value;

        public async Task SaveAsync() => await _context.SaveChangesAsync();
    }
}
