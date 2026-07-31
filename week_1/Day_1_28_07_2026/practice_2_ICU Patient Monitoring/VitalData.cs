namespace ICUMonitoring
{
    class VitalData
    {
        /// <summary>
        /// Creates and returns an array of sample patient vital records
        /// used by the ICU Monitoring System.
        /// </summary>
        public static PatientVital[] GetVitals()
        {
            // Create an array to store 10 PatientVital objects.
            PatientVital[] p = new PatientVital[10];

            // Create the first patient vital record and store it at index 0.
            p[0] = new PatientVital(72, 98, 120, 80, "09:00");

            // Create the second patient vital record and store it at index 1.
            p[1] = new PatientVital(75, 99, 118, 79, "09:01");

            // Create the third patient vital record and store it at index 2.
            p[2] = new PatientVital(82, 97, 122, 81, "09:02");

            // Create the fourth patient vital record and store it at index 3.
            p[3] = new PatientVital(95, 96, 130, 85, "09:03");

            // Create the fifth patient vital record and store it at index 4.
            p[4] = new PatientVital(110, 94, 140, 90, "09:04");

            // Create the sixth patient vital record and store it at index 5.
            p[5] = new PatientVital(88, 98, 125, 82, "09:05");

            // Create the seventh patient vital record and store it at index 6.
            p[6] = new PatientVital(70, 99, 118, 78, "09:06");

            // Create the eighth patient vital record and store it at index 7.
            p[7] = new PatientVital(65, 97, 115, 75, "09:07");

            // Create the ninth patient vital record and store it at index 8.
            p[8] = new PatientVital(100, 95, 135, 88, "09:08");

            // Create the tenth patient vital record and store it at index 9.
            p[9] = new PatientVital(78, 98, 120, 80, "09:09");

            // Return the array containing all patient vital records.
            return p;
        }
    }
}