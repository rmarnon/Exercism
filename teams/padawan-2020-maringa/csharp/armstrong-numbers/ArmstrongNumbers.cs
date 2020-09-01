using System;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        string numbers = number.ToString();
        double count = 0;

        foreach (char item in numbers)
        {
            count += Math.Pow(double.Parse(item.ToString()), numbers.Length);
        }
        return count == number;
    }
}