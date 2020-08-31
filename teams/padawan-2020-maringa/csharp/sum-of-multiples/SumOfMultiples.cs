using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    //public static int Sum(IEnumerable<int> multiples, int max) => multiples.Where(x => x <= max).Select(x => x * x).Sum();

    public static int Sum(IEnumerable<int> multiples, int max)
    {
        int value = 0;
        List<int> lista = new List<int>(); ;

        foreach (var item in multiples)
        {
            if (item == 0)
                break;

            int divide = 1;
            while (item * divide < max)
            {
                value = item * divide;
                if (!lista.Contains(value))
                {
                    lista.Add(value);
                }
                divide++;
            }
        }
        return lista.Sum();
    }
}