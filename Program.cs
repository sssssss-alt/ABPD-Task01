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
}