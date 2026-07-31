using System;

namespace ICUMonitoring
{
    class Display
    {
        public static void Show(PatientVital[] p)
        {
            Console.WriteLine("Heart\tSpO2\tSysBP\tDiaBP\tTime");

            foreach (PatientVital v in p)
            {
                Console.WriteLine(v.HeartRate + "\t" +
                                  v.OxygenLevel + "\t" +
                                  v.SystolicBP + "\t" +
                                  v.DiastolicBP + "\t" +
                                  v.Time);
            }
        }
    }
}