using CodingChallengeBusinessLayer.BusinessObjects;
using CodingChallengeBusinessLayer.Repository;


namespace CodingChallengeApi.Commands
{
    public class CreateAppointment : ICreateAppointment
    {
        public Tuple<bool, string> Execute(Appointment appointment)
        {
            string message = string.Empty;
            bool status = false;

            //Appointments are only 15 minutes, ensure the minutes are 00, 15, 30, or 45
            bool validTime = appointment.AppointmentDate.ToString("mm") == "00"
                            || appointment.AppointmentDate.ToString("mm") == "15"
                            || appointment.AppointmentDate.ToString("mm") == "30"
                            || appointment.AppointmentDate.ToString("mm") == "45";

            if (!validTime)
            {
                return Tuple.Create(false, "Invalid appointment time. Appointments can only be made quarterly of an hour.");
            }

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

            //ensure appointment doesn't already exist
            IAppointmentRepository repository = new AppointmentRepository();
            List<Appointment> existingAppointments = repository.GetAvailableByPractitionerIdAndDate(appointment.PractitionerId, appointment.AppointmentDate) ?? new List<Appointment>();

            bool appointmentAlreadyExists = false;
            foreach (Appointment existingAppointment in existingAppointments)
            {
                appointmentAlreadyExists = existingAppointment.AppointmentDate.ToString("HH:mm") == appointment.AppointmentDate.ToString("HH:mm");
                if (appointmentAlreadyExists)
                {
                    return Tuple.Create(false, "Appointment Already Exists.");
                }
            }

            //Set the object for insert
            appointment.Updated_DT = null;
            appointment.UpdatedBy = null;
            appointment.PatientId = null;
            appointment.Available = true;
            appointment.Confirmed = false;

            status = repository.Add(appointment);

            if (status == true)
            {
                message = "Success";
            }
            

            return new Tuple<bool, string>(status, message);
        }
    }
}
