using CodingChallengeApi.Commands;
using CodingChallengeBusinessLayer.BusinessObjects;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace CodingChallengeApi.Controllers
{
    [ApiController]
    [IgnoreAntiforgeryToken]
    [Route("api/[controller]/[action]")]
    public class ConfirmAppointmentController : Controller
    {
        private readonly ILogger<ConfirmAppointmentController> _logger;

        public ConfirmAppointmentController(ILogger<ConfirmAppointmentController> logger)
        {
            _logger = logger;
        }

        //[HttpGet]
        //[ActionName("Confirm")]
        //public Response ConfirmAppointment([FromBody] AppointmentConfirmation value)
        //{
        //    IConfirmAppointment confirmAppointment = new ConfirmAppointment();
        //    Tuple<bool, string> res = confirmAppointment.Execute(value.PatientId, value.PractitionerId, value.AppointmentDate);
        //    return new Response() { Status = res.Item1.ToString(), Message = res.Item2 };
        //}
    }
}
