using CodingChallengeBusinessLayer.BusinessObjects;

namespace CodingChallengeApi.Commands
{
    public interface IGetFacility
    {
        Facility Execute(int Id);
    }
}
