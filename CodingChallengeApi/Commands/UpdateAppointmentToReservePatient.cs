using CodingChallengeBusinessLayer.BusinessObjects;
using CodingChallengeBusinessLayer.Repository;


namespace CodingChallengeApi.Commands
{
    public class UpdateAppointmentToReservePatient : IUpdateAppointmentToReservePatient
    {
        public Tuple<bool, string> Execute(Appointment appointment)
        {
            string message = string.Empty;
            bool status = false;

            //ensure the Prac exists
            IGetPractitioner getPrac = new GetPractitioner();
            Practitioner prac = getPrac.Execute(appointment.PractitionerId);

            if (prac == null || prac.PractitionerId == 0)
            {
                return Tuple.Create(false, "Practitioner Not Found.");
            }

            //ensure the Facility exists
            IGetFacility getFac = new GetFacility();
            Facility fac = getFac.Execute(appointment.FacilityId);

            if (fac == null || fac.FacilityId == 0)
            {
                return Tuple.Create(false, "Facility Not Found.");
            }

            //ensure the client exists
            if (appointment.PatientId == null || appointment.PatientId == 0)
            {
                return Tuple.Create(false, "Invalid Patient");
            }
            IGetClient getClient = new GetClient();
            Client client = getClient.Execute(appointment.PatientId.GetValueOrDefault());

            if (client == null || client.ClientId == 0)
            {
                return Tuple.Create(false, "Client Not Found.");
            }

            //ensure appointment exist
            IAppointmentRepository repository = new AppointmentRepository();
            List<Appointment> existingAppointments = repository.GetAvailableByPractitionerIdAndDate(appointment.PractitionerId, appointment.AppointmentDate) ?? new List<Appointment>();

            bool appointmentAlreadyExists = false;
            foreach (Appointment existingAppointment in existingAppointments)
            {
                appointmentAlreadyExists = existingAppointment.AppointmentDate.ToString("HH:mm") == appointment.AppointmentDate.ToString("HH:mm");
                if (!appointmentAlreadyExists)
                {
                    return Tuple.Create(false, "Appointment Does Not Exists.");
                }
            }

            appointment.Available = false;
            appointment.Confirmed = true;
            appointment.UpdatedBy = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            appointment.Updated_DT = DateTime.Now;

            status = repository.Update(appointment);

            if (status == true)
            {
                message = "Appointment has been updated. Please Confirm";
            }
            

            return new Tuple<bool, string>(status, message);
        }
    }
}
