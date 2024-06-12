using CodingChallengeBusinessLayer.BusinessObjects;

namespace CodingChallengeApi.Commands
{
    public interface IGetClient
    {
        Client Execute(int Id);
    }
}
