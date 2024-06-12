using CodingChallengeBusinessLayer.BusinessObjects;

namespace CodingChallengeApi.Commands
{
    public interface ICreateAppointment
    {
        Tuple<bool, string> Execute(Appointment appointment);
    }
}
