namespace ICUMonitoring
{
    class PatientVital
    {
        // Stores the patient's heart rate (beats per minute).
        public int HeartRate;

        // Stores the patient's oxygen saturation level (SpO2).
        public int OxygenLevel;

        // Stores the patient's systolic blood pressure.
        public int SystolicBP;

        // Stores the patient's diastolic blood pressure.
        public int DiastolicBP;

        // Stores the time when the vital signs were recorded.
        public string Time;

        /// <summary>
        /// Initializes a new PatientVital object by assigning
        /// the patient's heart rate, oxygen level,
        /// blood pressure, and recording time.
        /// </summary>
        public PatientVital(int hr, int oxygen, int sbp, int dbp, string time)
        {
            // Assign the heart rate.
            HeartRate = hr;

            // Assign the oxygen level.
            OxygenLevel = oxygen;

            // Assign the systolic blood pressure.
            SystolicBP = sbp;

            // Assign the diastolic blood pressure.
            DiastolicBP = dbp;

            // Assign the recorded time.
            Time = time;
        }
    }
}