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
    public class ClientRepository : IClientRepository
    {
        IDbConnection _connection;

        readonly string connectionString = "Data Source=localhost; Initial Catalog=HenryMedsCodingChallenge; Integrated Security=SSPI;persist security info=True;";

        public ClientRepository()
        {
            _connection = new SqlConnection(connectionString);
        }

        public bool Add(Client client)
        {
            bool isAdded = false;

            IRepository<Client> repository = new Repository<Client>();
            isAdded = repository.Add(client);

            return isAdded;
        }

        public Client GetById(int Id)
        {
            IRepository<Client> repository = new Repository<Client>();
            return repository.GetById(Id);
        }

        public bool Update(Client client)
        {
            bool isUpdated = false;

            IRepository<Client> repository = new Repository<Client>();
            isUpdated = repository.Update(client);

            return isUpdated;
        }
    }
}
