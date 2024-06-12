using CodingChallengeBusinessLayer.BusinessObjects;
using CodingChallengeBusinessLayer.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallengeBusinessLayer.Repository
{
    public class FacilityRepository : IFacilityRepository
    {
        IDbConnection _connection;

        readonly string connectionString = "Data Source=localhost; Initial Catalog=HenryMedsCodingChallenge; Integrated Security=SSPI;persist security info=True;";

        public FacilityRepository()
        {
            _connection = new SqlConnection(connectionString);
        }

        public bool Add(Facility facility)
        {
            bool isAdded = false;

            IRepository<Facility> repository = new Repository<Facility>();
            isAdded = repository.Add(facility);

            return isAdded;
        }

        public Facility GetById(int Id)
        {
            IRepository<Facility> repository = new Repository<Facility>();
            return repository.GetById(Id);
        }

        public bool Update(Facility facility)
        {
            bool isUpdated = false;

            IRepository<Facility> repository = new Repository<Facility>();
            isUpdated = repository.Update(facility);

            return isUpdated;
        }


    }
}
