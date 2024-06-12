using CodingChallengeBusinessLayer.BusinessObjects;
using CodingChallengeBusinessLayer.Repository;

namespace CodingChallengeApi.Commands
{
    public class GetClient : IGetClient
    {
        public Client Execute(int Id)
        {
            IClientRepository repository = new ClientRepository();
            return repository.GetById(Id);
        }
    }
}
