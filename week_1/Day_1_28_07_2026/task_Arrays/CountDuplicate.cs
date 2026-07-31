using System;

public class CountDuplicate
{
    public static void Count(int[] array)
    {
        Console.WriteLine("Duplicate Elements With Count:");

        for (int i = 0; i < array.Length; i++)
        {
            bool alreadyCounted = false;

            for (int k = 0; k < i; k++)
            {
                if (array[i] == array[k])
                {
                    alreadyCounted = true;
                    break;
                }
            }

            if (alreadyCounted)
                continue;

            int count = 1;

            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    count++;
                }
            }

            if (count > 1)
            {
                Console.WriteLine(array[i] + " -> " + count + " times");
            }
        }
    }
}