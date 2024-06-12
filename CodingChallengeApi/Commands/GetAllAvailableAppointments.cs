using CodingChallengeBusinessLayer.BusinessObjects;
using CodingChallengeBusinessLayer.Repository;

namespace CodingChallengeApi.Commands
{
    public class GetAllAvailableAppointments : IGetAllAvailableAppointments
    {
        public List<Appointment> Execute()
        {
            IAppointmentRepository repository = new AppointmentRepository();
            List<Appointment> appointments = repository.GetAllAvailable();

            List<Appointment> removeAppointments = new List<Appointment>();

            foreach (Appointment appointment in appointments)
            {
                if (appointment.AppointmentDate < DateTime.Now.AddDays(1))
                {
                    removeAppointments.Add(appointment);
                }
            }
            appointments = appointments.Except(removeAppointments).ToList();

            return appointments;
        }
    }
}
