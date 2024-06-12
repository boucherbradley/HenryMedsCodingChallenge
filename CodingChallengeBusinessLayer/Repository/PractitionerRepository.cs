using CodingChallengeBusinessLayer.BusinessObjects;
using CodingChallengeBusinessLayer.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallengeBusinessLayer.Repository
{
    public class PractitionerRepository : IPractitionerRepository
    {
        IDbConnection _connection;

        readonly string connectionString = "Data Source=localhost; Initial Catalog=HenryMedsCodingChallenge; Integrated Security=SSPI;persist security info=True;";

        public PractitionerRepository()
        {
            _connection = new SqlConnection(connectionString);
        }

        public bool Add(Practitioner practitioner)
        {
            bool isAdded = false;

            IRepository<Practitioner> repository = new Repository<Practitioner>();
            isAdded = repository.Add(practitioner);

            return isAdded;
        }

        public Practitioner GetById(int Id)
        {
            IRepository<Practitioner> repository = new Repository<Practitioner>();
            return repository.GetById(Id);
        }

        public bool Update(Practitioner practitioner)
        {
            bool isUpdated = false;

            IRepository<Practitioner> repository = new Repository<Practitioner>();
            isUpdated = repository.Update(practitioner);

            return isUpdated;
        }
    }
}
