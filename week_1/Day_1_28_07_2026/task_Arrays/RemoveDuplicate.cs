using System;

public class RemoveDuplicate
{
    public static void Remove(int[] array)
    {
        Console.WriteLine("Array After Removing Duplicates:");

        for (int i = 0; i < array.Length; i++)
        {
            bool isDuplicate = false;

            for (int j = 0; j < i; j++)
            {
                if (array[i] == array[j])
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (!isDuplicate)
            {
                Console.Write(array[i] + " ");
            }
        }

        Console.WriteLine();
    }
}