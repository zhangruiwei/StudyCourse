using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Warren.StudyCource.CustomerService.API.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Warren.StudyCource.CustomerService.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeacherController : ControllerBase
    {
        private readonly ILogger<TeacherController> _logger;

        private readonly TeacherContext _teacherContext;

        public TeacherController(ILogger<TeacherController> logger, TeacherContext teacherContext)
        {
            _logger = logger;
            _teacherContext = teacherContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return new JsonResult(await _teacherContext.Teachers.FirstOrDefaultAsync());
        }
    }
}
