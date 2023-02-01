using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreMaster.Application.Interfaces;
using NetCoreMaster.Application.Services;

namespace NetCoreMaster.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        public readonly ServiceSudent _serviceSudent;

        public SchoolController(ServiceSudent serviceSudent)
        {
            this._serviceSudent = serviceSudent;
        }
        [HttpGet("logicwithoutdependencyinjection")]
        public async Task<ActionResult<dynamic>> GetSchool() => await this._serviceSudent.GetStudent();
    }
}
