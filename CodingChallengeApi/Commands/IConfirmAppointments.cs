using CodingChallengeBusinessLayer.BusinessObjects;

namespace CodingChallengeApi.Commands
{
    public interface IConfirmAppointments
    {
        Tuple<bool, string> Execute(string patientId, string pracititionerId);
    }
}
