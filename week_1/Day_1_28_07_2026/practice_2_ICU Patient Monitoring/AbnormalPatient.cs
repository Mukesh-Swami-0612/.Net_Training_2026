using System;

namespace ICUMonitoring
{
    class AbnormalPatient
    {
        //Abnormal Reading
        public static void FindAbnormal(PatientVital[] p)
        {
            Console.WriteLine("\nAbnormal Patient Details");
            Console.WriteLine("HR\tSpO2\tSysBP\tDiaBP\tTime");

            foreach (PatientVital v in p)
            {
                if (v.HeartRate < 60 || v.HeartRate > 100 ||
                    v.OxygenLevel < 95 ||
                    v.SystolicBP > 140 ||
                    v.DiastolicBP > 90)
                {
                    Console.WriteLine(v.HeartRate + "\t" +
                                      v.OxygenLevel + "\t" +
                                      v.SystolicBP + "\t" +
                                      v.DiastolicBP + "\t" +
                                      v.Time);
                }
            }
        }

        //Heart Rate
        public static void AverageHeartRate(PatientVital[] p)
        {
            int sum = 0;

            foreach (PatientVital v in p)
            {
                sum += v.HeartRate;
            }

            Console.WriteLine("\nAverage Heart Rate = " + (sum / p.Length));
        }

        // Highest Heart Rate
        public static void HighestHeartRate(PatientVital[] p)
        {
            int max = p[0].HeartRate;

            foreach (PatientVital v in p)
            {
                if (v.HeartRate > max)
                {
                    max = v.HeartRate;
                }
            }

            Console.WriteLine("Highest Heart Rate = " + max);
        }

        // Lowest Oxygen Level
        public static void LowestOxygen(PatientVital[] p)
        {
            int min = p[0].OxygenLevel;

            foreach (PatientVital v in p)
            {
                if (v.OxygenLevel < min)
                {
                    min = v.OxygenLevel;
                }
            }

            Console.WriteLine("Lowest Oxygen Level = " + min);
        }

        // Count Abnormal Patients
        public static void CountAbnormal(PatientVital[] p)
        {
            int count = 0;

            foreach (PatientVital v in p)
            {
                if (v.HeartRate < 60 || v.HeartRate > 100 ||
                    v.OxygenLevel < 95 ||
                    v.SystolicBP > 140 ||
                    v.DiastolicBP > 90)
                {
                    count++;
                }
            }

            Console.WriteLine("Total Abnormal Patients = " + count);
        }
    }
}