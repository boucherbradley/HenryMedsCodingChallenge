using CodingChallengeBusinessLayer.BusinessObjects;

namespace CodingChallengeApi.Commands
{
    public interface IGetAllAvailableAppointments
    {
        List<Appointment> Execute();
    }
}
