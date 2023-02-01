using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreMaster.Application.Interfaces;
using NetCoreMaster.Application.Services;

namespace NetCoreMaster.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolWithLogicinjectionController : ControllerBase
    {

        // using interface ISchool not service teacher
        public readonly ISchoolService _serviceTeacher;

        public SchoolWithLogicinjectionController(ISchoolService serviceTeacher)
        {
            this._serviceTeacher = serviceTeacher;
        }
        [HttpGet("logicwithdependencyinjection")]
        public async Task<ActionResult<dynamic>> GetSchool() => await this._serviceTeacher.GetTeacher();
    }
}
