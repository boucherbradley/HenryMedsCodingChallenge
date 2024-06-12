using CodingChallengeBusinessLayer.BusinessObjects;
using CodingChallengeBusinessLayer.Configuration;
using static Dapper.SqlMapper;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using static System.Net.Mime.MediaTypeNames;

namespace CodingChallengeBusinessLayer.Repository
{
    public class AppointmentRepository : IAppointmentRepository
    {
        IDbConnection _connection;

        readonly string connectionString = "Data Source=localhost; Initial Catalog=HenryMedsCodingChallenge; Integrated Security=SSPI;persist security info=True;";

        public AppointmentRepository()
        {
            _connection = new SqlConnection(connectionString);
        }

        public bool Add(Appointment appointment)
        {
            bool isAdded = false;

            IRepository<Appointment> repository = new Repository<Appointment>();
            isAdded = repository.Add(appointment);

            return isAdded;
        }

        public Appointment GetById(int Id)
        {
            IRepository<Appointment> repository = new Repository<Appointment>();
            return repository.GetById(Id);
        }

        public bool Update(Appointment appointment)
        {
            bool isUpdated= false;

            IRepository<Appointment> repository = new Repository<Appointment>();
            isUpdated = repository.Update(appointment);

            return isUpdated;
        }

        public List<Appointment> GetAvailableByPractitionerIdAndDate(int PractitionerId, DateTime AppointmentDate)
        {
            var appointment = new Appointment { PractitionerId = PractitionerId, AppointmentDate = AppointmentDate };
            string query = @"Select AppointmentId
                                    ,AppointmentDate
                                    ,PractitionerId
                                    ,FacilityId
                                    ,PatientId
                                    ,Available
                                    ,Confirmed
                                    ,Updated_DT
                                    ,UpdatedBy
                            FROM dbo.Appointment
                            WHERE PractitionerId = @PractitionerId
                            AND DATEDIFF(DAY, AppointmentDate, @AppointmentDate) = 0";

            return _connection.Query<Appointment>(query, appointment).ToList();
        }

        public List<Appointment> GetAllAvailable()
        {
            string query = @"Select AppointmentId
                                    ,AppointmentDate
                                    ,PractitionerId
                                    ,FacilityId
                                    ,PatientId
                                    ,Available
                                    ,Confirmed
                                    ,Updated_DT
                                    ,UpdatedBy
                            FROM dbo.Appointment
                            WHERE Available = 1 AND AppointmentDate >= DATEADD(DD,1,GETDATE())";

            return _connection.Query<Appointment>(query).ToList();
        }

        public List<Appointment> AllConfirmAppointmentByPatientAndPractitioner(int patientId, int practitionerId)
        {
            var appointment = new Appointment { PatientId = patientId, PractitionerId = practitionerId };
            string query = @"Select AppointmentId
                                    ,AppointmentDate
                                    ,PractitionerId
                                    ,FacilityId
                                    ,PatientId
                                    ,Available
                                    ,Confirmed
                                    ,Updated_DT
                                    ,UpdatedBy
                            FROM dbo.Appointment
                            WHERE PatientId = @patientId 
                            AND PractitionerId = @practitionerId
                            AND AppointmentDate >= GETDATE()";


            return _connection.Query<Appointment>(query, appointment).ToList();
        }
    }
}
