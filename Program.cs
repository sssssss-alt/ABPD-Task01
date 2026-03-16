using System;

class Program
{
    static double CalculateAverage(int[] values)
    {
        if (values == null || values.Length == 0)
            return 0;

        int sum = 0;
        for (int i = 0; i < values.Length; i++)
        {
            sum += values[i];
        }

        double average = (double)sum / values.Length;
        return average;
    }

    static int CalculateMax(int[] values)
    {
        if (values == null || values.Length == 0)
            return 0;

        int max = values[0];

        for (int i = 1; i < values.Length; i++)
        {
            if (values[i] > max)
            {
                max = values[i];
            }
        }

        return max;
    }

    static int CalculateMin(int[] values)
    {
        if (values == null || values.Length == 0)
            return 0;

        int min = values[0];

        for (int i = 1; i < values.Length; i++)
        {
            if (values[i] < min)
            {
                min = values[i];
            }
        }

        return min;
    }


    static void Main()
    {
        int[] numbers = { 5, 10, 15, 20 };

        double avg = CalculateAverage(numbers);
        int max = CalculateMax(numbers);

        Console.WriteLine("Average: " + avg);
        Console.WriteLine("Max: " + max);
    }
}