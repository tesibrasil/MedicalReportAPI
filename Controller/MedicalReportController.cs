using ImportMedicalReportAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ImportMedicalReportAPI.Controller
{
    [Route("report")]
    [ApiController]
    public class MedicalReportController : ControllerBase
    {

        private readonly IMedicalReportService _medicalReportService;

        public MedicalReportController(IMedicalReportService medReportService)
        {
            _medicalReportService = medReportService;
        }

        [HttpGet("GetMedicalReport")]
        public ActionResult<string> Get(int id) 
        {
            _medicalReportService.GetPatientMedicalReportsList(id);

            string x = "Funcionou";
            return Ok(x);
        }
    }
}
