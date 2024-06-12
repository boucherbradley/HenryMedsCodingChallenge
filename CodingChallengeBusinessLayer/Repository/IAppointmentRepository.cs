using CodingChallengeBusinessLayer.BusinessObjects;
using CodingChallengeBusinessLayer.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallengeBusinessLayer.Repository
{
    public interface IAppointmentRepository : IRepository<Appointment>
    {
        List<Appointment> GetAvailableByPractitionerIdAndDate(int PractitionerId, DateTime AppointmentDate);
        List<Appointment> GetAllAvailable();
        List<Appointment> AllConfirmAppointmentByPatientAndPractitioner(int patientId, int practitionerId);
    }
}
