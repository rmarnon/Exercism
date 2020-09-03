using System;
using System.Linq;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        string digits = new string(phoneNumber.Where(char.IsDigit).ToArray());

        digits = digits.TrimStart('1');

        bool match = Regex.IsMatch(digits, @"^[2-9]\d{2}[2-9]\d{6}$");

        return match ? digits : throw new ArgumentException();

    }
}