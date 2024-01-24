using System.Collections.Generic;
using System.Linq;
using System;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        int n = arr.Count();
        double countPositive = 0, countNegative = 0, countZero = 0;

        foreach (var num in arr)
        {
            if (num > 0)
                countPositive++;
            else if (num < 0)
                countNegative++;
            else
                countZero++;
        }

        // Calculate fractions
        double fractionPositive = countPositive / n;
        double fractionNegative = countNegative / n;
        double fractionZero = countZero / n;

        // Print fractions with six decimal places
        Console.WriteLine($"{fractionPositive:F6}");
        Console.WriteLine($"{fractionNegative:F6}");
        Console.WriteLine($"{fractionZero:F6}");

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
