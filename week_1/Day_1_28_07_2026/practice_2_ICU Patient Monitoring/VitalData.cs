namespace ICUMonitoring
{
    class VitalData
    {
        public static PatientVital[] GetVitals()
        {
            PatientVital[] p = new PatientVital[10];

            p[0] = new PatientVital(72, 98, 120, 80, "09:00");
            p[1] = new PatientVital(75, 99, 118, 79, "09:01");
            p[2] = new PatientVital(82, 97, 122, 81, "09:02");
            p[3] = new PatientVital(95, 96, 130, 85, "09:03");
            p[4] = new PatientVital(110, 94, 140, 90, "09:04");
            p[5] = new PatientVital(88, 98, 125, 82, "09:05");
            p[6] = new PatientVital(70, 99, 118, 78, "09:06");
            p[7] = new PatientVital(65, 97, 115, 75, "09:07");
            p[8] = new PatientVital(100, 95, 135, 88, "09:08");
            p[9] = new PatientVital(78, 98, 120, 80, "09:09");

            return p;
        }
    }
}