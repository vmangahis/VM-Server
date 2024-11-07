using Microsoft.AspNetCore.Mvc;
using VM_Server.Interfaces;
using VM_Server.Repositories;

namespace VM_Server.Controllers
{
    [Route("api/vm")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly IRepositoryManager _repoManager;
        public MainController(IRepositoryManager repoManager) { 
            _repoManager = repoManager;
        }
        [HttpGet("experiences")]
        public async Task<ActionResult> GetExp()
        {
            var exp = await _repoManager.Experiences.GetExperiencesAsync(TrackChanges: false);
            return Ok(exp);
        }
        [HttpGet("skills")]
        public async Task<ActionResult> GetSkills()
        {
            var sk = await _repoManager.Skills.GetAllSkillsAsync(TrackChanges: false);
            return Ok(sk);
        }
        [HttpGet("projects")]
        public async Task<ActionResult> GetProjects()
        {
            var prj = await _repoManager.Projects.GetAllProjectsAsync(TrackChanges: false);
            return Ok(prj);
        }
    }
}
