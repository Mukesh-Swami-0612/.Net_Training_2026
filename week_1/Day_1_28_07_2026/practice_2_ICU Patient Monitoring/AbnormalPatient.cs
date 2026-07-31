using System;

namespace ICUMonitoring
{
    class AbnormalPatient
    {
        /// <summary>
        /// Identifies and displays patients with abnormal vital signs
        /// based on heart rate, oxygen level, and blood pressure.
        /// </summary>
        public static void FindAbnormal(PatientVital[] p)
        {
            // Display the heading for abnormal patient details.
            Console.WriteLine("\nAbnormal Patient Details");
            Console.WriteLine("HR\tSpO2\tSysBP\tDiaBP\tTime");

            // Loop through each patient record.
            foreach (PatientVital v in p)
            {
                // Check if any vital sign is outside the normal range.
                if (v.HeartRate < 60 || v.HeartRate > 100 ||
                    v.OxygenLevel < 95 ||
                    v.SystolicBP > 140 ||
                    v.DiastolicBP > 90)
                {
                    // Display the abnormal patient's details.
                    Console.WriteLine(v.HeartRate + "\t" +
                                      v.OxygenLevel + "\t" +
                                      v.SystolicBP + "\t" +
                                      v.DiastolicBP + "\t" +
                                      v.Time);
                }
            }
        }

        /// <summary>
        /// Calculates and displays the average heart rate
        /// of all patients.
        /// </summary>
        public static void AverageHeartRate(PatientVital[] p)
        {
            // Variable to store the total heart rate.
            int sum = 0;

            // Add the heart rate of each patient.
            foreach (PatientVital v in p)
            {
                sum += v.HeartRate;
            }

            // Display the average heart rate.
            Console.WriteLine("\nAverage Heart Rate = " + (sum / p.Length));
        }

        /// <summary>
        /// Finds and displays the highest heart rate
        /// among all patients.
        /// </summary>
        public static void HighestHeartRate(PatientVital[] p)
        {
            // Assume the first patient's heart rate is the highest.
            int max = p[0].HeartRate;

            // Compare each patient's heart rate.
            foreach (PatientVital v in p)
            {
                if (v.HeartRate > max)
                {
                    // Update the highest heart rate.
                    max = v.HeartRate;
                }
            }

            // Display the highest heart rate.
            Console.WriteLine("Highest Heart Rate = " + max);
        }

        /// <summary>
        /// Finds and displays the lowest oxygen level
        /// among all patients.
        /// </summary>
        public static void LowestOxygen(PatientVital[] p)
        {
            // Assume the first patient's oxygen level is the lowest.
            int min = p[0].OxygenLevel;

            // Compare each patient's oxygen level.
            foreach (PatientVital v in p)
            {
                if (v.OxygenLevel < min)
                {
                    // Update the lowest oxygen level.
                    min = v.OxygenLevel;
                }
            }

            // Display the lowest oxygen level.
            Console.WriteLine("Lowest Oxygen Level = " + min);
        }

        /// <summary>
        /// Counts and displays the total number of patients
        /// with abnormal vital signs.
        /// </summary>
        public static void CountAbnormal(PatientVital[] p)
        {
            // Variable to store the abnormal patient count.
            int count = 0;

            // Check each patient's vital signs.
            foreach (PatientVital v in p)
            {
                if (v.HeartRate < 60 || v.HeartRate > 100 ||
                    v.OxygenLevel < 95 ||
                    v.SystolicBP > 140 ||
                    v.DiastolicBP > 90)
                {
                    // Increment the count for each abnormal patient.
                    count++;
                }
            }

            // Display the total abnormal patient count.
            Console.WriteLine("Total Abnormal Patients = " + count);
        }
    }
}