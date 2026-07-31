using System;

namespace ICUMonitoring
{
    class Program
    {
        /// <summary>
        /// Entry point of the ICU Monitoring application.
        /// Retrieves patient vital records, displays them,
        /// and performs various analyses to identify abnormal conditions.
        /// </summary>
        static void Main(string[] args)
        {
            // Retrieve all patient vital records.
            PatientVital[] p = VitalData.GetVitals();

            // Display all patient vital records.
            Display.Show(p);

            // Find and display abnormal patient records.
            AbnormalPatient.FindAbnormal(p);

            // Calculate and display the average heart rate.
            AbnormalPatient.AverageHeartRate(p);

            // Find and display the highest heart rate.
            AbnormalPatient.HighestHeartRate(p);

            // Find and display the lowest oxygen level.
            AbnormalPatient.LowestOxygen(p);

            // Count and display the number of abnormal patients.
            AbnormalPatient.CountAbnormal(p);
        }
    }
}