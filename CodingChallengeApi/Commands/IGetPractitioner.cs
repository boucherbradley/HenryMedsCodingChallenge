using CodingChallengeBusinessLayer.BusinessObjects;

namespace CodingChallengeApi.Commands
{
    public interface IGetPractitioner
    {
        Practitioner Execute(int Id);
    }
}
