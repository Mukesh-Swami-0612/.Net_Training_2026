using System;

namespace ICUMonitoring
{
    class Display
    {
        /// <summary>
        /// Displays all patient vital records in a tabular format,
        /// including heart rate, oxygen level, blood pressure,
        /// and the recorded time.
        /// </summary>
        public static void Show(PatientVital[] p)
        {
            // Display the table header.
            Console.WriteLine("Heart\tSpO2\tSysBP\tDiaBP\tTime");

            // Loop through each patient vital record in the array.
            foreach (PatientVital v in p)
            {
                // Display the patient's heart rate, oxygen level,
                // systolic BP, diastolic BP, and recorded time.
                Console.WriteLine(v.HeartRate + "\t" +
                                  v.OxygenLevel + "\t" +
                                  v.SystolicBP + "\t" +
                                  v.DiastolicBP + "\t" +
                                  v.Time);
            }
        }
    }
}