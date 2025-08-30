using activity_medic_appointment_api.Business;
using Microsoft.AspNetCore.Mvc;

namespace activity_medic_appointment_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DiagnosticosController : ControllerBase
    {
        private readonly IDiagnostico diagnostico;

        public DiagnosticosController(IDiagnostico diagnostico)
        {
            this.diagnostico = diagnostico;
        }
    }
}
