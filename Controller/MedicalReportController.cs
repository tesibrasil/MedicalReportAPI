using Microsoft.AspNetCore.Mvc;

namespace ImportMedicalReportAPI.Controller
{
    [Route("report")]
    [ApiController]
    public class MedicalReportController : ControllerBase
    {
        [HttpGet("GetMedicalReport")]
        public ActionResult<string> Get(int id) 
        {
            string x = "Funcionou";
            return Ok(x);
        }
    }
}
