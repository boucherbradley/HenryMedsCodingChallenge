using CodingChallengeBusinessLayer.BusinessObjects;

namespace CodingChallengeApi.Commands
{
    public interface IUpdateAppointmentToReservePatient
    {
        Tuple<bool, string> Execute(Appointment appointment);
    }
}
