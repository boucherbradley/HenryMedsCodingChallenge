using CodingChallengeBusinessLayer.BusinessObjects;
using CodingChallengeBusinessLayer.Repository;

namespace CodingChallengeApi.Commands
{
    public class GetFacility : IGetFacility
    {
        public Facility Execute(int Id)
        {
            IFacilityRepository repository = new FacilityRepository();
            return repository.GetById(Id);
        }
    }
}
