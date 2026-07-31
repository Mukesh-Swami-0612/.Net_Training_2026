using System;

namespace ICUMonitoring
{
    class Program
    {
        static void Main(string[] args)
        {
            PatientVital[] p = VitalData.GetVitals();

            Display.Show(p);

            AbnormalPatient.FindAbnormal(p);
            AbnormalPatient.AverageHeartRate(p);
            AbnormalPatient.HighestHeartRate(p);
            AbnormalPatient.LowestOxygen(p);
            AbnormalPatient.CountAbnormal(p);
        }
    }
}