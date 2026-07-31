using System;

public class PrintDuplicate
{
    public static void Print(int[] array)
    {
        Console.WriteLine("Duplicate Elements:");

        for (int i = 0; i < array.Length; i++)
        {
            bool alreadyPrinted = false;

            for (int k = 0; k < i; k++)
            {
                if (array[i] == array[k])
                {
                    alreadyPrinted = true;
                    break;
                }
            }

            if (alreadyPrinted)
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
                Console.Write(array[i] + " ");
            }
        }

        Console.WriteLine();
    }
}