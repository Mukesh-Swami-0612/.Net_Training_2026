namespace ICUMonitoring
{
    class PatientVital
    {
        public int HeartRate;
        public int OxygenLevel;
        public int SystolicBP;
        public int DiastolicBP;
        public string Time;

        public PatientVital(int hr, int oxygen, int sbp, int dbp, string time)
        {
            HeartRate = hr;
            OxygenLevel = oxygen;
            SystolicBP = sbp;
            DiastolicBP = dbp;
            Time = time;
        }
    }
}