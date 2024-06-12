using CodingChallengeBusinessLayer.BusinessObjects;
using CodingChallengeBusinessLayer.Repository;
using Microsoft.AspNetCore.Http;
using System;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodingChallengeApi.Commands
{
    public class ConfirmAppointments : IConfirmAppointments
    {
        public Tuple<bool, string> Execute(string patientId, string pracititionerId)
        {
            string message = string.Empty;
            bool status = false;

            int _patientId = 0;
            int.TryParse(patientId, out _patientId);

            int _pracititionerId = 0;
            int.TryParse(pracititionerId, out _pracititionerId);


            IAppointmentRepository repository = new AppointmentRepository();
            List<Appointment> appointments = repository.AllConfirmAppointmentByPatientAndPractitioner(_patientId, _pracititionerId);

            if (appointments != null)
            {
                status = true;
            }

            string dates = string.Empty;

            foreach (Appointment app in appointments)
            {
                dates += $"{app.AppointmentDate}, ";
            }
            dates = dates.TrimEnd(' ', ',');

            if (status == true)
            {
                message = $"Appointment has been confirmed for {dates}.";
            }

            return new Tuple<bool, string>(status, message);
        }
    }
}
