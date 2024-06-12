using CodingChallengeBusinessLayer.BusinessObjects;
using CodingChallengeBusinessLayer.Repository;

namespace CodingChallengeApi.Commands
{
    public class GetPractitioner : IGetPractitioner
    {
        public Practitioner Execute(int Id)
        {
            IPractitionerRepository repository = new PractitionerRepository();
            return repository.GetById(Id);
        }
    }
}
